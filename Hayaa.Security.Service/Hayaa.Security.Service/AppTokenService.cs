using Hayaa.BaseModel;
using Hayaa.BaseModel.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hayaa.Security.Service
{
   public interface AppTokenService : IBaseService<AppToken, AppTokenSearchPamater>
    {
        FunctionResult<AppToken> Get(int appId,String token);
    }
}
