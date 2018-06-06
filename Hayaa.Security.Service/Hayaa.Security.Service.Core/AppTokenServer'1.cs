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
        public FunctionResult<AppToken> Create(AppToken info)
        {
            var r = new FunctionResult<AppToken>(); int id = AppTokenDal.Add(info); if (id > 0) { r.Data = info; r.Data.AppTokenId = id; }
            return r;
        }
        public FunctionResult<AppToken> GetNormal(int appId, string token)
        {
            var r = new FunctionResult<AppToken>();
            r.Data = AppTokenDal.Get(appId, token);
            return r;
        }
        public FunctionResult<AppToken> GetByAppId(int appId)
        {
            var r = new FunctionResult<AppToken>();
            r.Data = AppTokenDal.GetByAppId(appId);
            return r;
        }
    }
}