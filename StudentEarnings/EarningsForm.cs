using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentEarnings
{
    public partial class EarningsForm : Form
    {
        public EarningsForm()
        {
            InitializeComponent();
        }

        double totalEarning = 0;
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            double tbSh;
            double tbE;
            double tbSa;
            try
            {
                totalEarning = 0;

                tbSh = double.Parse(tbSchool.Text.Trim());
                totalEarning += tbSh;
            }
            catch (FormatException)
            {
                MessageBox.Show("Невалиден доход 'Стипендия по успех'", "Грешка!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbSchool.Focus();
                tbSchool.Text = string.Empty;
            }
            try
            {
                tbE = double.Parse(tbEuro.Text.Trim());
                totalEarning += tbE;
            }
            catch (FormatException)
            {
                MessageBox.Show("Невалиден доход 'Европейска стипендия'!", "Грешка!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbEuro.Focus();
                tbEuro.Text = string.Empty;
            }
            try
            {
                tbSa = double.Parse(tbSalary.Text.Trim());
                totalEarning += tbSa;
            }
            catch (FormatException)
            {
                MessageBox.Show("Невалиден доход 'Заплата'!", "Грешка!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbSalary.Focus();
                tbSalary.Text = string.Empty;
            }

            if (tbSchool.Text.Trim() != "" && tbEuro.Text.Trim() != "" && tbSalary.Text.Trim() != "")
            {
                mf.receiveEarningsData(totalEarning.ToString());

                this.Close();
            }

            //if (tbSchool.Text.Trim() == "" || !double.TryParse(tbSchool.Text.Trim(), out tbSh))
            //{
            //    MessageBox.Show("Невалиден доход 'Стиендия по успех!'", "Грешка!",
            //        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    tbSchool.Focus();
            //    tbSchool.Text = string.Empty;
            //}
            //else if (tbEuro.Text.Trim() == "" || !double.TryParse(tbEuro.Text.Trim(), out tbE))
            //{
            //    MessageBox.Show("Невалиден доход 'Европейска стипендия'!", "Грешка!",
            //        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    tbEuro.Focus();
            //    tbEuro.Text = string.Empty;
            //}
            //else if (tbSalary.Text.Trim() == "" || !double.TryParse(tbSalary.Text.Trim(), out tbSa))
            //{
            //    MessageBox.Show("Невалиден доход 'Заплата'!", "Грешка!",
            //        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    tbSalary.Focus();
            //    tbSalary.Text = string.Empty;
            //}
            //else
            //{
            //    tbSh = double.Parse(tbSchool.Text);
            //    tbE = double.Parse(tbEuro.Text);
            //    tbSa = double.Parse(tbSalary.Text);

            //    totalEarning = tbSh + tbE + tbSa;

            //    mf.receiveEarningsData(totalEarning.ToString());

            //    this.Close();
            //}
        }

        private void tbSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnOK_Click(sender, e);
            }
        }

        private void tbEuro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnOK_Click(sender, e);
            }
        }

        private void tbSchool_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnOK_Click(sender, e);
            }
        }

        
    }
}
