using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hayaa.Security.Client
{
  public  class JobAuthorityFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            JobAuthority.JobAuthorityOnActionExecuting(context);
        }
    }
}
