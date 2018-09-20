using System;
using System.Collections.Generic;
using Hayaa.BaseModel;
namespace Hayaa.Security.Service
{
    public class LoginPwdSearchPamater : SearchPamaterMariadbBase
    {
        public int? LoginPwdId { set; get; }
        public List<int> LoginPwdIdList { set; get; }
        public int? LoginPwdIdMax { set; get; }
        public int? LoginPwdIdMin { set; get; }
        public void SetLoginPwdId(int? max, int? min) { this.LoginPwdIdMax = max; this.LoginPwdIdMin = min; this.LoginPwdIdPOT = PamaterOperationType.Between; }
        private PamaterOperationType LoginPwdIdPOT;
        public void SetLoginPwdId(int? info, PamaterOperationType pot) { this.LoginPwdId = info; this.LoginPwdIdPOT = pot; }
        private String GetLoginPwdIdSqlForSharp()
        {
            String sql = ""; switch (LoginPwdIdPOT)
            {
                case PamaterOperationType.Between: sql = "LoginPwdId between @LoginPwdIdMin to @LoginPwdIdMax"; break;
                case PamaterOperationType.StringContains: sql = "LoginPwdId like '%@LoginPwdId%'"; break;
                case PamaterOperationType.Equal: sql = "LoginPwdId=@LoginPwdId"; break;
                case PamaterOperationType.GreaterEqual: sql = "LoginPwdId>=@LoginPwdId"; break;
                case PamaterOperationType.GreaterThan: sql = "LoginPwdId>@LoginPwdId"; break;
                case PamaterOperationType.LessEqual: sql = "LoginPwdId<=@LoginPwdId"; break;
                case PamaterOperationType.LessThan: sql = "LoginPwdId<=@LoginPwdId"; break;
                case PamaterOperationType.In: sql = "LoginPwdId in(" + String.Join(",", this.LoginPwdIdList) + ")"; break;
                case PamaterOperationType.StringIn: sql = "LoginPwdId in('" + String.Join("','", this.LoginPwdIdList) + "')"; break;
            }
            return sql;
        }
        public String LoginPwd { set; get; }
        public List<String> LoginPwdList { set; get; }
        private PamaterOperationType LoginPwdPOT;
        public void SetLoginPwd(String info, PamaterOperationType pot) { this.LoginPwd = info; this.LoginPwdPOT = pot; }
        private String GetLoginPwdSqlForSharp()
        {
            String sql = ""; switch (LoginPwdPOT)
            {
                case PamaterOperationType.StringContains: sql = "LoginPwd like '%@LoginPwd%'"; break;
                case PamaterOperationType.Equal: sql = "LoginPwd=@LoginPwd"; break;
                case PamaterOperationType.GreaterEqual: sql = "LoginPwd>=@LoginPwd"; break;
                case PamaterOperationType.GreaterThan: sql = "LoginPwd>@LoginPwd"; break;
                case PamaterOperationType.LessEqual: sql = "LoginPwd<=@LoginPwd"; break;
                case PamaterOperationType.LessThan: sql = "LoginPwd<=@LoginPwd"; break;
                case PamaterOperationType.In: sql = "LoginPwd in(" + String.Join(",", this.LoginPwdList) + ")"; break;
                case PamaterOperationType.StringIn: sql = "LoginPwd in('" + String.Join("','", this.LoginPwdList) + "')"; break;
            }
            return sql;
        }
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