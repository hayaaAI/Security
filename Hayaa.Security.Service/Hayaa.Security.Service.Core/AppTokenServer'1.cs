using System;
using System.Collections.Generic;
using System.Text;
using Hayaa.DataAccess;
using Hayaa.BaseModel;
using Hayaa.Security.Service.Dao;
using Hayaa.Security.Service.Config;

namespace Hayaa.Security.Service
{
    public partial class AppTokenServer 
    {
        public FunctionResult<AppToken> GetNormal(int appId, string token)
        {
            var r = new FunctionResult<AppToken>();
            r.Data = AppTokenDal.Get(appId, token);
            return r;
        }
    }
}