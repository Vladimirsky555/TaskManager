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
            int i = 0;
            string lbl = "";
            Type type = model.GetType();

            var parameters = type.GetProperties();
            foreach (var pInfo in parameters)
            {
                IUIPart part = null;
                if (pInfo.PropertyType == typeof(int))
                {
                    //Создаем соответствующий тип
                    lbl = "INT";
                    object[] obj = new object[] { lbl };
                    MethodInfo label = type.GetMethod("SetLabel");
                    MethodInfo data = type.GetMethod("SetData");
                    label.Invoke(part, obj);
                    data.Invoke(part, null);
                }

                else if (pInfo.PropertyType == typeof(float))
                {
                    lbl = "FLOAT";
                    object[] obj = new object[] { lbl };
                    MethodInfo label = type.GetMethod("SetLabel");
                    MethodInfo data = type.GetMethod("SetData");
                    label.Invoke(part, obj);
                    data.Invoke(part, null);
                }

                else if (pInfo.PropertyType == typeof(string))
                {
                    lbl = "STRING";
                    object[] obj = new object[] { lbl };
                    MethodInfo label = type.GetMethod("SetLabel");
                    MethodInfo data = type.GetMethod("SetData");
                    label.Invoke(part, obj);
                    data.Invoke(part, null);
                }

                else if (pInfo.PropertyType == typeof(DateTime))
                {
                    lbl = "DATETIME";
                    object[] obj = new object[] { lbl };
                    MethodInfo label = type.GetMethod("SetLabel");
                    MethodInfo data = type.GetMethod("SetData");
                    label.Invoke(part, obj);
                    data.Invoke(part, null);
                }

                part.SetLabel(lbl);
                part.SetData(model, pInfo);

                UserControl control = (UserControl)part;
                control.Top = i * 50;
                control.Left = 0;

                Controls.Add(control);
            }
        }
    };
}
