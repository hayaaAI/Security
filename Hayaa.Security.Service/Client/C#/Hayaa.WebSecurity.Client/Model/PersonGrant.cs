using Hayaa.BaseModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hayaa.UserAuth.Service
{
   public class PersonGrant:BaseData
    {
        public int AppGrantId { set; get; }
        public int AppId { set; get; }
        public int UserId { set; get; }
        public int AppFunctionId { set; get; }

    }
}
