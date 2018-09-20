using Hayaa.Redis.Client;
using Hayaa.UserAuth.Service.Core.Config;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hayaa.UserAuth.Service.Core
{
    class RedisComponent
    {
        private static ServiceConfig g_ClientConfig = ConfigHelper.Instance.GetComponentConfig();
        private static RedisService g_RedisService = new RedisService(g_ClientConfig.CacheConfig);
        public static void SaveCache<T>(String key,T info) where T:class
        {
            g_RedisService.Set<T>(DefineTable.CacheName, key, info);
        }
    }
}
