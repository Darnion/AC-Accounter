using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DataGridView_Adm_Com.Models;
using Microsoft.EntityFrameworkCore;
using Excel = Microsoft.Office.Interop.Excel;

namespace DataGridView_Adm_Com
{
    public partial class AdmissionCommiteeForm : Form
    {
        private bool sortedByAlphabet = false;
        private bool sortedByMark = false;
        private static bool? filteredGenderMale = null;
        private static bool? filteredSumExamsGT = null;
        private static bool? filteredAgeGT = null;
        private static bool? filteredEducationFormFT = null;
        private static int filterValue = 0;
        private DbContextOptions<ApplicationContext> options;
        private int passGrade = 150;
        public User currentUser;
        public AdmissionCommiteeForm()
        {
            InitializeComponent();
            options = ConnectJSON.Option();
            dataGridView_Adm_Com.AutoGenerateColumns = false;
            dataGridView_Adm_Com.DataSource = ReadDB(options);
        }

        private void toolStripMenuItem_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var infoForm = new EntrantInfoForm();

            if (infoForm.ShowDialog(this) == DialogResult.OK)
            {
                CreateDB(options, infoForm.Entrant);
                dataGridView_Adm_Com.DataSource = ReadDB(options);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            var id = (Entrant)dataGridView_Adm_Com.Rows[dataGridView_Adm_Com.SelectedRows[0].Index].DataBoundItem;
            var infoForm = new EntrantInfoForm(id);
            if (infoForm.ShowDialog(this) == DialogResult.OK)
            {
                id.FullName = infoForm.Entrant.FullName;
                id.Gender = infoForm.Entrant.Gender;
                id.BirthDate = infoForm.Entrant.BirthDate;
                id.EducationForm = infoForm.Entrant.EducationForm;
                id.MathExams = infoForm.Entrant.MathExams;
                id.RussianExams = infoForm.Entrant.RussianExams;
                id.ITExams = infoForm.Entrant.ITExams;
                UpdateDB(options, id);
                dataGridView_Adm_Com.DataSource = ReadDB(options);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var id = (Entrant)dataGridView_Adm_Com.Rows[dataGridView_Adm_Com.SelectedRows[0].Index].DataBoundItem;
            if (MessageBox.Show($"Вы действительно хотите удалить {id.FullName}?",
                "Удаление записи", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                RemoveDB(options, id);
                dataGridView_Adm_Com.DataSource = ReadDB(options);
            }
        }

        private void dataGridView_Adm_Com_SelectionChanged(object sender, EventArgs e)
        {
            buttonEdit.Enabled =
                buttonDelete.Enabled =
                toolStripMenuItem_Edit.Enabled =
                toolStripMenuItem_Delete.Enabled =
                dataGridView_Adm_Com.SelectedRows.Count == 1;
        }

        private void dataGridView_Adm_Com_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView_Adm_Com.Columns[e.ColumnIndex].Name == "SexColumn")
            {
                switch ((Gender)e.Value)
                {
                    case Gender.Male:
                        e.Value = "Мужской";
                        break;
                    case Gender.Female:
                        e.Value = "Женский";
                        break;
                }
            }

            if (dataGridView_Adm_Com.Columns[e.ColumnIndex].Name == "BirthDateColumn")
            {
                e.Value = ((DateTime)e.Value).ToShortDateString();
            }

            if (dataGridView_Adm_Com.Columns[e.ColumnIndex].Name == "EducationFormColumn")
            {
                switch ((EducationForm)e.Value)
                {
                    case EducationForm.FullTime:
                        e.Value = "Очная";
                        break;
                    case EducationForm.Distant:
                        e.Value = "Заочная";
                        break;
                }
            }

            if (dataGridView_Adm_Com.Columns[e.ColumnIndex].Name == "SumExamsColumn")
            {
                var id = (Entrant)dataGridView_Adm_Com.Rows[e.RowIndex].DataBoundItem;
                e.Value = id.MathExams + id.RussianExams + id.ITExams;
            }

            if (e.RowIndex % 2 == 1)
            {
                dataGridView_Adm_Com.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Beige;
            }
        }

        private void dataGridView_Adm_Com_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var passedEntrants = 0;

            labelAmountEntrant.Text = $"Количество абитуриентов: {dataGridView_Adm_Com.RowCount}";

            for (var i = 0; i < dataGridView_Adm_Com.RowCount; i++)
            {
                var entrant = (Entrant)dataGridView_Adm_Com.Rows[i].DataBoundItem;
                if (entrant.RussianExams + entrant.MathExams + entrant.ITExams > passGrade)
                {
                    passedEntrants++;
                }
            }

