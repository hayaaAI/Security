﻿using System;
using System.Collections.Generic;
using System.Text;
using Hayaa.DataAccess;
using Hayaa.BaseModel;
using Hayaa.Security.Service.Config;

namespace Hayaa.Security.Service.Dao
{
    internal partial class AppFunctionDal 
    {
        internal static int Add(AppFunction info)
        {
            string sql = "insert into AppFunction(FunctionName,PathName,Title,Status,AppServiceId) select @FunctionName,@PathName,@Title,@Status,@AppServiceId from DUAL where not exists(select AppFuntionId from AppFunction where FunctionName=@FunctionName and AppServiceId=@AppServiceId);select @@IDENTITY;";
            return InsertWithReturnID<AppFunction, int>(con, sql, info);
        }
        internal static int SigningNoMatching(int appFunctionId)
        {
            string sql = "update AppFunction set Status=2 where AppFunctionId=@AppFunctionId";
            return Excute(con, sql, new { AppFunctionId=appFunctionId });
        }
        internal static int SigningNoMatchingByAppServiceId(int appServiceId)
        {
            string sql = "update AppFunction set Status=2 where AppServiceId=@AppServiceId";
            return Excute(con, sql, new { AppServiceId = appServiceId });
        }
        internal static bool CancleById(List<int> idList)
        {
            string sql = "update AppFunction set Status=3 where AppFunctionId in @ids";
            return Excute(con, sql, new { ids = idList.ToArray() }) > 0;
        }
    }
}