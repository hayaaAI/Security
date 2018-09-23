using System;
using System.Collections.Generic;
using Hayaa.BaseModel;
/// <summary>
///代码效率工具生成，此文件不要修改
/// </summary>
namespace Hayaa.Security.Service{public class JobGrantSearchPamater:SearchPamaterMariadbBase {public int? JobGrantId{set;get;}
public List<int> JobGrantIdList{set;get;}
public int? JobGrantIdMax{set;get;}
public int? JobGrantIdMin{set;get;}
public void SetJobGrantId(int? max,int? min){ this.JobGrantIdMax=max;this.JobGrantIdMin=min;this.JobGrantIdPOT=PamaterOperationType.Between;}
private PamaterOperationType JobGrantIdPOT;
public void SetJobGrantId(int? info,PamaterOperationType pot){ this.JobGrantId=info;this.JobGrantIdPOT=pot;}
private String GetJobGrantIdSqlForSharp(){String sql = "";switch (JobGrantIdPOT){
case PamaterOperationType.Between:sql = "JobGrantId between @JobGrantIdMin to @JobGrantIdMax";break;
case PamaterOperationType.StringContains:sql = "JobGrantId like '%@JobGrantId%'";break;
case PamaterOperationType.Equal:sql = "JobGrantId=@JobGrantId";break;
case PamaterOperationType.GreaterEqual:sql = "JobGrantId>=@JobGrantId";break;
case PamaterOperationType.GreaterThan:sql = "JobGrantId>@JobGrantId";break;
case PamaterOperationType.LessEqual:sql = "JobGrantId<=@JobGrantId";break;
case PamaterOperationType.LessThan:sql = "JobGrantId<=@JobGrantId";break;
case PamaterOperationType.In:sql = "JobGrantId in(" + String.Join(",", this.JobGrantIdList) + ")";break;
case PamaterOperationType.StringIn:sql = "JobGrantId in('" + String.Join("','", this.JobGrantIdList)+"')";break;
}
return sql;}
public int? JobId{set;get;}
public List<int> JobIdList{set;get;}
public int? JobIdMax{set;get;}
public int? JobIdMin{set;get;}
public void SetJobId(int? max,int? min){ this.JobIdMax=max;this.JobIdMin=min;this.JobIdPOT=PamaterOperationType.Between;}
private PamaterOperationType JobIdPOT;
public void SetJobId(int? info,PamaterOperationType pot){ this.JobId=info;this.JobIdPOT=pot;}
private String GetJobIdSqlForSharp(){String sql = "";switch (JobIdPOT){
case PamaterOperationType.Between:sql = "JobId between @JobIdMin to @JobIdMax";break;
case PamaterOperationType.StringContains:sql = "JobId like '%@JobId%'";break;
case PamaterOperationType.Equal:sql = "JobId=@JobId";break;
case PamaterOperationType.GreaterEqual:sql = "JobId>=@JobId";break;
case PamaterOperationType.GreaterThan:sql = "JobId>@JobId";break;
case PamaterOperationType.LessEqual:sql = "JobId<=@JobId";break;
case PamaterOperationType.LessThan:sql = "JobId<=@JobId";break;
case PamaterOperationType.In:sql = "JobId in(" + String.Join(",", this.JobIdList) + ")";break;
case PamaterOperationType.StringIn:sql = "JobId in('" + String.Join("','", this.JobIdList)+"')";break;
}
return sql;}
public int? AppServiceId{set;get;}
public List<int> AppServiceIdList{set;get;}
public int? AppServiceIdMax{set;get;}
public int? AppServiceIdMin{set;get;}
public void SetAppServiceId(int? max,int? min){ this.AppServiceIdMax=max;this.AppServiceIdMin=min;this.AppServiceIdPOT=PamaterOperationType.Between;}
private PamaterOperationType AppServiceIdPOT;
public void SetAppServiceId(int? info,PamaterOperationType pot){ this.AppServiceId=info;this.AppServiceIdPOT=pot;}
private String GetAppServiceIdSqlForSharp(){String sql = "";switch (AppServiceIdPOT){
case PamaterOperationType.Between:sql = "AppServiceId between @AppServiceIdMin to @AppServiceIdMax";break;
case PamaterOperationType.StringContains:sql = "AppServiceId like '%@AppServiceId%'";break;
case PamaterOperationType.Equal:sql = "AppServiceId=@AppServiceId";break;
case PamaterOperationType.GreaterEqual:sql = "AppServiceId>=@AppServiceId";break;
case PamaterOperationType.GreaterThan:sql = "AppServiceId>@AppServiceId";break;
case PamaterOperationType.LessEqual:sql = "AppServiceId<=@AppServiceId";break;
case PamaterOperationType.LessThan:sql = "AppServiceId<=@AppServiceId";break;
case PamaterOperationType.In:sql = "AppServiceId in(" + String.Join(",", this.AppServiceIdList) + ")";break;
case PamaterOperationType.StringIn:sql = "AppServiceId in('" + String.Join("','", this.AppServiceIdList)+"')";break;
}
return sql;}
public int? AppFunctionId{set;get;}
public List<int> AppFunctionIdList{set;get;}
public int? AppFunctionIdMax{set;get;}
public int? AppFunctionIdMin{set;get;}
public void SetAppFunctionId(int? max,int? min){ this.AppFunctionIdMax=max;this.AppFunctionIdMin=min;this.AppFunctionIdPOT=PamaterOperationType.Between;}
private PamaterOperationType AppFunctionIdPOT;
public void SetAppFunctionId(int? info,PamaterOperationType pot){ this.AppFunctionId=info;this.AppFunctionIdPOT=pot;}
private String GetAppFunctionIdSqlForSharp(){String sql = "";switch (AppFunctionIdPOT){
case PamaterOperationType.Between:sql = "AppFunctionId between @AppFunctionIdMin to @AppFunctionIdMax";break;
case PamaterOperationType.StringContains:sql = "AppFunctionId like '%@AppFunctionId%'";break;
case PamaterOperationType.Equal:sql = "AppFunctionId=@AppFunctionId";break;
case PamaterOperationType.GreaterEqual:sql = "AppFunctionId>=@AppFunctionId";break;
case PamaterOperationType.GreaterThan:sql = "AppFunctionId>@AppFunctionId";break;
case PamaterOperationType.LessEqual:sql = "AppFunctionId<=@AppFunctionId";break;
case PamaterOperationType.LessThan:sql = "AppFunctionId<=@AppFunctionId";break;
case PamaterOperationType.In:sql = "AppFunctionId in(" + String.Join(",", this.AppFunctionIdList) + ")";break;
case PamaterOperationType.StringIn:sql = "AppFunctionId in('" + String.Join("','", this.AppFunctionIdList)+"')";break;
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
}}