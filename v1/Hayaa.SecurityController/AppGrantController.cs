using Hayaa.BaseModel.Model;
using Hayaa.Security.Service;
using Hayaa.ServicePlatform.Client;
using Hayaa.WorkerSecurity.Client;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hayaa.SecurityController
{
    [Route("api/[controller]")]
    [UserAuthorityFilter]
    public class AppGrantController: Controller
    {
        private AppGrantService appGrantService = PlatformServiceFactory.Instance.CreateService<AppGrantService>(AppRoot.GetDefaultAppUser());
        private AppTokenService appTokenService = PlatformServiceFactory.Instance.CreateService<AppTokenService>(AppRoot.GetDefaultAppUser());
        private AppInstanceTokenService appInstanceTokenService = PlatformServiceFactory.Instance.CreateService<AppInstanceTokenService>(AppRoot.GetDefaultAppUser());
        /// <summary>
        /// 实例基础授权验证
        /// </summary>
        /// <param name="appinstanceid"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        [HttpPost]
        public TransactionResult<Boolean> AppInstanceBaseAuth(int appinstanceid,String token)
        {
            var r = new TransactionResult<Boolean>();
            var aisaResult = appInstanceTokenService.Get(appinstanceid, token);
            if (aisaResult.ActionResult && aisaResult.HavingData)
            {
                var data = aisaResult.Data;
                r.Data = data.Status;
            }
            else
                r.Data = false;
            return r;
        }
        [HttpPost]
        public TransactionResult<Boolean> AppBaseAuth(int appid, String token)
        {
            var r = new TransactionResult<Boolean>();
            var atsResult = appTokenService.GetNormal(appid, token);
            if (atsResult.ActionResult && atsResult.HavingData)
            {
                r.Data = true;
            }
            else
                r.Data = false;
            return r;
        }
    }
}
