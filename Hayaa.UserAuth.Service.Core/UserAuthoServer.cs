using System;
using Hayaa.BaseModel;
using Hayaa.CacheKeyStatic;
using Hayaa.Common;
using Hayaa.UserAuth.Service.Core.DataAccess;

namespace Hayaa.UserAuth.Service.Core
{
    public class UserAuthoServer : IUserAuthoService
    {
        public FunctionOpenResult<string> CompanyUserLogin(string loginKey, string pwd, string sessionKey)
        {
            FunctionOpenResult<string> result = new FunctionOpenResult<string>() { ActionResult=true };
            //获取会话数据
            UserSession userSession = UserSessionDal.Get(sessionKey);
            int sessionId = (userSession==null)?0:userSession.SessionId;
            //先检查失败次数
            LoginAudit loginAudit =(sessionId>0)? LoginAuditDal.Get(sessionId):new LoginAudit();
            if ((loginAudit != null) && (loginAudit.FailTotal >= 3))
            {
                result.ActionResult = false;
                result.ErrorMsg = "密码错误太多";
                result.ErrorCode = ErrorCode.PwdAttack;
                return result;
            }
            //验证口令
            UserSession loginSession= CompanyLoginDal.Get(loginKey, pwd);
            loginSession.SessionKey = sessionKey;
            if (loginSession.UserId > 0)
            {
                loginSession.Status = 1;
                loginSession.SessionId=UserSessionDal.Add(loginSession);
                userSession = loginSession;
                //添加会话缓存
                RedisComponent.SaveCache<UserSession>(String.Format(UserAuthorityCacheKey.AuthorityCacheKey, sessionKey), loginSession);

            }
            else
            {              
                loginAudit.FailTotal++;
                result.ActionResult = false;
                result.ErrorMsg = "验证未通过";
                result.ErrorCode = ErrorCode.LoginFail;
            }
            if (userSession == null)
            {
                loginSession.Status = 1;
                UserSessionDal.Add(loginSession);
            }
            if (loginAudit == null)
            {              
                LoginAuditDal.Add(loginAudit);
            }
            return result;
        }
    }
}
