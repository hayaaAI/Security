using Hayaa.BaseModel.Model;
using Hayaa.Common;
using Hayaa.Security.Client.Config;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hayaa.Security.Client
{
    class AppAuthority
    {
        public static void AppAuthOnActionExecuting(ActionExecutingContext context)
        {
            bool isPost = context.HttpContext.Request.Method.ToLower().Equals("post");           
            String strAppId = isPost ? context.HttpContext.Request.Form["appid"] : context.HttpContext.Request.Query["appid"];
            int appId = 0;
            int.TryParse(strAppId, out appId);
            if (appId > 0)
            {
                var urlParamater = new Dictionary<string, string>();
                String response = HttpHelper.Transaction(ConfigHelper.Instance.GetComponentConfig().AppSecurityBaseAuthUrl, urlParamater);
                TransactionResult<Boolean> serverResult = JsonHelper.DeserializeSafe<TransactionResult<Boolean>>(response);
                if (serverResult.Code != 0)
                {
                    context.Result = new ContentResult() { Content = "未授权访问" };
                }
            }
            else
            {
                context.Result = new ContentResult() { Content = "无授权标识" };
            }
        }
    }
}
