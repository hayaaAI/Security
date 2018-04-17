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
    internal partial class Rel_App_AppFunctionDal : CommonDal
    {
        private static String con = ConfigHelper.Instance.GetConnection(DefineTable.DatabaseName);
        internal static int Add(Rel_App_AppFunction info)
        {
            string sql = "insert into Rel_App_AppFunction(Id,AppId,AppFunctionId) values(@Id,@AppId,@AppFunctionId)";
            return Insert<Rel_App_AppFunction>(con, sql, info);
        }
        internal static int Update(Rel_App_AppFunction info)
        {
            string sql = "update Rel_App_AppFunction set Id=@Id,AppId=@AppId,AppFunctionId=@AppFunctionId where Rel_App_AppFunctionId=@Rel_App_AppFunctionId";
            return Insert<Rel_App_AppFunction>(con, sql, info);
        }
        internal static bool Delete(List<int> IDs)
        {
            string sql = "delete from  Rel_App_AppFunction where Rel_App_AppFunctionId in @ids";
            return Excute(con, sql, new { ids = IDs.ToArray() }) > 0;
        }
        internal static Rel_App_AppFunction Get(int Id)
        {
            string sql = "select * from Rel_App_AppFunction  where Rel_App_AppFunctionId=@Rel_App_AppFunctionId";
            return Get<Rel_App_AppFunction>(con, sql, new { Rel_App_AppFunctionId = Id });
        }
        //internal static List<Rel_App_AppFunction> GetList(Rel_App_AppFunctionSearchPamater pamater)
        //{
        //    string sql = "select * from Rel_App_AppFunction " + pamater.CreateWhereSql();
        //    return GetList<Rel_App_AppFunction>(con, sql, pamater);
        //}
       
    }
}