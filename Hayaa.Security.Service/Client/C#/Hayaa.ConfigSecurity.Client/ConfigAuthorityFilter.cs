using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hayaa.ConfigSecurity.Client
{
    public class ConfigAuthorityFilter : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            bool isPost = context.HttpContext.Request.Method.ToLower().Equals("post");
            String strAppId = isPost ? context.HttpContext.Request.Form["appid"] : context.HttpContext.Request.Query["appid"];
            int appId = 0;
            int.TryParse(strAppId, out appId);
            if (appId > 0)
            {
                var urlParamater = new Dictionary<string, string>();
                String token = isPost ? context.HttpContext.Request.Form["apt"] : context.HttpContext.Request.Query["apt"];
                Boolean configResult = ConfigSecurityProvider.Auth(appId, token);
                if (!configResult)
                {
                    context.Result = new ContentResult() { Content = "未授权访问" };
                }
            }
            else
            {
                context.Result = new ContentResult() { Content = "无授权标识" };
            }
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
           
        }
    }
}
