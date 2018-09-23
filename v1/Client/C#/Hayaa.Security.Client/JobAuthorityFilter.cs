using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hayaa.Security.Client
{
  public  class JobAuthorityFilter : IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            JobAuthority.JobAuthorityOnActionExecuting(context);
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
            
        }

     
    }
}
