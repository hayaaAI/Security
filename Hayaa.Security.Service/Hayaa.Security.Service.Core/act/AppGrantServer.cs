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
    public partial class AppGrantServer : AppGrantService
    {
        public FunctionResult<AppGrant> Create(AppGrant info)
        {
            var r = new FunctionResult<AppGrant>(); int id = AppGrantDal.Add(info); if (id > 0) { r.Data = info; r.Data.AppGrantId = id; }
            return r;
        }
        public FunctionOpenResult<bool> UpdateByID(AppGrant info) { var r = new FunctionOpenResult<bool>(); r.Data = AppGrantDal.Update(info) > 0; return r; }
        public FunctionOpenResult<bool> DeleteByID(List<int> idList) { var r = new FunctionOpenResult<bool>(); r.Data = AppGrantDal.Delete(idList); return r; }
        public FunctionResult<AppGrant> Get(int Id) { var r = new FunctionResult<AppGrant>(); r.Data = AppGrantDal.Get(Id); return r; }
        public FunctionListResult<AppGrant> GetList(AppGrantSearchPamater pamater) { var r = new FunctionListResult<AppGrant>(); r.Data = AppGrantDal.GetList(pamater); return r; }
        public GridPager<AppGrant> GetPager(GridPagerPamater<AppGrantSearchPamater> searchParam) { var r = AppGrantDal.GetGridPager(searchParam); return r; }

       
    }
}