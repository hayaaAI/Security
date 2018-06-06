using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hayaa.TestController
{
    [Route("api/[controller]/[action]")]
    public  class Test1Controller: Controller
    {
        [HttpGet]
        public String Get()
        {
            return "test";
        }
    }
}
