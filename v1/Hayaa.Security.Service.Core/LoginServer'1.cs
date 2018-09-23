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
    public partial class LoginServer 
    {
      

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
    }
}
