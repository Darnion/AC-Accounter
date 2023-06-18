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
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace DataGridView_Adm_Com
{
    public partial class AdminPanelForm : Form
    {
        private DbContextOptions<ApplicationContext> options;
        private bool sortedByPrivilegeAsc = false;
        public User currentUser;

        public AdminPanelForm()
        {
            InitializeComponent();
            options = ConnectJSON.Option();
            dataGridView_Users.AutoGenerateColumns = false;
            dataGridView_Users.DataSource = ReadDB(options);
        }

        // CRUD
        private static void CreateDB(DbContextOptions<ApplicationContext> options, User user)
        {
            using (var db = new ApplicationContext(options))
            {
                User t = new User();
                user.Id = t.Id;
                db.Users.Add(user);
                db.SaveChanges();
            }
        }
        private static List<User> ReadDB(DbContextOptions<ApplicationContext> options)
        {
            using (ApplicationContext db = new ApplicationContext(options))
            {
                return db.Users
                    .OrderBy(x => x.Id)
                    .ToList();
            }
        }
        private static void UpdateDB(DbContextOptions<ApplicationContext> options, User user)
        {
            using (var db = new ApplicationContext(options))
            {
                var value = db.Users.FirstOrDefault(u => u.Id == user.Id);
                if (value != null)
                {
                    value.Login = user.Login;
                    value.Password = user.Password;
                    value.Privilege = user.Privilege;
                    db.SaveChanges();
                }
            }
        }
        private static void DeleteDB(DbContextOptions<ApplicationContext> options, User user)
        {
            using (var db = new ApplicationContext(options))
            {
                var value = db.Users.FirstOrDefault(u => u.Id == user.Id);
                if (value != null)
                {
                    db.Users.Remove(value);
                    db.SaveChanges();
                }

            }
        }

        private void dataGridView_Users_SelectionChanged(object sender, EventArgs e)
        {
            // активация/деактивация кнопок изменения записей
            buttonEdit.Enabled = buttonDelete.Enabled = dataGridView_Users.SelectedRows.Count == 1;
        }

        private void dataGridView_Users_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // активация/деактивация кнопки сортировки
            if (dataGridView_Users.SelectedCells.Count > 0)
            {
                buttonSort.Enabled = true;
            }
            else
            {
                buttonSort.Enabled = false;
            }
        }

        // нажатие кнопки сортировки по привилегии
        private void buttonPrivilegeSort_Click(object sender, EventArgs e)
        {
            if (sortedByPrivilegeAsc)
            {
                using (ApplicationContext db = new ApplicationContext(options))
                {
                    dataGridView_Users.DataSource = db.Users
                                                        .OrderByDescending(x => x.Privilege)
                                                        .ToList();
                }
            }
            else
            {
                using (ApplicationContext db = new ApplicationContext(options))
                {
                    dataGridView_Users.DataSource = db.Users
                                                        .OrderBy(x => x.Privilege)
                                                        .ToList();
                }
            }

            sortedByPrivilegeAsc = !sortedByPrivilegeAsc;
        }

        // нажатие кнопки сброса сортировки
        private void sortClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sortedByPrivilegeAsc = false;
            using (ApplicationContext db = new ApplicationContext(options))
            {
                dataGridView_Users.DataSource = db.Users
                                                    .OrderBy(x => x.Id)
                                                    .ToList();
            }
        }

        // формат таблицы
        private void dataGridView_Users_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex % 2 == 1)
            {
                dataGridView_Users.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Beige;
            }
        }

        // закрытие формы
        private void AdminPanelForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }

        // активация/деактивация кнопки фильтра по логину
        private void filterToolStripTextBox_TextChanged(object sender, EventArgs e)
        {
            if (filterToolStripTextBox.Text != "")
            {
                loginToolStripMenuItem.Enabled = true;
            }
            else
            {
                loginToolStripMenuItem.Enabled = false;
            }
        }

        // обработка ввода в TextBox
        private void filterToolStripTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 'A' || e.KeyChar > 'z') && !char.IsDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != '_')
            {
                e.Handled = true;
            }
        }

        // поиск по логину
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext(options))
            {
                dataGridView_Users.DataSource = db.Users
                                                    .Where(x => x.Login.ToLower().Contains(filterToolStripTextBox.Text.ToLower()))
                                                    .ToList();
            }

            if (dataGridView_Users.RowCount == 0)
            {
                MessageBox.Show("Записей соответствующих фильтру не найдено", "Поиск");
            }
        }

        // поиск по привилегии
        private void privilegeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext(options))
            {
                if (filterToolStripTextBox.Text == "")
                {
                    dataGridView_Users.DataSource = db.Users
                                                    .Where(x => x.Privilege == null)
                                                    .ToList();
                }
                else
                {
                    dataGridView_Users.DataSource = db.Users
                                                    .Where(x => x.Privilege.ToLower().Contains(filterToolStripTextBox.Text.ToLower()))
                                                    .ToList();
                }
            }

            if (dataGridView_Users.RowCount == 0)
            {
                MessageBox.Show("Записей соответствующих фильтру не найдено", "Поиск");
            }
        }

        // очистка фильтра
        private void clearFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext(options))
            {
                dataGridView_Users.DataSource = db.Users
                                                    .OrderBy(x => x.Id)
                                                    .ToList();
            }
        }

        // обработка нажатия кнопки добавления пользователя
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var infoForm = new UserInfoForm();

            if (infoForm.ShowDialog(this) == DialogResult.OK)
            {
                CreateDB(options, infoForm.User);
                dataGridView_Users.DataSource = ReadDB(options);
            }
        }

        // обработка нажатия кнопки изменения пользователя
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            var id = (User)dataGridView_Users.Rows[dataGridView_Users.SelectedRows[0].Index].DataBoundItem;
            var infoForm = new UserInfoForm(id);
            if (id.Login != currentUser.Login || id.Password != currentUser.Password)
            {
                if (infoForm.ShowDialog(this) == DialogResult.OK)
                {
                    id.Login = infoForm.User.Login;
                    id.Password = infoForm.User.Password;
                    id.Privilege = infoForm.User.Privilege;
                    UpdateDB(options, id);
                    dataGridView_Users.DataSource = ReadDB(options);
                }
            }
            else
            {
                if (infoForm.ShowDialog(this) == DialogResult.OK)
                {
                    id.Login = currentUser.Login = infoForm.User.Login;
                    id.Password = currentUser.Password = infoForm.User.Password;
                    id.Privilege = "admin";
                    UpdateDB(options, id);
                    dataGridView_Users.DataSource = ReadDB(options);
                }
            }
        }

        // обработка нажатия кнопки удаления пользователя
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var id = (User)dataGridView_Users.Rows[dataGridView_Users.SelectedRows[0].Index].DataBoundItem;
            if (id.Login != currentUser.Login || id.Password != currentUser.Password)
            {
                if (MessageBox.Show($"Вы действительно хотите удалить {id.Login}?",
                "Удаление записи", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DeleteDB(options, id);
                    dataGridView_Users.DataSource = ReadDB(options);
                }
            }
            else
            {
                MessageBox.Show("Вы не можете удалить свою учетную запись", "Ошибка");
            }
        }
    }
}
