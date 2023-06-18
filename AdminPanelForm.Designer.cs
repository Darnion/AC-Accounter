namespace DataGridView_Adm_Com
{
    partial class AdminPanelForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanelForm));
            this.toolStripControl = new System.Windows.Forms.ToolStrip();
            this.buttonAdd = new System.Windows.Forms.ToolStripButton();
            this.buttonEdit = new System.Windows.Forms.ToolStripButton();
            this.buttonDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonSort = new System.Windows.Forms.ToolStripDropDownButton();
            this.buttonPrivilegeSort = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sortClearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.filterToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.dataGridView_Users = new System.Windows.Forms.DataGridView();
            this.LoginColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PasswordColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrivilegeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filterToolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.privilegeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.clearFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Users)).BeginInit();
            this.SuspendLayout();
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
            this.toolStripSeparator1,
            this.filterToolStripButton,
            this.filterToolStripTextBox});
            this.toolStripControl.Location = new System.Drawing.Point(0, 0);
            this.toolStripControl.Name = "toolStripControl";
            this.toolStripControl.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStripControl.Size = new System.Drawing.Size(506, 27);
            this.toolStripControl.TabIndex = 4;
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
            this.buttonPrivilegeSort,
            this.toolStripSeparator2,
            this.sortClearToolStripMenuItem});
            this.buttonSort.Enabled = false;
            this.buttonSort.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonSort.Size = new System.Drawing.Size(103, 24);
            this.buttonSort.Text = "Отсортировать";
            // 
            // buttonPrivilegeSort
            // 
            this.buttonPrivilegeSort.Name = "buttonPrivilegeSort";
            this.buttonPrivilegeSort.Size = new System.Drawing.Size(159, 22);
            this.buttonPrivilegeSort.Text = "По привилегии";
            this.buttonPrivilegeSort.Click += new System.EventHandler(this.buttonPrivilegeSort_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(156, 6);
            // 
            // sortClearToolStripMenuItem
            // 
            this.sortClearToolStripMenuItem.Name = "sortClearToolStripMenuItem";
            this.sortClearToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.sortClearToolStripMenuItem.Text = "Сброс";
            this.sortClearToolStripMenuItem.Click += new System.EventHandler(this.sortClearToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // filterToolStripTextBox
            // 
            this.filterToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.filterToolStripTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.filterToolStripTextBox.Name = "filterToolStripTextBox";
            this.filterToolStripTextBox.Size = new System.Drawing.Size(130, 23);
            this.filterToolStripTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.filterToolStripTextBox_KeyPress);
            this.filterToolStripTextBox.TextChanged += new System.EventHandler(this.filterToolStripTextBox_TextChanged);
            // 
            // dataGridView_Users
            // 
            this.dataGridView_Users.AllowUserToAddRows = false;
            this.dataGridView_Users.AllowUserToDeleteRows = false;
            this.dataGridView_Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Users.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LoginColumn,
            this.PasswordColumn,
            this.PrivilegeColumn});
            this.dataGridView_Users.Location = new System.Drawing.Point(0, 30);
            this.dataGridView_Users.Name = "dataGridView_Users";
            this.dataGridView_Users.ReadOnly = true;
            this.dataGridView_Users.Size = new System.Drawing.Size(506, 300);
            this.dataGridView_Users.TabIndex = 5;
            this.dataGridView_Users.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView_Users_CellFormatting);
            this.dataGridView_Users.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView_Users_DataBindingComplete);
            this.dataGridView_Users.SelectionChanged += new System.EventHandler(this.dataGridView_Users_SelectionChanged);
            // 
            // LoginColumn
            // 
            this.LoginColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LoginColumn.DataPropertyName = "Login";
            this.LoginColumn.HeaderText = "Логин";
            this.LoginColumn.Name = "LoginColumn";
            this.LoginColumn.ReadOnly = true;
            // 
            // PasswordColumn
            // 
            this.PasswordColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PasswordColumn.DataPropertyName = "Password";
            this.PasswordColumn.HeaderText = "Пароль";
            this.PasswordColumn.Name = "PasswordColumn";
            this.PasswordColumn.ReadOnly = true;
            // 
            // PrivilegeColumn
            // 
            this.PrivilegeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PrivilegeColumn.DataPropertyName = "Privilege";
            this.PrivilegeColumn.HeaderText = "Привилегия";
            this.PrivilegeColumn.Name = "PrivilegeColumn";
            this.PrivilegeColumn.ReadOnly = true;
            // 
            // filterToolStripButton
            // 
            this.filterToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.filterToolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.privilegeToolStripMenuItem,
            this.выToolStripMenuItem,
            this.clearFilterToolStripMenuItem});
            this.filterToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("filterToolStripButton.Image")));
            this.filterToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.filterToolStripButton.Name = "filterToolStripButton";
            this.filterToolStripButton.Size = new System.Drawing.Size(55, 24);
            this.filterToolStripButton.Text = "Поиск";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Enabled = false;
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loginToolStripMenuItem.Text = "Логин";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // privilegeToolStripMenuItem
            // 
            this.privilegeToolStripMenuItem.Name = "privilegeToolStripMenuItem";
            this.privilegeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.privilegeToolStripMenuItem.Text = "Привилегия";
            this.privilegeToolStripMenuItem.Click += new System.EventHandler(this.privilegeToolStripMenuItem_Click);
            // 
            // выToolStripMenuItem
            // 
            this.выToolStripMenuItem.Name = "выToolStripMenuItem";
            this.выToolStripMenuItem.Size = new System.Drawing.Size(177, 6);
            // 
            // clearFilterToolStripMenuItem
            // 
            this.clearFilterToolStripMenuItem.Name = "clearFilterToolStripMenuItem";
            this.clearFilterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clearFilterToolStripMenuItem.Text = "Сброс";
            this.clearFilterToolStripMenuItem.Click += new System.EventHandler(this.clearFilterToolStripMenuItem_Click);
            // 
            // AdminPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 330);
            this.Controls.Add(this.dataGridView_Users);
            this.Controls.Add(this.toolStripControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdminPanelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Админ-панель";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminPanelForm_FormClosed);
            this.toolStripControl.ResumeLayout(false);
            this.toolStripControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Users)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripControl;
        private System.Windows.Forms.ToolStripButton buttonAdd;
        private System.Windows.Forms.ToolStripButton buttonEdit;
        private System.Windows.Forms.ToolStripButton buttonDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripDropDownButton buttonSort;
        private System.Windows.Forms.ToolStripMenuItem buttonPrivilegeSort;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox filterToolStripTextBox;
        private System.Windows.Forms.DataGridView dataGridView_Users;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoginColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PasswordColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrivilegeColumn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem sortClearToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton filterToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem privilegeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator выToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearFilterToolStripMenuItem;
    }
}