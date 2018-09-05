using Hayaa.BaseModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hayaa.UserAuth.Service
{
  public  class UserSession: BaseData
    {
        public int SessionId { set; get; }
        public int UserId { set; get; }
        public String SessionKey { set; get; }
        public short Status { set; get; }
    }
}
