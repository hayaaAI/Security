﻿using Hayaa.BaseModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hayaa.WorkerSecurity.Client
{
  public  class UserAuthorityFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            bool isPost = context.HttpContext.Request.Method.ToLower().Equals("post");

            var urlParamater = new Dictionary<string, string>();
            String token = isPost ? context.HttpContext.Request.Form["authtoken"] : context.HttpContext.Request.Query["authtoken"];
            Boolean configResult = WorkerSecurityProvider.UserAuth(token);
            if (!configResult)
            {
                context.Result = new JsonResult(new FunctionOpenResult<bool>()
                {
                    ActionResult = false,
                    Data = false,
                    ErrorCode = 403,
                    ErrorMsg = "未登陆"
                });
            }
        }
    }
}
