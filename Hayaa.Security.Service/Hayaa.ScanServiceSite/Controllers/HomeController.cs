using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Hayaa.BaseModel.Model;
using Hayaa.Security.Service;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hayaa.AppScanServiceSite.Controllers
{
    [Produces("application/json")]
    [Consumes("application/json", "multipart/form-data")]//此处为新增
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IHostingEnvironment _hostingEnvironment;

        public HomeController(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
        [HttpGet]
        public String Index()
        {
            return "home";
        }
        // POST api/values
        [HttpPost]      
        [EnableCors("any")]
        public IActionResult UploadDll(IFormCollection files)
        {
            var filePath = Path.GetTempFileName();      
            for (var i = 0; i < files.Files.Count; i++)
            {
                var file = files.Files[i];
                if (file.Length > 0)
                {
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }
                }
            }
            List<AppService> list = GetAppComponentService(filePath);
            return Ok(new {  list= list });
        }       
        private List<AppService> GetAppComponentService(String filePath)
        {
            List<AppService> list = new List<AppService>();
            Assembly assembly = Assembly.LoadFile(filePath);
            List<Type> typeList = assembly.GetTypes().ToList();
            typeList.ForEach(t =>
            {
            AppService appService = new AppService() { AppFunctions = new List<AppFunction>() };
                list.Add(appService);
            if (t.Name.Contains("Controller"))
            {
                appService.Name = t.Name;
                appService.Title = t.Name;
                t.GetMethods().ToList().ForEach(m=>{
                    DescAttribute desc =m.GetCustomAttribute(typeof(DescAttribute)) as DescAttribute;
                    if (desc != null)
                    {
                        appService.AppFunctions.Add(new AppFunction()
                        {
                            Title=desc.Title,
                            FunctionName = m.Name,
                            PathName = m.Name.ToLower()
                        });
                    }
                });
                }
            });
            return list;
        }
    }
}
