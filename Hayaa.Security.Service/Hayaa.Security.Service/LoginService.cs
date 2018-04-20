using Hayaa.BaseModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hayaa.Security.Service
{
   public interface LoginService
    {
        /// <summary>
        /// 使用可登陆信息和密码进行登陆
        /// </summary>
        /// <param name="loginKey">可登陆信息：用户名、邮箱、手机号</param>
        /// <param name="pwd">密码</param>
        /// <returns></returns>
        FunctionResult<JobToken> Login(String loginKey, String pwd);
        /// <summary>
        /// 使用手机号和验证码登陆
        /// </summary>
        /// <param name="mobile"></param>
        /// <param name="code"></param>
        /// <returns></returns>
        FunctionResult<JobToken> MobileLogin(String mobile, String code);
    }
}
