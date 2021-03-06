﻿using Hayaa.BaseModel;
using Hayaa.Common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hayaa.CompanyWebSecurity.Client
{
    public class UserAuthorityFilter : IActionFilter
    {
        /// <summary>
        /// 仅支持form格式数据提交
        /// </summary>
        /// <param name="context"></param>
        public void OnActionExecuted(ActionExecutedContext context)
        {
            bool isPost = context.HttpContext.Request.Method.ToLower().Equals("post");

            var urlParamater = new Dictionary<string, string>();
            String token = isPost ? context.HttpContext.Request.Form["authtoken"] : context.HttpContext.Request.Query["authtoken"];
            String path = context.HttpContext.Request.Path;
            int userId = UserSecurityProvider.BaseAuth(token);
            Boolean baseAuth = userId > 0;
            if (!baseAuth) {
                context.Result = new JsonResult(new FunctionOpenResult<bool>()
                {
                    ActionResult = false,
                    Data = false,
                    ErrorCode = ErrorCode.LoginFail,
                    ErrorMsg = "未登陆"
                });
                return;
            }
            Boolean configResult =(userId > 0)? UserSecurityProvider.PermissionAuth(userId, path, userId>0):false;
            if (!configResult)
            {
                context.Result = new JsonResult(new FunctionOpenResult<bool>() {
                     ActionResult=false,
                      Data=false,
                       ErrorCode= ErrorCode.NoPermission,
                        ErrorMsg="未授权"
                });
            }

        }

        public void OnActionExecuting(ActionExecutingContext context)
        {

        }
    }
}
