using Hayaa.BaseModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hayaa.Security.Service
{
   public class LoginToken : BaseData
    {
        public int LoginTokenId { set; get; }
        public int UserId { set; get; }
        public String Token { set; get; }
        public DateTime EndTime { set; get; }
        public Boolean Status { set; get; }
    }
}
