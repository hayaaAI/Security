using Hayaa.BaseModel.Model;
using Hayaa.Security.Service;
using Hayaa.ServicePlatform.Client;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections.Generic;
using Hayaa.ServicePlatform.Service;
using System;
using Hayaa.SecurityController.Model;
using Hayaa.WorkerSecurity.Client;

namespace Hayaa.SecurityController
{
    [Route("api/[controller]/[action]")]
    [UserAuthorityFilter]
    public partial class AppServiceController : Controller
    {
        private AppServiceService appService = PlatformServiceFactory.Instance.CreateService<AppServiceService>(AppRoot.GetDefaultAppUser());
        private AppInstanceService appInstanceService = PlatformServiceFactory.Instance.CreateService<AppInstanceService>(AppRoot.GetDefaultAppUser());
        private AppTokenService appTokenService = PlatformServiceFactory.Instance.CreateService<AppTokenService>(AppRoot.GetDefaultAppUser());
        private AppInstanceTokenService appInstanceTokenService = PlatformServiceFactory.Instance.CreateService<AppInstanceTokenService>(AppRoot.GetDefaultAppUser());
        [HttpPost]
        [Desc("AutoCreate", "自动添加服务数据", "")]
        public TransactionResult<List<Security.Service.AppService>> AutoCreate(List<Security.Service.AppService> data)
        {
            var r = new TransactionResult<List<Security.Service.AppService>>();
            var addResult = appService.Add(data);
            if (addResult.ActionResult && addResult.HavingData)
            {
                r.Data = addResult.Data;
            }
            else
            {
                r.Code = 101;
                r.Message = "AppId不能为0";
            }
            return r;
        }
        [HttpPost]
        [Desc("GetAppServiceByAppId", "获取app的服务列表", "根据appId获取app的服务列表")]
        public TransactionResult<List<Security.Service.AppService>> GetAppServiceByAppId(int appId)
        {
            var r = new TransactionResult<List<Security.Service.AppService>>();
            var serviceResult = appService.GetList(new AppServiceSearchPamater() { AppId = appId });
            if (serviceResult.ActionResult)
            {
                r.Data = serviceResult.Data;
            }
            else
            {
                r.Code = 101;
                r.Message = "AppInstanceId不能为0";
            }
            return r;
        }
        [HttpPost]
        [Desc("GetAppService", "获取指定AppService", "根据主键获取数据")]
        public TransactionResult<Security.Service.AppService> GetAppService(int appServiceId)
        {
            TransactionResult<Security.Service.AppService> r = new TransactionResult<Security.Service.AppService>();
            var serviceResult = appService.Get(appServiceId);
            if (serviceResult.ActionResult && serviceResult.HavingData)
            {
                r.Data = serviceResult.Data;
            }
            else
            {
                r.Code = 103;
                r.Message = "暂无数据";
            }
            return r;
        }
        [HttpPost]
        [Desc("AddAppService", "添加AddAppService", "")]
        public TransactionResult<Security.Service.AppService> AddAppService(Security.Service.AppService info)
        {
            TransactionResult<Security.Service.AppService> r = new TransactionResult<Security.Service.AppService>();
            var serviceResult = appService.Create(info);
            if (serviceResult.ActionResult && serviceResult.HavingData)
            {
                r.Data = serviceResult.Data;
            }
            else
            {
                r.Code = 103;
                r.Message = "暂无数据";
            }
            return r;
        }
        [HttpPost]
        [Desc("UpdateAppService", "更新AppService", "根据主键更新数据")]
        public TransactionResult<Boolean> UpdateAppService(Security.Service.AppService info)
        {
            TransactionResult<Boolean> r = new TransactionResult<Boolean>();
            var updateResult = appService.UpdateByID(info);
            if (updateResult.ActionResult)
            {
                r.Data = updateResult.Data;
            }
            else
            {
                r.Code = 103;
                r.Message = "暂无数据";
            }
            return r;
        }
    }
}
