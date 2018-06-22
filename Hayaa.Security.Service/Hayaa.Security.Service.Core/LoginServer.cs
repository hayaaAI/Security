using System;
using System.Collections.Generic;
using System.Text;
using Hayaa.BaseModel;
using Hayaa.CacheKeyStatic;
using Hayaa.Redis.Client;
using Hayaa.Security.Service.Config;
using Hayaa.Security.Service.Dao;

namespace Hayaa.Security.Service.Core
{
    public partial class LoginServer : LoginService
    {
        public FunctionResult<JobToken> MobileLogin(string mobile, string code)
        {
            var r = new FunctionResult<JobToken>();
            LoginInfo data = LoginDal.MobileLogin(mobile, code);
            if (data != null)
            {
                var jobToken = new JobToken()
                {
                    JobId = GetJobId(data.UserId),
                    UserId = data.UserId,
                    Token = GetToken()
                };
                if (JobTokenDal.Add(jobToken) > 0)
                {
                    r.Data = jobToken;
                }
                else
                {
                    r.ErrorMsg = "无法获取标识";
                }
            }
            else
            {
                r.ErrorMsg = "无匹配用户登陆信息";
            }
            return r;
        }

        public FunctionOpenResult<bool> Reg(string key, string pwd,int userId)
        {
            FunctionOpenResult<bool> r = new FunctionOpenResult<bool>();
           int loginInfoId= LoginInfoDal.Insert(new LoginInfo() { LoginKey = key, UserId = userId, Status = 1 });
            if (loginInfoId>0)
            {
                r.Data=LoginPwdDal.Add(new LoginPwdInfo() {
                     LoginInfoId= loginInfoId,
                     LoginPwd=pwd,
                     Status=true
                },false)>0;
            }
            return r;
        }

        public FunctionResult<LoginToken> UserLogin(string loginKey, string pwd)
        {
            var r = new FunctionResult<LoginToken>();
            pwd = Encryption(pwd);
            LoginInfo data = LoginDal.Login(loginKey, pwd);
            if (data != null)
            {
                var token = new LoginToken()
                {                    
                    UserId = data.UserId,
                    Token = GetToken()
                };
                if (LoginTokenDal.Add(token) > 0)
                {
                    r.Data = token;
                     RedisService.Set<LoginToken>(DefineTable.CacheName, String.Format(UserAuthorityCacheKey.AuthorityCacheKey, token.Token), token);
                }
                else
                {
                    r.ErrorMsg = "无法获取标识";
                }
            }
            else
            {
                r.ErrorMsg = "无匹配用户登陆信息";
            }
            return r;
        }

        public FunctionOpenResult<bool> UserIsLogin(string authtoken)
        {
            FunctionOpenResult<bool> r = new FunctionOpenResult<bool>();
            var info = RedisService.Get<LoginToken>(DefineTable.CacheName, String.Format(UserAuthorityCacheKey.AuthorityCacheKey, authtoken));
            r.Data = false;
            if (info != null)
            {
                if ((info.Status)&& (info.EndTime > DateTime.Now))
                {
                    r.Data = true;
                }
                
            }
            return r;
        }
        public FunctionResult<JobToken> Login(string loginKey, string pwd)
        {
            var r = new FunctionResult<JobToken>();
            pwd = Encryption(pwd);
            LoginInfo data = LoginDal.Login(loginKey, pwd);
            if (data != null)
            {
                var jobToken = new JobToken()
                {
                    JobId = GetJobId(data.UserId),
                    UserId = data.UserId,
                    Token = GetToken()
                };
                if (JobTokenDal.Add(jobToken) > 0)
                {
                    r.Data = jobToken;
                    RedisService.Set<JobToken>(DefineTable.CacheName, String.Format(JobAuthorityCacheKey.AuthorityCacheKey, jobToken.Token), jobToken);
                }
                else
                {
                    r.ErrorMsg = "无法获取标识";
                }
            }
            else
            {
                r.ErrorMsg = "无匹配用户登陆信息";
            }
            return r;
        }
        public FunctionOpenResult<bool> WorkerIsLogin(string authtoken)
        {
            FunctionOpenResult<bool> r = new FunctionOpenResult<bool>();
            var info = RedisService.Get<JobToken>(DefineTable.CacheName, String.Format(JobAuthorityCacheKey.AuthorityCacheKey, authtoken));
            r.Data = false;
            if (info != null)
            {
                if (info.EndTime>DateTime.Now)
                {
                    r.Data = true;
                }

            }
            return r;
        }
    }
}
