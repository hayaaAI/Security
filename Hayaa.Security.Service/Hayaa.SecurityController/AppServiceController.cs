using Hayaa.BaseModel.Model;
using Hayaa.Security.Service;
using Hayaa.ServicePlatform.Client;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections.Generic;
using Hayaa.ServicePlatform.Service;
using System;
using Hayaa.SecurityController.Model;

namespace Hayaa.SecurityController
{
    [Route("api/[controller]")]
    public class AppServiceController
    {
        private AppServiceService appService = PlatformServiceFactory.Instance.CreateService<AppServiceService>(AppRoot.GetDefaultAppUser());
        private AppInstanceService appInstanceService = PlatformServiceFactory.Instance.CreateService<AppInstanceService>(AppRoot.GetDefaultAppUser());
        private AppTokenService appTokenService = PlatformServiceFactory.Instance.CreateService<AppTokenService>(AppRoot.GetDefaultAppUser());
        private AppInstanceTokenService appInstanceTokenService = PlatformServiceFactory.Instance.CreateService<AppInstanceTokenService>(AppRoot.GetDefaultAppUser());
        [HttpPost]
        public TransactionResult<AppAuthReponse> AppAuth(List<Security.Service.AppService> appservice,int appinstanceid,String t)
        {
            TransactionResult<AppAuthReponse> r = new TransactionResult<AppAuthReponse>();
            var temp = appservice.Select(ap => ap.AppId).Distinct();
            if (temp.Count() > 1)
            {
                r.Code = 102;
                r.Message = "AppId必须只有一个";
                return r;
            }
            int appId = temp.FirstOrDefault();
            if (appId > 0)
            {
                //检查是否已有服务数据
              var existResult=  appService.ExistAppService(appId);
                if (existResult.ActionResult && existResult.Data)
                {
                    //检查是否匹配
                    var compareResult = appService.IsCompare(appservice, appId);
                    if (compareResult.ActionResult)
                    {
                        r.Code = compareResult.Data ? 0 : 103;
                        r.Message = compareResult.Data ? "" : "服务数据不匹配";
                        if (compareResult.Data)//服务特征匹配
                        {
                            //验证token
                          var atsResult=  appTokenService.Get(appId, t);
                            if (atsResult.ActionResult && atsResult.HavingData)
                            {
                                //新实例申请实例Id
                                if (appinstanceid == 0)
                                {
                                   var aisResult= appInstanceService.Create(new AppInstance() { AppId=appId });
                                    if (aisResult.ActionResult && aisResult.HavingData)
                                    {
                                        appinstanceid = aisResult.Data.AppInstanceId;
                                    }
                                }
                                //替换token
                                var aitsResult =   appInstanceTokenService.ExchangeToken(appinstanceid, t);
                                if (aitsResult.ActionResult && aitsResult.HavingData)
                                {
                                    r.Data = new AppAuthReponse()
                                    {
                                        AppInstanceId = appinstanceid,
                                        AppInstanceToken = aitsResult.Data.Token
                                    };
                                }
                                else
                                {
                                    r.Code = 103;
                                    r.Message = "实例token置换失败:"+ aitsResult.ErrorMsg;
                                }
                            }
                            else
                            {
                                r.Code = 103;
                                r.Message = "App验证未通过";
                            }
                        }
                        else
                        {
                            if (appinstanceid > 0)
                            {
                                //记录实例服务特征数据
                                appService.RecordAppService(appservice, appinstanceid);
                            }
                        }
                    }
                }
                else
                {
                    r.Code = 103;
                    r.Message = "App无服务数据";
                }
            }
            else
            {
                r.Code = 101;
                r.Message = "AppId不能为0";
            }           
            return r;
        }
        [HttpPost]
        public TransactionResult<int> UpdateAppService(int appinstanceid,int appid)
        {
            TransactionResult<int> r = new TransactionResult<int>();
            if (appinstanceid > 0)
            {
                var updateResult = appService.Update(appinstanceid, appid);
                if (updateResult.ActionResult)
                {
                    r.Code = updateResult.Data ? 0 : 103;
                    r.Message = updateResult.Data ? "" : "服务数据更新失败";
                }
            }
            else
            {
                r.Code = 101;
                r.Message = "AppInstanceId不能为0";
            }
            return r;
        }
    }
}
