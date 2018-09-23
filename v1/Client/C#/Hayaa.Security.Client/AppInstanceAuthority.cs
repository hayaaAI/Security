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
    class AppInstanceAuthority
    {
        public static void AppInstanceAuthOnActionExecuting(ActionExecutingContext context)
        {
            bool isPost = context.HttpContext.Request.Method.ToLower().Equals("post");
            String appInstanceToken = isPost ? context.HttpContext.Request.Form["apt"] : context.HttpContext.Request.Query["apt"];
            String strAppInstanceId = isPost ? context.HttpContext.Request.Form["aid"] : context.HttpContext.Request.Query["aid"];
            int appInstanceId = 0;
            int.TryParse(strAppInstanceId, out appInstanceId);
            if (appInstanceId > 0)
            {
              var authority= SecurityRoot.GetAuthority();
                if (authority != null)
                {                  
                      String actionName= context.ActionDescriptor.DisplayName;
                      String serviceName = context.RouteData.Values["Controller"].ToString();
                    Dictionary<string, List<string>> authorityData = SecurityRoot.GetAuthority();
                    if (authorityData.ContainsKey(serviceName))
                    {
                        if (!authorityData[serviceName].Exists(af=>af==actionName)) 
                        {
                            context.Result = new ContentResult() { Content = "功能未授权" };
                        }
                    }
                    else
                    {
                        context.Result = new ContentResult() { Content = "服务未授权" };
                    }
                }
                else
                {
                    context.Result = new ContentResult() { Content = "无授权数据" };
                }
            }
            else
            {
                context.Result = new ContentResult() { Content = "无授权标识" };
            }

        }
        public static void AppInstanceBaseAuthOnActionExecuting(ActionExecutingContext context)
        {
            bool isPost = context.HttpContext.Request.Method.ToLower().Equals("post");
            String appInstanceToken = isPost ? context.HttpContext.Request.Form["apt"] : context.HttpContext.Request.Query["apt"];
            String strAppInstanceId = isPost ? context.HttpContext.Request.Form["aid"] : context.HttpContext.Request.Query["aid"];
            int appInstanceId = 0;
            int.TryParse(strAppInstanceId, out appInstanceId);
            if (appInstanceId > 0)
            {
                var urlParamater = new Dictionary<string, string>();
                String response = HttpHelper.Transaction(ConfigHelper.Instance.GetComponentConfig().AppInstanceSecurityBaseAuthUrl, urlParamater);
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
