﻿using Hayaa.BaseModel.Model;
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
 
    public partial class AppServiceController
    {
        /// <summary>
        /// App认证
        /// 实例Id获取
        /// token置换
        /// </summary>
        /// <param name="appservice">带认证的App特征数据</param>
        /// <param name="appinstanceid">实例id，可为0</param>
        /// <param name="t">待认证App的部署token</param>
        /// <returns></returns>
        [HttpPost]
        public TransactionResult<AppAuthReponse> AppAuth(List<Security.Service.AppService> appservice, int appinstanceid, String t)
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
                var existResult = appService.ExistAppService(appId);
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
                            var atsResult = appTokenService.GetNormal(appId, t);
                            if (atsResult.ActionResult && atsResult.HavingData)
                            {
                                //新实例申请实例Id
                                if (appinstanceid == 0)
                                {
                                    var aisResult = appInstanceService.Create(new AppInstance() { AppId = appId });
                                    if (aisResult.ActionResult && aisResult.HavingData)
                                    {
                                        appinstanceid = aisResult.Data.AppInstanceId;
                                    }
                                }
                                //替换token
                                var aitsResult = appInstanceTokenService.ExchangeToken(appinstanceid, t);
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
                                    r.Message = "实例token置换失败:" + aitsResult.ErrorMsg;
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
        public TransactionResult<List<Security.Service.AppService>> GetAuthority(int appid)
        {
            var r = new TransactionResult<List<Security.Service.AppService>>();
            if (appid == 0)
            {
                r.Code = 103;
                r.Message = "AppId不能为0";
            }
            if (appid > 0)
            {
                var asResult = appService.GetAuthority(appid);
                if (asResult.ActionResult && asResult.HavingData)
                {
                    r.Data = asResult.Data;
                }
                else
                {
                    r.Code = 0;
                    r.Message = "App无授权数据";
                }
            }
            return r;
        }

    }
}
