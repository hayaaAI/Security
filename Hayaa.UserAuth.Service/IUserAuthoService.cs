using Hayaa.BaseModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hayaa.UserAuth.Service
{
   public interface IUserAuthoService
    {
        /// <summary>
        /// 企业用户登陆
        /// </summary>
        /// <param name="loginKey">登录名</param>
        /// <param name="pwd">用户密码</param>
        /// <param name="sessionId">客户端会话Id</param>
        /// <returns>加密后的会话Id</returns>
        FunctionOpenResult<String> CompanyUserLogin(String loginKey, String pwd, String sessionId);
       
    }
}
