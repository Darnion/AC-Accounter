using System;
using System.Linq;
using System.Windows.Forms;
using DataGridView_Adm_Com.Models;
using Microsoft.EntityFrameworkCore;

namespace DataGridView_Adm_Com
{
    public partial class AuthorizationForm : Form
    {
        private DbContextOptions<ApplicationContext> options;
        public AuthorizationForm()
        {
            InitializeComponent();
            options = ConnectJSON.Option();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext(options))
            {
                try
                {
                    var user = db.Users.First(u => u.Login == loginTextBox.Text);

                    if (user.Password == passwordTextBox.Text)
                    {
                        var AdmComForm = new AdmissionCommiteeForm();
                        AdmComForm.Owner = this;
                        AdmComForm.currentUser = user;

                        if (user.Privilege == "admin")
                        {
                            AdmComForm.adminPanelToolStripMenuItem.Visible = true;
                            AdmComForm.adminPanelToolStripMenuItem.Enabled = true;
                        }

                        AdmComForm.Show();
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("Неверный пароль", "Ошибка");
                    }
                }
                catch
                {
                    MessageBox.Show("Пользователь с указанным именем не существует", "Ошибка");
                }
            }
        }

        private void loginTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 'A' || e.KeyChar > 'z') && !char.IsDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != '_')
            {
                e.Handled = true;
            }
        }

        private void passwordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) || (e.KeyChar > 'А' && e.KeyChar < 'я'))
            {
                e.Handled = true;
            }
        }
    }
}
