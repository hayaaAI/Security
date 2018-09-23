using Hayaa.BaseModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hayaa.Security.Service.Config
{
    /// <summary>
    /// 服务配置类
    /// </summary>
    [Serializable]
    internal class SecurityServiceConfig:BaseData, ConfigContent
    {
       
        public AppSettings AppSettings { set; get; }
        public ConnectionStrings ConnectionStrings { set; get; }
    }
}
