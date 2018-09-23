using Hayaa.CacheKeyStatic;
using Hayaa.Security.Client.Config;
using Hayaa.Security.Client.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hayaa.Security.Client
{
    class JobAuthorityCache
    {
        public static Dictionary<String, List<String>> GetJobAuthData(string jobToken)
        {
          var data=  Redis.Client.RedisService.Get<List<AppService>>(ConfigHelper.Instance.GetComponentConfig().CacheConfigName, String.Format(JobAuthorityCacheKey.AuthorityCacheKey, jobToken));
            return data.ToDictionary(k => k.Name, v => v.AppFunctions.Select(a => a.FunctionName).ToList());
        }
    }
}
