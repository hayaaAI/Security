using Hayaa.BaseModel;
using Hayaa.BaseModel.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hayaa.Security.Service
{
   public interface AppGrantService : IBaseService<AppGrant, AppGrantSearchPamater>
    {
        /// <summary>
        /// 对App进行授权
        /// </summary>
        /// <param name="appId">被授权App的Id</param>
        /// <param name="authority">被授权权限</param>
        /// <returns></returns>
        FunctionOpenResult<bool> Grant(int appId, Dictionary<int, List<int>> authority);
    }
}
