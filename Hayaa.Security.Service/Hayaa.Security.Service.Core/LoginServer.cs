using System;
using System.Collections.Generic;
using System.Text;
using Hayaa.BaseModel;
using Hayaa.Security.Service.Dao;

namespace Hayaa.Security.Service.Core
{
    public class LoginServer : LoginService
    {
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

        private string Encryption(string pwd)
        {
            return pwd;
        }

        private string GetToken()
        {
            return Guid.NewGuid().ToString().Replace("-", "");
        }

        /// <summary>
        /// TODO
        /// 获取jobid
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        private int GetJobId(int userId)
        {
            return 1;
        }

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
    }
}
