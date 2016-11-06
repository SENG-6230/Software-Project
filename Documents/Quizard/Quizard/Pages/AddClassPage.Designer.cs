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
            this.headCbx = new System.Windows.Forms.ComboBox();
            this.teacherCbx = new System.Windows.Forms.ComboBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.assistantsLbl = new System.Windows.Forms.Label();
            this.assistantsBx = new System.Windows.Forms.CheckedListBox();
            this.studentsLbl = new System.Windows.Forms.Label();
            this.studentsBx = new System.Windows.Forms.CheckedListBox();
            this.numberValBx = new System.Windows.Forms.TextBox();
            this.numberLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameBx
            // 
            this.nameBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBx.Location = new System.Drawing.Point(376, 36);
            this.nameBx.Margin = new System.Windows.Forms.Padding(6);
            this.nameBx.Name = "nameBx";
            this.nameBx.Size = new System.Drawing.Size(312, 41);
            this.nameBx.TabIndex = 15;
            this.nameBx.Text = "Software Engineering";
            // 
            // userNameLbl
            // 
            this.userNameLbl.AutoSize = true;
            this.userNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLbl.Location = new System.Drawing.Point(44, 42);
            this.userNameLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.userNameLbl.Name = "userNameLbl";
            this.userNameLbl.Size = new System.Drawing.Size(100, 36);
            this.userNameLbl.TabIndex = 14;
            this.userNameLbl.Text = "Name:";
            // 
            // teacherLbl
            // 
            this.teacherLbl.AutoSize = true;
            this.teacherLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherLbl.Location = new System.Drawing.Point(44, 104);
            this.teacherLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.teacherLbl.Name = "teacherLbl";
            this.teacherLbl.Size = new System.Drawing.Size(131, 36);
            this.teacherLbl.TabIndex = 20;
            this.teacherLbl.Text = "Teacher:";
            // 
            // departmentLbl
            // 
            this.departmentLbl.AutoSize = true;
            this.departmentLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentLbl.Location = new System.Drawing.Point(44, 160);
            this.departmentLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.departmentLbl.Name = "departmentLbl";
            this.departmentLbl.Size = new System.Drawing.Size(253, 36);
            this.departmentLbl.TabIndex = 18;
            this.departmentLbl.Text = "Department Head:";
            // 
            // headCbx
            // 
            this.headCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.headCbx.FormattingEnabled = true;
            this.headCbx.Location = new System.Drawing.Point(376, 160);
            this.headCbx.Margin = new System.Windows.Forms.Padding(6);
            this.headCbx.Name = "headCbx";
            this.headCbx.Size = new System.Drawing.Size(312, 33);
            this.headCbx.TabIndex = 19;
            // 
            // teacherCbx
            // 
            this.teacherCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.teacherCbx.FormattingEnabled = true;
            this.teacherCbx.Items.AddRange(new object[] {
            "Vilkomir, Sergiy"});
            this.teacherCbx.Location = new System.Drawing.Point(376, 104);
            this.teacherCbx.Margin = new System.Windows.Forms.Padding(6);
            this.teacherCbx.Name = "teacherCbx";
            this.teacherCbx.Size = new System.Drawing.Size(312, 33);
            this.teacherCbx.TabIndex = 21;
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(32, 624);
            this.addBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(188, 64);
            this.addBtn.TabIndex = 22;
            this.addBtn.Text = "Add Class";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Location = new System.Drawing.Point(250, 624);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(188, 64);
            this.cancelBtn.TabIndex = 23;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // assistantsLbl
            // 
            this.assistantsLbl.AutoSize = true;
            this.assistantsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assistantsLbl.Location = new System.Drawing.Point(552, 280);
            this.assistantsLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.assistantsLbl.Name = "assistantsLbl";
            this.assistantsLbl.Size = new System.Drawing.Size(160, 72);
            this.assistantsLbl.TabIndex = 27;
            this.assistantsLbl.Text = "Teaching\r\n Assistants";
            this.assistantsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // assistantsBx
            // 
            this.assistantsBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assistantsBx.FormattingEnabled = true;
            this.assistantsBx.Items.AddRange(new object[] {
            "Swetha Mahendrakar"});
            this.assistantsBx.Location = new System.Drawing.Point(466, 358);
            this.assistantsBx.Margin = new System.Windows.Forms.Padding(6);
            this.assistantsBx.Name = "assistantsBx";
            this.assistantsBx.Size = new System.Drawing.Size(328, 364);
            this.assistantsBx.TabIndex = 26;
            // 
            // studentsLbl
            // 
            this.studentsLbl.AutoSize = true;
            this.studentsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentsLbl.Location = new System.Drawing.Point(904, 42);
            this.studentsLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.studentsLbl.Name = "studentsLbl";
            this.studentsLbl.Size = new System.Drawing.Size(133, 36);
            this.studentsLbl.TabIndex = 25;
            this.studentsLbl.Text = "Students";
            // 
            // studentsBx
            // 
            this.studentsBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentsBx.FormattingEnabled = true;
            this.studentsBx.Items.AddRange(new object[] {
            "Alan Master",
            "David Anderson",
            "Bigyan Pandit",
            "Mohammed Sarim Akbar",
            "Jonathan Eng"});
            this.studentsBx.Location = new System.Drawing.Point(806, 106);
            this.studentsBx.Margin = new System.Windows.Forms.Padding(6);
            this.studentsBx.Name = "studentsBx";
            this.studentsBx.Size = new System.Drawing.Size(328, 616);
            this.studentsBx.TabIndex = 24;
            // 
            // numberValBx
            // 
            this.numberValBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberValBx.Location = new System.Drawing.Point(207, 228);
            this.numberValBx.Margin = new System.Windows.Forms.Padding(6);
            this.numberValBx.Name = "numberValBx";
            this.numberValBx.Size = new System.Drawing.Size(312, 41);
            this.numberValBx.TabIndex = 29;
            this.numberValBx.Text = "SENG 6230";
            // 
            // numberLbl
            // 
            this.numberLbl.AutoSize = true;
            this.numberLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberLbl.Location = new System.Drawing.Point(44, 228);
            this.numberLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.numberLbl.Name = "numberLbl";
            this.numberLbl.Size = new System.Drawing.Size(128, 36);
            this.numberLbl.TabIndex = 28;
            this.numberLbl.Text = "Number:";
            // 
            // AddClassPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.numberValBx);
            this.Controls.Add(this.numberLbl);
            this.Controls.Add(this.assistantsLbl);
            this.Controls.Add(this.assistantsBx);
            this.Controls.Add(this.studentsLbl);
            this.Controls.Add(this.studentsBx);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.teacherCbx);
            this.Controls.Add(this.teacherLbl);
            this.Controls.Add(this.headCbx);
            this.Controls.Add(this.departmentLbl);
            this.Controls.Add(this.nameBx);
            this.Controls.Add(this.userNameLbl);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(1140, 728);
            this.Name = "AddClassPage";
            this.Size = new System.Drawing.Size(1140, 728);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameBx;
        private System.Windows.Forms.Label userNameLbl;
        private System.Windows.Forms.Label teacherLbl;
        private System.Windows.Forms.Label departmentLbl;
        private System.Windows.Forms.ComboBox headCbx;
        private System.Windows.Forms.ComboBox teacherCbx;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label assistantsLbl;
        private System.Windows.Forms.CheckedListBox assistantsBx;
        private System.Windows.Forms.Label studentsLbl;
        private System.Windows.Forms.CheckedListBox studentsBx;
        private System.Windows.Forms.TextBox numberValBx;
        private System.Windows.Forms.Label numberLbl;
    }
}
