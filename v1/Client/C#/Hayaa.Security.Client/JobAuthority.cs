using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hayaa.Security.Client
{
  internal class JobAuthority
    {
        public static void JobAuthorityOnActionExecuting(ActionExecutingContext context)
        {
            bool isPost = context.HttpContext.Request.Method.ToLower().Equals("post");
            String token = isPost ? context.HttpContext.Request.Form["jt"] : context.HttpContext.Request.Query["jt"];          
            if (!String.IsNullOrEmpty(token))
            {
                var authority = JobAuthorityCache.GetJobAuthData(token);
                if (authority != null)
                {
                    String actionName = context.ActionDescriptor.DisplayName;
                    String serviceName = context.RouteData.Values["Controller"].ToString();
                    Dictionary<string, List<string>> authorityData = SecurityRoot.GetAuthority();
                    if (authorityData.ContainsKey(serviceName))
                    {
                        if (!authorityData[serviceName].Exists(af => af == actionName))
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
