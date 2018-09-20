using Hayaa.ConfigSeed.Standard;
using Hayaa.RemoteConfig.Client;

namespace Hayaa.UserAuth.Service.Core.Config
{
    internal class ConfigHelper: ConfigTool<ServiceConfig, SecurityServiceRootConfig>
    {
        private static ConfigHelper _instance = new ConfigHelper();
        private ConfigHelper() : base(DefineTable.ComponetID)
        {

        }

        internal static ConfigHelper Instance { get => _instance; }
    }
}
