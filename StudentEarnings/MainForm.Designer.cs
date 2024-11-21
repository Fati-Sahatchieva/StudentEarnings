
namespace StudentEarnings
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnStudentForm = new System.Windows.Forms.Button();
            this.lbStudent = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEarningsForm = new System.Windows.Forms.Button();
            this.lbEarnings = new System.Windows.Forms.ListBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BackgroundImage = global::StudentEarnings.Properties.Resources.back1;
            this.panel2.Controls.Add(this.btnStudentForm);
            this.panel2.Controls.Add(this.lbStudent);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnEarningsForm);
            this.panel2.Controls.Add(this.lbEarnings);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(723, 424);
            this.panel2.TabIndex = 7;
            // 
            // btnStudentForm
            // 
            this.btnStudentForm.BackColor = System.Drawing.Color.SteelBlue;
            this.btnStudentForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStudentForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStudentForm.Location = new System.Drawing.Point(108, 322);
            this.btnStudentForm.Margin = new System.Windows.Forms.Padding(2);
            this.btnStudentForm.Name = "btnStudentForm";
            this.btnStudentForm.Size = new System.Drawing.Size(269, 60);
            this.btnStudentForm.TabIndex = 2;
            this.btnStudentForm.Text = "Въведи данни на студент";
            this.btnStudentForm.UseVisualStyleBackColor = false;
            this.btnStudentForm.Click += new System.EventHandler(this.btnStudentForm_Click);
            // 
            // lbStudent
            // 
            this.lbStudent.AllowDrop = true;
            this.lbStudent.BackColor = System.Drawing.SystemColors.Window;
            this.lbStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbStudent.FormattingEnabled = true;
            this.lbStudent.ItemHeight = 20;
            this.lbStudent.Location = new System.Drawing.Point(53, 139);
            this.lbStudent.Margin = new System.Windows.Forms.Padding(2);
            this.lbStudent.Name = "lbStudent";
            this.lbStudent.Size = new System.Drawing.Size(372, 164);
            this.lbStudent.TabIndex = 0;
            this.lbStudent.Click += new System.EventHandler(this.lbStudent_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(49, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Студент:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(32, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(335, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "Доходи на студентите";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(454, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Месечен Общ Доход:";
            // 
            // btnEarningsForm
            // 
            this.btnEarningsForm.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEarningsForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEarningsForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEarningsForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEarningsForm.Location = new System.Drawing.Point(469, 322);
            this.btnEarningsForm.Margin = new System.Windows.Forms.Padding(2);
            this.btnEarningsForm.Name = "btnEarningsForm";
            this.btnEarningsForm.Size = new System.Drawing.Size(178, 60);
            this.btnEarningsForm.TabIndex = 3;
            this.btnEarningsForm.Text = "Въведи доход на студента";
            this.btnEarningsForm.UseVisualStyleBackColor = false;
            this.btnEarningsForm.Click += new System.EventHandler(this.btnEarningsForm_Click);
            // 
            // lbEarnings
            // 
            this.lbEarnings.BackColor = System.Drawing.SystemColors.Window;
            this.lbEarnings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbEarnings.FormattingEnabled = true;
            this.lbEarnings.ItemHeight = 20;
            this.lbEarnings.Location = new System.Drawing.Point(458, 139);
            this.lbEarnings.Margin = new System.Windows.Forms.Padding(2);
            this.lbEarnings.Name = "lbEarnings";
            this.lbEarnings.Size = new System.Drawing.Size(200, 164);
            this.lbEarnings.TabIndex = 1;
            this.lbEarnings.Click += new System.EventHandler(this.lbEarnings_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(723, 424);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Доходи на студентите";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbEarnings;
        private System.Windows.Forms.Button btnEarningsForm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbStudent;
        private System.Windows.Forms.Button btnStudentForm;
        private System.Windows.Forms.Panel panel2;
    }
}

