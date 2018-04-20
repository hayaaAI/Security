using System;
using System.Collections.Generic;
using System.Text;
using Hayaa.DataAccess;
using Hayaa.BaseModel;
using Hayaa.Security.Service.Config;
/// <summary>
///代码效率工具生成，此文件不要修改
/// </summary>
namespace Hayaa.Security.Service.Dao{internal partial class JobGrantDal:CommonDal{
private static String con= ConfigHelper.Instance.GetConnection(DefineTable.DatabaseName);
internal static int Add(JobGrant info){
 string sql = "insert into JobGrant(JobId,AppServiceId,AppFunctionId) values(@JobId,@AppServiceId,@AppFunctionId)";
return Insert<JobGrant>(con,sql, info);
}
internal static int Update(JobGrant info){
 string sql = "update JobGrant set JobId=@JobId,AppServiceId=@AppServiceId,AppFunctionId=@AppFunctionId where JobGrantId=@JobGrantId";
return Update<JobGrant>(con,sql, info);
}
internal static bool Delete(List<int> IDs){
 string sql = "delete from  JobGrant where JobGrantId in @ids";
return Excute(con,sql, new { ids = IDs.ToArray() }) > 0;
}
internal static JobGrant Get(int Id){
 string sql = "select * from JobGrant  where JobGrantId=@JobGrantId";
return Get<JobGrant>(con,sql,new{ JobGrantId=Id });
}
internal static List<JobGrant> GetList(JobGrantSearchPamater pamater){
 string sql = "select * from JobGrant "+pamater.CreateWhereSql();
return GetList<JobGrant>(con,sql,pamater);
}
internal static GridPager<JobGrant> GetGridPager(GridPagerPamater<JobGrantSearchPamater> pamater){
 string sql = "select SQL_CALC_FOUND_ROWS * from JobGrant "+pamater.SearchPamater.CreateWhereSql()+" limit @Start,*@PageSize;select FOUND_ROWS();";
 pamater.SearchPamater.Start = (pamater.Current-1)* pamater.PageSize;
pamater.SearchPamater.PageSize = pamater.PageSize;
return GetGridPager<JobGrant>(con,sql, pamater.PageSize, pamater.Current, pamater.SearchPamater);
}
}}