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
    public partial class LoginForm : Form
    {
        const string LOGIN = "admin";
        const string PASSWORD = "admin";

        public LoginForm()
        {
            InitializeComponent();
        }

        // События нажатия кнопки "ОК"
        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == LOGIN && textBoxPassword.Text == PASSWORD)
            {
                MessageBox.Show("Вход выполнен");

                Close();
            }
            else
                MessageBox.Show("Неверный логин или пароль");
        }

        // Событие нажатия кнопки "Отмена"
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Событие нажатия кнопки "Видимость пароля"
        private void buttonVisiblePassword_Click(object sender, EventArgs e)
        {
            // Меняется значение "видимость текста" на противоположное значение
            textBoxPassword.UseSystemPasswordChar = !textBoxPassword.UseSystemPasswordChar;
        }
    }
}
