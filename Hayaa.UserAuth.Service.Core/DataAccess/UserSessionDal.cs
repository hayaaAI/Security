using Hayaa.DataAccess;
using Hayaa.UserAuth.Service.Core.Config;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hayaa.UserAuth.Service.Core.DataAccess
{
    class UserSessionDal : CommonDal
    {
        private static String con = ConfigHelper.Instance.GetConnection(DefineTable.DatabaseName);

        internal static UserSession Get(string sessionKey)
        {
            string sql = "select * from UserSession where SessionKey=@SessionKey and Status=1";

            return Get<UserSession>(con, sql, new { SessionKey=sessionKey });
        }

        internal static int Add(UserSession info)
        {
            string sql = "insert into UserSession(UserId,SessionKey,Status) value(@UserId,@SessionKey,@Status);select @@IDENTITY;";
            return InsertWithReturnID<UserSession, int>(con, sql, info);
        }
    }
}
