using Hayaa.ConfigSeed.Standard;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hayaa.Security.Client.Config
{
    internal class ConfigHelper : ConfigTool<SecurityConfig, SecurityRootConfig>
    {
        private static ConfigHelper _instance = new ConfigHelper();
        private ConfigHelper() : base(DefineTable.SecurityClientComponetID)
        {

        }

        internal static ConfigHelper Instance { get => _instance; }
    }
}
