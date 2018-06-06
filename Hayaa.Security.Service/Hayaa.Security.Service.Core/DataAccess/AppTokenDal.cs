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
    internal partial class AppTokenDal : CommonDal
    {
        private static String con = ConfigHelper.Instance.GetConnection(DefineTable.DatabaseName);
        internal static int Add(AppToken info)
        {
            string sql = "insert into AppToken(AppId,Token,Status) values(@AppId,@Token,@Status);select @@IDENTITY;";
            return InsertWithReturnID<AppToken,int>(con, sql, info);
        }
        internal static int Update(AppToken info)
        {
            string sql = "update AppToken set AppId=@AppId,Token=@Token,Status=@Status where AppTokenId=@AppTokenId";
            return Update<AppToken>(con, sql, info);
        }
        internal static bool Delete(List<int> IDs)
        {
            string sql = "delete from  AppToken where AppTokenId in @ids";
            return Excute(con, sql, new { ids = IDs.ToArray() }) > 0;
        }
        internal static AppToken Get(int Id)
        {
            string sql = "select * from AppToken  where AppTokenId=@AppTokenId";
            return Get<AppToken>(con, sql, new { AppTokenId = Id });
        }
        internal static List<AppToken> GetList(AppTokenSearchPamater pamater)
        {
            string sql = "select * from AppToken " + pamater.CreateWhereSql();
            return GetList<AppToken>(con, sql, pamater);
        }
        internal static GridPager<AppToken> GetGridPager(GridPagerPamater<AppTokenSearchPamater> pamater)
        {
            string sql = "select SQL_CALC_FOUND_ROWS * from AppToken " + pamater.SearchPamater.CreateWhereSql() + " limit @Start,*@PageSize;select FOUND_ROWS();";
            pamater.SearchPamater.Start = (pamater.Current - 1) * pamater.PageSize;
            pamater.SearchPamater.PageSize = pamater.PageSize;
            return GetGridPager<AppToken>(con, sql, pamater.PageSize, pamater.Current, pamater.SearchPamater);
        }
    }
}