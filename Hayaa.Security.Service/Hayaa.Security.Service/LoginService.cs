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
        FunctionOpenResult<Boolean> WorkerIsLogin(String authtoken);
        /// <summary>
        /// 无需授权的用户登陆
        /// </summary>
        /// <param name="loginKey"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        FunctionResult<LoginToken> UserLogin(String loginKey, String pwd);
        FunctionOpenResult<Boolean> UserIsLogin(String authtoken);
     
        /// <summary>
        /// 使用手机号和验证码登陆
        /// </summary>
        /// <param name="mobile"></param>
        /// <param name="code"></param>
        /// <returns></returns>
        FunctionResult<JobToken> MobileLogin(String mobile, String code);
        /// <summary>
        /// 注册用户信息
        /// </summary>
        /// <param name="key">人员登陆凭证</param>
        /// <param name="pwd">密码</param>
        /// <returns></returns>
        FunctionOpenResult<Boolean> Reg(string key, string pwd,int userId);
       
    }
}
