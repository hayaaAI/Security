using Hayaa.BaseModel.Model;
using Hayaa.Common;
using Hayaa.UserAuth.Service;
using Hayaa.UserAuth.Service.Core;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hayaa.UserAuth.Controller
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserAuthController : ControllerBase
    {
        IUserAuthoService userAuthoService = new UserAuthoServer();
        [HttpPost]
        [HttpGet]
        [EnableCors("any")]
        public TransactionResult<String> CompanyUserLogin([FromForm] string loginKey, [FromForm] string pwd, [FromForm] string sessionKey)
        {
            TransactionResult<String> result = new TransactionResult<String>();
            var serviceResult = userAuthoService.CompanyUserLogin(loginKey, pwd, sessionKey);
            if (serviceResult.ActionResult)
            {
                result.Data = serviceResult.Data;
            }
            else
            {
                result.Code = serviceResult.ErrorCode;
                result.Message = serviceResult.ErrorMsg;
            }
            return result;
        }
    }
}
