using Hayaa.DataAccess;
using Hayaa.Security.Service.Config;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hayaa.Security.Service.Dao
{
   internal partial class LoginTokenDal: CommonDal
    {
        private static String con = ConfigHelper.Instance.GetConnection(DefineTable.DatabaseName);
        internal static int Add(LoginToken info)
        {
            string sql = "insert into LoginToken(LoginTokenId,UserId,Token,EndTime,Status) values(@LoginTokenId,@UserId,@Token,@EndTime,@Status)";
            return Insert<LoginToken>(con, sql, info);
        }
    }
}
