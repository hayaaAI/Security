using Hayaa.DataAccess;
using Hayaa.UserAuth.Service.Core.Config;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hayaa.UserAuth.Service.Core.DataAccess
{
    class CompanyLoginDal : CommonDal
    {
        private static String con = ConfigHelper.Instance.GetConnection(DefineTable.DatabaseName);


        internal static UserSession Get(string loginKey, string pwd)
        {
            string sql = "select 0 as SessionId,cli.UserId as UserId,'' as SessionKey,1 as Status from CompanyLoginInfo as cli inner join CompanyLoginPwd clp on cli.LoginInfoId=clp.LoginInfoId and  cli.Status=1 and clp.Status=1 where cli.LoginKey=@LoginKey and clp.LoginPwd=@LoginPwd";

            return Get<UserSession > (con, sql, new { LoginKey = loginKey, LoginPwd = pwd });
        }
    }
}
