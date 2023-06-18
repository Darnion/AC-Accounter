namespace DataGridView_Adm_Com
{
    partial class AdmissionCommiteeForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdmissionCommiteeForm));
            this.dataGridView_Adm_Com = new System.Windows.Forms.DataGridView();
            this.FIOColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SexColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EducationFormColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MathExamsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RussianExamsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITExamsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SumExamsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStripHeader = new System.Windows.Forms.MenuStrip();
            this.fileItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem_Close = new System.Windows.Forms.ToolStripMenuItem();
            this.editItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.changePassGradeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripInfo = new System.Windows.Forms.StatusStrip();
            this.labelAmountEntrant = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelAmountPassGrade = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonAdd = new System.Windows.Forms.ToolStripButton();
            this.buttonEdit = new System.Windows.Forms.ToolStripButton();
            this.buttonDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonSort = new System.Windows.Forms.ToolStripDropDownButton();
            this.buttonAlphabetSort = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonMarkSort = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripControl = new System.Windows.Forms.ToolStrip();
            this.searchToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.searchToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.filterToolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.genderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.educationFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sumExamsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.clearFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Adm_Com)).BeginInit();
            this.menuStripHeader.SuspendLayout();
            this.statusStripInfo.SuspendLayout();
            this.toolStripControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_Adm_Com
            // 
            this.dataGridView_Adm_Com.AllowUserToAddRows = false;
            this.dataGridView_Adm_Com.AllowUserToDeleteRows = false;
            this.dataGridView_Adm_Com.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Adm_Com.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FIOColumn,
            this.SexColumn,
            this.BirthDateColumn,
            this.EducationFormColumn,
            this.MathExamsColumn,
            this.RussianExamsColumn,
            this.ITExamsColumn,
            this.SumExamsColumn});
            this.dataGridView_Adm_Com.Location = new System.Drawing.Point(0, 52);
            this.dataGridView_Adm_Com.Name = "dataGridView_Adm_Com";
            this.dataGridView_Adm_Com.ReadOnly = true;
            this.dataGridView_Adm_Com.Size = new System.Drawing.Size(844, 373);
            this.dataGridView_Adm_Com.TabIndex = 0;
            this.dataGridView_Adm_Com.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView_Adm_Com_CellFormatting);
            this.dataGridView_Adm_Com.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView_Adm_Com_DataBindingComplete);
            this.dataGridView_Adm_Com.SelectionChanged += new System.EventHandler(this.dataGridView_Adm_Com_SelectionChanged);
            // 
            // FIOColumn
            // 
            this.FIOColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FIOColumn.DataPropertyName = "FullName";
            this.FIOColumn.HeaderText = "ФИО";
            this.FIOColumn.Name = "FIOColumn";
            this.FIOColumn.ReadOnly = true;
            this.FIOColumn.Width = 59;
            // 
            // SexColumn
            // 
            this.SexColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SexColumn.DataPropertyName = "Gender";
            this.SexColumn.HeaderText = "Пол";
            this.SexColumn.Name = "SexColumn";
            this.SexColumn.ReadOnly = true;
            // 
            // BirthDateColumn
            // 
            this.BirthDateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BirthDateColumn.DataPropertyName = "BirthDate";
            this.BirthDateColumn.HeaderText = "Дата рождения";
            this.BirthDateColumn.Name = "BirthDateColumn";
            this.BirthDateColumn.ReadOnly = true;
            // 
            // EducationFormColumn
            // 
            this.EducationFormColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EducationFormColumn.DataPropertyName = "EducationForm";
            this.EducationFormColumn.HeaderText = "Форма обучения";
            this.EducationFormColumn.Name = "EducationFormColumn";
            this.EducationFormColumn.ReadOnly = true;
            // 
            // MathExamsColumn
            // 
            this.MathExamsColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MathExamsColumn.DataPropertyName = "MathExams";
            this.MathExamsColumn.HeaderText = "ЕГЭ по математике";
            this.MathExamsColumn.Name = "MathExamsColumn";
            this.MathExamsColumn.ReadOnly = true;
            // 
            // RussianExamsColumn
            // 
            this.RussianExamsColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RussianExamsColumn.DataPropertyName = "RussianExams";
            this.RussianExamsColumn.HeaderText = "ЕГЭ по русскому языку";
            this.RussianExamsColumn.Name = "RussianExamsColumn";
            this.RussianExamsColumn.ReadOnly = true;
            // 
            // ITExamsColumn
            // 
            this.ITExamsColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ITExamsColumn.DataPropertyName = "ITExams";
            this.ITExamsColumn.HeaderText = "ЕГЭ по информатике";
            this.ITExamsColumn.Name = "ITExamsColumn";
            this.ITExamsColumn.ReadOnly = true;
            // 
            // SumExamsColumn
            // 
            this.SumExamsColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SumExamsColumn.HeaderText = "Сумма баллов";
            this.SumExamsColumn.Name = "SumExamsColumn";
            this.SumExamsColumn.ReadOnly = true;
            // 
            // menuStripHeader
            // 
            this.menuStripHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStripHeader.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileItem,
            this.editItem,
            this.adminPanelToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStripHeader.Location = new System.Drawing.Point(0, 0);
            this.menuStripHeader.Name = "menuStripHeader";
            this.menuStripHeader.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStripHeader.Size = new System.Drawing.Size(844, 24);
            this.menuStripHeader.TabIndex = 1;
            // 
            // fileItem
            // 
            this.fileItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem,
            this.toolStripSeparator2,
            this.toolStripMenuItem_Close});
            this.fileItem.Name = "fileItem";
            this.fileItem.Size = new System.Drawing.Size(48, 20);
            this.fileItem.Text = "Файл";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Image = global::DataGridView_Adm_Com.Properties.Resources.excel;
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.exportToolStripMenuItem.Text = "Экспорт";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(117, 6);
            // 
            // toolStripMenuItem_Close
            // 
            this.toolStripMenuItem_Close.Name = "toolStripMenuItem_Close";
            this.toolStripMenuItem_Close.Size = new System.Drawing.Size(120, 22);
            this.toolStripMenuItem_Close.Text = "Закрыть";
            this.toolStripMenuItem_Close.Click += new System.EventHandler(this.toolStripMenuItem_Close_Click);
            // 
            // editItem
            // 
            this.editItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_Add,
            this.toolStripSeparator3,
            this.toolStripMenuItem_Edit,
            this.toolStripSeparator4,
            this.toolStripMenuItem_Delete,
            this.toolStripSeparator7,
            this.changePassGradeToolStripMenuItem});
            this.editItem.Name = "editItem";
            this.editItem.Size = new System.Drawing.Size(59, 20);
            this.editItem.Text = "Правка";
            // 
            // toolStripMenuItem_Add
            // 
            this.toolStripMenuItem_Add.Name = "toolStripMenuItem_Add";
            this.toolStripMenuItem_Add.Size = new System.Drawing.Size(222, 22);
            this.toolStripMenuItem_Add.Text = "Добавить";
            this.toolStripMenuItem_Add.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(219, 6);
            // 
            // toolStripMenuItem_Edit
            // 
            this.toolStripMenuItem_Edit.Enabled = false;
            this.toolStripMenuItem_Edit.Name = "toolStripMenuItem_Edit";
            this.toolStripMenuItem_Edit.Size = new System.Drawing.Size(222, 22);
            this.toolStripMenuItem_Edit.Text = "Изменить";
            this.toolStripMenuItem_Edit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(219, 6);
            // 
            // toolStripMenuItem_Delete
            // 
            this.toolStripMenuItem_Delete.Enabled = false;
            this.toolStripMenuItem_Delete.Name = "toolStripMenuItem_Delete";
            this.toolStripMenuItem_Delete.Size = new System.Drawing.Size(222, 22);
            this.toolStripMenuItem_Delete.Text = "Удалить";
            this.toolStripMenuItem_Delete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(219, 6);
            // 
            // changePassGradeToolStripMenuItem
            // 
            this.changePassGradeToolStripMenuItem.Name = "changePassGradeToolStripMenuItem";
            this.changePassGradeToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.changePassGradeToolStripMenuItem.Text = "Изменить проходной балл";
            this.changePassGradeToolStripMenuItem.Click += new System.EventHandler(this.changePassGradeToolStripMenuItem_Click);
            // 
            // adminPanelToolStripMenuItem
            // 
            this.adminPanelToolStripMenuItem.Enabled = false;
            this.adminPanelToolStripMenuItem.Name = "adminPanelToolStripMenuItem";
            this.adminPanelToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.adminPanelToolStripMenuItem.Text = "Админ-панель";
            this.adminPanelToolStripMenuItem.Visible = false;
            this.adminPanelToolStripMenuItem.Click += new System.EventHandler(this.adminPanelToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showInfoToolStripMenuItem,
            this.aboutToolStripMenuItem1});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.infoToolStripMenuItem.Text = "Справка";
            // 
            // showInfoToolStripMenuItem
            // 
            this.showInfoToolStripMenuItem.Image = global::DataGridView_Adm_Com.Properties.Resources.info;
            this.showInfoToolStripMenuItem.Name = "showInfoToolStripMenuItem";
            this.showInfoToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.showInfoToolStripMenuItem.Text = "Просмотр справки";
            this.showInfoToolStripMenuItem.Click += new System.EventHandler(this.showInfoToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Image = global::DataGridView_Adm_Com.Properties.Resources.logo_college;
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(179, 22);
            this.aboutToolStripMenuItem1.Text = "О программе";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // statusStripInfo
            // 
            this.statusStripInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelAmountEntrant,
            this.labelAmountPassGrade});
            this.statusStripInfo.Location = new System.Drawing.Point(0, 428);
            this.statusStripInfo.Name = "statusStripInfo";
            this.statusStripInfo.Size = new System.Drawing.Size(844, 22);
            this.statusStripInfo.SizingGrip = false;
            this.statusStripInfo.TabIndex = 2;
            // 
            // labelAmountEntrant
            // 
            this.labelAmountEntrant.Name = "labelAmountEntrant";
            this.labelAmountEntrant.Size = new System.Drawing.Size(157, 17);
            this.labelAmountEntrant.Text = "Количество абитуриентов: ";
            // 
            // labelAmountPassGrade
            // 
            this.labelAmountPassGrade.Name = "labelAmountPassGrade";
            this.labelAmountPassGrade.Size = new System.Drawing.Size(317, 17);
            this.labelAmountPassGrade.Text = "Количество абитуриентов с проходным баллом (>150): ";
            // 
            // buttonAdd
            // 
            this.buttonAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(63, 24);
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonEdit.Enabled = false;
            this.buttonEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(65, 24);
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonDelete.Enabled = false;
            this.buttonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(55, 24);
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 27);
            // 
            // buttonSort
            // 
            this.buttonSort.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonSort.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonAlphabetSort,
            this.toolStripSeparator5,
            this.buttonMarkSort});
            this.buttonSort.Enabled = false;
            this.buttonSort.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonSort.Size = new System.Drawing.Size(103, 24);
            this.buttonSort.Text = "Отсортировать";
            this.buttonSort.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.buttonSort_DropDownItemClicked);
            // 
            // buttonAlphabetSort
            // 
            this.buttonAlphabetSort.Image = global::DataGridView_Adm_Com.Properties.Resources.sort_alphabetical_variant_icon;
            this.buttonAlphabetSort.Name = "buttonAlphabetSort";
            this.buttonAlphabetSort.Size = new System.Drawing.Size(172, 22);
            this.buttonAlphabetSort.Text = "По алфавиту";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(169, 6);
            // 
            // buttonMarkSort
            // 
            this.buttonMarkSort.Image = global::DataGridView_Adm_Com.Properties.Resources.Tifinagh_Letter_Yi_svg;
            this.buttonMarkSort.Name = "buttonMarkSort";
            this.buttonMarkSort.Size = new System.Drawing.Size(172, 22);
            this.buttonMarkSort.Text = "По сумме баллов";
            // 
            // toolStripControl
            // 
            this.toolStripControl.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolStripControl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonAdd,
            this.buttonEdit,
            this.buttonDelete,
            this.toolStripSeparator6,
            this.buttonSort,
            this.searchToolStripButton,
            this.searchToolStripTextBox,
            this.toolStripSeparator1,
            this.filterToolStripButton,
            this.filterToolStripTextBox});
            this.toolStripControl.Location = new System.Drawing.Point(0, 24);
            this.toolStripControl.Name = "toolStripControl";
            this.toolStripControl.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStripControl.Size = new System.Drawing.Size(844, 27);
            this.toolStripControl.TabIndex = 3;
            // 
            // searchToolStripButton
            // 
            this.searchToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.searchToolStripButton.Enabled = false;
            this.searchToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("searchToolStripButton.Image")));
            this.searchToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.searchToolStripButton.Name = "searchToolStripButton";
            this.searchToolStripButton.Size = new System.Drawing.Size(46, 24);
            this.searchToolStripButton.Text = "Поиск";
            this.searchToolStripButton.ToolTipText = "Поиск";
            this.searchToolStripButton.Click += new System.EventHandler(this.searchToolStripButton_Click);
            // 
            // searchToolStripTextBox
            // 
            this.searchToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchToolStripTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchToolStripTextBox.Name = "searchToolStripTextBox";
            this.searchToolStripTextBox.Size = new System.Drawing.Size(150, 23);
            this.searchToolStripTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchToolStripTextBox_KeyPress);
            this.searchToolStripTextBox.TextChanged += new System.EventHandler(this.searchToolStripTextBox_TextChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // filterToolStripButton
            // 
            this.filterToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.filterToolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.genderToolStripMenuItem,
            this.educationFormToolStripMenuItem,
            this.ageToolStripMenuItem,
            this.sumExamsToolStripMenuItem,
            this.выToolStripMenuItem,
            this.clearFilterToolStripMenuItem});
            this.filterToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("filterToolStripButton.Image")));
            this.filterToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.filterToolStripButton.Name = "filterToolStripButton";
            this.filterToolStripButton.Size = new System.Drawing.Size(61, 24);
            this.filterToolStripButton.Text = "Фильтр";
            this.filterToolStripButton.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.filterToolStripButton_DropDownItemClicked);
            // 
            // genderToolStripMenuItem
            // 
            this.genderToolStripMenuItem.Image = global::DataGridView_Adm_Com.Properties.Resources.male_gender_symbol;
            this.genderToolStripMenuItem.Name = "genderToolStripMenuItem";
            this.genderToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.genderToolStripMenuItem.Text = "Пол";
            // 
            // educationFormToolStripMenuItem
            // 
            this.educationFormToolStripMenuItem.Name = "educationFormToolStripMenuItem";
            this.educationFormToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.educationFormToolStripMenuItem.Text = "Форма обучения (очная)";
            // 
            // ageToolStripMenuItem
            // 
            this.ageToolStripMenuItem.Enabled = false;
            this.ageToolStripMenuItem.Image = global::DataGridView_Adm_Com.Properties.Resources.great_or_equal_symbol;
            this.ageToolStripMenuItem.Name = "ageToolStripMenuItem";
            this.ageToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.ageToolStripMenuItem.Text = "Возраст";
            // 
            // sumExamsToolStripMenuItem
            // 
            this.sumExamsToolStripMenuItem.Enabled = false;
            this.sumExamsToolStripMenuItem.Image = global::DataGridView_Adm_Com.Properties.Resources.great_or_equal_symbol;
            this.sumExamsToolStripMenuItem.Name = "sumExamsToolStripMenuItem";
            this.sumExamsToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.sumExamsToolStripMenuItem.Text = "Сумма баллов";
            // 
            // выToolStripMenuItem
            // 
            this.выToolStripMenuItem.Name = "выToolStripMenuItem";
            this.выToolStripMenuItem.Size = new System.Drawing.Size(209, 6);
            // 
            // clearFilterToolStripMenuItem
            // 
            this.clearFilterToolStripMenuItem.Enabled = false;
            this.clearFilterToolStripMenuItem.Name = "clearFilterToolStripMenuItem";
            this.clearFilterToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.clearFilterToolStripMenuItem.Text = "Сброс";
            // 
            // filterToolStripTextBox
            // 
            this.filterToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.filterToolStripTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.filterToolStripTextBox.Name = "filterToolStripTextBox";
            this.filterToolStripTextBox.Size = new System.Drawing.Size(100, 23);
            this.filterToolStripTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.filterToolStripTextBox_KeyPress);
            this.filterToolStripTextBox.TextChanged += new System.EventHandler(this.filterToolStripTextBox_TextChanged);
            // 
            // helpProvider
            // 
            this.helpProvider.HelpNamespace = "C:\\Users\\Darnion\\source\\Adm_Com_EFCore\\Resources\\info.txt";
            // 
            // AdmissionCommiteeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 450);
            this.Controls.Add(this.toolStripControl);
            this.Controls.Add(this.statusStripInfo);
            this.Controls.Add(this.dataGridView_Adm_Com);
            this.Controls.Add(this.menuStripHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripHeader;
            this.MaximizeBox = false;
            this.Name = "AdmissionCommiteeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Приемная комиссия";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdmissionCommiteeForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Adm_Com)).EndInit();
            this.menuStripHeader.ResumeLayout(false);
            this.menuStripHeader.PerformLayout();
            this.statusStripInfo.ResumeLayout(false);
            this.statusStripInfo.PerformLayout();
            this.toolStripControl.ResumeLayout(false);
            this.toolStripControl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Adm_Com;
        private System.Windows.Forms.MenuStrip menuStripHeader;
        private System.Windows.Forms.StatusStrip statusStripInfo;
        private System.Windows.Forms.ToolStripMenuItem fileItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Close;
        private System.Windows.Forms.ToolStripMenuItem editItem;
        private System.Windows.Forms.ToolStripStatusLabel labelAmountEntrant;
        private System.Windows.Forms.ToolStripStatusLabel labelAmountPassGrade;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Add;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Edit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Delete;
        private System.Windows.Forms.ToolStripButton buttonAdd;
        private System.Windows.Forms.ToolStripButton buttonEdit;
        private System.Windows.Forms.ToolStripButton buttonDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripDropDownButton buttonSort;
        private System.Windows.Forms.ToolStripMenuItem buttonAlphabetSort;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem buttonMarkSort;
        private System.Windows.Forms.ToolStrip toolStripControl;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        public System.Windows.Forms.ToolStripMenuItem adminPanelToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton searchToolStripButton;
        private System.Windows.Forms.ToolStripTextBox searchToolStripTextBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox filterToolStripTextBox;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem changePassGradeToolStripMenuItem;
        private System.Windows.Forms.HelpProvider helpProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIOColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SexColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EducationFormColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MathExamsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RussianExamsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITExamsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SumExamsColumn;
        private System.Windows.Forms.ToolStripDropDownButton filterToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem genderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem educationFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sumExamsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator выToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearFilterToolStripMenuItem;
    }
}

