namespace Quizard
{
    partial class AssignmentForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBoxName = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBoxDueDate = new System.Windows.Forms.GroupBox();
            this.dueDatePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBoxFile = new System.Windows.Forms.GroupBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.lblFile = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            this.groupBoxStudentFile = new System.Windows.Forms.GroupBox();
            this.lblSubmission = new System.Windows.Forms.Label();
            this.btnStudentDownload = new System.Windows.Forms.Button();
            this.btnStudentUpload = new System.Windows.Forms.Button();
            this.groupBoxGrades = new System.Windows.Forms.GroupBox();
            this.btnGrade = new System.Windows.Forms.Button();
            this.lblMyGrade = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBoxName.SuspendLayout();
            this.groupBoxDueDate.SuspendLayout();
            this.groupBoxFile.SuspendLayout();
            this.groupBoxStudentFile.SuspendLayout();
            this.groupBoxGrades.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.groupBoxName);
            this.flowLayoutPanel1.Controls.Add(this.groupBoxDueDate);
            this.flowLayoutPanel1.Controls.Add(this.groupBoxFile);
            this.flowLayoutPanel1.Controls.Add(this.groupBoxStudentFile);
            this.flowLayoutPanel1.Controls.Add(this.groupBoxGrades);
            this.flowLayoutPanel1.Controls.Add(this.btnSave);
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(25, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(548, 394);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // groupBoxName
            // 
            this.groupBoxName.Controls.Add(this.txtName);
            this.groupBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.groupBoxName.Location = new System.Drawing.Point(3, 3);
            this.groupBoxName.Name = "groupBoxName";
            this.groupBoxName.Size = new System.Drawing.Size(252, 95);
            this.groupBoxName.TabIndex = 0;
            this.groupBoxName.TabStop = false;
            this.groupBoxName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(3, 23);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(243, 24);
            this.txtName.TabIndex = 0;
            // 
            // groupBoxDueDate
            // 
            this.groupBoxDueDate.Controls.Add(this.dueDatePicker);
            this.groupBoxDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.groupBoxDueDate.Location = new System.Drawing.Point(261, 3);
            this.groupBoxDueDate.Name = "groupBoxDueDate";
            this.groupBoxDueDate.Size = new System.Drawing.Size(283, 95);
            this.groupBoxDueDate.TabIndex = 1;
            this.groupBoxDueDate.TabStop = false;
            this.groupBoxDueDate.Text = "Due Date";
            // 
            // dueDatePicker
            // 
            this.dueDatePicker.Location = new System.Drawing.Point(6, 23);
            this.dueDatePicker.Name = "dueDatePicker";
            this.dueDatePicker.Size = new System.Drawing.Size(271, 24);
            this.dueDatePicker.TabIndex = 0;
            // 
            // groupBoxFile
            // 
            this.groupBoxFile.Controls.Add(this.btnDownload);
            this.groupBoxFile.Controls.Add(this.lblFile);
            this.groupBoxFile.Controls.Add(this.btnUpload);
            this.groupBoxFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.groupBoxFile.Location = new System.Drawing.Point(3, 104);
            this.groupBoxFile.Name = "groupBoxFile";
            this.groupBoxFile.Size = new System.Drawing.Size(252, 95);
            this.groupBoxFile.TabIndex = 2;
            this.groupBoxFile.TabStop = false;
            this.groupBoxFile.Text = "Assignment File";
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(87, 22);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(91, 28);
            this.btnDownload.TabIndex = 4;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(6, 53);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(0, 18);
            this.lblFile.TabIndex = 0;
            // 
            // btnUpload
            // 
            this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnUpload.Location = new System.Drawing.Point(6, 23);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 27);
            this.btnUpload.TabIndex = 3;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // groupBoxStudentFile
            // 
            this.groupBoxStudentFile.Controls.Add(this.lblSubmission);
            this.groupBoxStudentFile.Controls.Add(this.btnStudentDownload);
            this.groupBoxStudentFile.Controls.Add(this.btnStudentUpload);
            this.groupBoxStudentFile.Location = new System.Drawing.Point(261, 104);
            this.groupBoxStudentFile.Name = "groupBoxStudentFile";
            this.groupBoxStudentFile.Size = new System.Drawing.Size(283, 95);
            this.groupBoxStudentFile.TabIndex = 4;
            this.groupBoxStudentFile.TabStop = false;
            this.groupBoxStudentFile.Text = "Student Submitted File";
            // 
            // lblSubmission
            // 
            this.lblSubmission.AutoSize = true;
            this.lblSubmission.Location = new System.Drawing.Point(6, 53);
            this.lblSubmission.Name = "lblSubmission";
            this.lblSubmission.Size = new System.Drawing.Size(0, 18);
            this.lblSubmission.TabIndex = 6;
            // 
            // btnStudentDownload
            // 
            this.btnStudentDownload.Location = new System.Drawing.Point(84, 20);
            this.btnStudentDownload.Name = "btnStudentDownload";
            this.btnStudentDownload.Size = new System.Drawing.Size(91, 30);
            this.btnStudentDownload.TabIndex = 5;
            this.btnStudentDownload.Text = "Download";
            this.btnStudentDownload.UseVisualStyleBackColor = true;
            this.btnStudentDownload.Click += new System.EventHandler(this.btnStudentDownload_Click);
            // 
            // btnStudentUpload
            // 
            this.btnStudentUpload.Location = new System.Drawing.Point(3, 20);
            this.btnStudentUpload.Name = "btnStudentUpload";
            this.btnStudentUpload.Size = new System.Drawing.Size(75, 30);
            this.btnStudentUpload.TabIndex = 0;
            this.btnStudentUpload.Text = "Upload";
            this.btnStudentUpload.UseVisualStyleBackColor = true;
            this.btnStudentUpload.Click += new System.EventHandler(this.btnStudentUpload_Click);
            // 
            // groupBoxGrades
            // 
            this.groupBoxGrades.Controls.Add(this.btnGrade);
            this.groupBoxGrades.Controls.Add(this.lblMyGrade);
            this.groupBoxGrades.Location = new System.Drawing.Point(3, 205);
            this.groupBoxGrades.Name = "groupBoxGrades";
            this.groupBoxGrades.Size = new System.Drawing.Size(252, 100);
            this.groupBoxGrades.TabIndex = 5;
            this.groupBoxGrades.TabStop = false;
            this.groupBoxGrades.Text = "Grades";
            // 
            // btnGrade
            // 
            this.btnGrade.Location = new System.Drawing.Point(6, 23);
            this.btnGrade.Name = "btnGrade";
            this.btnGrade.Size = new System.Drawing.Size(172, 26);
            this.btnGrade.TabIndex = 0;
            this.btnGrade.Text = "Grade Submissions";
            this.btnGrade.UseVisualStyleBackColor = true;
            this.btnGrade.Click += new System.EventHandler(this.btnGrade_Click);
            // 
            // lblMyGrade
            // 
            this.lblMyGrade.AutoSize = true;
            this.lblMyGrade.Location = new System.Drawing.Point(6, 52);
            this.lblMyGrade.Name = "lblMyGrade";
            this.lblMyGrade.Size = new System.Drawing.Size(0, 18);
            this.lblMyGrade.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnSave.Location = new System.Drawing.Point(261, 205);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(78, 27);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AssignmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 432);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "AssignmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add An Assignment";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBoxName.ResumeLayout(false);
            this.groupBoxName.PerformLayout();
            this.groupBoxDueDate.ResumeLayout(false);
            this.groupBoxFile.ResumeLayout(false);
            this.groupBoxFile.PerformLayout();
            this.groupBoxStudentFile.ResumeLayout(false);
            this.groupBoxStudentFile.PerformLayout();
            this.groupBoxGrades.ResumeLayout(false);
            this.groupBoxGrades.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBoxName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox groupBoxDueDate;
        private System.Windows.Forms.DateTimePicker dueDatePicker;
        private System.Windows.Forms.GroupBox groupBoxFile;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBoxStudentFile;
        private System.Windows.Forms.Button btnStudentUpload;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnStudentDownload;
        private System.Windows.Forms.Label lblSubmission;
        private System.Windows.Forms.GroupBox groupBoxGrades;
        private System.Windows.Forms.Button btnGrade;
        private System.Windows.Forms.Label lblMyGrade;
    }
}