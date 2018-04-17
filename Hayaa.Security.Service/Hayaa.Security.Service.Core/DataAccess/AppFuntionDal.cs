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
    internal partial class AppFuntionDal : CommonDal
    {
        private static String con = ConfigHelper.Instance.GetConnection(DefineTable.DatabaseName);
        internal static int Add(AppFuntion info)
        {
            string sql = "insert into AppFuntion(FuntionName,PathName,Title,Status,AppServiceId) values(@FuntionName,@PathName,@Title,@Status,@AppServiceId)";
            return Insert<AppFuntion>(con, sql, info);
        }
        internal static int Update(AppFuntion info)
        {
            string sql = "update AppFuntion set FuntionName=@FuntionName,PathName=@PathName,Title=@Title,Status=@Status,AppServiceId=@AppServiceId where AppFuntionId=@AppFuntionId";
            return Insert<AppFuntion>(con, sql, info);
        }
        internal static bool Delete(List<int> IDs)
        {
            string sql = "delete from  AppFuntion where AppFuntionId in @ids";
            return Excute(con, sql, new { ids = IDs.ToArray() }) > 0;
        }
        internal static AppFuntion Get(int Id)
        {
            string sql = "select * from AppFuntion  where AppFuntionId=@AppFuntionId";
            return Get<AppFuntion>(con, sql, new { AppFuntionId = Id });
        }
        internal static List<AppFuntion> GetList(AppFuntionSearchPamater pamater)
        {
            string sql = "select * from AppFuntion " + pamater.CreateWhereSql();
            return GetList<AppFuntion>(con, sql, pamater);
        }
        internal static GridPager<AppFuntion> GetGridPager(GridPagerPamater<AppFuntionSearchPamater> pamater)
        {
            string sql = "select SQL_CALC_FOUND_ROWS * from AppFuntion " + pamater.SearchPamater.CreateWhereSql() + " limit @Start,*@PageSize;select FOUND_ROWS();";
            pamater.SearchPamater.Start = (pamater.Current - 1) * pamater.PageSize;
            pamater.SearchPamater.PageSize = pamater.PageSize;
            return GetGridPager<AppFuntion>(con, sql, pamater.PageSize, pamater.Current, pamater.SearchPamater);
        }
    }
}