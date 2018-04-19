using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace Hayaa.Security.Client
{
    public class AppInstanceAuthorityFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            AppInstanceAuthority.OnActionExecuting(context);
        }
    }
}
