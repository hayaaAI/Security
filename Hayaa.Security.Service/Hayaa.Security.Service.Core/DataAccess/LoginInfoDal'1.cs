using System;
using System.Collections.Generic;
using System.Text;
using Hayaa.DataAccess;
using Hayaa.BaseModel;
using Hayaa.Security.Service.Config;
/// <summary>
///代码效率工具生成，此文件不要修改
/// </summary>
namespace Hayaa.Security.Service.Dao
{

    internal partial class LoginInfoDal
    {
        internal static int Insert(LoginInfo info)
        {
            string sql = "insert into LoginInfo(LoginKey,UserId,Status) select @LoginKey,@UserId,@Status from DUAL where not exists(select LoginInfoId from LoginInfo where UserId=@UserId and LoginKey=@LoginKey);select @@IDENTITY;";
            return InsertWithReturnID<LoginInfo, int>(con, sql, info);

        }

    }
}