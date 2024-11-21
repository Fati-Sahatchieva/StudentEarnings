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
    public partial class MainForm : Form
    {
        static List<string> students = new List<string>();
        static List<string> earnings = new List<string>();

        BindingSource studentsBindingSource = new BindingSource();
        BindingSource earningsBindingSource = new BindingSource();

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnStudentForm_Click(object sender, EventArgs e)
        {
            StudentForm sf = new StudentForm();

            sf.ShowDialog();
        }

        internal void receiveEarningsData(string totalEarnings)
        {
            earnings.Add(" " + totalEarnings + " лв");
        }

        internal void receiveData(string studentData)
        {
            students.Add(studentData);
        }

        private void btnEarningsForm_Click(object sender, EventArgs e)
        {
            EarningsForm ef = new EarningsForm();

            ef.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            studentsBindingSource.DataSource = students;
            earningsBindingSource.DataSource = earnings;

            lbStudent.DataSource = studentsBindingSource;
            lbEarnings.DataSource = earningsBindingSource;
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            studentsBindingSource.ResetBindings(false);
            earningsBindingSource.ResetBindings(false);
        }

        private void lbStudent_Click(object sender, EventArgs e)
        {
            int i = lbStudent.SelectedIndex;
            int j = lbEarnings.SelectedIndex;
            if (i >= 0)
            {
               DialogResult result = MessageBox.Show("Желаете ли да изтриете студента " + students[i] + " ?", "Потвърдете изтриването",
                    MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    students.RemoveAt(i);
                    studentsBindingSource.ResetBindings(false);
                    if (i == j)
                    {
                        earnings.RemoveAt(j);
                        earningsBindingSource.ResetBindings(false);
                    }
                    
                }
            }
        }

        private void lbEarnings_Click(object sender, EventArgs e)
        {
            int y = lbEarnings.SelectedIndex;
            if (y >= 0)
            {
                DialogResult result = MessageBox.Show($"Желаете ли да изтриете доход {y + 1} ?", "Потвърдете изтриването",
                     MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    earnings.RemoveAt(y);
                    earningsBindingSource.ResetBindings(false);
                }
            }
        }

    }
}
