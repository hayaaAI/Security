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
    public partial class JobGrantServer : JobGrantService
    {
        public FunctionResult<JobGrant> Create(JobGrant info)
        {
            var r = new FunctionResult<JobGrant>(); int id = JobGrantDal.Add(info); if (id > 0) { r.Data = info; r.Data.JobGrantId = id; }
            return r;
        }
        public FunctionOpenResult<bool> UpdateByID(JobGrant info) { var r = new FunctionOpenResult<bool>(); r.Data = JobGrantDal.Update(info) > 0; return r; }
        public FunctionOpenResult<bool> DeleteByID(List<int> idList) { var r = new FunctionOpenResult<bool>(); r.Data = JobGrantDal.Delete(idList); return r; }
        public FunctionResult<JobGrant> Get(int Id) { var r = new FunctionResult<JobGrant>(); r.Data = JobGrantDal.Get(Id); return r; }
        public FunctionListResult<JobGrant> GetList(JobGrantSearchPamater pamater) { var r = new FunctionListResult<JobGrant>(); r.Data = JobGrantDal.GetList(pamater); return r; }
        public GridPager<JobGrant> GetPager(GridPagerPamater<JobGrantSearchPamater> searchParam) { var r = JobGrantDal.GetGridPager(searchParam); return r; }

       
    }
}