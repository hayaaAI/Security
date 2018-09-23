using Hayaa.BaseModel.Model;
using Hayaa.Common;
using Hayaa.Security.Client.Config;
using Hayaa.Security.Client.Model;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Hayaa.Security.Client
{
  public  class SecurityRoot
    {
        public static void Init(int appId)
        {
            g_authorityData = GetAuthority(appId);
           
        }
        public static void Reset(int appId)
        {
            Init(appId);
        }
        private static Dictionary<String, List<String>> g_authorityData = null;     
        private static Dictionary<String, List<String>> GetAuthority(int appId)
        {
            Dictionary<String, List<String>> result = new Dictionary<string, List<string>>();
            var urlParamater = new Dictionary<string, string>();
            urlParamater.Add("appid", appId.ToString());
            String response = HttpHelper.Transaction(ConfigHelper.Instance.GetComponentConfig().AppSecurityUrl, urlParamater);
            TransactionResult<List<AppService>> serverResult = JsonHelper.DeserializeSafe<TransactionResult<List<AppService>>>(response);
            if (serverResult.Code == 0)
            {
                serverResult.Data.ForEach(aps => {
                    result.Add(aps.Name, aps.AppFunctions.Select(af => af.FunctionName).ToList());
                });
            }
            else
            {
                throw new Exception(serverResult.Message);
            }
            return result;
        }
        internal static Dictionary<String, List<String>> GetAuthority()
        {
            return g_authorityData;
        }
    }
}
