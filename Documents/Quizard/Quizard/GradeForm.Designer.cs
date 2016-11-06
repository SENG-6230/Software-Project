namespace Quizard
{
    partial class GradeForm
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
            this.groupBoxSubmissions = new System.Windows.Forms.GroupBox();
            this.listBoxSubmissions = new System.Windows.Forms.ListBox();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDownload = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBoxSubmissions.SuspendLayout();
            this.groupBoxInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.groupBoxSubmissions);
            this.flowLayoutPanel1.Controls.Add(this.groupBoxInfo);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(434, 310);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // groupBoxSubmissions
            // 
            this.groupBoxSubmissions.Controls.Add(this.listBoxSubmissions);
            this.groupBoxSubmissions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.groupBoxSubmissions.Location = new System.Drawing.Point(3, 3);
            this.groupBoxSubmissions.Name = "groupBoxSubmissions";
            this.groupBoxSubmissions.Size = new System.Drawing.Size(200, 307);
            this.groupBoxSubmissions.TabIndex = 0;
            this.groupBoxSubmissions.TabStop = false;
            this.groupBoxSubmissions.Text = "Submissions";
            // 
            // listBoxSubmissions
            // 
            this.listBoxSubmissions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.listBoxSubmissions.FormattingEnabled = true;
            this.listBoxSubmissions.ItemHeight = 18;
            this.listBoxSubmissions.Location = new System.Drawing.Point(3, 34);
            this.listBoxSubmissions.Name = "listBoxSubmissions";
            this.listBoxSubmissions.Size = new System.Drawing.Size(197, 274);
            this.listBoxSubmissions.TabIndex = 0;
            this.listBoxSubmissions.SelectedIndexChanged += new System.EventHandler(this.listBoxSubmissions_SelectedIndexChanged);
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.btnDownload);
            this.groupBoxInfo.Controls.Add(this.label1);
            this.groupBoxInfo.Controls.Add(this.btnSave);
            this.groupBoxInfo.Controls.Add(this.txtGrade);
            this.groupBoxInfo.Controls.Add(this.lblName);
            this.groupBoxInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.groupBoxInfo.Location = new System.Drawing.Point(209, 3);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(215, 307);
            this.groupBoxInfo.TabIndex = 1;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Submission Info";
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(61, 90);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(148, 24);
            this.txtGrade.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblName.Location = new System.Drawing.Point(6, 34);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(102, 18);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Student Name";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(134, 120);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 28);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Grade";
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(9, 55);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(99, 29);
            this.btnDownload.TabIndex = 1;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // GradeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 322);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "GradeForm";
            this.Text = "Grading Assignment";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBoxSubmissions.ResumeLayout(false);
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBoxSubmissions;
        private System.Windows.Forms.ListBox listBoxSubmissions;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDownload;
    }
}