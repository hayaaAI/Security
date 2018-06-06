using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hayaa.SecurityController
{
    [Route("api/[controller]/[action]")]
    public  class TestController: Controller
    {
        [HttpGet]
        public String Get()
        {
            return "test";
        }
    }
}
