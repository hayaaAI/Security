using System;
using System.Collections.Generic;
using System.Text;
using Hayaa.DataAccess;
using Hayaa.BaseModel;
using Hayaa.Security.Service.Dao;
using Hayaa.Security.Service.Config;
/// <summary>
///代码效率工具生成，此文件不要修改
/// </summary>
namespace Hayaa.Security.Service
{
    public partial class LoginPwdServer : LoginPwdService
    {
        public FunctionResult<LoginPwdInfo> Create(LoginPwdInfo info)
        {
            var r = new FunctionResult<LoginPwdInfo>(); int id = LoginPwdDal.Add(info); if (id > 0) { r.Data = info; r.Data.LoginPwdId = id; }
            return r;
        }
        public FunctionOpenResult<bool> UpdateByID(LoginPwdInfo info) { var r = new FunctionOpenResult<bool>(); r.Data = LoginPwdDal.Update(info) > 0; return r; }
        public FunctionOpenResult<bool> DeleteByID(List<int> idList) { var r = new FunctionOpenResult<bool>(); r.Data = LoginPwdDal.Delete(idList); return r; }
        public FunctionResult<LoginPwdInfo> Get(int Id) { var r = new FunctionResult<LoginPwdInfo>(); r.Data = LoginPwdDal.Get(Id); return r; }
        public FunctionListResult<LoginPwdInfo> GetList(LoginPwdSearchPamater pamater) { var r = new FunctionListResult<LoginPwdInfo>(); r.Data = LoginPwdDal.GetList(pamater); return r; }
        public GridPager<LoginPwdInfo> GetPager(GridPagerPamater<LoginPwdSearchPamater> searchParam) { var r = LoginPwdDal.GetGridPager(searchParam); return r; }
    }
}