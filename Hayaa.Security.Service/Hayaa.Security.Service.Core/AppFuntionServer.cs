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
        public FunctionResult<AppFunction> Create(AppFunction info)
        {
            var r = new FunctionResult<AppFunction>(); int id = AppFunctionDal.Add(info); if (id > 0) { r.Data = info; r.Data.AppFuntionId = id; }
            return r;
        }
        public FunctionOpenResult<bool> UpdateByID(AppFunction info) { var r = new FunctionOpenResult<bool>(); r.Data = AppFunctionDal.Update(info) > 0; return r; }
        public FunctionOpenResult<bool> DeleteByID(List<int> idList) { var r = new FunctionOpenResult<bool>(); r.Data = AppFunctionDal.Delete(idList); return r; }
        public FunctionResult<AppFunction> Get(int Id) { var r = new FunctionResult<AppFunction>(); r.Data = AppFunctionDal.Get(Id); return r; }
        public FunctionListResult<AppFunction> GetList(AppFunctionSearchPamater pamater) { var r = new FunctionListResult<AppFunction>(); r.Data = AppFunctionDal.GetList(pamater); return r; }
        public GridPager<AppFunction> GetPager(GridPagerPamater<AppFunctionSearchPamater> searchParam) { var r = AppFunctionDal.GetGridPager(searchParam); return r; }

     
    }
}