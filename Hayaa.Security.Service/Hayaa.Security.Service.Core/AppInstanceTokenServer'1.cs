using System;
using System.Collections.Generic;
using System.Text;
using Hayaa.DataAccess;
using Hayaa.BaseModel;
using Hayaa.Security.Service.Dao;
using Hayaa.Security.Service.Config;
/// <summary>
///代码效率工具生成，此文件不要修改
/// </summary>
namespace Hayaa.Security.Service
{
    public partial class AppInstanceTokenServer 
    {
        public FunctionResult<AppInstanceToken> ExchangeToken(int appInstanceId, string appToken)
        {
            String appInstanceToken = CreateToken(appToken);
            var temp = AppInstanceTokenDal.GetByAppInstanceId(appInstanceId);
            if (temp != null) return new FunctionResult<AppInstanceToken>() {
                ErrorMsg = "实例已有有效token"
            };
            return Create(new AppInstanceToken() {
                 AppInstanceId=appInstanceId,
                  AppToken=appToken,
                   Token=appInstanceToken
            });
        }
        /// <summary>
        /// 通过算法进行内容置换
        /// TODO
        /// </summary>
        /// <param name="appToken"></param>
        /// <returns></returns>
        private string CreateToken(string appToken)
        {
            return Guid.NewGuid().ToString().Replace("-","");
        }
        public FunctionResult<AppInstanceToken> Get(int appInstanceId, string token)
        {
            var r = new FunctionResult<AppInstanceToken>();
            r.Data = AppInstanceTokenDal.GetByAppInstanceIdAndToken(appInstanceId, token);
            return r;
        }
    }
}