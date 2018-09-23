using Hayaa.DataAccess;
using Hayaa.Security.Service.Config;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hayaa.Security.Service.Dao
{
    class LoginDal : CommonDal
    {
        private static String con = ConfigHelper.Instance.GetConnection(DefineTable.DatabaseName);

        internal static LoginInfo Login(string loginKey, string pwd)
        {
            string sql = "select li.* from LoginInfo as li inner join LoginPwd as lp on li.LoginInfoId=lp.LoginInfoId and li.Status=1 and lp.Status=1  where li.LoginKey=@LoginKey and  lp.LoginPwd=@LoginPwd";
            return Get<LoginInfo>(con, sql, new { LoginKey = loginKey, LoginPwd= pwd });
        }

        internal static LoginInfo MobileLogin(string mobile, string code)
        {
            //string sql = "select li.* from LoginInfo as li inner join LoginPwd as lp on li.LoginInfoId=lp.LoginInfoId and li.Status=1 and lp.Status=1  where li.LoginKey=@LoginKey and  lp.LoginPwd=@LoginPwd";
            //return Get<LoginInfo>(con, sql, new { LoginKey = loginKey, LoginPwd = pwd });
            return null;
        }
    }
}
