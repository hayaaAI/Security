using System;
using System.Collections.Generic;
using Hayaa.BaseModel;
/// <summary>
///代码效率工具生成，此文件不要修改
/// </summary>
namespace Hayaa.Security.Service
{
    public class AppGrantSearchPamater : SearchPamaterMariadbBase
    {
        public int? AppGrantId { set; get; }
        public List<int> AppGrantIdList { set; get; }
        public int? AppGrantIdMax { set; get; }
        public int? AppGrantIdMin { set; get; }
        public void SetAppGrantId(int? max, int? min) { this.AppGrantIdMax = max; this.AppGrantIdMin = min; this.AppGrantIdPOT = PamaterOperationType.Between; }
        private PamaterOperationType AppGrantIdPOT;
        public void SetAppGrantId(int? info, PamaterOperationType pot) { this.AppGrantId = info; this.AppGrantIdPOT = pot; }
        private String GetAppGrantIdSqlForSharp()
        {
            String sql = ""; switch (AppGrantIdPOT)
            {
                case PamaterOperationType.Between: sql = "AppGrantId between @AppGrantIdMin to @AppGrantIdMax"; break;
                case PamaterOperationType.StringContains: sql = "AppGrantId like '%@AppGrantId%'"; break;
                case PamaterOperationType.Equal: sql = "AppGrantId=@AppGrantId"; break;
                case PamaterOperationType.GreaterEqual: sql = "AppGrantId>=@AppGrantId"; break;
                case PamaterOperationType.GreaterThan: sql = "AppGrantId>@AppGrantId"; break;
                case PamaterOperationType.LessEqual: sql = "AppGrantId<=@AppGrantId"; break;
                case PamaterOperationType.LessThan: sql = "AppGrantId<=@AppGrantId"; break;
                case PamaterOperationType.In: sql = "AppGrantId in(" + String.Join(",", this.AppGrantIdList) + ")"; break;
                case PamaterOperationType.StringIn: sql = "AppGrantId in('" + String.Join("','", this.AppGrantIdList) + "')"; break;
            }
            return sql;
        }
        public int? AppId { set; get; }
        public List<int> AppIdList { set; get; }
        public int? AppIdMax { set; get; }
        public int? AppIdMin { set; get; }
        public void SetAppId(int? max, int? min) { this.AppIdMax = max; this.AppIdMin = min; this.AppIdPOT = PamaterOperationType.Between; }
        private PamaterOperationType AppIdPOT;
        public void SetAppId(int? info, PamaterOperationType pot) { this.AppId = info; this.AppIdPOT = pot; }
        private String GetAppIdSqlForSharp()
        {
            String sql = ""; switch (AppIdPOT)
            {
                case PamaterOperationType.Between: sql = "AppId between @AppIdMin to @AppIdMax"; break;
                case PamaterOperationType.StringContains: sql = "AppId like '%@AppId%'"; break;
                case PamaterOperationType.Equal: sql = "AppId=@AppId"; break;
                case PamaterOperationType.GreaterEqual: sql = "AppId>=@AppId"; break;
                case PamaterOperationType.GreaterThan: sql = "AppId>@AppId"; break;
                case PamaterOperationType.LessEqual: sql = "AppId<=@AppId"; break;
                case PamaterOperationType.LessThan: sql = "AppId<=@AppId"; break;
                case PamaterOperationType.In: sql = "AppId in(" + String.Join(",", this.AppIdList) + ")"; break;
                case PamaterOperationType.StringIn: sql = "AppId in('" + String.Join("','", this.AppIdList) + "')"; break;
            }
            return sql;
        }
        public int? AppServiceId { set; get; }
        public List<int> AppServiceIdList { set; get; }
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
        public int? AppFunctionId { set; get; }
        public List<int> AppFunctionIdList { set; get; }
        public int? AppFunctionIdMax { set; get; }
        public int? AppFunctionIdMin { set; get; }
        public void SetAppFunctionId(int? max, int? min) { this.AppFunctionIdMax = max; this.AppFunctionIdMin = min; this.AppFunctionIdPOT = PamaterOperationType.Between; }
        private PamaterOperationType AppFunctionIdPOT;
        public void SetAppFunctionId(int? info, PamaterOperationType pot) { this.AppFunctionId = info; this.AppFunctionIdPOT = pot; }
        private String GetAppFunctionIdSqlForSharp()
        {
            String sql = ""; switch (AppFunctionIdPOT)
            {
                case PamaterOperationType.Between: sql = "AppFunctionId between @AppFunctionIdMin to @AppFunctionIdMax"; break;
                case PamaterOperationType.StringContains: sql = "AppFunctionId like '%@AppFunctionId%'"; break;
                case PamaterOperationType.Equal: sql = "AppFunctionId=@AppFunctionId"; break;
                case PamaterOperationType.GreaterEqual: sql = "AppFunctionId>=@AppFunctionId"; break;
                case PamaterOperationType.GreaterThan: sql = "AppFunctionId>@AppFunctionId"; break;
                case PamaterOperationType.LessEqual: sql = "AppFunctionId<=@AppFunctionId"; break;
                case PamaterOperationType.LessThan: sql = "AppFunctionId<=@AppFunctionId"; break;
                case PamaterOperationType.In: sql = "AppFunctionId in(" + String.Join(",", this.AppFunctionIdList) + ")"; break;
                case PamaterOperationType.StringIn: sql = "AppFunctionId in('" + String.Join("','", this.AppFunctionIdList) + "')"; break;
            }
            return sql;
        }
        public DateTime? CreateTime { set; get; }
        public List<DateTime> CreateTimeList { set; get; }
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
    }
}