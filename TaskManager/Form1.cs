using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager
{
    public partial class Form1 : Form
    {
        LoginForm loginForm;

        public Form1()
        {
            InitializeComponent();

            loginForm = new LoginForm();
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            loginForm.ShowDialog();
        }
    }
}
