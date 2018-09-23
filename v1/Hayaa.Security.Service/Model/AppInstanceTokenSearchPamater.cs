using System;
using System.Collections.Generic;
using Hayaa.BaseModel;
/// <summary>
///代码效率工具生成，此文件不要修改
/// </summary>
namespace Hayaa.Security.Service{public class AppInstanceTokenSearchPamater:SearchPamaterMariadbBase {public int? AppInstanceTokenId{set;get;}
public List<int> AppInstanceTokenIdList{set;get;}
public int? AppInstanceTokenIdMax{set;get;}
public int? AppInstanceTokenIdMin{set;get;}
public void SetAppInstanceTokenId(int? max,int? min){ this.AppInstanceTokenIdMax=max;this.AppInstanceTokenIdMin=min;this.AppInstanceTokenIdPOT=PamaterOperationType.Between;}
private PamaterOperationType AppInstanceTokenIdPOT;
public void SetAppInstanceTokenId(int? info,PamaterOperationType pot){ this.AppInstanceTokenId=info;this.AppInstanceTokenIdPOT=pot;}
private String GetAppInstanceTokenIdSqlForSharp(){String sql = "";switch (AppInstanceTokenIdPOT){
case PamaterOperationType.Between:sql = "AppInstanceTokenId between @AppInstanceTokenIdMin to @AppInstanceTokenIdMax";break;
case PamaterOperationType.StringContains:sql = "AppInstanceTokenId like '%@AppInstanceTokenId%'";break;
case PamaterOperationType.Equal:sql = "AppInstanceTokenId=@AppInstanceTokenId";break;
case PamaterOperationType.GreaterEqual:sql = "AppInstanceTokenId>=@AppInstanceTokenId";break;
case PamaterOperationType.GreaterThan:sql = "AppInstanceTokenId>@AppInstanceTokenId";break;
case PamaterOperationType.LessEqual:sql = "AppInstanceTokenId<=@AppInstanceTokenId";break;
case PamaterOperationType.LessThan:sql = "AppInstanceTokenId<=@AppInstanceTokenId";break;
case PamaterOperationType.In:sql = "AppInstanceTokenId in(" + String.Join(",", this.AppInstanceTokenIdList) + ")";break;
case PamaterOperationType.StringIn:sql = "AppInstanceTokenId in('" + String.Join("','", this.AppInstanceTokenIdList)+"')";break;
}
return sql;}
public int? AppInstanceId{set;get;}
public List<int> AppInstanceIdList{set;get;}
public int? AppInstanceIdMax{set;get;}
public int? AppInstanceIdMin{set;get;}
public void SetAppInstanceId(int? max,int? min){ this.AppInstanceIdMax=max;this.AppInstanceIdMin=min;this.AppInstanceIdPOT=PamaterOperationType.Between;}
private PamaterOperationType AppInstanceIdPOT;
public void SetAppInstanceId(int? info,PamaterOperationType pot){ this.AppInstanceId=info;this.AppInstanceIdPOT=pot;}
private String GetAppInstanceIdSqlForSharp(){String sql = "";switch (AppInstanceIdPOT){
case PamaterOperationType.Between:sql = "AppInstanceId between @AppInstanceIdMin to @AppInstanceIdMax";break;
case PamaterOperationType.StringContains:sql = "AppInstanceId like '%@AppInstanceId%'";break;
case PamaterOperationType.Equal:sql = "AppInstanceId=@AppInstanceId";break;
case PamaterOperationType.GreaterEqual:sql = "AppInstanceId>=@AppInstanceId";break;
case PamaterOperationType.GreaterThan:sql = "AppInstanceId>@AppInstanceId";break;
case PamaterOperationType.LessEqual:sql = "AppInstanceId<=@AppInstanceId";break;
case PamaterOperationType.LessThan:sql = "AppInstanceId<=@AppInstanceId";break;
case PamaterOperationType.In:sql = "AppInstanceId in(" + String.Join(",", this.AppInstanceIdList) + ")";break;
case PamaterOperationType.StringIn:sql = "AppInstanceId in('" + String.Join("','", this.AppInstanceIdList)+"')";break;
}
return sql;}
public String Token{set;get;}
public List<String> TokenList{set;get;}
private PamaterOperationType TokenPOT;
public void SetToken(String info,PamaterOperationType pot){ this.Token=info;this.TokenPOT=pot;}
private String GetTokenSqlForSharp(){String sql = "";switch (TokenPOT){
case PamaterOperationType.Between:sql = "Token between @TokenMin to @TokenMax";break;
case PamaterOperationType.StringContains:sql = "Token like '%@Token%'";break;
case PamaterOperationType.Equal:sql = "Token=@Token";break;
case PamaterOperationType.GreaterEqual:sql = "Token>=@Token";break;
case PamaterOperationType.GreaterThan:sql = "Token>@Token";break;
case PamaterOperationType.LessEqual:sql = "Token<=@Token";break;
case PamaterOperationType.LessThan:sql = "Token<=@Token";break;
case PamaterOperationType.In:sql = "Token in(" + String.Join(",", this.TokenList) + ")";break;
case PamaterOperationType.StringIn:sql = "Token in('" + String.Join("','", this.TokenList)+"')";break;
}
return sql;}
public String AppToken{set;get;}
public List<String> AppTokenList{set;get;}
private PamaterOperationType AppTokenPOT;
public void SetAppToken(String info,PamaterOperationType pot){ this.AppToken=info;this.AppTokenPOT=pot;}
private String GetAppTokenSqlForSharp(){String sql = "";switch (AppTokenPOT){
case PamaterOperationType.Between:sql = "AppToken between @AppTokenMin to @AppTokenMax";break;
case PamaterOperationType.StringContains:sql = "AppToken like '%@AppToken%'";break;
case PamaterOperationType.Equal:sql = "AppToken=@AppToken";break;
case PamaterOperationType.GreaterEqual:sql = "AppToken>=@AppToken";break;
case PamaterOperationType.GreaterThan:sql = "AppToken>@AppToken";break;
case PamaterOperationType.LessEqual:sql = "AppToken<=@AppToken";break;
case PamaterOperationType.LessThan:sql = "AppToken<=@AppToken";break;
case PamaterOperationType.In:sql = "AppToken in(" + String.Join(",", this.AppTokenList) + ")";break;
case PamaterOperationType.StringIn:sql = "AppToken in('" + String.Join("','", this.AppTokenList)+"')";break;
}
return sql;}
public bool? Status{set;get;}
public List<bool> StatusList{set;get;}
public bool? StatusMax{set;get;}
public bool? StatusMin{set;get;}
public void SetStatus(bool? max,bool? min){ this.StatusMax=max;this.StatusMin=min;this.StatusPOT=PamaterOperationType.Between;}
private PamaterOperationType StatusPOT;
public void SetStatus(bool? info,PamaterOperationType pot){ this.Status=info;this.StatusPOT=pot;}
private String GetStatusSqlForSharp(){String sql = "";switch (StatusPOT){
case PamaterOperationType.Between:sql = "Status between @StatusMin to @StatusMax";break;
case PamaterOperationType.StringContains:sql = "Status like '%@Status%'";break;
case PamaterOperationType.Equal:sql = "Status=@Status";break;
case PamaterOperationType.GreaterEqual:sql = "Status>=@Status";break;
case PamaterOperationType.GreaterThan:sql = "Status>@Status";break;
case PamaterOperationType.LessEqual:sql = "Status<=@Status";break;
case PamaterOperationType.LessThan:sql = "Status<=@Status";break;
case PamaterOperationType.In:sql = "Status in(" + String.Join(",", this.StatusList) + ")";break;
case PamaterOperationType.StringIn:sql = "Status in('" + String.Join("','", this.StatusList)+"')";break;
}
return sql;}
public DateTime? CreateTime{set;get;}
public List<DateTime> CreateTimeList{set;get;}
public DateTime? CreateTimeMax{set;get;}
public DateTime? CreateTimeMin{set;get;}
public void SetCreateTime(DateTime? max,DateTime? min){ this.CreateTimeMax=max;this.CreateTimeMin=min;this.CreateTimePOT=PamaterOperationType.Between;}
private PamaterOperationType CreateTimePOT;
public void SetCreateTime(DateTime? info,PamaterOperationType pot){ this.CreateTime=info;this.CreateTimePOT=pot;}
private String GetCreateTimeSqlForSharp(){String sql = "";switch (CreateTimePOT){
case PamaterOperationType.Between:sql = "CreateTime between @CreateTimeMin to @CreateTimeMax";break;
case PamaterOperationType.StringContains:sql = "CreateTime like '%@CreateTime%'";break;
case PamaterOperationType.Equal:sql = "CreateTime=@CreateTime";break;
case PamaterOperationType.GreaterEqual:sql = "CreateTime>=@CreateTime";break;
case PamaterOperationType.GreaterThan:sql = "CreateTime>@CreateTime";break;
case PamaterOperationType.LessEqual:sql = "CreateTime<=@CreateTime";break;
case PamaterOperationType.LessThan:sql = "CreateTime<=@CreateTime";break;
case PamaterOperationType.In:sql = "CreateTime in(" + String.Join(",", this.CreateTimeList) + ")";break;
case PamaterOperationType.StringIn:sql = "CreateTime in('" + String.Join("','", this.CreateTimeList)+"')";break;
}
return sql;}
public DateTime? UpdateTime{set;get;}
public List<DateTime> UpdateTimeList{set;get;}
public DateTime? UpdateTimeMax{set;get;}
public DateTime? UpdateTimeMin{set;get;}
public void SetUpdateTime(DateTime? max,DateTime? min){ this.UpdateTimeMax=max;this.UpdateTimeMin=min;this.UpdateTimePOT=PamaterOperationType.Between;}
private PamaterOperationType UpdateTimePOT;
public void SetUpdateTime(DateTime? info,PamaterOperationType pot){ this.UpdateTime=info;this.UpdateTimePOT=pot;}
private String GetUpdateTimeSqlForSharp(){String sql = "";switch (UpdateTimePOT){
case PamaterOperationType.Between:sql = "UpdateTime between @UpdateTimeMin to @UpdateTimeMax";break;
case PamaterOperationType.StringContains:sql = "UpdateTime like '%@UpdateTime%'";break;
case PamaterOperationType.Equal:sql = "UpdateTime=@UpdateTime";break;
case PamaterOperationType.GreaterEqual:sql = "UpdateTime>=@UpdateTime";break;
case PamaterOperationType.GreaterThan:sql = "UpdateTime>@UpdateTime";break;
case PamaterOperationType.LessEqual:sql = "UpdateTime<=@UpdateTime";break;
case PamaterOperationType.LessThan:sql = "UpdateTime<=@UpdateTime";break;
case PamaterOperationType.In:sql = "UpdateTime in(" + String.Join(",", this.UpdateTimeList) + ")";break;
case PamaterOperationType.StringIn:sql = "UpdateTime in('" + String.Join("','", this.UpdateTimeList)+"')";break;
}
return sql;}
}}