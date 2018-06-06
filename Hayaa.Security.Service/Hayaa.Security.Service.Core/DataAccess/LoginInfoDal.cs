using System;
using System.Collections.Generic;
using System.Text;
using Hayaa.DataAccess;
using Hayaa.BaseModel;
using Hayaa.Security.Service.Config;
/// <summary>
///代码效率工具生成，此文件不要修改
/// </summary>
namespace Hayaa.Security.Service.Dao{

internal partial class LoginInfoDal : CommonDal
{
    private static String con = ConfigHelper.Instance.GetConnection(DefineTable.DatabaseName);
    internal static int Add(LoginInfo info, bool isReturn = true)
    {
        string sql = null;
            if (isReturn)
        {
            sql = "insert into LoginInfo(LoginKey,UserId,Status) values(@LoginKey,@UserId,@Status);select @@IDENTITY;";
            return InsertWithReturnID<LoginInfo,int>(con, sql, info);
        }
        else
        {
            sql = "insert into LoginInfo(LoginKey,UserId,Status) values(@LoginKey,@UserId,@Status);";
            return Insert<LoginInfo>(con, sql, info);
        }
    }
    internal static int Update(LoginInfo info)
    {
        string sql = "update LoginInfo set LoginKey=@LoginKey,UserId=@UserId,Status=@Status where LoginInfoId=@LoginInfoId";
        return Update<LoginInfo>(con, sql, info);
    }
    internal static bool Delete(List<int> IDs)
    {
        string sql = "delete from  LoginInfo where LoginInfoId in @ids";
        return Excute(con, sql, new { ids = IDs.ToArray() }) > 0;
    }
    internal static LoginInfo Get(int Id)
    {
        string sql = "select * from LoginInfo  where LoginInfoId=@LoginInfoId";
        return Get<LoginInfo>(con, sql, new { LoginInfoId = Id });
    }
    internal static List<LoginInfo> GetList(LoginInfoSearchPamater pamater)
    {
        string sql = "select * from LoginInfo " + pamater.CreateWhereSql();
        return GetList<LoginInfo>(con, sql, pamater);
    }
    internal static GridPager<LoginInfo> GetGridPager(GridPagerPamater<LoginInfoSearchPamater> pamater)
    {
        string sql = "select SQL_CALC_FOUND_ROWS * from LoginInfo " + pamater.SearchPamater.CreateWhereSql() + " limit @Start,@PageSize;select FOUND_ROWS();";
        pamater.SearchPamater.Start = (pamater.Current - 1) * pamater.PageSize;
        pamater.SearchPamater.PageSize = pamater.PageSize;
        return GetGridPager<LoginInfo>(con, sql, pamater.PageSize, pamater.Current, pamater.SearchPamater);
    }
}}