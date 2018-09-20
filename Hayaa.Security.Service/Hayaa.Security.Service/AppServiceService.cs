using Hayaa.BaseModel;
using Hayaa.BaseModel.Service;
using System;
using System.Collections.Generic;

namespace Hayaa.Security.Service
{
    public interface AppServiceService : IBaseService<AppService, AppServiceSearchPamater>
    {
        /// <summary>
        /// 检查App的服务功能数据是否存在
        /// </summary>
        /// <param name="appId">AppId</param>
        /// <returns>true表示存在数据false表示不存在数据</returns>
        FunctionOpenResult<bool> ExistAppService(int appId);
        /// <summary>
        /// 服务实例与已注册服务数据匹配比较
        /// </summary>
        /// <param name="target">服务实例的功能数据</param>
        /// <param name="appId">AppId</param>
        /// <returns></returns>
        FunctionOpenResult<bool> IsCompare(List<AppService> target, int appId);
        /// <summary>
        /// 记录实例的服务数据
        /// </summary>
        /// <param name="data">实例的服务数据</param>
        /// <param name="appInstanceId">App实例Id</param>
        /// <returns></returns>
        FunctionOpenResult<bool> RecordAppService(List<AppService> data, int appInstanceId);
        /// <summary>
        /// 自动添加服务与功能数据
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        FunctionListResult<AppService> Add(List<AppService> data);
        /// <summary>
        /// 依据一个实例的服务功能添加数据
        /// </summary>
        /// <param name="data">服务实例的功能数据</param>
        /// <returns></returns>
        FunctionOpenResult<bool> Add(List<AppService> data,int appInstanceId);      

        /// <summary>
        /// 依据一个实例的服务功能更新数据
        /// 未存在的添加，可匹配的不变，找不到匹配功能的已有数据进行标识
        /// </summary>
        ///<param name="appId">AppId</param>
        /// <param name="appInstanceId">更新指定的服务实例Id</param>
        /// <returns></returns>
        FunctionOpenResult<bool> Update(int appInstanceId, int appId);
        /// <summary>
        /// 注销无匹配的服务数据
        /// </summary>
        /// <param name="idList"></param>
        /// <returns></returns>
        FunctionOpenResult<bool> CancleById(List<int> idList);
        /// <summary>
        /// 获取授权的权限数据
        /// </summary>
        /// <param name="appId">被授权的App</param>
        /// <returns></returns>
        FunctionListResult<AppService> GetAuthority(int appId);
        /// <summary>
        /// 获取岗位授权的数据
        /// </summary>
        /// <param name="jobId">被授权的岗位</param>
        /// <returns></returns>
        FunctionListResult<AppService> GetJobAuthority(int jobId);
    }
}
