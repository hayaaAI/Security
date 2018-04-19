using Hayaa.BaseModel;
using Hayaa.BaseModel.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hayaa.Security.Service
{
   public interface AppInstanceTokenService : IBaseService<AppInstanceToken, AppInstanceTokenSearchPamater>
    {
        /// <summary>
        /// 通过App的token置换实例的token
        /// </summary>
        /// <param name="appInstanceId">实例Id</param>
        /// <param name="appToken">App的token，配置在App本地</param>
        /// <returns></returns>
        FunctionResult<AppInstanceToken> ExchangeToken(int appInstanceId,String appToken);
    }
}
