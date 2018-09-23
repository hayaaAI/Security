using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hayaa.Security.Client
{
    public class AppInstanceAuthorityFilter : IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            AppInstanceAuthority.AppInstanceAuthOnActionExecuting(context);
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
           
        }

       
    }
}
