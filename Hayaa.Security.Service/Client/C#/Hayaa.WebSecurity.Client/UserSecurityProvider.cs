using Hayaa.CacheKeyStatic;
using Hayaa.Redis.Client;
using Hayaa.Redis.Client.Config;
using Hayaa.UserAuth.Service;
using Hayaa.CompanyWebSecurity.Client.Config;
using Hayaa.CompanyWebSecurity.Client.Model;
using System;
using System.Collections.Generic;

namespace Hayaa.CompanyWebSecurity.Client
{
    internal class UserSecurityProvider
    {
        private static ClientConfig g_ClientConfig = ConfigHelper.Instance.GetComponentConfig();
        private static RedisService g_RedisService = new RedisService(g_ClientConfig.CacheConfig);

        public static int BaseAuth(String sessionKey)
        {
            int result = 0;
            var info = g_RedisService.Get<UserSession>(DefineTable.CacheName, String.Format(UserAuthorityCacheKey.AuthorityCacheKey, sessionKey));
            if (info != null)
            {
                if (info.UserId>0)
                {
                    result = info.UserId;
                }               

            }
            return result;
        }
        public static Boolean PermissionAuth(int userId,String webapiPath,Boolean baseAuthResult)
        {
            Boolean result = false;
            if (g_ClientConfig.OnlyBaseAuth) {
                result = baseAuthResult;
                return result; }
            var info = g_RedisService.Get<AppFunction>(DefineTable.CacheName, String.Format(CoreCacheKey.AppFunctionWebApiCacheKey, webapiPath));
            if (info != null)
            {
               var userPermission = g_RedisService.Get<List<PersonGrant>>(DefineTable.CacheName, String.Format(UserAuthorityCacheKey.PermissionCacheKey, userId));
                if (userPermission != null)
                {
                    result = userPermission.Exists(p => (p.AppFunctionId==info.AppFuntionId)&&(p.AppId==info.AppId));
                }

            }
            return result;
        }
    }
}
