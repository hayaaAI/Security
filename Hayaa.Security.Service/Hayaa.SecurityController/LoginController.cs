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
        [Desc("WorkerUserLogin", "企业用户无授权登陆", "")]
        public TransactionResult<String> WorkerUserLogin(String loginkey, String pwd)
        {
            var r = new TransactionResult<String>();
            var lsReulst = loginService.Login(loginkey, pwd);
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
        [Desc("WorkerUserIsLogin", "企业用户登陆状态判断", "根据登陆会话判断登录状态")]
        public TransactionResult<Boolean> WorkerUserIsLogin(String authtoken)
        {
            var r = new TransactionResult<Boolean>();
            var lsReulst = loginService.WorkerIsLogin(authtoken);
            if (lsReulst.ActionResult)
            {
                r.Data = lsReulst.Data;
            }
            else
            {
                r.Code = 103;
                r.Message = lsReulst.ErrorMsg;
            }
            r.Data = true;
            return r;
        }
        [HttpPost("{loginkey?}/{pwd?}")]
        [EnableCors("any")]
        [Desc("WorkerLogin", "企业用户授权验证登陆", "")]
        public TransactionResult<String> WorkerLogin(String loginkey, String pwd)
        {
            var r = new TransactionResult<String>();
            var lsReulst = loginService.Login(loginkey, pwd);
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
        [Desc("WorkerIsLogin", "企业用户登陆状态判断", "根据登陆会话判断登录状态")]
        public TransactionResult<Boolean> WorkerIsLogin(String authtoken)
        {
            var r = new TransactionResult<Boolean>();
            var lsReulst = loginService.WorkerIsLogin(authtoken);
            if (lsReulst.ActionResult)
            {
                r.Data = lsReulst.Data;
            }
            else
            {
                r.Code = 103;
                r.Message = lsReulst.ErrorMsg;
            }
            r.Data = true;
            return r;
        }
        [HttpPost("{mobile?}/{code?}")]
        [EnableCors("any")]
        [Desc("WorkerMobileLogin", "企业用户手机登陆", "根据手机验证码登陆")]
        public TransactionResult<String> WorkerMobileLogin(String mobile, String code)
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
        [Desc("WorkerReg", "企业用户注册", "")]
        public TransactionResult<Boolean> WorkerReg(String key, String pwd,int userId)
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
