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
    public partial class LoginInfoServer : LoginInfoService
    {
        public FunctionResult<LoginInfo> Create(LoginInfo info)
        {
            var r = new FunctionResult<LoginInfo>(); int id = LoginInfoDal.Add(info); if (id > 0) { r.Data = info; r.Data.LoginInfoId = id; }
            return r;
        }
        public FunctionOpenResult<bool> UpdateByID(LoginInfo info) { var r = new FunctionOpenResult<bool>(); r.Data = LoginInfoDal.Update(info) > 0; return r; }
        public FunctionOpenResult<bool> DeleteByID(List<int> idList) { var r = new FunctionOpenResult<bool>(); r.Data = LoginInfoDal.Delete(idList); return r; }
        public FunctionResult<LoginInfo> Get(int Id) { var r = new FunctionResult<LoginInfo>(); r.Data = LoginInfoDal.Get(Id); return r; }
        public FunctionListResult<LoginInfo> GetList(LoginInfoSearchPamater pamater) { var r = new FunctionListResult<LoginInfo>(); r.Data = LoginInfoDal.GetList(pamater); return r; }
        public GridPager<LoginInfo> GetPager(GridPagerPamater<LoginInfoSearchPamater> searchParam) { var r = LoginInfoDal.GetGridPager(searchParam); return r; }
    }
}