using Hayaa.RemoteConfig.Client;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hayaa.CompanyWebSecurity.Client.Config
{
    internal class ConfigHelper : ConfigTool<ClientConfig, ClientRootConfig>
    {
        private static ConfigHelper _instance = new ConfigHelper();
        private ConfigHelper() : base(DefineTable.ClientComponetID)
        {

        }

        internal static ConfigHelper Instance { get => _instance; }
    }
}
