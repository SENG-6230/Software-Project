namespace Quizard.Pages
{
    partial class ClassesPage
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("CSCI 6230");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("SENG 6000");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("CSCI 6540");
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.addClassBtn = new System.Windows.Forms.Button();
            this.classInfoPanel = new System.Windows.Forms.Panel();
            this.quizGradeValLbl = new System.Windows.Forms.Label();
            this.quizGradelbl = new System.Windows.Forms.Label();
            this.addAssignmentBtn = new System.Windows.Forms.Button();
            this.assistantsLbl = new System.Windows.Forms.Label();
            this.assistantsBx = new System.Windows.Forms.ListBox();
            this.studentsLbl = new System.Windows.Forms.Label();
            this.studentsBx = new System.Windows.Forms.ListBox();
            this.gradeValLbl = new System.Windows.Forms.Label();
            this.attendanceLbl = new System.Windows.Forms.Label();
            this.attendanceValLbl = new System.Windows.Forms.Label();
            this.gradeLbl = new System.Windows.Forms.Label();
            this.assignmentsLbl = new System.Windows.Forms.Label();
            this.assignmentsBx = new System.Windows.Forms.ListBox();
            this.assignmentStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.downloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teacherValueLbl = new System.Windows.Forms.Label();
            this.teacherNameLbl = new System.Windows.Forms.Label();
            this.classNameValueLbl = new System.Windows.Forms.Label();
            this.classNameLbl = new System.Windows.Forms.Label();
            this.addClassPage = new Quizard.Pages.AddClassPage();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.classInfoPanel.SuspendLayout();
            this.assignmentStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.treeView1);
            this.splitContainer.Panel1.Controls.Add(this.addClassBtn);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.AutoScroll = true;
            this.splitContainer.Panel2.Controls.Add(this.classInfoPanel);
            this.splitContainer.Panel2.Controls.Add(this.addClassPage);
            this.splitContainer.Size = new System.Drawing.Size(730, 370);
            this.splitContainer.SplitterDistance = 150;
            this.splitContainer.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.Location = new System.Drawing.Point(0, 44);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Class1";
            treeNode1.Text = "CSCI 6230";
            treeNode2.Name = "class 2";
            treeNode2.Text = "SENG 6000";
            treeNode3.Name = "Class3";
            treeNode3.Text = "CSCI 6540";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            this.treeView1.Size = new System.Drawing.Size(150, 326);
            this.treeView1.TabIndex = 0;
            // 
            // addClassBtn
            // 
            this.addClassBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.addClassBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addClassBtn.Location = new System.Drawing.Point(0, 0);
            this.addClassBtn.Name = "addClassBtn";
            this.addClassBtn.Size = new System.Drawing.Size(150, 44);
            this.addClassBtn.TabIndex = 2;
            this.addClassBtn.Text = "Add Class";
            this.addClassBtn.UseVisualStyleBackColor = true;
            this.addClassBtn.Click += new System.EventHandler(this.addClassBtn_Click);
            // 
            // classInfoPanel
            // 
            this.classInfoPanel.Controls.Add(this.quizGradeValLbl);
            this.classInfoPanel.Controls.Add(this.quizGradelbl);
            this.classInfoPanel.Controls.Add(this.addAssignmentBtn);
            this.classInfoPanel.Controls.Add(this.assistantsLbl);
            this.classInfoPanel.Controls.Add(this.assistantsBx);
            this.classInfoPanel.Controls.Add(this.studentsLbl);
            this.classInfoPanel.Controls.Add(this.studentsBx);
            this.classInfoPanel.Controls.Add(this.gradeValLbl);
            this.classInfoPanel.Controls.Add(this.attendanceLbl);
            this.classInfoPanel.Controls.Add(this.attendanceValLbl);
            this.classInfoPanel.Controls.Add(this.gradeLbl);
            this.classInfoPanel.Controls.Add(this.assignmentsLbl);
            this.classInfoPanel.Controls.Add(this.assignmentsBx);
            this.classInfoPanel.Controls.Add(this.teacherValueLbl);
            this.classInfoPanel.Controls.Add(this.teacherNameLbl);
            this.classInfoPanel.Controls.Add(this.classNameValueLbl);
            this.classInfoPanel.Controls.Add(this.classNameLbl);
            this.classInfoPanel.Location = new System.Drawing.Point(3, 3);
            this.classInfoPanel.Name = "classInfoPanel";
            this.classInfoPanel.Size = new System.Drawing.Size(570, 364);
            this.classInfoPanel.TabIndex = 0;
            // 
            // quizGradeValLbl
            // 
            this.quizGradeValLbl.AutoSize = true;
            this.quizGradeValLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quizGradeValLbl.Location = new System.Drawing.Point(512, 298);
            this.quizGradeValLbl.Name = "quizGradeValLbl";
            this.quizGradeValLbl.Size = new System.Drawing.Size(45, 18);
            this.quizGradeValLbl.TabIndex = 17;
            this.quizGradeValLbl.Text = "100%";
            // 
            // quizGradelbl
            // 
            this.quizGradelbl.AutoSize = true;
            this.quizGradelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quizGradelbl.Location = new System.Drawing.Point(401, 298);
            this.quizGradelbl.Name = "quizGradelbl";
            this.quizGradelbl.Size = new System.Drawing.Size(88, 18);
            this.quizGradelbl.TabIndex = 16;
            this.quizGradelbl.Text = "Quiz Grade:";
            // 
            // addAssignmentBtn
            // 
            this.addAssignmentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAssignmentBtn.Location = new System.Drawing.Point(414, 319);
            this.addAssignmentBtn.Name = "addAssignmentBtn";
            this.addAssignmentBtn.Size = new System.Drawing.Size(135, 29);
            this.addAssignmentBtn.TabIndex = 15;
            this.addAssignmentBtn.Text = "Add Assignment";
            this.addAssignmentBtn.UseVisualStyleBackColor = true;
            this.addAssignmentBtn.Click += new System.EventHandler(this.addAssignmentBtn_Click);
            // 
            // assistantsLbl
            // 
            this.assistantsLbl.AutoSize = true;
            this.assistantsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assistantsLbl.Location = new System.Drawing.Point(52, 150);
            this.assistantsLbl.Name = "assistantsLbl";
            this.assistantsLbl.Size = new System.Drawing.Size(80, 36);
            this.assistantsLbl.TabIndex = 14;
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
            this.assistantsBx.Location = new System.Drawing.Point(12, 189);
            this.assistantsBx.Name = "assistantsBx";
            this.assistantsBx.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.assistantsBx.Size = new System.Drawing.Size(166, 166);
            this.assistantsBx.TabIndex = 13;
            // 
            // studentsLbl
            // 
            this.studentsLbl.AutoSize = true;
            this.studentsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentsLbl.Location = new System.Drawing.Point(243, 96);
            this.studentsLbl.Name = "studentsLbl";
            this.studentsLbl.Size = new System.Drawing.Size(66, 18);
            this.studentsLbl.TabIndex = 12;
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
            this.studentsBx.Location = new System.Drawing.Point(202, 117);
            this.studentsBx.Name = "studentsBx";
            this.studentsBx.Size = new System.Drawing.Size(166, 238);
            this.studentsBx.TabIndex = 11;
            // 
            // gradeValLbl
            // 
            this.gradeValLbl.AutoSize = true;
            this.gradeValLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradeValLbl.Location = new System.Drawing.Point(120, 80);
            this.gradeValLbl.Name = "gradeValLbl";
            this.gradeValLbl.Size = new System.Drawing.Size(37, 18);
            this.gradeValLbl.TabIndex = 10;
            this.gradeValLbl.Text = "88%";
            // 
            // attendanceLbl
            // 
            this.attendanceLbl.AutoSize = true;
            this.attendanceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attendanceLbl.Location = new System.Drawing.Point(20, 110);
            this.attendanceLbl.Name = "attendanceLbl";
            this.attendanceLbl.Size = new System.Drawing.Size(85, 18);
            this.attendanceLbl.TabIndex = 8;
            this.attendanceLbl.Text = "Attendance:";
            // 
            // attendanceValLbl
            // 
            this.attendanceValLbl.AutoSize = true;
            this.attendanceValLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attendanceValLbl.Location = new System.Drawing.Point(120, 110);
            this.attendanceValLbl.Name = "attendanceValLbl";
            this.attendanceValLbl.Size = new System.Drawing.Size(37, 18);
            this.attendanceValLbl.TabIndex = 7;
            this.attendanceValLbl.Text = "95%";
            // 
            // gradeLbl
            // 
            this.gradeLbl.AutoSize = true;
            this.gradeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradeLbl.Location = new System.Drawing.Point(20, 80);
            this.gradeLbl.Name = "gradeLbl";
            this.gradeLbl.Size = new System.Drawing.Size(53, 18);
            this.gradeLbl.TabIndex = 6;
            this.gradeLbl.Text = "Grade:";
            // 
            // assignmentsLbl
            // 
            this.assignmentsLbl.AutoSize = true;
            this.assignmentsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignmentsLbl.Location = new System.Drawing.Point(429, 18);
            this.assignmentsLbl.Name = "assignmentsLbl";
            this.assignmentsLbl.Size = new System.Drawing.Size(93, 18);
            this.assignmentsLbl.TabIndex = 5;
            this.assignmentsLbl.Text = "Assignments";
            // 
            // assignmentsBx
            // 
            this.assignmentsBx.ContextMenuStrip = this.assignmentStrip;
            this.assignmentsBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignmentsBx.FormattingEnabled = true;
            this.assignmentsBx.ItemHeight = 18;
            this.assignmentsBx.Items.AddRange(new object[] {
            "Quiz 1,",
            "Quiz 2,",
            "Quiz 3"});
            this.assignmentsBx.Location = new System.Drawing.Point(395, 39);
            this.assignmentsBx.Name = "assignmentsBx";
            this.assignmentsBx.Size = new System.Drawing.Size(166, 256);
            this.assignmentsBx.TabIndex = 4;
            this.assignmentsBx.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.assignmentsBx_MouseDoubleClick);
            // 
            // assignmentStrip
            // 
            this.assignmentStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.assignmentStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.downloadToolStripMenuItem,
            this.uploadToolStripMenuItem});
            this.assignmentStrip.Name = "assignmentStrip";
            this.assignmentStrip.Size = new System.Drawing.Size(129, 48);
            // 
            // downloadToolStripMenuItem
            // 
            this.downloadToolStripMenuItem.Name = "downloadToolStripMenuItem";
            this.downloadToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.downloadToolStripMenuItem.Text = "Download";
            // 
            // uploadToolStripMenuItem
            // 
            this.uploadToolStripMenuItem.Name = "uploadToolStripMenuItem";
            this.uploadToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.uploadToolStripMenuItem.Text = "Upload";
            // 
            // teacherValueLbl
            // 
            this.teacherValueLbl.AutoSize = true;
            this.teacherValueLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherValueLbl.Location = new System.Drawing.Point(120, 50);
            this.teacherValueLbl.Name = "teacherValueLbl";
            this.teacherValueLbl.Size = new System.Drawing.Size(106, 18);
            this.teacherValueLbl.TabIndex = 3;
            this.teacherValueLbl.Text = "Sergiy Vilkomir";
            // 
            // teacherNameLbl
            // 
            this.teacherNameLbl.AutoSize = true;
            this.teacherNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherNameLbl.Location = new System.Drawing.Point(20, 50);
            this.teacherNameLbl.Name = "teacherNameLbl";
            this.teacherNameLbl.Size = new System.Drawing.Size(70, 18);
            this.teacherNameLbl.TabIndex = 2;
            this.teacherNameLbl.Text = "Teacher: ";
            // 
            // classNameValueLbl
            // 
            this.classNameValueLbl.AutoSize = true;
            this.classNameValueLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classNameValueLbl.Location = new System.Drawing.Point(120, 19);
            this.classNameValueLbl.Name = "classNameValueLbl";
            this.classNameValueLbl.Size = new System.Drawing.Size(79, 18);
            this.classNameValueLbl.TabIndex = 1;
            this.classNameValueLbl.Text = "CSCI 6230";
            // 
            // classNameLbl
            // 
            this.classNameLbl.AutoSize = true;
            this.classNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classNameLbl.Location = new System.Drawing.Point(20, 20);
            this.classNameLbl.Name = "classNameLbl";
            this.classNameLbl.Size = new System.Drawing.Size(91, 18);
            this.classNameLbl.TabIndex = 0;
            this.classNameLbl.Text = "Class name:";
            // 
            // addClassPage
            // 
            this.addClassPage.Location = new System.Drawing.Point(-3, 0);
            this.addClassPage.MinimumSize = new System.Drawing.Size(570, 364);
            this.addClassPage.Name = "addClassPage";
            this.addClassPage.Size = new System.Drawing.Size(570, 364);
            this.addClassPage.TabIndex = 18;
            // 
            // ClassesPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.Controls.Add(this.splitContainer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(730, 370);
            this.Name = "ClassesPage";
            this.Size = new System.Drawing.Size(730, 370);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.classInfoPanel.ResumeLayout(false);
            this.classInfoPanel.PerformLayout();
            this.assignmentStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel classInfoPanel;
        private System.Windows.Forms.Label teacherValueLbl;
        private System.Windows.Forms.Label teacherNameLbl;
        private System.Windows.Forms.Label classNameValueLbl;
        private System.Windows.Forms.Label classNameLbl;
        private System.Windows.Forms.Label assistantsLbl;
        private System.Windows.Forms.ListBox assistantsBx;
        private System.Windows.Forms.Label studentsLbl;
        private System.Windows.Forms.ListBox studentsBx;
        private System.Windows.Forms.Label gradeValLbl;
        private System.Windows.Forms.Label attendanceLbl;
        private System.Windows.Forms.Label attendanceValLbl;
        private System.Windows.Forms.Label gradeLbl;
        private System.Windows.Forms.Label assignmentsLbl;
        private System.Windows.Forms.ListBox assignmentsBx;
        private System.Windows.Forms.Button addAssignmentBtn;
        private System.Windows.Forms.ContextMenuStrip assignmentStrip;
        private System.Windows.Forms.ToolStripMenuItem downloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uploadToolStripMenuItem;
        private System.Windows.Forms.Label quizGradeValLbl;
        private System.Windows.Forms.Label quizGradelbl;
        private System.Windows.Forms.Button addClassBtn;
        private AddClassPage addClassPage;
    }
}
