using Hayaa.BaseModel;
using Hayaa.BaseModel.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hayaa.Security.Service
{
   public interface JobGrantService : IBaseService<JobGrant, JobGrantSearchPamater>
    {
        /// <summary>
        /// 对App进行授权
        /// </summary>
        /// <param name="jobId">被授权岗位的Id</param>
        /// <param name="authority">被授权权限</param>
        /// <returns></returns>
        FunctionOpenResult<bool> Grant(int jobId, Dictionary<int, List<int>> authority);
    }
}
