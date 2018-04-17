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
    internal partial class Rel_Job_AppFunctionDal : CommonDal
    {
        private static String con = ConfigHelper.Instance.GetConnection(DefineTable.DatabaseName);
        internal static int Add(Rel_Job_AppFunction info)
        {
            string sql = "insert into Rel_Job_AppFunction(Id,JobId,AppFunctionId) values(@Id,@JobId,@AppFunctionId)";
            return Insert<Rel_Job_AppFunction>(con, sql, info);
        }
        internal static int Update(Rel_Job_AppFunction info)
        {
            string sql = "update Rel_Job_AppFunction set Id=@Id,JobId=@JobId,AppFunctionId=@AppFunctionId where Rel_Job_AppFunctionId=@Rel_Job_AppFunctionId";
            return Insert<Rel_Job_AppFunction>(con, sql, info);
        }
        internal static bool Delete(List<int> IDs)
        {
            string sql = "delete from  Rel_Job_AppFunction where Rel_Job_AppFunctionId in @ids";
            return Excute(con, sql, new { ids = IDs.ToArray() }) > 0;
        }
        internal static Rel_Job_AppFunction Get(int Id)
        {
            string sql = "select * from Rel_Job_AppFunction  where Rel_Job_AppFunctionId=@Rel_Job_AppFunctionId";
            return Get<Rel_Job_AppFunction>(con, sql, new { Rel_Job_AppFunctionId = Id });
        }
        //internal static List<Rel_Job_AppFunction> GetList(Rel_Job_AppFunctionSearchPamater pamater)
        //{
        //    string sql = "select * from Rel_Job_AppFunction " + pamater.CreateWhereSql();
        //    return GetList<Rel_Job_AppFunction>(con, sql, pamater);
        //}
        
    }
}