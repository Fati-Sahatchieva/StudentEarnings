using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentEarnings
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

       
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            double outFNo;
            
            if (tbFirstName.Text.Trim() == "")
            {
                MessageBox.Show("Невалидно Име!", "Грешка!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbFirstName.Focus();
                tbFirstName.Text = string.Empty;
            }
            else if (tbLastName.Text.Trim() == "")
            {
                MessageBox.Show("Невалидна Фамилия!", "Грешка!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbLastName.Focus();
                tbLastName.Text = string.Empty;
            }
            else if (tbFNo.Text.Trim() == "" || !double.TryParse(tbFNo.Text.Trim(), out outFNo) || 
                tbFNo.Text.Trim().Length > 10 || tbFNo.Text.Trim().Length < 10)
            {
                MessageBox.Show("Невалиден Фак.№!", "Грешка!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbFNo.Focus();
            }
            else
            {
                string studentData = " " + tbFirstName.Text.Trim() + " " + tbLastName.Text.Trim() + "   Фак.№ " + tbFNo.Text.Trim();
                mf.receiveData(studentData);

                this.Close();
            }

        }

        private void tbFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnOK_Click(sender, e);
            }
        }

        private void tbLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnOK_Click(sender, e);
            }
        }

        private void tbFNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnOK_Click(sender, e);
            }
        }

    }
}
