using Hayaa.BaseModel;
using System;

namespace Hayaa.UserAuth.Service
{
    public class LoginAudit:BaseData
    {
        public int LoginAuditId { set; get; }
        public int SessionId { set; get; }
        public int FailTotal { set; get; }
    }
}
