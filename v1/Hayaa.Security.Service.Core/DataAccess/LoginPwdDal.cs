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
    internal partial class LoginPwdDal : CommonDal
    {
        private static String con = ConfigHelper.Instance.GetConnection(DefineTable.DatabaseName);
        internal static int Add(LoginPwdInfo info, bool isReturn = true)
        {
            string sql = null; if (isReturn)
            {
                sql = "insert into LoginPwd(LoginPwd,LoginInfoId,Status) values(@LoginPwd,@LoginInfoId,@Status);select @@IDENTITY;";
                return InsertWithReturnID<LoginPwdInfo, int>(con, sql, info);
            }
            else
            {
                sql = "insert into LoginPwd(LoginPwd,LoginInfoId,Status) values(@LoginPwd,@LoginInfoId,@Status);";
                return Insert<LoginPwdInfo>(con, sql, info);
            }
        }
        internal static int Update(LoginPwdInfo info)
        {
            string sql = "update LoginPwd set LoginPwd=@LoginPwd,LoginInfoId=@LoginInfoId,Status=@Status where LoginPwdId=@LoginPwdId";
            return Update<LoginPwdInfo>(con, sql, info);
        }
        internal static bool Delete(List<int> IDs)
        {
            string sql = "delete from  LoginPwd where LoginPwdId in @ids";
            return Excute(con, sql, new { ids = IDs.ToArray() }) > 0;
        }
        internal static LoginPwdInfo Get(int Id)
        {
            string sql = "select * from LoginPwd  where LoginPwdId=@LoginPwdId";
            return Get<LoginPwdInfo>(con, sql, new { LoginPwdId = Id });
        }
        internal static List<LoginPwdInfo> GetList(LoginPwdSearchPamater pamater)
        {
            string sql = "select * from LoginPwd " + pamater.CreateWhereSql();
            return GetList<LoginPwdInfo>(con, sql, pamater);
        }
        internal static GridPager<LoginPwdInfo> GetGridPager(GridPagerPamater<LoginPwdSearchPamater> pamater)
        {
            string sql = "select SQL_CALC_FOUND_ROWS * from LoginPwd " + pamater.SearchPamater.CreateWhereSql() + " limit @Start,@PageSize;select FOUND_ROWS();";
            pamater.SearchPamater.Start = (pamater.Current - 1) * pamater.PageSize;
            pamater.SearchPamater.PageSize = pamater.PageSize;
            return GetGridPager<LoginPwdInfo>(con, sql, pamater.PageSize, pamater.Current, pamater.SearchPamater);
        }
    }
}