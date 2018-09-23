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
    internal partial class AppGrantDal : CommonDal
    {
        private static String con = ConfigHelper.Instance.GetConnection(DefineTable.DatabaseName);
        internal static int Add(AppGrant info)
        {
            string sql = "insert into AppGrant(AppId,AppServiceId,AppFunctionId) values(@AppId,@AppServiceId,@AppFunctionId)";
            return Insert<AppGrant>(con, sql, info);
        }
        internal static int Update(AppGrant info)
        {
            string sql = "update AppGrant set AppId=@AppId,AppServiceId=@AppServiceId,AppFunctionId=@AppFunctionId where AppGrantId=@AppGrantId";
            return Update<AppGrant>(con, sql, info);
        }
        internal static bool Delete(List<int> IDs)
        {
            string sql = "delete from  AppGrant where AppGrantId in @ids";
            return Excute(con, sql, new { ids = IDs.ToArray() }) > 0;
        }
        internal static AppGrant Get(int Id)
        {
            string sql = "select * from AppGrant  where AppGrantId=@AppGrantId";
            return Get<AppGrant>(con, sql, new { AppGrantId = Id });
        }
        internal static List<AppGrant> GetList(AppGrantSearchPamater pamater)
        {
            string sql = "select * from AppGrant " + pamater.CreateWhereSql();
            return GetList<AppGrant>(con, sql, pamater);
        }
        internal static GridPager<AppGrant> GetGridPager(GridPagerPamater<AppGrantSearchPamater> pamater)
        {
            string sql = "select SQL_CALC_FOUND_ROWS * from AppGrant " + pamater.SearchPamater.CreateWhereSql() + " limit @Start,*@PageSize;select FOUND_ROWS();";
            pamater.SearchPamater.Start = (pamater.Current - 1) * pamater.PageSize;
            pamater.SearchPamater.PageSize = pamater.PageSize;
            return GetGridPager<AppGrant>(con, sql, pamater.PageSize, pamater.Current, pamater.SearchPamater);
        }
    }
}