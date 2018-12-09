using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace TaskManager.Service
{
    class ServiceHolder : IServiceHolder
    {
       Dictionary<Type, Object> ServiceList = new Dictionary<Type, object>();
       public  bool RegisterService(Type description, Object service)
        {
            try
            {
                ServiceList.Add(description, service);
            }
            catch
            {
                return false;
            }
            return true;
        }
        public bool UnRegisterService(Type service)
        {
            try
            {
                ServiceList.Remove(service);
            }
            catch
            {
                return false;
            }
            return true;
        }
        public Object GetService(Type service)
        {
            return ServiceList[service];
        }

        public bool ClearAll()
        {
            if (ServiceList.Count == 0)
            {
                return false;
            }
            else
            {
                ServiceList.Clear();
                return true;
            }
        }
        public Object CreateObject(Type description)
        {
            ConstructorInfo[] ctorInfo = description.GetConstructors();
            foreach (ConstructorInfo cInfo in ctorInfo)
            {
                ParameterInfo[] pInfo = cInfo.GetParameters();
                List<Object> obj = new List<Object>();
                foreach (ParameterInfo p in pInfo)
                {
                    Object Obj = ServiceList[p.GetType()];

                    if (Obj != null)
                    {
                        obj.Add(Obj);
                    }
                    else
                    {
                        break;
                    }
                }

                if (pInfo.Length == obj.Count)
                {
                    return cInfo.Invoke(obj.ToArray());
                }
            }
            return (Object)null;
        }
    }
}
