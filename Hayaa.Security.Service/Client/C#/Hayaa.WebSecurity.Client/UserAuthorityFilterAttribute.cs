using Hayaa.BaseModel;
using Hayaa.BaseModel.Model;
using Hayaa.Common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;


namespace Hayaa.CompanyWebSecurity.Client
{
  public  class UserAuthorityFilterAttribute : ActionFilterAttribute
    {
        /// <summary>
        /// 仅支持form格式数据提交
        /// </summary>
        /// <param name="context"></param>
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var request = context.HttpContext.Request;
            bool isPost = request.Method.ToLower().Equals("post");
            bool isJson = request.Headers.Values.Contains("application/json, text/plain, */*");
            var urlParamater = new Dictionary<string, string>();
            var requestFrom = context.HttpContext.Request.Form;
            var requestQuery= context.HttpContext.Request.Query;
            String token = isPost?requestFrom["authtoken"]: requestQuery["authtoken"];
            String path = context.HttpContext.Request.Path;
            int userId = UserSecurityProvider.BaseAuth(token);
            Boolean baseAuth = userId > 0;
            if (!baseAuth)
            {
                context.Result = new JsonResult(new TransactionResult<bool>()
                {                   
                    Data = false,
                    Code = ErrorCode.LoginFail,
                    Message = "未登陆"
                });
                return;
            }
            Boolean configResult = (userId > 0) ? UserSecurityProvider.PermissionAuth(userId, path, userId > 0) : false;
            if (!configResult)
            {
                context.Result = new JsonResult(new TransactionResult<bool>()
                {
                   
                    Data = false,
                    Code = ErrorCode.NoPermission,
                    Message = "未授权"
                });
            }
        }
    }
}
