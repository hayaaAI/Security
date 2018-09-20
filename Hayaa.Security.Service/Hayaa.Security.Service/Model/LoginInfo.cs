using System;
using System.Collections.Generic;
using Hayaa.BaseModel;
/// <summary>
///代码效率工具生成，此文件不要修改
/// </summary>
namespace Hayaa.Security.Service
{
    public class LoginInfo : BaseData
    {
        public int LoginInfoId { set; get; }
        public String LoginKey { set; get; }
        public int UserId { set; get; }
        public int Status { set; get; }

    }
}