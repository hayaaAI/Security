using System;
using System.Collections.Generic;
using System.Text;
using Hayaa.DataAccess;
using Hayaa.BaseModel;
using Hayaa.Security.Service.Dao;
using Hayaa.Security.Service.Config;
using Hayaa.Redis.Client;
using Hayaa.CacheKeyStatic;

namespace Hayaa.Security.Service
{
    public partial class AppTokenServer
    {
        public FunctionResult<AppToken> Create(AppToken info)
        {
            var r = new FunctionResult<AppToken>(); int id = AppTokenDal.Add(info); if (id > 0)
            {
                r.Data = info; r.Data.AppTokenId = id;
                RedisService.Set<AppToken>("default", String.Format(ConfigAuthorityCacheKey.AuthorityCacheKey, id), info);
            }
            return r;
        }
        public FunctionOpenResult<bool> UpdateByID(AppToken info) {
            var r = new FunctionOpenResult<bool>();
            r.Data = AppTokenDal.Update(info) > 0;
            if (r.Data&&info.Status)
            {
                RedisService.Set<AppToken>("default", String.Format(ConfigAuthorityCacheKey.AuthorityCacheKey, info.AppId), info);
            }
            else
            {
                RedisService.Delete("default", String.Format(ConfigAuthorityCacheKey.AuthorityCacheKey, info.AppId));
            }
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