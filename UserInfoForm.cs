using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataGridView_Adm_Com.Models;

namespace DataGridView_Adm_Com
{
    public partial class UserInfoForm : Form
    {
        private readonly User user;
        public UserInfoForm()
        {
            InitializeComponent();
            Text = "Добавление пользователя";
            user = new User();
        }

        public UserInfoForm(User source) : this()
        {
            Text = "Редактирование пользователя";
            textBoxLogin.Text = source.Login;
            textBoxPassword.Text = source.Password;
            textBoxPrivilege.Text = source.Privilege;
        }

        public User User => user;

        private void textBoxLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 'A' || e.KeyChar > 'z') && !char.IsDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != '_')
            {
                e.Handled = true;
            }
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) || (e.KeyChar > 'А' && e.KeyChar < 'я'))
            {
                e.Handled = true;
            }
        }

        private void textBoxPrivilege_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 'A' || e.KeyChar > 'z'))
            {
                e.Handled = true;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {
            buttonSave.Enabled = !string.IsNullOrEmpty(textBoxLogin.Text) && !string.IsNullOrEmpty(textBoxPassword.Text);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            user.Login = textBoxLogin.Text;
            user.Password = textBoxPassword.Text;
            user.Privilege = textBoxPrivilege.Text;

            DialogResult = DialogResult.OK;
        }
    }
}
