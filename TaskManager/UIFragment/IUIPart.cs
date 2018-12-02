using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace TaskManager.UIFragment
{
    interface IUIPart
    {
        void SetLabel(string label);
        void SetData(Object model, PropertyInfo fieldInfo);
        bool Validate();
        void Save();
    }
}
