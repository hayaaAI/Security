using Hayaa.BaseModel;
using Hayaa.BaseModel.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hayaa.Security.Service
{
   public interface AppTokenService : IBaseService<AppToken, AppTokenSearchPamater>
    {
        /// <summary>
        /// 获取正常状态的token实体
        /// </summary>
        /// <param name="appId"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        FunctionResult<AppToken> GetNormal(int appId,String token);
    }
}
