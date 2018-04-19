using System;
using System.Collections.Generic;
using System.Text;
using Hayaa.DataAccess;
using Hayaa.BaseModel;
using Hayaa.Security.Service.Dao;
using Hayaa.Security.Service.Config;

namespace Hayaa.Security.Service
{
    public partial class AppGrantServer 
    {
        public FunctionOpenResult<bool> Grant(int appId, Dictionary<int, List<int>> authority)
        {
            var r = new FunctionOpenResult<bool>();
            foreach(var kv in authority)
            {
                kv.Value.ForEach(fid => {
                    AppGrantDal.Add(new AppGrant() { AppFunctionId =fid, AppId=appId, AppServiceId=kv.Key});
                });
                
            }
            r.Data = true;
            return r;
        }
    }
}