using Hayaa.BaseModel.Model;
using Hayaa.Security.Service;
using Hayaa.ServicePlatform.Client;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections.Generic;

namespace Hayaa.SecurityController
{
    [Route("api/[controller]")]
    public class AppServiceController
    {
        private AppServiceService appService = PlatformServiceFactory.Instance.CreateService<AppServiceService>(AppRoot.GetDefaultAppUser());
        [HttpPost]
        public TransactionResult<int> SetAppService(List<AppService> appservice,int appinstanceid)
        {
            TransactionResult<int> r = new TransactionResult<int>();
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
                    var compareResult = appService.IsCompare(appservice, appId,appinstanceid);
                    if (compareResult.ActionResult)
                    {
                        r.Code = compareResult.Data ? 0 : 103;
                        r.Message = compareResult.Data ? "" : "服务数据不匹配";
                    }
                }
                else
                {
                   var addResult= appService.Add(appservice, appinstanceid);
                    if (addResult.ActionResult)
                    {
                        r.Code = addResult.Data ? 0 : 103;
                        r.Message = addResult.Data ? "" : "服务数据添加失败";
                    }
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
