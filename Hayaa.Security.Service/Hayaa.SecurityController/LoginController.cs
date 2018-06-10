using Hayaa.BaseModel.Model;
using Hayaa.Security.Service;
using Hayaa.ServicePlatform.Client;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hayaa.SecurityController
{
    [Route("api/[controller]/[action]")]
    public class LoginController : Controller
    {
        private LoginService loginService = PlatformServiceFactory.Instance.CreateService<LoginService>(AppRoot.GetDefaultAppUser());
        [HttpPost("{loginkey?}/{pwd?}")]
        [EnableCors("any")]
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
        [EnableCors("any")]
        public TransactionResult<Boolean> IsLogin()
        {
            var r = new TransactionResult<Boolean>();
            //var lsReulst = loginService.IsLogin();
            //if (lsReulst.ActionResult && lsReulst.HavingData)
            //{
            //    r.Data = lsReulst.Data.Token;
            //}
            //else
            //{
            //    r.Code = 103;
            //    r.Message = lsReulst.ErrorMsg;
            //}
            r.Data = true;
            return r;
        }
        [HttpPost("{mobile?}/{code?}")]
        [EnableCors("any")]
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
        [HttpPost("{key?}/{pwd?}/{userId?}")]
        [EnableCors("any")]
        public TransactionResult<Boolean> Reg(String key, String pwd,int userId)
        {
            var r = new TransactionResult<Boolean>();
            var lsReulst = loginService.Reg(key, pwd, userId);
            if (lsReulst.ActionResult)
            {
                r.Data = lsReulst.Data;
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
