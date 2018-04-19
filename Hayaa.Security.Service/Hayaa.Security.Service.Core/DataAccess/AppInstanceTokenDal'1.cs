using System;
using System.Collections.Generic;
using System.Text;
using Hayaa.DataAccess;
using Hayaa.BaseModel;
using Hayaa.Security.Service.Config;

namespace Hayaa.Security.Service.Dao
{
    internal partial class AppInstanceTokenDal
    {
      
        internal static AppInstanceToken GetByAppInstanceId(int Id)
        {
            string sql = "select * from AppInstanceToken  where Status=1 and AppInstanceId=@AppInstanceId";
            return Get<AppInstanceToken>(con, sql, new { AppInstanceId = Id });
        }       
    }
}