using Hayaa.Redis.Client.Config;
using Hayaa.RemoteConfig.Client;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hayaa.UserAuth.Service.Core.Config
{
    /// <summary>
    /// 服务配置类
    /// </summary>
    [Serializable]
    public class ServiceConfig: ConfigContent
    {
        public RedisClientConfig CacheConfig { set; get; }
        public AppSettings AppSettings { set; get; }
        public ConnectionStrings ConnectionStrings { set; get; }
    }
}
