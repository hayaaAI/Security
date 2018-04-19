using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hayaa.Security.Client
{
  public  class AppInstanceBaseAuthorityFilter : IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            AppInstanceAuthority.AppInstanceBaseAuthOnActionExecuting(context);
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
            
        }

     
    }
}
