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
            this.lblFile = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBoxName.SuspendLayout();
            this.groupBoxDueDate.SuspendLayout();
            this.groupBoxFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.groupBoxName);
            this.flowLayoutPanel1.Controls.Add(this.groupBoxDueDate);
            this.flowLayoutPanel1.Controls.Add(this.groupBoxFile);
            this.flowLayoutPanel1.Controls.Add(this.btnSave);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(25, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(563, 394);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // groupBoxName
            // 
            this.groupBoxName.Controls.Add(this.txtName);
            this.groupBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.groupBoxName.Location = new System.Drawing.Point(3, 3);
            this.groupBoxName.Name = "groupBoxName";
            this.groupBoxName.Size = new System.Drawing.Size(115, 95);
            this.groupBoxName.TabIndex = 0;
            this.groupBoxName.TabStop = false;
            this.groupBoxName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(3, 23);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 24);
            this.txtName.TabIndex = 0;
            // 
            // groupBoxDueDate
            // 
            this.groupBoxDueDate.Controls.Add(this.dueDatePicker);
            this.groupBoxDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.groupBoxDueDate.Location = new System.Drawing.Point(124, 3);
            this.groupBoxDueDate.Name = "groupBoxDueDate";
            this.groupBoxDueDate.Size = new System.Drawing.Size(215, 95);
            this.groupBoxDueDate.TabIndex = 1;
            this.groupBoxDueDate.TabStop = false;
            this.groupBoxDueDate.Text = "Due Date";
            // 
            // dueDatePicker
            // 
            this.dueDatePicker.Location = new System.Drawing.Point(6, 23);
            this.dueDatePicker.Name = "dueDatePicker";
            this.dueDatePicker.Size = new System.Drawing.Size(200, 24);
            this.dueDatePicker.TabIndex = 0;
            // 
            // groupBoxFile
            // 
            this.groupBoxFile.Controls.Add(this.lblFile);
            this.groupBoxFile.Controls.Add(this.btnUpload);
            this.groupBoxFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.groupBoxFile.Location = new System.Drawing.Point(345, 3);
            this.groupBoxFile.Name = "groupBoxFile";
            this.groupBoxFile.Size = new System.Drawing.Size(200, 95);
            this.groupBoxFile.TabIndex = 2;
            this.groupBoxFile.TabStop = false;
            this.groupBoxFile.Text = "Assignment File";
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(6, 29);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(95, 18);
            this.lblFile.TabIndex = 0;
            this.lblFile.Text = "Upload A File";
            // 
            // btnUpload
            // 
            this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnUpload.Location = new System.Drawing.Point(119, 24);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 27);
            this.btnUpload.TabIndex = 3;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnSave.Location = new System.Drawing.Point(3, 104);
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
            this.ClientSize = new System.Drawing.Size(618, 432);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "AssignmentForm";
            this.Text = "AssignmentForm";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBoxName.ResumeLayout(false);
            this.groupBoxName.PerformLayout();
            this.groupBoxDueDate.ResumeLayout(false);
            this.groupBoxFile.ResumeLayout(false);
            this.groupBoxFile.PerformLayout();
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
    }
}