using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hayaa.Security.Client
{
  public  class AppBaseAuthorityFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            AppAuthority.AppAuthOnActionExecuting(context);
        }
    }
}
