using System;
using System.Collections.Generic;
using System.Text;
using Hayaa.DataAccess;
using Hayaa.BaseModel;
using Hayaa.Security.Service.Dao;
using Hayaa.Security.Service.Config;

namespace Hayaa.Security.Service
{
    public partial class JobGrantServer 
    {
        public FunctionOpenResult<bool> Grant(int jobId, Dictionary<int, List<int>> authority)
        {
            var r = new FunctionOpenResult<bool>();
            foreach (var kv in authority)
            {
                kv.Value.ForEach(fid => {
                    JobGrantDal.Add(new JobGrant() { AppFunctionId = fid, JobId=jobId, AppServiceId = kv.Key });
                });

            }
            r.Data = true;
            return r;
        }
    }
}