using Hayaa.Redis.Client.Config;
using Hayaa.RemoteConfig.Client;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hayaa.CompanyWebSecurity.Client.Config
{
    class ClientConfig : ConfigContent
    {
        public AppSettings AppSettings { set; get; }
        public ConnectionStrings ConnectionStrings { set; get; }
        public RedisClientConfig CacheConfig { set; get; }
        /// <summary>
        /// 会话长度，单位秒
        /// </summary>
        public int SessionLength { set; get; }
        /// <summary>
        /// 程序AppId
        /// </summary>
        //public int AppId { set; get; }
        public Boolean OnlyBaseAuth { set; get; }
    }
}
