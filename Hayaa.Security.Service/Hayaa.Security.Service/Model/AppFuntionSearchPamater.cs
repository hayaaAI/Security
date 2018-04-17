using System;
using System.Collections.Generic;
using Hayaa.BaseModel;
/// <summary>
///代码效率工具生成，此文件不要修改
/// </summary>
namespace Hayaa.Security.Service
{
    public class AppFuntionSearchPamater : SearchPamaterMariadbBase
    {
        public int? AppFuntionId { set; get; }
        public List<int?> AppFuntionIdList { set; get; }
        public int? AppFuntionIdMax { set; get; }
        public int? AppFuntionIdMin { set; get; }
        public void SetAppFuntionId(int? max, int? min) { this.AppFuntionIdMax = max; this.AppFuntionIdMin = min; this.AppFuntionIdPOT = PamaterOperationType.Between; }
        private PamaterOperationType AppFuntionIdPOT;
        public void SetAppFuntionId(int? info, PamaterOperationType pot) { this.AppFuntionId = info; this.AppFuntionIdPOT = pot; }
        private String GetAppFuntionIdSqlForSharp()
        {
            String sql = ""; switch (AppFuntionIdPOT)
            {
                case PamaterOperationType.Between: sql = "AppFuntionId between @AppFuntionIdMin to @AppFuntionIdMax"; break;
                case PamaterOperationType.StringContains: sql = "AppFuntionId like '%@AppFuntionId%'"; break;
                case PamaterOperationType.Equal: sql = "AppFuntionId=@AppFuntionId"; break;
                case PamaterOperationType.GreaterEqual: sql = "AppFuntionId>=@AppFuntionId"; break;
                case PamaterOperationType.GreaterThan: sql = "AppFuntionId>@AppFuntionId"; break;
                case PamaterOperationType.LessEqual: sql = "AppFuntionId<=@AppFuntionId"; break;
                case PamaterOperationType.LessThan: sql = "AppFuntionId<=@AppFuntionId"; break;
                case PamaterOperationType.In: sql = "AppFuntionId in(" + String.Join(",", this.AppFuntionIdList) + ")"; break;
                case PamaterOperationType.StringIn: sql = "AppFuntionId in('" + String.Join("','", this.AppFuntionIdList) + "')"; break;
            }
            return sql;
        }
        public String FuntionName { set; get; }
        public List<String> FuntionNameList { set; get; }
        private PamaterOperationType FuntionNamePOT;
        public void SetFuntionName(String info, PamaterOperationType pot) { this.FuntionName = info; this.FuntionNamePOT = pot; }
        private String GetFuntionNameSqlForSharp()
        {
            String sql = ""; switch (FuntionNamePOT)
            {
                case PamaterOperationType.Between: sql = "FuntionName between @FuntionNameMin to @FuntionNameMax"; break;
                case PamaterOperationType.StringContains: sql = "FuntionName like '%@FuntionName%'"; break;
                case PamaterOperationType.Equal: sql = "FuntionName=@FuntionName"; break;
                case PamaterOperationType.GreaterEqual: sql = "FuntionName>=@FuntionName"; break;
                case PamaterOperationType.GreaterThan: sql = "FuntionName>@FuntionName"; break;
                case PamaterOperationType.LessEqual: sql = "FuntionName<=@FuntionName"; break;
                case PamaterOperationType.LessThan: sql = "FuntionName<=@FuntionName"; break;
                case PamaterOperationType.In: sql = "FuntionName in(" + String.Join(",", this.FuntionNameList) + ")"; break;
                case PamaterOperationType.StringIn: sql = "FuntionName in('" + String.Join("','", this.FuntionNameList) + "')"; break;
            }
            return sql;
        }
        public String PathName { set; get; }
        public List<String> PathNameList { set; get; }
        private PamaterOperationType PathNamePOT;
        public void SetPathName(String info, PamaterOperationType pot) { this.PathName = info; this.PathNamePOT = pot; }
        private String GetPathNameSqlForSharp()
        {
            String sql = ""; switch (PathNamePOT)
            {
                case PamaterOperationType.Between: sql = "PathName between @PathNameMin to @PathNameMax"; break;
                case PamaterOperationType.StringContains: sql = "PathName like '%@PathName%'"; break;
                case PamaterOperationType.Equal: sql = "PathName=@PathName"; break;
                case PamaterOperationType.GreaterEqual: sql = "PathName>=@PathName"; break;
                case PamaterOperationType.GreaterThan: sql = "PathName>@PathName"; break;
                case PamaterOperationType.LessEqual: sql = "PathName<=@PathName"; break;
                case PamaterOperationType.LessThan: sql = "PathName<=@PathName"; break;
                case PamaterOperationType.In: sql = "PathName in(" + String.Join(",", this.PathNameList) + ")"; break;
                case PamaterOperationType.StringIn: sql = "PathName in('" + String.Join("','", this.PathNameList) + "')"; break;
            }
            return sql;
        }
        public String Title { set; get; }
        public List<String> TitleList { set; get; }
        private PamaterOperationType TitlePOT;
        public void SetTitle(String info, PamaterOperationType pot) { this.Title = info; this.TitlePOT = pot; }
        private String GetTitleSqlForSharp()
        {
            String sql = ""; switch (TitlePOT)
            {
                case PamaterOperationType.Between: sql = "Title between @TitleMin to @TitleMax"; break;
                case PamaterOperationType.StringContains: sql = "Title like '%@Title%'"; break;
                case PamaterOperationType.Equal: sql = "Title=@Title"; break;
                case PamaterOperationType.GreaterEqual: sql = "Title>=@Title"; break;
                case PamaterOperationType.GreaterThan: sql = "Title>@Title"; break;
                case PamaterOperationType.LessEqual: sql = "Title<=@Title"; break;
                case PamaterOperationType.LessThan: sql = "Title<=@Title"; break;
                case PamaterOperationType.In: sql = "Title in(" + String.Join(",", this.TitleList) + ")"; break;
                case PamaterOperationType.StringIn: sql = "Title in('" + String.Join("','", this.TitleList) + "')"; break;
            }
            return sql;
        }
        public byte? Status { set; get; }
        public List<byte?> StatusList { set; get; }
        public byte? StatusMax { set; get; }
        public byte? StatusMin { set; get; }
        public void SetStatus(byte? max, byte? min) { this.StatusMax = max; this.StatusMin = min; this.StatusPOT = PamaterOperationType.Between; }
        private PamaterOperationType StatusPOT;
        public void SetStatus(byte? info, PamaterOperationType pot) { this.Status = info; this.StatusPOT = pot; }
        private String GetStatusSqlForSharp()
        {
            String sql = ""; switch (StatusPOT)
            {
                case PamaterOperationType.Between: sql = "Status between @StatusMin to @StatusMax"; break;
                case PamaterOperationType.StringContains: sql = "Status like '%@Status%'"; break;
                case PamaterOperationType.Equal: sql = "Status=@Status"; break;
                case PamaterOperationType.GreaterEqual: sql = "Status>=@Status"; break;
                case PamaterOperationType.GreaterThan: sql = "Status>@Status"; break;
                case PamaterOperationType.LessEqual: sql = "Status<=@Status"; break;
                case PamaterOperationType.LessThan: sql = "Status<=@Status"; break;
                case PamaterOperationType.In: sql = "Status in(" + String.Join(",", this.StatusList) + ")"; break;
                case PamaterOperationType.StringIn: sql = "Status in('" + String.Join("','", this.StatusList) + "')"; break;
            }
            return sql;
        }
        public int? AppServiceId { set; get; }
        public List<int?> AppServiceIdList { set; get; }
        public int? AppServiceIdMax { set; get; }
        public int? AppServiceIdMin { set; get; }
        public void SetAppServiceId(int? max, int? min) { this.AppServiceIdMax = max; this.AppServiceIdMin = min; this.AppServiceIdPOT = PamaterOperationType.Between; }
        private PamaterOperationType AppServiceIdPOT;
        public void SetAppServiceId(int? info, PamaterOperationType pot) { this.AppServiceId = info; this.AppServiceIdPOT = pot; }
        private String GetAppServiceIdSqlForSharp()
        {
            String sql = ""; switch (AppServiceIdPOT)
            {
                case PamaterOperationType.Between: sql = "AppServiceId between @AppServiceIdMin to @AppServiceIdMax"; break;
                case PamaterOperationType.StringContains: sql = "AppServiceId like '%@AppServiceId%'"; break;
                case PamaterOperationType.Equal: sql = "AppServiceId=@AppServiceId"; break;
                case PamaterOperationType.GreaterEqual: sql = "AppServiceId>=@AppServiceId"; break;
                case PamaterOperationType.GreaterThan: sql = "AppServiceId>@AppServiceId"; break;
                case PamaterOperationType.LessEqual: sql = "AppServiceId<=@AppServiceId"; break;
                case PamaterOperationType.LessThan: sql = "AppServiceId<=@AppServiceId"; break;
                case PamaterOperationType.In: sql = "AppServiceId in(" + String.Join(",", this.AppServiceIdList) + ")"; break;
                case PamaterOperationType.StringIn: sql = "AppServiceId in('" + String.Join("','", this.AppServiceIdList) + "')"; break;
            }
            return sql;
        }
        public DateTime? CreateTime { set; get; }
        public List<DateTime?> CreateTimeList { set; get; }
        public DateTime? CreateTimeMax { set; get; }
        public DateTime? CreateTimeMin { set; get; }
        public void SetCreateTime(DateTime? max, DateTime? min) { this.CreateTimeMax = max; this.CreateTimeMin = min; this.CreateTimePOT = PamaterOperationType.Between; }
        private PamaterOperationType CreateTimePOT;
        public void SetCreateTime(DateTime? info, PamaterOperationType pot) { this.CreateTime = info; this.CreateTimePOT = pot; }
        private String GetCreateTimeSqlForSharp()
        {
            String sql = ""; switch (CreateTimePOT)
            {
                case PamaterOperationType.Between: sql = "CreateTime between @CreateTimeMin to @CreateTimeMax"; break;
                case PamaterOperationType.StringContains: sql = "CreateTime like '%@CreateTime%'"; break;
                case PamaterOperationType.Equal: sql = "CreateTime=@CreateTime"; break;
                case PamaterOperationType.GreaterEqual: sql = "CreateTime>=@CreateTime"; break;
                case PamaterOperationType.GreaterThan: sql = "CreateTime>@CreateTime"; break;
                case PamaterOperationType.LessEqual: sql = "CreateTime<=@CreateTime"; break;
                case PamaterOperationType.LessThan: sql = "CreateTime<=@CreateTime"; break;
                case PamaterOperationType.In: sql = "CreateTime in(" + String.Join(",", this.CreateTimeList) + ")"; break;
                case PamaterOperationType.StringIn: sql = "CreateTime in('" + String.Join("','", this.CreateTimeList) + "')"; break;
            }
            return sql;
        }
        public DateTime? UpdateTime { set; get; }
        public List<DateTime?> UpdateTimeList { set; get; }
        public DateTime? UpdateTimeMax { set; get; }
        public DateTime? UpdateTimeMin { set; get; }
        public void SetUpdateTime(DateTime? max, DateTime? min) { this.UpdateTimeMax = max; this.UpdateTimeMin = min; this.UpdateTimePOT = PamaterOperationType.Between; }
        private PamaterOperationType UpdateTimePOT;
        public void SetUpdateTime(DateTime? info, PamaterOperationType pot) { this.UpdateTime = info; this.UpdateTimePOT = pot; }
        private String GetUpdateTimeSqlForSharp()
        {
            String sql = ""; switch (UpdateTimePOT)
            {
                case PamaterOperationType.Between: sql = "UpdateTime between @UpdateTimeMin to @UpdateTimeMax"; break;
                case PamaterOperationType.StringContains: sql = "UpdateTime like '%@UpdateTime%'"; break;
                case PamaterOperationType.Equal: sql = "UpdateTime=@UpdateTime"; break;
                case PamaterOperationType.GreaterEqual: sql = "UpdateTime>=@UpdateTime"; break;
                case PamaterOperationType.GreaterThan: sql = "UpdateTime>@UpdateTime"; break;
                case PamaterOperationType.LessEqual: sql = "UpdateTime<=@UpdateTime"; break;
                case PamaterOperationType.LessThan: sql = "UpdateTime<=@UpdateTime"; break;
                case PamaterOperationType.In: sql = "UpdateTime in(" + String.Join(",", this.UpdateTimeList) + ")"; break;
                case PamaterOperationType.StringIn: sql = "UpdateTime in('" + String.Join("','", this.UpdateTimeList) + "')"; break;
            }
            return sql;
        }
    }
}