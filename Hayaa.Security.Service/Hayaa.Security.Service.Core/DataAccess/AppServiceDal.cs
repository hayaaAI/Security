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
    internal partial class AppServiceDal : CommonDal
    {
        private static String con = ConfigHelper.Instance.GetConnection(DefineTable.DatabaseName);
       
        internal static int Update(AppService info)
        {
            string sql = "update AppService set Name=@Name,Title=@Title,AppId=@AppId,Status=@Status where AppServiceId=@AppServiceId";
            return Update<AppService>(con, sql, info);
        }
        internal static bool Delete(List<int> IDs)
        {
            string sql = "delete from  AppService where AppServiceId in @ids";
            return Excute(con, sql, new { ids = IDs.ToArray() }) > 0;
        }
        internal static AppService Get(int Id)
        {
            string sql = "select * from AppService  where AppServiceId=@AppServiceId";
            return Get<AppService>(con, sql, new { AppServiceId = Id });
        }
        internal static List<AppService> GetList(AppServiceSearchPamater pamater)
        {
            string sql = "select * from AppService " + pamater.CreateWhereSql();
            return GetList<AppService>(con, sql, pamater);
        }
        internal static GridPager<AppService> GetGridPager(GridPagerPamater<AppServiceSearchPamater> pamater)
        {
            string sql = "select SQL_CALC_FOUND_ROWS * from AppService " + pamater.SearchPamater.CreateWhereSql() + " limit @Start,*@PageSize;select FOUND_ROWS();";
            pamater.SearchPamater.Start = (pamater.Current - 1) * pamater.PageSize;
            pamater.SearchPamater.PageSize = pamater.PageSize;
            return GetGridPager<AppService>(con, sql, pamater.PageSize, pamater.Current, pamater.SearchPamater);
        }

     
    }
}