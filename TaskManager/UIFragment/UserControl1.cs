﻿using System;
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
    public partial class UserControl1 : UserControl, IUIPart
    {

        Object model;
        PropertyInfo fieldInfo;

        public UserControl1()
        {
            InitializeComponent();
        }
        public void SetLabel(string label)
        {
            this.label1.Text = label;
        }
        public void SetData(Object model, PropertyInfo fieldInfo)
        {
            this.model = model;
            this.fieldInfo = fieldInfo;
            this.textBox1.Text = fieldInfo.GetValue(model).ToString();
        }
        public new bool Validate()
        {
            if(this.textBox1.Text == "")
            {
                return false;
            }
            int value;
            bool chek = int.TryParse(this.textBox1.Text,out value);
            return chek;
        }
        public void Save()
        {
            int value;
            bool chek = int.TryParse(this.textBox1.Text, out value);

            fieldInfo.SetValue(model, value);
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
