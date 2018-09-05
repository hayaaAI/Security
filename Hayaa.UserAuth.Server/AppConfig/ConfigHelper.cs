using Hayaa.RemoteConfig.Client;

namespace Hayaa.UserAuth.Server.Config
{
    internal class ConfigHelper: ConfigTool<ServiceConfig, ServiceRootConfig>
    {
        private static ConfigHelper _instance = new ConfigHelper();
        private ConfigHelper() : base(DefineTable.ComponetID)
        {

        }

        internal static ConfigHelper Instance { get => _instance; }
    }
}
