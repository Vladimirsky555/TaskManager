using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows.Forms;
using TaskManager.Model;
using TaskManager.UIFragment;

namespace TaskManager.UI
{
    public partial class UIBuilder : Form
    {
        object model;
        public UIBuilder(object _model)
        {
            InitializeComponent();
            model = _model;
            InitFields();
        }

        private void InitFields()
        {
            Type type = model.GetType();

            var parameters = type.GetProperties();
            foreach (var pInfo in parameters)
            {
                IUIPart part = null;
                if (pInfo.PropertyType == typeof(int))
                {
                    //Создаем соответствующий тип
                }

                else if (pInfo.PropertyType == typeof(float))
                {

                }

                part.SetLabel("sdafasdf");
                part.SetData(model, pInfo);

                UserControl control = (UserControl)part;
                control.Top = 0;
                control.Left = 0;

                Controls.Add(control);
            }

            //methods = type.GetMethods();
            //foreach(MethodInfo method in methods)
            //{
            //    ParameterInfo[] ps = method.GetParameters();

            //    if (ps.Length == 1)
            //    {
            //        ModelAttribute attribute = method.GetCustomAttribute<ModelAttribute>();
            //        if (attribute != null)
            //        {
            //            object[] obj = new object[] { attribute.Label };
            //            method.Invoke(model, obj);
            //        }
            //    }

            //    if(ps.Length == 2)
            //    {
            //        PropertyInfo[] fields = type.GetProperties();
            //        object[] obj = new object[] { model, fields[1] };
            //        method.Invoke(model, obj);
            //    }
            //}
        }
    };
}
