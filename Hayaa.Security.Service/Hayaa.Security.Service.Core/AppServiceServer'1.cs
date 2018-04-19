using System;
using System.Collections.Generic;
using System.Text;
using Hayaa.DataAccess;
using Hayaa.BaseModel;
using Hayaa.Security.Service.Dao;
using Hayaa.Security.Service.Config;
using System.Linq;
using Hayaa.Common;

namespace Hayaa.Security.Service
{
    public partial class AppServiceServer
    {
        public FunctionOpenResult<bool> IsCompare(List<AppService> target, int appId)
        {
            var r = new FunctionOpenResult<bool>();
            List<AppService> source = GetAppServiceByAppId(appId);
            if (target != null)
            {
               
                foreach (var ap in target)
                {
                    var sap = source.Find(t => t.Name == ap.Name);
                    if (sap != null)
                    {
                        ap.AppFunctions.Sort();
                        sap.AppFunctions.Sort();
                        String strAp = String.Join(",", ap.AppFunctions.Select(a => a.FunctionName));
                        String strSap = String.Join(",", sap.AppFunctions.Select(a => a.FunctionName));
                        if (strAp == strSap)
                        {
                            r.Data = true;
                        }
                        else
                        {
                            r.ErrorMsg = String.Format("{0}服务的方法名称不匹配", sap.Name);
                            r.Data = false;
                            break;
                        }
                    }
                    else
                    {
                        r.ErrorMsg = String.Format("{0}服务找不到数据", ap.Name);
                        r.Data = false;
                        break;
                    }
                };
            }
            else
                r.Data = false;
           
            return r;
        }

        private static List<AppService> GetAppServiceByAppId(int appId)
        {
            var parmater = new AppServiceSearchPamater();
            parmater.SetAppId(appId, PamaterOperationType.Equal);
            parmater.SetStatus(null, PamaterOperationType.In);
            parmater.StatusList = new List<byte>() {0,1 };
            var source = AppServiceDal.GetList(parmater);
            if (source != null)
            {
                var functionParamter = new AppFunctionSearchPamater();
                functionParamter.SetAppServiceId(null, PamaterOperationType.In);
                functionParamter.AppServiceIdList = source.Select(a => a.AppServiceId).ToList();
                functionParamter.SetStatus(null, PamaterOperationType.In);
                functionParamter.StatusList = new List<byte>() { 0, 1 };
                var functionSource = AppFunctionDal.GetList(functionParamter);
                if (functionSource != null)
                {
                    source.ForEach(ap =>
                    {
                        ap.AppFunctions = functionSource.FindAll(af => af.AppServiceId == ap.AppServiceId);
                    });
                }
            }

            return source;
        }

        public FunctionOpenResult<bool> ExistAppService(int appId)
        {
            var r = new FunctionOpenResult<bool>();

            var parmater = new AppServiceSearchPamater();
            parmater.SetAppId(appId, PamaterOperationType.Equal);
            var source = AppServiceDal.GetList(parmater);
            if ((source != null) && (source.Count > 0))
            {
                r.Data = true;
            }
            else
            {
                r.Data = false;
            }
            return r;
        }
        public FunctionOpenResult<bool> RecordAppService(List<AppService> data, int appInstanceId)
        {
            FunctionOpenResult<bool> r = new FunctionOpenResult<bool>();
            r.Data = Rel_AppInstance_AppServiceDal.UpdateAppInstanceId(new Rel_AppInstance_AppService()
            {
                AppInstanceId = appInstanceId,
                AppService = JsonHelper.Serlaize<List<AppService>>(data),
                IsCompare = r.Data
            }) > 0;
            if (!r.Data)
            {
                r.Data = Rel_AppInstance_AppServiceDal.Add(new Rel_AppInstance_AppService()
                {
                    AppInstanceId = appInstanceId,
                    AppService = JsonHelper.Serlaize<List<AppService>>(data),
                    IsCompare = r.Data
                }) > 0;
            }
            return r;
        }