            labelAmountPassGrade.Text = $"Количество абитуриентов с проходным баллом (>{passGrade}): {passedEntrants}";

            if (dataGridView_Adm_Com.SelectedCells.Count > 0)
            {
                buttonSort.Enabled = true;
            }
            else
            {
                buttonSort.Enabled = false;
            }
        }

        private static void CreateDB(DbContextOptions<ApplicationContext> options, Entrant entrant)
        {
            using (var db = new ApplicationContext(options))
            {
                Entrant t = new Entrant();
                entrant.Id = t.Id;
                db.AdmComDB.Add(entrant);
                db.SaveChanges();
            }
        }
        private static void RemoveDB(DbContextOptions<ApplicationContext> options, Entrant entrant)
        {
            using (var db = new ApplicationContext(options))
            {
                var value = db.AdmComDB.FirstOrDefault(u => u.Id == entrant.Id);
                if (value != null)
                {
                    db.AdmComDB.Remove(value);
                    db.SaveChanges();
                }
            }
        }
        private static void UpdateDB(DbContextOptions<ApplicationContext> options, Entrant entrant)
        {
            using (var db = new ApplicationContext(options))
            {
                var value = db.AdmComDB.FirstOrDefault(u => u.Id == entrant.Id);
                if (value != null)
                {
                    value.FullName = entrant.FullName;
                    value.Gender = entrant.Gender;
                    value.BirthDate = entrant.BirthDate;
                    value.EducationForm = entrant.EducationForm;
                    value.MathExams = entrant.MathExams;
                    value.RussianExams = entrant.RussianExams;
                    value.ITExams = entrant.ITExams;
                    db.SaveChanges();
                }
            }
        }
        private static List<Entrant> ReadDB(DbContextOptions<ApplicationContext> options)
        {
            using (ApplicationContext db = new ApplicationContext(options))
            {
                return db.AdmComDB
                    .OrderBy(x => x.Id)
                    .ToList();
            }
        }

        private static List<Entrant> SortAlphabetUpDB(DbContextOptions<ApplicationContext> options)
        {
            using (ApplicationContext db = new ApplicationContext(options))
            {
                return db.AdmComDB
                    .OrderBy(x => x.FullName)
                    .ToList();
            }
        }

        private static List<Entrant> SortAlphabetDownDB(DbContextOptions<ApplicationContext> options)
        {
            using (ApplicationContext db = new ApplicationContext(options))
            {
                return db.AdmComDB
                    .OrderByDescending(x => x.FullName)
                    .ToList();
            }
        }

        private static List<Entrant> SortMarkUpDB(DbContextOptions<ApplicationContext> options)
        {
            using (ApplicationContext db = new ApplicationContext(options))
            {
                return db.AdmComDB
                    .OrderBy(x => x.MathExams + x.RussianExams + x.ITExams)
                    .ToList();
            }
        }

        private static List<Entrant> SortMarkDownDB(DbContextOptions<ApplicationContext> options)
        {
            using (ApplicationContext db = new ApplicationContext(options))
            {
                return db.AdmComDB
                    .OrderByDescending(x => x.MathExams + x.RussianExams + x.ITExams)
                    .ToList();
            }
        }

