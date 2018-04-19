using System;
using System.Collections.Generic;
using Hayaa.BaseModel;
/// <summary>
///代码效率工具生成，此文件不要修改
/// </summary>
namespace Hayaa.Security.Service
{
    public class AppToken : BaseData
    {
        public int AppTokenId { set; get; }
        public int AppId { set; get; }
        public String Token { set; get; }
        public bool Status { set; get; }
      
    }
}