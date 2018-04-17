using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;

namespace Hayaa.ServiceScaner
{
    public class Scaner
    {
        public List<MvcController> WebControllerScan(String assemblyPath)
        {
            List<MvcController> result = new List<MvcController>();
            Assembly assembly = Assembly.LoadFile(assemblyPath);
            List<Type> typeList = assembly.GetTypes().ToList();
            if (typeList != null)
            {
                typeList.ForEach(t =>
                {
                    if (t.Name.Contains("Controller"))
                    {
                        MvcController service = new MvcController() { Namespace = t.Namespace, ClassName = t.Name, Functions = new List<Function>() };
                        List<MethodInfo> methods = t.GetMethods().ToList();
                        if (methods != null)
                        {
                            methods.ForEach(m =>
                            {
                                service.Functions.Add(new Function() {
                                    Name = m.Name
                                });
                            });
                        }
                    }
                });
            }
            
            return result;
        }
    }
}
