using System;
using System.Collections.Generic;
using Hayaa.BaseModel;
namespace Hayaa.Security.Service
{
    public class LoginInfoSearchPamater : SearchPamaterMariadbBase
    {
        public int? LoginInfoId { set; get; }
        public List<int> LoginInfoIdList { set; get; }
        public int? LoginInfoIdMax { set; get; }
        public int? LoginInfoIdMin { set; get; }
        public void SetLoginInfoId(int? max, int? min) { this.LoginInfoIdMax = max; this.LoginInfoIdMin = min; this.LoginInfoIdPOT = PamaterOperationType.Between; }
        private PamaterOperationType LoginInfoIdPOT;
        public void SetLoginInfoId(int? info, PamaterOperationType pot) { this.LoginInfoId = info; this.LoginInfoIdPOT = pot; }
        private String GetLoginInfoIdSqlForSharp()
        {
            String sql = ""; switch (LoginInfoIdPOT)
            {
                case PamaterOperationType.Between: sql = "LoginInfoId between @LoginInfoIdMin to @LoginInfoIdMax"; break;
                case PamaterOperationType.StringContains: sql = "LoginInfoId like '%@LoginInfoId%'"; break;
                case PamaterOperationType.Equal: sql = "LoginInfoId=@LoginInfoId"; break;
                case PamaterOperationType.GreaterEqual: sql = "LoginInfoId>=@LoginInfoId"; break;
                case PamaterOperationType.GreaterThan: sql = "LoginInfoId>@LoginInfoId"; break;
                case PamaterOperationType.LessEqual: sql = "LoginInfoId<=@LoginInfoId"; break;
                case PamaterOperationType.LessThan: sql = "LoginInfoId<=@LoginInfoId"; break;
                case PamaterOperationType.In: sql = "LoginInfoId in(" + String.Join(",", this.LoginInfoIdList) + ")"; break;
                case PamaterOperationType.StringIn: sql = "LoginInfoId in('" + String.Join("','", this.LoginInfoIdList) + "')"; break;
            }
            return sql;
        }
        public String LoginKey { set; get; }
        public List<String> LoginKeyList { set; get; }
        private PamaterOperationType LoginKeyPOT;
        public void SetLoginKey(String info, PamaterOperationType pot) { this.LoginKey = info; this.LoginKeyPOT = pot; }
        private String GetLoginKeySqlForSharp()
        {
            String sql = ""; switch (LoginKeyPOT)
            {
                case PamaterOperationType.StringContains: sql = "LoginKey like '%@LoginKey%'"; break;
                case PamaterOperationType.Equal: sql = "LoginKey=@LoginKey"; break;
                case PamaterOperationType.GreaterEqual: sql = "LoginKey>=@LoginKey"; break;
                case PamaterOperationType.GreaterThan: sql = "LoginKey>@LoginKey"; break;
                case PamaterOperationType.LessEqual: sql = "LoginKey<=@LoginKey"; break;
                case PamaterOperationType.LessThan: sql = "LoginKey<=@LoginKey"; break;
                case PamaterOperationType.In: sql = "LoginKey in(" + String.Join(",", this.LoginKeyList) + ")"; break;
                case PamaterOperationType.StringIn: sql = "LoginKey in('" + String.Join("','", this.LoginKeyList) + "')"; break;
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
        public int? Status { set; get; }
        public List<int> StatusList { set; get; }
        public int? StatusMax { set; get; }
        public int? StatusMin { set; get; }
        public void SetStatus(int? max, int? min) { this.StatusMax = max; this.StatusMin = min; this.StatusPOT = PamaterOperationType.Between; }
        private PamaterOperationType StatusPOT;
        public void SetStatus(int? info, PamaterOperationType pot) { this.Status = info; this.StatusPOT = pot; }
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