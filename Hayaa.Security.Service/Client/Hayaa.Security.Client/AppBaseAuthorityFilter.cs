using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hayaa.Security.Client
{
  public  class AppBaseAuthorityFilter : IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            AppAuthority.AppAuthOnActionExecuting(context);
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
            
        }

     
    }
}
