using System;
using System.Collections.Generic;
using System.Text;

namespace Hayaa.Security.Service.Dao
{
   internal partial class AppTokenDal
    {
        internal static AppToken Get(int appId,String token)
        {
            string sql = "select * from AppToken  where Status=1 and AppId=@AppId and Token=@Token";
            return Get<AppToken>(con, sql, new { AppId = appId,Token=token });
        }
    }
}
