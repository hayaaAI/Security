using Hayaa.ConfigSeed.Standard;


namespace Hayaa.Security.Service.Config
{
    internal class ConfigHelper: ConfigTool<SecurityServiceConfig, SecurityServiceRootConfig>
    {
        private static ConfigHelper _instance = new ConfigHelper();
        private ConfigHelper() : base(DefineTable.SecurityServiceComponetID)
        {

        }

        internal static ConfigHelper Instance { get => _instance; }
    }
}
