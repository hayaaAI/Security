using Hayaa.BaseModel.Model;
using Hayaa.Security.Service;
using Hayaa.ServicePlatform.Client;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hayaa.SecurityController
{
    [Route("api/[controller]/[action]")]
    public  class AppFunctionController : Controller
    {
        private AppFuntionService service = PlatformServiceFactory.Instance.CreateService<AppFuntionService>(AppRoot.GetDefaultAppUser());
        [HttpPost]
        [Desc("GetList", "获取AppService功能列表", "根据appServiceId获取功能列表")]
        public TransactionResult<List<AppFunction>> GetList(int appServiceId)
        {
            var r = new TransactionResult<List<AppFunction>>();
            var serviceResult = service.GetList(new AppFunctionSearchPamater(){ AppServiceId=appServiceId });
            if (serviceResult.ActionResult)
            {
                r.Data = serviceResult.Data;
            }
            else
            {
                r.Code = 101;
                r.Message = "AppInstanceId不能为0";
            }
            return r;
        }
        [HttpPost]
        [Desc("Get", "获取指定功能", "根据主键获取数据")]
        public TransactionResult<AppFunction> Get(int id)
        {
            var r = new TransactionResult<AppFunction>();
            var serviceResult = service.Get(id);
            if (serviceResult.ActionResult && serviceResult.HavingData)
            {
                r.Data = serviceResult.Data;
            }
            else
            {
                r.Code = 103;
                r.Message = "暂无数据";
            }
            return r;
        }
        [HttpPost]
        [Desc("Add", "添加功能数据", "手动添加功能数据")]
        public TransactionResult<AppFunction> Add(AppFunction info)
        {
           var r = new TransactionResult<AppFunction>();
            var serviceResult = service.Create(info);
            if (serviceResult.ActionResult && serviceResult.HavingData)
            {
                r.Data = serviceResult.Data;
            }
            else
            {
                r.Code = 103;
                r.Message = "暂无数据";
            }
            return r;
        }
        [HttpPost]
        [Desc("Edit", "更新功能数据", "根据主键更新数据")]
        public TransactionResult<Boolean> Edit(AppFunction info)
        {
            TransactionResult<Boolean> r = new TransactionResult<Boolean>();
            var updateResult = service.UpdateByID(info);
            if (updateResult.ActionResult)
            {
                r.Data = updateResult.Data;
            }
            else
            {
                r.Code = 103;
                r.Message = "暂无数据";
            }
            return r;
        }
    }
}
