using System;
using System.Collections.Generic;
using Hayaa.BaseModel;
namespace Hayaa.Security.Service
{
    public class LoginPwdInfo : BaseData
    {
        public int LoginPwdId { set; get; }
        public String LoginPwd { set; get; }
        public int LoginInfoId { set; get; }
        public bool Status { set; get; }
     
    }
}