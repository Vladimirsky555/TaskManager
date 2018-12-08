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
                }

                else if (pInfo.PropertyType == typeof(float))
                {
                    lbl = "FLOAT";
                    MethodInfo label = type.GetMethod("SetLabel");
                    MethodInfo data = type.GetMethod("SetData");
                    label.Invoke(lbl, new object[0]);
                    //data.Invoke(model, type.GetProperty(""));
                }

                else if (pInfo.PropertyType == typeof(string))
                {

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
