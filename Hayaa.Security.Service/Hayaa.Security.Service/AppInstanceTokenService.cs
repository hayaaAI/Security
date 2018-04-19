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
        /// <summary>
        /// 通过实例id与实例token获取token信息
        /// </summary>
        /// <param name="appInstanceId">实例id</param>
        /// <param name="token">实例token</param>
        /// <returns></returns>
        FunctionResult<AppInstanceToken> Get(int appInstanceId,String token);
    }
}
