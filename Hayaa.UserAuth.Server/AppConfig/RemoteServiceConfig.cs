using Hayaa.RemoteConfig.Client;
using Hayaa.RPC.Common.Config;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hayaa.UserAuth.Server.Config
{
    /// <summary>
    /// 服务配置类
    /// </summary>
    [Serializable]
    public class ServiceConfig: ConfigContent
    {
       
        public AppSettings AppSettings { set; get; }
        public ConnectionStrings ConnectionStrings { set; get; }
        public RPCConfig ServerConfig { set; get; }
    }
}
