using Hayaa.BaseModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hayaa.CompanyWebSecurity.Client.Model
{
    [Serializable]
    internal class AppFunction : BaseData
    {
        public int AppFuntionId { set; get; }
        public int AppId { set; get; }
        public String FunctionName { set; get; }
        public String ClassFullName { set; get; }
        public String InterfaceFullName { set; get; }
        public String Remark { set; get; }
        public String WebApiPath { set; get; }
        public byte Status { set; get; }
        public int AppServiceId { set; get; }

    }
}
