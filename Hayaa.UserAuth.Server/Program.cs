using Hayaa.RemoteConfig.Client;
using Hayaa.RPC.Service.Server;
using Hayaa.UserAuth.Server.Config;
using System;

namespace Hayaa.UserAuth.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            AppSeed.Instance.InitConfig();
            RpcServer rpcServer = new RpcServer();
            var rpcServerConfig = ConfigHelper.Instance.GetComponentConfig();
            if ((rpcServerConfig == null) || (rpcServerConfig.ServerConfig == null))
            {
                Console.WriteLine("RPC服务端未配置");
            }
            else
                rpcServer.Run(rpcServerConfig.ServerConfig);
        }
    }
}
