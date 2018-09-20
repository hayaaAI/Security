using Hayaa.CacheKeyStatic;
using Hayaa.Redis.Client;
using Hayaa.Security.Service;
using System;

namespace Hayaa.WorkerSecurity.Client
{
    internal class WorkerSecurityProvider
    {
        public static Boolean UserAuth(String token)
        {
            Boolean result = false;
            var info = RedisService.Get<LoginToken>(DefineTable.CacheName, String.Format(UserAuthorityCacheKey.AuthorityCacheKey, token));
            if (info != null)
            {
                if ((info.Status) && (info.EndTime > DateTime.Now))
                {
                    result = true;
                }

            }
            return result;
        }
        public static Boolean WorkerAuth(String token)
        {
            Boolean result = false;
            var info = RedisService.Get<JobToken>(DefineTable.CacheName, String.Format(JobAuthorityCacheKey.AuthorityCacheKey, token));
            if (info != null)
            {
                if(info.EndTime > DateTime.Now)
                {
                    result = true;
                }

            }
            return result;
        }
    }
}
