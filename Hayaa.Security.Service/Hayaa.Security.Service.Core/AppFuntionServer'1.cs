using System;
using System.Collections.Generic;
using System.Text;
using Hayaa.DataAccess;
using Hayaa.BaseModel;
using Hayaa.Security.Service.Dao;
using Hayaa.Security.Service.Config;

namespace Hayaa.Security.Service
{
    public partial class AppFuntionServer 
    {
       
        public FunctionOpenResult<bool> CancleById(List<int> idList)
        {
            var r = new FunctionOpenResult<bool>();
            r.Data = AppFunctionDal.CancleById(idList);
            return r;
        }
    }
}