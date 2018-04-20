using Hayaa.BaseModel.Model;
using Hayaa.Security.Service;
using Hayaa.ServicePlatform.Client;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hayaa.SecurityController
{
    [Route("api/[controller]")]
    public class LoginController : Controller
    {
        private LoginService loginService = PlatformServiceFactory.Instance.CreateService<LoginService>(AppRoot.GetDefaultAppUser());
        [HttpPost]
        public TransactionResult<String> Login(String loginkey, String pwd)
        {
            var r = new TransactionResult<String>();
           var lsReulst= loginService.Login(loginkey, pwd);
            if (lsReulst.ActionResult && lsReulst.HavingData)
            {
                r.Data = lsReulst.Data.Token;
            }
            else
            {
                r.Code = 103;
                r.Message = lsReulst.ErrorMsg;
            }
            return r;
        }
        [HttpPost]
        public TransactionResult<String> MobileLogin(String mobile, String code)
        {
            var r = new TransactionResult<String>();
            var lsReulst = loginService.MobileLogin(mobile, code);
            if (lsReulst.ActionResult && lsReulst.HavingData)
            {
                r.Data = lsReulst.Data.Token;
            }
            else
            {
                r.Code = 103;
                r.Message = lsReulst.ErrorMsg;
            }
            return r;
        }
    }
}
