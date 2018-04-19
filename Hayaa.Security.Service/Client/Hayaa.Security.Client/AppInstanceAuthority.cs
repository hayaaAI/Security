using Hayaa.ServicePlatform.Client;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hayaa.Security.Client
{
    class AppInstanceAuthority
    {
        public static void OnActionExecuting(ActionExecutingContext context)
        {
            bool isPost = context.HttpContext.Request.Method.ToLower().Equals("post");
            String appInstanceToken = isPost ? context.HttpContext.Request.Form["apt"] : context.HttpContext.Request.Query["apt"];
            String strAppInstanceId = isPost ? context.HttpContext.Request.Form["aid"] : context.HttpContext.Request.Query["aid"];
            int appInstanceId = 0;
            int.TryParse(strAppInstanceId, out appInstanceId);
            if (appInstanceId > 0)
            {
              var authority=  AppRoot.GetAuthority();
                if (authority != null)
                {                  
                      String actionName= context.ActionDescriptor.DisplayName;
                      String serviceName = context.RouteData.Values["Controller"].ToString();
                    Dictionary<string, List<string>> authorityData = AppRoot.GetAuthority();
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
    }
}
