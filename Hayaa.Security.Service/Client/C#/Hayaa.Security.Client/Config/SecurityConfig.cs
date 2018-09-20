using Hayaa.BaseModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hayaa.Security.Client.Config
{
    internal class SecurityConfig :BaseData, ConfigContent
    {
        /// <summary>
        /// App授权数据获取地址
        /// </summary>
        public String AppSecurityUrl { set; get; }
        /// <summary>
        /// App基础授权地址
        /// </summary>
        public String AppSecurityBaseAuthUrl { set; get; }
        /// <summary>
        /// App实例基础授权地址
        /// </summary>
        public String AppInstanceSecurityBaseAuthUrl { set; get; }
        /// <summary>
        /// 缓存的配置名
        /// </summary>
        public String CacheConfigName { set; get; }
        public AppSettings AppSettings { set; get; }
        public ConnectionStrings ConnectionStrings { set; get; }
    }
}
