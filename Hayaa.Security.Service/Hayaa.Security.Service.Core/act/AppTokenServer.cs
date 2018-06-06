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
    public partial class AppTokenServer : AppTokenService
    {
      
        public FunctionOpenResult<bool> UpdateByID(AppToken info) { var r = new FunctionOpenResult<bool>(); r.Data = AppTokenDal.Update(info) > 0; return r; }
        public FunctionOpenResult<bool> DeleteByID(List<int> idList) { var r = new FunctionOpenResult<bool>(); r.Data = AppTokenDal.Delete(idList); return r; }
        public FunctionResult<AppToken> Get(int Id) { var r = new FunctionResult<AppToken>(); r.Data = AppTokenDal.Get(Id); return r; }
        public FunctionListResult<AppToken> GetList(AppTokenSearchPamater pamater) { var r = new FunctionListResult<AppToken>(); r.Data = AppTokenDal.GetList(pamater); return r; }
        public GridPager<AppToken> GetPager(GridPagerPamater<AppTokenSearchPamater> searchParam) { var r = AppTokenDal.GetGridPager(searchParam); return r; }

       
    }
}