        private void buttonSort_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == buttonAlphabetSort)
            {
                if (!sortedByAlphabet)
                {
                    dataGridView_Adm_Com.DataSource = SortAlphabetUpDB(options);
                    sortedByAlphabet = !sortedByAlphabet;
                }
                else
                {
                    dataGridView_Adm_Com.DataSource = SortAlphabetDownDB(options);
                    sortedByAlphabet = !sortedByAlphabet;
                }
            }
            else if (e.ClickedItem == buttonMarkSort)
            {
                if (!sortedByMark)
                {
                    dataGridView_Adm_Com.DataSource = SortMarkUpDB(options);
                    sortedByMark = !sortedByMark;
                }
                else
                {
                    dataGridView_Adm_Com.DataSource = SortMarkDownDB(options);
                    sortedByMark = !sortedByMark;
                }
            }
        }

        private void AdmissionCommiteeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }

        private void searchToolStripTextBox_TextChanged(object sender, EventArgs e)
        {
            if (searchToolStripTextBox.Text != "")
            {
                searchToolStripButton.Enabled = true;
            }
            else
            {
                searchToolStripButton.Enabled = false;
            }
        }

        private void searchToolStripButton_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < dataGridView_Adm_Com.RowCount; i++)
            {
                for (var j = 0; j < dataGridView_Adm_Com.ColumnCount - 1; j++)
                {
                    if (dataGridView_Adm_Com.Rows[i].Cells[j].EditedFormattedValue.ToString().ToLower().Contains(searchToolStripTextBox.Text.ToLower()))
                    {
                        dataGridView_Adm_Com.Rows[i].Cells[j].Selected = true;
                    }
                    else
                    {
                        dataGridView_Adm_Com.Rows[i].Cells[j].Selected = false;
                    }
                }
            }

            if (dataGridView_Adm_Com.SelectedCells.Count == 0)
            {
                MessageBox.Show("Поиск не дал результатов", "Поиск");
            }
        }

        private static List<Entrant> FilterGender(DbContextOptions<ApplicationContext> options)
        {
            using (ApplicationContext db = new ApplicationContext(options))
            {
                if (filteredGenderMale == null)
                {
                    filteredGenderMale = true;
                    return db.AdmComDB
                        .Where(x => x.Gender == Gender.Male)
                        .ToList();
                }
                else if (filteredGenderMale == true)
                {
                    filteredGenderMale = false;
                    return db.AdmComDB
                        .Where(x => x.Gender == Gender.Female)
                        .ToList();
                }
                else
                {
                    return FilterClear(options);
                }
            }
        }

        private static List<Entrant> FilterEducationForm(DbContextOptions<ApplicationContext> options)
        {
            using (ApplicationContext db = new ApplicationContext(options))
            {
                if (filteredEducationFormFT == null)
                {
                    filteredEducationFormFT = true;
                    return db.AdmComDB
                        .Where(x => x.EducationForm == EducationForm.FullTime)
                        .ToList();
                }
                else if (filteredEducationFormFT == true)
                {
                    filteredEducationFormFT = false;
                    return db.AdmComDB
                        .Where(x => x.EducationForm == EducationForm.Distant)
                        .ToList();
                }
                else
                {
                    return FilterClear(options);
                }
            }
        }

        private static List<Entrant> FilterAge(DbContextOptions<ApplicationContext> options)
        {
            using (ApplicationContext db = new ApplicationContext(options))
            {
                var targetBirthDate = new DateTime(DateTime.Today.Year - filterValue, DateTime.Today.Month, DateTime.Today.Day);

                if (filteredAgeGT == null)
                {
                    filteredAgeGT = true;
                    return db.AdmComDB
                        .Where(x => x.BirthDate < targetBirthDate)
                        .ToList();
                }
                else if (filteredAgeGT == true)
                {
                    filteredAgeGT = false;
                    return db.AdmComDB
                        .Where(x => x.BirthDate > targetBirthDate)
                        .ToList();
                }
                else
                {
                    return FilterClear(options);
                }
            }
        }

        private static List<Entrant> FilterSumExams(DbContextOptions<ApplicationContext> options)
        {
            using (ApplicationContext db = new ApplicationContext(options))
            {
                if (filteredSumExamsGT == null)
                {
                    filteredSumExamsGT = true;
                    return db.AdmComDB
                        .Where(x => x.ITExams + x.MathExams + x.RussianExams >= filterValue)
                        .ToList();
                }
                else if (filteredSumExamsGT == true)
                {
                    filteredSumExamsGT = false;
                    return db.AdmComDB
                        .Where(x => x.ITExams + x.MathExams + x.RussianExams < filterValue)
                        .ToList();
                }
                else
                {
                    return FilterClear(options);
                }
            }
        }

        private static List<Entrant> FilterClear(DbContextOptions<ApplicationContext> options)
        {
            filteredGenderMale = null;
            filteredAgeGT = null;
            filteredEducationFormFT = null;
            filteredSumExamsGT = null;

            using (ApplicationContext db = new ApplicationContext(options))
            {
                return db.AdmComDB
                    .OrderBy(x => x.Id)
                    .ToList();
            }
        }

        //нажатие одной из кнопок фильтра
        private void filterToolStripButton_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // нажатие кнопки фильтр по полу
            if (e.ClickedItem == genderToolStripMenuItem)
            {
                if (!filteredGenderMale.HasValue)
                {
                    FilterClear(options);
                }
                dataGridView_Adm_Com.DataSource = FilterGender(options);
            }

            // нажатие кнопки фильтр по форме обучения
            if (e.ClickedItem == educationFormToolStripMenuItem)
            {
                if (!filteredEducationFormFT.HasValue)
                {
                    FilterClear(options);
                }
                dataGridView_Adm_Com.DataSource = FilterEducationForm(options);
            }

            // нажатие кнопки фильтр по возрасту
            if (e.ClickedItem == ageToolStripMenuItem)
            {
                if (!filteredAgeGT.HasValue)
                {
                    FilterClear(options);
                }
                dataGridView_Adm_Com.DataSource = FilterAge(options);
            }

            // нажатие кнопки фильтр по сумме баллов
            if (e.ClickedItem == sumExamsToolStripMenuItem)
            {
                if (!filteredSumExamsGT.HasValue)
                {
                    FilterClear(options);
                }
                dataGridView_Adm_Com.DataSource = FilterSumExams(options);
            }

            // нажатие кнопки сброса фильтра
            if (e.ClickedItem == clearFilterToolStripMenuItem)
            {
                dataGridView_Adm_Com.DataSource = FilterClear(options);
            }

            // активация/деактивация кнопки "Сброс"
            if (filteredGenderMale.HasValue || filteredEducationFormFT.HasValue || filteredSumExamsGT.HasValue || filteredAgeGT.HasValue)
            {
                clearFilterToolStripMenuItem.Enabled = true;
            }
            else
            {
                clearFilterToolStripMenuItem.Enabled = false;
            }

            // обновление иконок фильтров
            switch (filteredGenderMale)
            {
                case true:
                    genderToolStripMenuItem.Image = Properties.Resources.female_gender_symbol;
                    break;
                case false:
                    genderToolStripMenuItem.Image = null;
                    break;
                default:
                    genderToolStripMenuItem.Image = Properties.Resources.male_gender_symbol;
                    break;
            }

            switch (filteredEducationFormFT)
            {
                case true:
                    educationFormToolStripMenuItem.Text = "Форма обучения (заочная)";
                    break;
                case false:
                    educationFormToolStripMenuItem.Text = "Форма обучения (сброс)";
                    break;
                default:
                    educationFormToolStripMenuItem.Text = "Форма обучения (очная)";
                    break;
            }

            switch (filteredAgeGT)
            {
                case true:
                    ageToolStripMenuItem.Image = Properties.Resources.less_symbol;
                    break;
                case false:
                    ageToolStripMenuItem.Image = null;
                    break;
                default:
                    ageToolStripMenuItem.Image = Properties.Resources.great_or_equal_symbol;
                    break;
            }

            switch (filteredSumExamsGT)
            {
                case true:
                    sumExamsToolStripMenuItem.Image = Properties.Resources.less_symbol;
                    break;
                case false:
                    sumExamsToolStripMenuItem.Image = null;
                    break;
                default:
                    sumExamsToolStripMenuItem.Image = Properties.Resources.great_or_equal_symbol;
                    break;
            }
        }

        private void filterToolStripTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void searchToolStripTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void filterToolStripTextBox_TextChanged(object sender, EventArgs e)
        {
            if (filterToolStripTextBox.Text != "")
            {
                ageToolStripMenuItem.Enabled = sumExamsToolStripMenuItem.Enabled = true;
                int.TryParse(filterToolStripTextBox.Text, out filterValue);
            }
            else
            {
                ageToolStripMenuItem.Enabled = sumExamsToolStripMenuItem.Enabled = false;
            }
        }

        private void showInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, helpProvider.HelpNamespace);
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.Owner = this;
            aboutBox.Show();
        }

        private void adminPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminPanelForm adminPanel = new AdminPanelForm();
            adminPanel.Owner = this;
            adminPanel.currentUser = this.currentUser;
            adminPanel.Show();
            Hide();
        }

        private void changePassGradeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassGradeForm passGradeForm = new ChangePassGradeForm();
            passGradeForm.Owner = this;

            if (passGradeForm.ShowDialog() == DialogResult.OK)
            {
                int.TryParse(passGradeForm.textBoxPassGrade.Text, out passGrade);
                labelAmountPassGrade.Text = $"Количество абитуриентов с проходным баллом (>{passGrade}):" +
                    $" {ReadDB(options).Where(pE => pE.MathExams + pE.RussianExams + pE.ITExams > passGrade).Count()}";
                passGradeForm.Close();
            }
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Excel.Application ExcelApp = new Excel.Application();
            Excel.Workbook ExcelWorkBook;
            Excel.Worksheet ExcelWorkSheet;

            ExcelApp.WindowState = Excel.XlWindowState.xlMaximized;

            // книга
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);

            // таблица 
            ExcelWorkSheet = (Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);
            ExcelWorkSheet.StandardWidth = 25;

            for (var j = 0; j < dataGridView_Adm_Com.ColumnCount; j++)
            {
                ExcelApp.Cells[1, j + 1] = dataGridView_Adm_Com.Columns[j].HeaderText;
            }

            for (var i = 0; i < dataGridView_Adm_Com.RowCount; i++)
            {
                for (var j = 0; j < dataGridView_Adm_Com.ColumnCount; j++)
                {
                    ExcelApp.Cells[i + 2, j + 1] = dataGridView_Adm_Com.Rows[i].Cells[j].EditedFormattedValue;
                }
            }

            // вызов Excel
            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;
        }
    }
}
