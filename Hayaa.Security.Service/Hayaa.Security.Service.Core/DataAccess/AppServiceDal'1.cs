﻿using System;
using System.Collections.Generic;
using System.Text;
using Hayaa.DataAccess;
using Hayaa.BaseModel;
using Hayaa.Security.Service.Config;

namespace Hayaa.Security.Service.Dao
{
    internal partial class AppServiceDal 
    {

        internal static int SigningNoMatching(int appServiceId)
        {
            string sql = "update AppService set  Status=2 where AppServiceId=@AppServiceId";
            return Excute(con, sql, new { AppServiceId = appServiceId });
        }
        internal static bool CancleById(List<int> idList)
        {
            string sql = "update AppService set  Status=3 where  AppServiceId in @ids";
            return Excute(con, sql, new { ids = idList.ToArray() }) > 0;
        }
    }
}