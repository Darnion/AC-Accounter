using System;
using System.Windows.Forms;

namespace DataGridView_Adm_Com
{
    public partial class ChangePassGradeForm : Form
    {
        public ChangePassGradeForm()
        {
            InitializeComponent();
        }

        private void textBoxPassGrade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxPassGrade_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPassGrade.Text != "")
            {
                buttonOk.Enabled = true;
                if (int.Parse(textBoxPassGrade.Text) > 300)
                {
                    textBoxPassGrade.Text = "300";
                }
            }
            else
            {
                buttonOk.Enabled = false;
            }
        }
    }
}
