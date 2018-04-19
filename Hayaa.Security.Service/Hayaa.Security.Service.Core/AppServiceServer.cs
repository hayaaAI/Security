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
    public partial class AppServiceServer : AppServiceService
    {
        public AppServiceServer()
        {
        }

        public FunctionResult<AppService> Create(AppService info)
        {
            var r = new FunctionResult<AppService>(); int id = AppServiceDal.Add(info); if (id > 0) { r.Data = info; r.Data.AppServiceId = id; }
            return r;
        }
        public FunctionOpenResult<bool> UpdateByID(AppService info) { var r = new FunctionOpenResult<bool>(); r.Data = AppServiceDal.Update(info) > 0; return r; }
        public FunctionOpenResult<bool> DeleteByID(List<int> idList) { var r = new FunctionOpenResult<bool>(); r.Data = AppServiceDal.Delete(idList); return r; }
        public FunctionResult<AppService> Get(int Id) { var r = new FunctionResult<AppService>(); r.Data = AppServiceDal.Get(Id); return r; }
        public FunctionListResult<AppService> GetList(AppServiceSearchPamater pamater) { var r = new FunctionListResult<AppService>(); r.Data = AppServiceDal.GetList(pamater); return r; }
        public GridPager<AppService> GetPager(GridPagerPamater<AppServiceSearchPamater> searchParam) { var r = AppServiceDal.GetGridPager(searchParam); return r; }

       
    }
}