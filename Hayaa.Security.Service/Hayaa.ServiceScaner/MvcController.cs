using System;
using System.Collections.Generic;
using System.Text;

namespace Hayaa.ServiceScaner
{
   public class MvcController
    {
        /// <summary>
        /// 命名空间
        /// </summary>
        public String Namespace { set; get; }
        /// <summary>
        /// 类名
        /// </summary>
        public String ClassName { set; get; }
        public List<Function> Functions { set; get; }
    }
}
