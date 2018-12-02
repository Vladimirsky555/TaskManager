using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace TaskManager.UIFragment
{
    public partial class FloatControl : UserControl, IUIPart
    {
        Object model;
        PropertyInfo fieldInfo;
        public FloatControl()
        {
            InitializeComponent();
        }

        public void SetLabel(string label)
        {
            this.label2.Text = label;
        }
        public void SetData(Object model, PropertyInfo fieldInfo)
        {
            this.model = model;
            this.fieldInfo = fieldInfo;
            this.textBox2.Text = fieldInfo.GetValue(model).ToString();
        }
        public new bool Validate()
        {
            if(this.textBox2.Text == "")
            {
                return false;
            }
            float value;
            bool chek = float.TryParse(this.textBox2.Text, out value);
            return chek;
        }
        public void Save()
        {
            float value;
            bool chek = float.TryParse(this.textBox2.Text,out value);

            if (chek)
            {
                fieldInfo.SetValue(model, value);
            }
        }
       
    }
}