        public FunctionOpenResult<bool> Add(List<AppService> data, int appInstanceId)
        {
            var r = new FunctionOpenResult<bool>();
            r.Data = false;
            if (data != null)
            {
                Rel_AppInstance_AppServiceDal.Add(new Rel_AppInstance_AppService() {
                     AppInstanceId=appInstanceId,
                      AppService=JsonHelper.Serlaize<List<AppService>>(data)
                       
                });
                
                r.Data = true;
            }
            return r;
        }

        public FunctionOpenResult<bool> Update( int appInstanceId,int appId)
        {
            Rel_AppInstance_AppService raas= Rel_AppInstance_AppServiceDal.GetByAppInstanceId(appInstanceId);
            List<AppService> data = (raas!=null)?JsonHelper.Deserialize<List<AppService>>(raas.AppService):null;
            var r = new FunctionOpenResult<bool>();
            r.Data = false;
            if (data != null)
            {
                Rel_AppInstance_AppServiceDal.UpdateAppInstanceId(new Rel_AppInstance_AppService()
                {
                    AppInstanceId = appInstanceId,
                    AppService = JsonHelper.Serlaize<List<AppService>>(data)

                });
                List<AppService> source = GetAppServiceByAppId(appId);
                data.ForEach(ap => {
                    var sap = source.Find(t => t.Name == ap.Name);
                    if (sap!=null)
                    {
                        if (ap.AppFunctions != null)
                        {
                            ap.AppFunctions.ForEach(af => {
                                if (!(sap.AppFunctions.RemoveAll(t => t.FunctionName == af.FunctionName)>0))//将已经保存的数据消除,如果消除数量为0表示此数据需要保存
                                {
                                    AppFunctionDal.Add(af);
                                }
                            });
                            if (sap.AppFunctions.Count > 0)//表示有实例未拥有的数据存在，需要打上无匹配的标识
                            {
                                sap.AppFunctions.ForEach(af => {
                                    AppFunctionDal.SigningNoMatching(af.AppFuntionId);
                                });
                                sap.AppFunctions.Clear();
                            }
                        }
                    }
                    else
                    {//数据中未找到的的AppService进行插入
                      int appServiceId=AppServiceDal.Add(ap);
                        if (appServiceId > 0)
                        {
                            if (ap.AppFunctions != null)
                            {
                                ap.AppFunctions.ForEach(af => {
                                    AppFunctionDal.Add(af);
                                });
                               
                            }                            
                        }
                    }
                });
                var sapList = source.FindAll(ap => ap.AppFunctions.Count > 0);//找出无匹配的AppService,并且打上无匹配标识
                if (sapList != null)
                {
                    sapList.ForEach(ap => {
                        AppServiceDal.SigningNoMatching(ap.AppServiceId);
                        AppFunctionDal.SigningNoMatchingByAppServiceId(ap.AppServiceId);
                    });
                }
                r.Data = true;
            }
            return r;
        }
        public FunctionOpenResult<bool> CancleById(List<int> idList)
        {
            var r = new FunctionOpenResult<bool>();
            r.Data = AppServiceDal.CancleById(idList); 
            return r;
        }
        public FunctionListResult<AppService> GetAuthority(int appId)
        {
            var r = new FunctionListResult<AppService>();
            var pamater = new AppGrantSearchPamater() { AppId=appId };
            var list = AppGrantDal.GetList(pamater);
            List<AppService> asList = null;
            r.Data = asList;
            if (list != null)
            {
                asList = list.Select(a => new AppService() { AppServiceId=a.AppServiceId, AppFunctions=new List<AppFunction>() }).ToList();
                var functionPamater = new AppFunctionSearchPamater();
                functionPamater.SetAppFuntionId(null, PamaterOperationType.In);
                functionPamater.AppFuntionIdList = list.Select(a => a.AppFunctionId).ToList();
                functionPamater.SetStatus(1, PamaterOperationType.Equal);
                var appFunctions = AppFunctionDal.GetList(functionPamater);
                if (appFunctions != null)
                {
                    if (asList != null)
                    {
                        asList.ForEach(t => {
                            t.AppFunctions = appFunctions.FindAll(af => af.AppServiceId == t.AppServiceId);
                        });                       
                    }
                }
            }
            return r;
        }
    }
}