using System;
using System.Collections.Generic;
using System.Text;
using Hayaa.DataAccess;
using Hayaa.BaseModel;
using Hayaa.Security.Service.Config;

namespace Hayaa.Security.Service.Dao
{
    internal partial class Rel_AppInstance_AppServiceDal
    {
       
        internal static int UpdateAppInstanceId(Rel_AppInstance_AppService info)
        {
            string sql = "update Rel_AppInstance_AppService set AppService=@AppService where AppInstanceId=@AppInstanceId";
            return Update<Rel_AppInstance_AppService>(con, sql, info);
        }
        internal static Rel_AppInstance_AppService GetByAppInstanceId(int Id)
        {
            string sql = "select * from Rel_AppInstance_AppService  where AppInstanceId=@AppInstanceId";
            return Get<Rel_AppInstance_AppService>(con, sql, new { AppInstanceId = Id });
        }

    }
}