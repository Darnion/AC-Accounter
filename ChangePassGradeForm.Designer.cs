namespace DataGridView_Adm_Com
{
    partial class ChangePassGradeForm
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
            this.labelPassGrade = new System.Windows.Forms.Label();
            this.textBoxPassGrade = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPassGrade
            // 
            this.labelPassGrade.AutoSize = true;
            this.labelPassGrade.Location = new System.Drawing.Point(40, 29);
            this.labelPassGrade.Name = "labelPassGrade";
            this.labelPassGrade.Size = new System.Drawing.Size(92, 13);
            this.labelPassGrade.TabIndex = 0;
            this.labelPassGrade.Text = "Проходной балл:";
            // 
            // textBoxPassGrade
            // 
            this.textBoxPassGrade.Location = new System.Drawing.Point(138, 25);
            this.textBoxPassGrade.MaxLength = 3;
            this.textBoxPassGrade.Name = "textBoxPassGrade";
            this.textBoxPassGrade.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassGrade.TabIndex = 1;
            this.textBoxPassGrade.TextChanged += new System.EventHandler(this.textBoxPassGrade_TextChanged);
            this.textBoxPassGrade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPassGrade_KeyPress);
            // 
            // buttonOk
            // 
            this.buttonOk.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Enabled = false;
            this.buttonOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOk.Location = new System.Drawing.Point(102, 86);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 2;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = false;
            // 
            // ChangePassGradeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(279, 135);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBoxPassGrade);
            this.Controls.Add(this.labelPassGrade);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ChangePassGradeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Установите проходной балл";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPassGrade;
        private System.Windows.Forms.Button buttonOk;
        public System.Windows.Forms.TextBox textBoxPassGrade;
    }
}