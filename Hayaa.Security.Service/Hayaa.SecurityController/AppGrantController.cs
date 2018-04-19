using Hayaa.BaseModel.Model;
using Hayaa.Security.Service;
using Hayaa.ServicePlatform.Client;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hayaa.SecurityController
{
    [Route("api/[controller]")]
    public class AppGrantController: Controller
    {
        private AppGrantService appGrantService = PlatformServiceFactory.Instance.CreateService<AppGrantService>(AppRoot.GetDefaultAppUser());
        
    }
}
