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
    internal partial class JobTokenDal : CommonDal
    {
        private static String con = ConfigHelper.Instance.GetConnection(DefineTable.DatabaseName);
        internal static int Add(JobToken info)
        {
            string sql = "insert into JobToken(JobId,UserId,Token,EndTime) values(@JobId,@UserId,@Token,@EndTime)";
            return Insert<JobToken>(con, sql, info);
        }
        internal static int Update(JobToken info)
        {
            string sql = "update JobToken set JobId=@JobId,UserId=@UserId,Token=@Token,EndTime=@EndTime where JobTokenId=@JobTokenId";
            return Update<JobToken>(con, sql, info);
        }
        internal static bool Delete(List<int> IDs)
        {
            string sql = "delete from  JobToken where JobTokenId in @ids";
            return Excute(con, sql, new { ids = IDs.ToArray() }) > 0;
        }
        internal static JobToken Get(int Id)
        {
            string sql = "select * from JobToken  where JobTokenId=@JobTokenId";
            return Get<JobToken>(con, sql, new { JobTokenId = Id });
        }
        internal static List<JobToken> GetList(JobTokenSearchPamater pamater)
        {
            string sql = "select * from JobToken " + pamater.CreateWhereSql();
            return GetList<JobToken>(con, sql, pamater);
        }
        internal static GridPager<JobToken> GetGridPager(GridPagerPamater<JobTokenSearchPamater> pamater)
        {
            string sql = "select SQL_CALC_FOUND_ROWS * from JobToken " + pamater.SearchPamater.CreateWhereSql() + " limit @Start,*@PageSize;select FOUND_ROWS();";
            pamater.SearchPamater.Start = (pamater.Current - 1) * pamater.PageSize;
            pamater.SearchPamater.PageSize = pamater.PageSize;
            return GetGridPager<JobToken>(con, sql, pamater.PageSize, pamater.Current, pamater.SearchPamater);
        }
    }
}