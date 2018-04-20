using System;
using System.Collections.Generic;
using Hayaa.BaseModel;
/// <summary>
///代码效率工具生成，此文件不要修改
/// </summary>
namespace Hayaa.Security.Service
{
    public class JobTokenSearchPamater : SearchPamaterMariadbBase
    {
        public int? JobTokenId { set; get; }
        public List<int> JobTokenIdList { set; get; }
        public int? JobTokenIdMax { set; get; }
        public int? JobTokenIdMin { set; get; }
        public void SetJobTokenId(int? max, int? min) { this.JobTokenIdMax = max; this.JobTokenIdMin = min; this.JobTokenIdPOT = PamaterOperationType.Between; }
        private PamaterOperationType JobTokenIdPOT;
        public void SetJobTokenId(int? info, PamaterOperationType pot) { this.JobTokenId = info; this.JobTokenIdPOT = pot; }
        private String GetJobTokenIdSqlForSharp()
        {
            String sql = ""; switch (JobTokenIdPOT)
            {
                case PamaterOperationType.Between: sql = "JobTokenId between @JobTokenIdMin to @JobTokenIdMax"; break;
                case PamaterOperationType.StringContains: sql = "JobTokenId like '%@JobTokenId%'"; break;
                case PamaterOperationType.Equal: sql = "JobTokenId=@JobTokenId"; break;
                case PamaterOperationType.GreaterEqual: sql = "JobTokenId>=@JobTokenId"; break;
                case PamaterOperationType.GreaterThan: sql = "JobTokenId>@JobTokenId"; break;
                case PamaterOperationType.LessEqual: sql = "JobTokenId<=@JobTokenId"; break;
                case PamaterOperationType.LessThan: sql = "JobTokenId<=@JobTokenId"; break;
                case PamaterOperationType.In: sql = "JobTokenId in(" + String.Join(",", this.JobTokenIdList) + ")"; break;
                case PamaterOperationType.StringIn: sql = "JobTokenId in('" + String.Join("','", this.JobTokenIdList) + "')"; break;
            }
            return sql;
        }
        public int? JobId { set; get; }
        public List<int> JobIdList { set; get; }
        public int? JobIdMax { set; get; }
        public int? JobIdMin { set; get; }
        public void SetJobId(int? max, int? min) { this.JobIdMax = max; this.JobIdMin = min; this.JobIdPOT = PamaterOperationType.Between; }
        private PamaterOperationType JobIdPOT;
        public void SetJobId(int? info, PamaterOperationType pot) { this.JobId = info; this.JobIdPOT = pot; }
        private String GetJobIdSqlForSharp()
        {
            String sql = ""; switch (JobIdPOT)
            {
                case PamaterOperationType.Between: sql = "JobId between @JobIdMin to @JobIdMax"; break;
                case PamaterOperationType.StringContains: sql = "JobId like '%@JobId%'"; break;
                case PamaterOperationType.Equal: sql = "JobId=@JobId"; break;
                case PamaterOperationType.GreaterEqual: sql = "JobId>=@JobId"; break;
                case PamaterOperationType.GreaterThan: sql = "JobId>@JobId"; break;
                case PamaterOperationType.LessEqual: sql = "JobId<=@JobId"; break;
                case PamaterOperationType.LessThan: sql = "JobId<=@JobId"; break;
                case PamaterOperationType.In: sql = "JobId in(" + String.Join(",", this.JobIdList) + ")"; break;
                case PamaterOperationType.StringIn: sql = "JobId in('" + String.Join("','", this.JobIdList) + "')"; break;
            }
            return sql;
        }
        public int? UserId { set; get; }
        public List<int> UserIdList { set; get; }
        public int? UserIdMax { set; get; }
        public int? UserIdMin { set; get; }
        public void SetUserId(int? max, int? min) { this.UserIdMax = max; this.UserIdMin = min; this.UserIdPOT = PamaterOperationType.Between; }
        private PamaterOperationType UserIdPOT;
        public void SetUserId(int? info, PamaterOperationType pot) { this.UserId = info; this.UserIdPOT = pot; }
        private String GetUserIdSqlForSharp()
        {
            String sql = ""; switch (UserIdPOT)
            {
                case PamaterOperationType.Between: sql = "UserId between @UserIdMin to @UserIdMax"; break;
                case PamaterOperationType.StringContains: sql = "UserId like '%@UserId%'"; break;
                case PamaterOperationType.Equal: sql = "UserId=@UserId"; break;
                case PamaterOperationType.GreaterEqual: sql = "UserId>=@UserId"; break;
                case PamaterOperationType.GreaterThan: sql = "UserId>@UserId"; break;
                case PamaterOperationType.LessEqual: sql = "UserId<=@UserId"; break;
                case PamaterOperationType.LessThan: sql = "UserId<=@UserId"; break;
                case PamaterOperationType.In: sql = "UserId in(" + String.Join(",", this.UserIdList) + ")"; break;
                case PamaterOperationType.StringIn: sql = "UserId in('" + String.Join("','", this.UserIdList) + "')"; break;
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
        public DateTime? EndTime { set; get; }
        public List<DateTime> EndTimeList { set; get; }
        public DateTime? EndTimeMax { set; get; }
        public DateTime? EndTimeMin { set; get; }
        public void SetEndTime(DateTime? max, DateTime? min) { this.EndTimeMax = max; this.EndTimeMin = min; this.EndTimePOT = PamaterOperationType.Between; }
        private PamaterOperationType EndTimePOT;
        public void SetEndTime(DateTime? info, PamaterOperationType pot) { this.EndTime = info; this.EndTimePOT = pot; }
        private String GetEndTimeSqlForSharp()
        {
            String sql = ""; switch (EndTimePOT)
            {
                case PamaterOperationType.Between: sql = "EndTime between @EndTimeMin to @EndTimeMax"; break;
                case PamaterOperationType.StringContains: sql = "EndTime like '%@EndTime%'"; break;
                case PamaterOperationType.Equal: sql = "EndTime=@EndTime"; break;
                case PamaterOperationType.GreaterEqual: sql = "EndTime>=@EndTime"; break;
                case PamaterOperationType.GreaterThan: sql = "EndTime>@EndTime"; break;
                case PamaterOperationType.LessEqual: sql = "EndTime<=@EndTime"; break;
                case PamaterOperationType.LessThan: sql = "EndTime<=@EndTime"; break;
                case PamaterOperationType.In: sql = "EndTime in(" + String.Join(",", this.EndTimeList) + ")"; break;
                case PamaterOperationType.StringIn: sql = "EndTime in('" + String.Join("','", this.EndTimeList) + "')"; break;
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