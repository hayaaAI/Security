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
    public partial class JobTokenServer : JobTokenService
    {
        public FunctionResult<JobToken> Create(JobToken info)
        {
            var r = new FunctionResult<JobToken>(); int id = JobTokenDal.Add(info); if (id > 0) { r.Data = info; r.Data.JobTokenId = id; }
            return r;
        }
        public FunctionOpenResult<bool> UpdateByID(JobToken info) { var r = new FunctionOpenResult<bool>(); r.Data = JobTokenDal.Update(info) > 0; return r; }
        public FunctionOpenResult<bool> DeleteByID(List<int> idList) { var r = new FunctionOpenResult<bool>(); r.Data = JobTokenDal.Delete(idList); return r; }
        public FunctionResult<JobToken> Get(int Id) { var r = new FunctionResult<JobToken>(); r.Data = JobTokenDal.Get(Id); return r; }
        public FunctionListResult<JobToken> GetList(JobTokenSearchPamater pamater) { var r = new FunctionListResult<JobToken>(); r.Data = JobTokenDal.GetList(pamater); return r; }
        public GridPager<JobToken> GetPager(GridPagerPamater<JobTokenSearchPamater> searchParam) { var r = JobTokenDal.GetGridPager(searchParam); return r; }
    }
}