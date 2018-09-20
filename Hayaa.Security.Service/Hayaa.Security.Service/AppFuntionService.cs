using Hayaa.BaseModel;
using Hayaa.BaseModel.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hayaa.Security.Service
{
  public  interface AppFuntionService : IBaseService<AppFunction, AppFunctionSearchPamater>
    {
        /// <summary>
        /// 注销无匹配的功能数据
        /// </summary>
        /// <param name="idList"></param>
        /// <returns></returns>
        FunctionOpenResult<bool> CancleById(List<int> idList);
    }
}
