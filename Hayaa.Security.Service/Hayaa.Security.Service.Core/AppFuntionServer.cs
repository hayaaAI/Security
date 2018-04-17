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
    public partial class AppFuntionServer : AppFuntionService
    {
        public FunctionResult<AppFuntion> Create(AppFuntion info)
        {
            var r = new FunctionResult<AppFuntion>(); int id = AppFuntionDal.Add(info); if (id > 0) { r.Data = info; r.Data.AppFuntionId = id; }
            return r;
        }
        public FunctionOpenResult<bool> UpdateByID(AppFuntion info) { var r = new FunctionOpenResult<bool>(); r.Data = AppFuntionDal.Update(info) > 0; return r; }
        public FunctionOpenResult<bool> DeleteByID(List<int> idList) { var r = new FunctionOpenResult<bool>(); r.Data = AppFuntionDal.Delete(idList); return r; }
        public FunctionResult<AppFuntion> Get(int Id) { var r = new FunctionResult<AppFuntion>(); r.Data = AppFuntionDal.Get(Id); return r; }
        public FunctionListResult<AppFuntion> GetList(AppFuntionSearchPamater pamater) { var r = new FunctionListResult<AppFuntion>(); r.Data = AppFuntionDal.GetList(pamater); return r; }
        public GridPager<AppFuntion> GetPager(GridPagerPamater<AppFuntionSearchPamater> searchParam) { var r = AppFuntionDal.GetGridPager(searchParam); return r; }
    }
}