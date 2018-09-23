using System;
using System.Collections.Generic;
using System.Text;
using Hayaa.DataAccess;
using Hayaa.BaseModel;
using Hayaa.Security.Service.Config;
/// <summary>
///代码效率工具生成，此文件不要修改
/// </summary>
namespace Hayaa.Security.Service.Dao{internal partial class AppInstanceTokenDal:CommonDal{
private static String con= ConfigHelper.Instance.GetConnection(DefineTable.DatabaseName);
internal static int Add(AppInstanceToken info){
 string sql = "insert into AppInstanceToken(AppInstanceId,Token,AppToken,Status) values(@AppInstanceId,@Token,@AppToken,@Status)";
return Insert<AppInstanceToken>(con,sql, info);
}
internal static int Update(AppInstanceToken info){
 string sql = "update AppInstanceToken set AppInstanceId=@AppInstanceId,Token=@Token,AppToken=@AppToken,Status=@Status where AppInstanceTokenId=@AppInstanceTokenId";
return Update<AppInstanceToken>(con,sql, info);
}
internal static bool Delete(List<int> IDs){
 string sql = "delete from  AppInstanceToken where AppInstanceTokenId in @ids";
return Excute(con,sql, new { ids = IDs.ToArray() }) > 0;
}
internal static AppInstanceToken Get(int Id){
 string sql = "select * from AppInstanceToken  where AppInstanceTokenId=@AppInstanceTokenId";
return Get<AppInstanceToken>(con,sql,new{ AppInstanceTokenId=Id });
}
internal static List<AppInstanceToken> GetList(AppInstanceTokenSearchPamater pamater){
 string sql = "select * from AppInstanceToken "+pamater.CreateWhereSql();
return GetList<AppInstanceToken>(con,sql,pamater);
}
internal static GridPager<AppInstanceToken> GetGridPager(GridPagerPamater<AppInstanceTokenSearchPamater> pamater){
 string sql = "select SQL_CALC_FOUND_ROWS * from AppInstanceToken "+pamater.SearchPamater.CreateWhereSql()+" limit @Start,*@PageSize;select FOUND_ROWS();";
 pamater.SearchPamater.Start = (pamater.Current-1)* pamater.PageSize;
pamater.SearchPamater.PageSize = pamater.PageSize;
return GetGridPager<AppInstanceToken>(con,sql, pamater.PageSize, pamater.Current, pamater.SearchPamater);
}
}}