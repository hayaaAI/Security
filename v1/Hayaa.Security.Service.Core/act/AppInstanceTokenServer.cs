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
    public partial class AppInstanceTokenServer : AppInstanceTokenService
    {
        public FunctionResult<AppInstanceToken> Create(AppInstanceToken info)
        {
            var r = new FunctionResult<AppInstanceToken>(); int id = AppInstanceTokenDal.Add(info); if (id > 0) { r.Data = info; r.Data.AppInstanceTokenId = id; }
            return r;
        }
        public FunctionOpenResult<bool> UpdateByID(AppInstanceToken info) { var r = new FunctionOpenResult<bool>(); r.Data = AppInstanceTokenDal.Update(info) > 0; return r; }
        public FunctionOpenResult<bool> DeleteByID(List<int> idList) { var r = new FunctionOpenResult<bool>(); r.Data = AppInstanceTokenDal.Delete(idList); return r; }
        public FunctionResult<AppInstanceToken> Get(int Id) { var r = new FunctionResult<AppInstanceToken>(); r.Data = AppInstanceTokenDal.Get(Id); return r; }
        public FunctionListResult<AppInstanceToken> GetList(AppInstanceTokenSearchPamater pamater) { var r = new FunctionListResult<AppInstanceToken>(); r.Data = AppInstanceTokenDal.GetList(pamater); return r; }
        public GridPager<AppInstanceToken> GetPager(GridPagerPamater<AppInstanceTokenSearchPamater> searchParam) { var r = AppInstanceTokenDal.GetGridPager(searchParam); return r; }

      
    }
}