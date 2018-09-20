using System;
using System.Collections.Generic;
using Hayaa.BaseModel;
/// <summary>
///代码效率工具生成，此文件不要修改
/// </summary>
namespace Hayaa.Security.Service
{
    public class AppTokenSearchPamater : SearchPamaterMariadbBase
    {
        public int? AppTokenId { set; get; }
        public List<int> AppTokenIdList { set; get; }
        public int? AppTokenIdMax { set; get; }
        public int? AppTokenIdMin { set; get; }
        public void SetAppTokenId(int? max, int? min) { this.AppTokenIdMax = max; this.AppTokenIdMin = min; this.AppTokenIdPOT = PamaterOperationType.Between; }
        private PamaterOperationType AppTokenIdPOT;
        public void SetAppTokenId(int? info, PamaterOperationType pot) { this.AppTokenId = info; this.AppTokenIdPOT = pot; }
        private String GetAppTokenIdSqlForSharp()
        {
            String sql = ""; switch (AppTokenIdPOT)
            {
                case PamaterOperationType.Between: sql = "AppTokenId between @AppTokenIdMin to @AppTokenIdMax"; break;
                case PamaterOperationType.StringContains: sql = "AppTokenId like '%@AppTokenId%'"; break;
                case PamaterOperationType.Equal: sql = "AppTokenId=@AppTokenId"; break;
                case PamaterOperationType.GreaterEqual: sql = "AppTokenId>=@AppTokenId"; break;
                case PamaterOperationType.GreaterThan: sql = "AppTokenId>@AppTokenId"; break;
                case PamaterOperationType.LessEqual: sql = "AppTokenId<=@AppTokenId"; break;
                case PamaterOperationType.LessThan: sql = "AppTokenId<=@AppTokenId"; break;
                case PamaterOperationType.In: sql = "AppTokenId in(" + String.Join(",", this.AppTokenIdList) + ")"; break;
                case PamaterOperationType.StringIn: sql = "AppTokenId in('" + String.Join("','", this.AppTokenIdList) + "')"; break;
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
        public String Token { set; get; }
        public List<String> TokenList { set; get; }
        private PamaterOperationType TokenPOT;
        public void SetToken(String info, PamaterOperationType pot) { this.Token = info; this.TokenPOT = pot; }
        private String GetTokenSqlForSharp()
        {
            String sql = ""; switch (TokenPOT)
            {
                case PamaterOperationType.Between: sql = "Token between @TokenMin to @TokenMax"; break;
                case PamaterOperationType.StringContains: sql = "Token like '%@Token%'"; break;
                case PamaterOperationType.Equal: sql = "Token=@Token"; break;
                case PamaterOperationType.GreaterEqual: sql = "Token>=@Token"; break;
                case PamaterOperationType.GreaterThan: sql = "Token>@Token"; break;
                case PamaterOperationType.LessEqual: sql = "Token<=@Token"; break;
                case PamaterOperationType.LessThan: sql = "Token<=@Token"; break;
                case PamaterOperationType.In: sql = "Token in(" + String.Join(",", this.TokenList) + ")"; break;
                case PamaterOperationType.StringIn: sql = "Token in('" + String.Join("','", this.TokenList) + "')"; break;
            }
            return sql;
        }
        public bool? Status { set; get; }
        public List<bool> StatusList { set; get; }
        public bool? StatusMax { set; get; }
        public bool? StatusMin { set; get; }
        public void SetStatus(bool? max, bool? min) { this.StatusMax = max; this.StatusMin = min; this.StatusPOT = PamaterOperationType.Between; }
        private PamaterOperationType StatusPOT;
        public void SetStatus(bool? info, PamaterOperationType pot) { this.Status = info; this.StatusPOT = pot; }
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
        public DateTime? UpdateTime { set; get; }
        public List<DateTime> UpdateTimeList { set; get; }
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