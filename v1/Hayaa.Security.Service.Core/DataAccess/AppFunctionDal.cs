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
    internal partial class AppFunctionDal : CommonDal
    {
        private static String con = ConfigHelper.Instance.GetConnection(DefineTable.DatabaseName);
       

      

        internal static int Update(AppFunction info)
        {
            string sql = "update AppFunction set FunctionName=@FunctionName,PathName=@PathName,Title=@Title,Status=@Status,AppServiceId=@AppServiceId where AppFunctionId=@AppFunctionId";
            return Update<AppFunction>(con, sql, info);
        }
        internal static bool Delete(List<int> IDs)
        {
            string sql = "delete from  AppFunction where AppFunctionId in @ids";
            return Excute(con, sql, new { ids = IDs.ToArray() }) > 0;
        }
        internal static AppFunction Get(int Id)
        {
            string sql = "select * from AppFunction  where AppFunctionId=@AppFunctionId";
            return Get<AppFunction>(con, sql, new { AppFunctionId = Id });
        }
        internal static List<AppFunction> GetList(AppFunctionSearchPamater pamater)
        {
            string sql = "select * from AppFunction " + pamater.CreateWhereSql();
            return GetList<AppFunction>(con, sql, pamater);
        }
        internal static GridPager<AppFunction> GetGridPager(GridPagerPamater<AppFunctionSearchPamater> pamater)
        {
            string sql = "select SQL_CALC_FOUND_ROWS * from AppFunction " + pamater.SearchPamater.CreateWhereSql() + " limit @Start,*@PageSize;select FOUND_ROWS();";
            pamater.SearchPamater.Start = (pamater.Current - 1) * pamater.PageSize;
            pamater.SearchPamater.PageSize = pamater.PageSize;
            return GetGridPager<AppFunction>(con, sql, pamater.PageSize, pamater.Current, pamater.SearchPamater);
        }
    }
}