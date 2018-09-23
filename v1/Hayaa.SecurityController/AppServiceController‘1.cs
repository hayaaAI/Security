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
 
    public partial class AppServiceController
    {
        [HttpPost]
        [Desc("AddAppToken", "添加app的token", "")]
        public TransactionResult<AppToken> AddAppToken(AppToken info)
        {
            var r = new TransactionResult<AppToken>();

            var asResult = appTokenService.Create(info);
                if (asResult.ActionResult && asResult.HavingData)
                {
                    r.Data = asResult.Data;
                }
                else
                {
                    r.Code = 103;
                    r.Message = "暂无数据";
                }
            
            return r;
        }
        [HttpPost]
        [Desc("EditAppToken", "编辑app的token", "根据主键更新数据")]
        public TransactionResult<Boolean> EditAppToken(AppToken info)
        {
            var r = new TransactionResult<Boolean>();

            var asResult = appTokenService.UpdateByID(info);
            if (asResult.ActionResult)
            {
                r.Data = asResult.Data;
            }
            else
            {
                r.Code = 103;
                r.Message = "暂无数据";
            }

            return r;
        }
        [HttpPost]
        [Desc("GetAppToken", "获取App的token", "根据appId获取指定的token")]
        public TransactionResult<AppToken> GetAppToken(int appid)
        {
            var r = new TransactionResult<AppToken>();
            if (appid == 0)
            {
                r.Code = 103;
                r.Message = "AppId不能为0";
            }
            if (appid > 0)
            {
                var asResult = appTokenService.GetByAppId(appid);
                if (asResult.ActionResult && asResult.HavingData)
                {
                    r.Data = asResult.Data;
                }
                else
                {
                    r.Code =103;
                    r.Message = "暂无数据";
                }
            }
            return r;
        }
       
    }
}
