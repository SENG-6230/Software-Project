namespace Quizard.Pages
{
    partial class AddClassPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameBx = new System.Windows.Forms.TextBox();
            this.userNameLbl = new System.Windows.Forms.Label();
            this.teacherLbl = new System.Windows.Forms.Label();
            this.departmentLbl = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.assistantsLbl = new System.Windows.Forms.Label();
            this.assistantsBx = new System.Windows.Forms.ListBox();
            this.studentsLbl = new System.Windows.Forms.Label();
            this.studentsBx = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // nameBx
            // 
            this.nameBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBx.Location = new System.Drawing.Point(188, 18);
            this.nameBx.Name = "nameBx";
            this.nameBx.Size = new System.Drawing.Size(158, 24);
            this.nameBx.TabIndex = 15;
            this.nameBx.Text = "SENG 6230";
            // 
            // userNameLbl
            // 
            this.userNameLbl.AutoSize = true;
            this.userNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLbl.Location = new System.Drawing.Point(22, 21);
            this.userNameLbl.Name = "userNameLbl";
            this.userNameLbl.Size = new System.Drawing.Size(52, 18);
            this.userNameLbl.TabIndex = 14;
            this.userNameLbl.Text = "Name:";
            // 
            // teacherLbl
            // 
            this.teacherLbl.AutoSize = true;
            this.teacherLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherLbl.Location = new System.Drawing.Point(22, 52);
            this.teacherLbl.Name = "teacherLbl";
            this.teacherLbl.Size = new System.Drawing.Size(66, 18);
            this.teacherLbl.TabIndex = 20;
            this.teacherLbl.Text = "Teacher:";
            // 
            // departmentLbl
            // 
            this.departmentLbl.AutoSize = true;
            this.departmentLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentLbl.Location = new System.Drawing.Point(22, 80);
            this.departmentLbl.Name = "departmentLbl";
            this.departmentLbl.Size = new System.Drawing.Size(128, 18);
            this.departmentLbl.TabIndex = 18;
            this.departmentLbl.Text = "Department Head:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(188, 80);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(158, 21);
            this.comboBox1.TabIndex = 19;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Vilkomir, Sergiy"});
            this.comboBox2.Location = new System.Drawing.Point(188, 52);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(158, 21);
            this.comboBox2.TabIndex = 21;
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(16, 312);
            this.addBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(94, 32);
            this.addBtn.TabIndex = 22;
            this.addBtn.Text = "Add Class";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Location = new System.Drawing.Point(125, 312);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(94, 32);
            this.cancelBtn.TabIndex = 23;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // assistantsLbl
            // 
            this.assistantsLbl.AutoSize = true;
            this.assistantsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assistantsLbl.Location = new System.Drawing.Point(272, 114);
            this.assistantsLbl.Name = "assistantsLbl";
            this.assistantsLbl.Size = new System.Drawing.Size(80, 36);
            this.assistantsLbl.TabIndex = 27;
            this.assistantsLbl.Text = "Teaching\r\n Assistants";
            this.assistantsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // assistantsBx
            // 
            this.assistantsBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assistantsBx.FormattingEnabled = true;
            this.assistantsBx.ItemHeight = 18;
            this.assistantsBx.Items.AddRange(new object[] {
            "Swetha Mahendrakar"});
            this.assistantsBx.Location = new System.Drawing.Point(224, 162);
            this.assistantsBx.Name = "assistantsBx";
            this.assistantsBx.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.assistantsBx.Size = new System.Drawing.Size(166, 184);
            this.assistantsBx.TabIndex = 26;
            // 
            // studentsLbl
            // 
            this.studentsLbl.AutoSize = true;
            this.studentsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentsLbl.Location = new System.Drawing.Point(452, 21);
            this.studentsLbl.Name = "studentsLbl";
            this.studentsLbl.Size = new System.Drawing.Size(66, 18);
            this.studentsLbl.TabIndex = 25;
            this.studentsLbl.Text = "Students";
            // 
            // studentsBx
            // 
            this.studentsBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentsBx.FormattingEnabled = true;
            this.studentsBx.ItemHeight = 18;
            this.studentsBx.Items.AddRange(new object[] {
            "Alan Master",
            "David Anderson",
            "Bigyan Pandit",
            "Mohammed Sarim Akbar",
            "Jonathan Eng"});
            this.studentsBx.Location = new System.Drawing.Point(403, 53);
            this.studentsBx.Name = "studentsBx";
            this.studentsBx.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.studentsBx.Size = new System.Drawing.Size(166, 310);
            this.studentsBx.TabIndex = 24;
          //  this.studentsBx.SelectedIndexChanged += new System.EventHandler(this.studentsBx_SelectedIndexChanged);
            // 
            // AddClassPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.assistantsLbl);
            this.Controls.Add(this.assistantsBx);
            this.Controls.Add(this.studentsLbl);
            this.Controls.Add(this.studentsBx);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.teacherLbl);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.departmentLbl);
            this.Controls.Add(this.nameBx);
            this.Controls.Add(this.userNameLbl);
            this.MinimumSize = new System.Drawing.Size(570, 364);
            this.Name = "AddClassPage";
            this.Size = new System.Drawing.Size(570, 364);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameBx;
        private System.Windows.Forms.Label userNameLbl;
        private System.Windows.Forms.Label teacherLbl;
        private System.Windows.Forms.Label departmentLbl;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label assistantsLbl;
        private System.Windows.Forms.ListBox assistantsBx;
        private System.Windows.Forms.Label studentsLbl;
        private System.Windows.Forms.ListBox studentsBx;
    }
}
