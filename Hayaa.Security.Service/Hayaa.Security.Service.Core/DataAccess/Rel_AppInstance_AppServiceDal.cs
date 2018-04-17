using System;
using System.Collections.Generic;
using System.Text;
using Hayaa.DataAccess;
using Hayaa.BaseModel;
using Hayaa.Security.Service.Config;
/// <summary>
///代码效率工具生成，此文件不要修改
/// </summary>
namespace Hayaa.Security.Service.Dao
{
    internal partial class Rel_AppInstance_AppServiceDal : CommonDal
    {
        private static String con = ConfigHelper.Instance.GetConnection(DefineTable.DatabaseName);
        internal static int Add(Rel_AppInstance_AppService info)
        {
            string sql = "insert into Rel_AppInstance_AppService(Id,AppInstanceId,AppService,IsCompare) values(@Id,@AppInstanceId,@AppService,@IsCompare)";
            return Insert<Rel_AppInstance_AppService>(con, sql, info);
        }
       
        internal static bool Delete(List<int> IDs)
        {
            string sql = "delete from  Rel_AppInstance_AppService where Rel_AppInstance_AppServiceId in @ids";
            return Excute(con, sql, new { ids = IDs.ToArray() }) > 0;
        }
        internal static Rel_AppInstance_AppService Get(int Id)
        {
            string sql = "select * from Rel_AppInstance_AppService  where Rel_AppInstance_AppServiceId=@Rel_AppInstance_AppServiceId";
            return Get<Rel_AppInstance_AppService>(con, sql, new { Rel_AppInstance_AppServiceId = Id });
        }
     
    }
}