﻿using Hayaa.CacheKeyStatic;
using Hayaa.Redis.Client;
using Hayaa.Security.Client.Config;
using Hayaa.Security.Service;
using System;

namespace Hayaa.ConfigSecurity.Client
{
    class ConfigSecurityProvider
    {
        public static Boolean Auth(int appId, String appToken)
        {
            Boolean result = false;
            var info = RedisService.Get<AppToken>(DefineTable.CacheName, String.Format(ConfigAuthorityCacheKey.AuthorityCacheKey, appId));
            if (info != null)
            {
                if ((info.Token== appToken) && (info.Status))
                {
                    result = true;
                }
                if (String.IsNullOrEmpty(appToken))
                {
                    result = false;
                }
            }
            return result;
        }
    }
}
