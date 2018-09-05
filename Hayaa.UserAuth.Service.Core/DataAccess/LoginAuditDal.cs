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

        internal static int Add(LoginAudit info)
        {
            string sql = "insert into UserSession(SessionId,FailTotal) value(@SessionId,@FailTotal);select @@IDENTITY;";
            return InsertWithReturnID<LoginAudit, int>(con, sql, info);
        }
    }
}
