using Hayaa.DataAccess;
using Hayaa.UserAuth.Service.Core.Config;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hayaa.UserAuth.Service.Core.DataAccess
{
    class LoginAuditDal : CommonDal
    {
        private static String con = ConfigHelper.Instance.GetConnection(DefineTable.DatabaseName);

       
        internal static LoginAudit Get(int sessionId)
        {
            string sql = "select * from LoginAudit where SessionId=@SessionId";

            return Get<LoginAudit>(con, sql, new { SessionId = sessionId });
        }

        internal static LoginAudit Add(LoginAudit info)
        {
            string sql = "insert into LoginAudit(SessionId,FailTotal) value(@SessionId,@FailTotal);select @@IDENTITY;";
            info.LoginAuditId= InsertWithReturnID<LoginAudit, int>(con, sql, info);
            return info;
        }
    }
}
