namespace Quizard.Pages
{
    partial class UsersPage
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Vilkomir, Sergiy");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Eng, Jonathan");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Akbar, Mohammed Sarim");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Pandit, Bigyan");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Anderson, David Michael");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Master, Alan");
            this.label1 = new System.Windows.Forms.Label();
            this.usersBx = new System.Windows.Forms.TreeView();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.addUserBtn = new System.Windows.Forms.Button();
            this.classInfoPanel = new System.Windows.Forms.Panel();
            this.createBtn = new System.Windows.Forms.Button();
            this.roleCbx = new System.Windows.Forms.ComboBox();
            this.emailBx = new System.Windows.Forms.TextBox();
            this.passwordBx = new System.Windows.Forms.TextBox();
            this.nameBx = new System.Windows.Forms.TextBox();
            this.roleLbl = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.userNameLbl = new System.Windows.Forms.Label();
            this.userMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.classInfoPanel.SuspendLayout();
            this.userMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(640, 288);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Users";
            // 
            // usersBx
            // 
            this.usersBx.ContextMenuStrip = this.userMenuStrip;
            this.usersBx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usersBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersBx.Location = new System.Drawing.Point(0, 88);
            this.usersBx.Margin = new System.Windows.Forms.Padding(6);
            this.usersBx.Name = "usersBx";
            treeNode1.Name = "Node0";
            treeNode1.Text = "Vilkomir, Sergiy";
            treeNode2.Name = "Node1";
            treeNode2.Text = "Eng, Jonathan";
            treeNode3.Name = "Node2";
            treeNode3.Text = "Akbar, Mohammed Sarim";
            treeNode4.Name = "Node3";
            treeNode4.Text = "Pandit, Bigyan";
            treeNode5.Name = "Node4";
            treeNode5.Text = "Anderson, David Michael";
            treeNode6.Name = "Node5";
            treeNode6.Text = "Master, Alan";
            this.usersBx.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
            this.usersBx.Size = new System.Drawing.Size(250, 652);
            this.usersBx.TabIndex = 0;
            this.usersBx.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.usersBx_NodeMouseClick);
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Margin = new System.Windows.Forms.Padding(6);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.usersBx);
            this.splitContainer.Panel1.Controls.Add(this.addUserBtn);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.AutoScroll = true;
            this.splitContainer.Panel2.Controls.Add(this.classInfoPanel);
            this.splitContainer.Size = new System.Drawing.Size(1460, 740);
            this.splitContainer.SplitterDistance = 250;
            this.splitContainer.SplitterWidth = 8;
            this.splitContainer.TabIndex = 1;
            // 
            // addUserBtn
            // 
            this.addUserBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.addUserBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUserBtn.Location = new System.Drawing.Point(0, 0);
            this.addUserBtn.Margin = new System.Windows.Forms.Padding(6);
            this.addUserBtn.Name = "addUserBtn";
            this.addUserBtn.Size = new System.Drawing.Size(250, 88);
            this.addUserBtn.TabIndex = 1;
            this.addUserBtn.Text = "Add User";
            this.addUserBtn.UseVisualStyleBackColor = true;
            // 
            // classInfoPanel
            // 
            this.classInfoPanel.Controls.Add(this.createBtn);
            this.classInfoPanel.Controls.Add(this.roleCbx);
            this.classInfoPanel.Controls.Add(this.emailBx);
            this.classInfoPanel.Controls.Add(this.passwordBx);
            this.classInfoPanel.Controls.Add(this.nameBx);
            this.classInfoPanel.Controls.Add(this.roleLbl);
            this.classInfoPanel.Controls.Add(this.passwordLbl);
            this.classInfoPanel.Controls.Add(this.emailLbl);
            this.classInfoPanel.Controls.Add(this.userNameLbl);
            this.classInfoPanel.Location = new System.Drawing.Point(6, 8);
            this.classInfoPanel.Margin = new System.Windows.Forms.Padding(6);
            this.classInfoPanel.Name = "classInfoPanel";
            this.classInfoPanel.Size = new System.Drawing.Size(940, 726);
            this.classInfoPanel.TabIndex = 0;
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(775, 653);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(136, 53);
            this.createBtn.TabIndex = 18;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // roleCbx
            // 
            this.roleCbx.FormattingEnabled = true;
            this.roleCbx.Items.AddRange(new object[] {
            "Administrator",
            "Department Head",
            "Teacher",
            "Teacher assistant",
            "Student"});
            this.roleCbx.Location = new System.Drawing.Point(384, 234);
            this.roleCbx.Margin = new System.Windows.Forms.Padding(6);
            this.roleCbx.Name = "roleCbx";
            this.roleCbx.Size = new System.Drawing.Size(312, 33);
            this.roleCbx.TabIndex = 17;
            // 
            // emailBx
            // 
            this.emailBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailBx.Location = new System.Drawing.Point(384, 108);
            this.emailBx.Margin = new System.Windows.Forms.Padding(6);
            this.emailBx.Name = "emailBx";
            this.emailBx.Size = new System.Drawing.Size(312, 41);
            this.emailBx.TabIndex = 16;
            this.emailBx.Text = "VILKOMIRS@ecu.edu";
            // 
            // passwordBx
            // 
            this.passwordBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBx.Location = new System.Drawing.Point(384, 178);
            this.passwordBx.Margin = new System.Windows.Forms.Padding(6);
            this.passwordBx.Name = "passwordBx";
            this.passwordBx.Size = new System.Drawing.Size(312, 41);
            this.passwordBx.TabIndex = 15;
            this.passwordBx.Text = "password";
            // 
            // nameBx
            // 
            this.nameBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBx.Location = new System.Drawing.Point(384, 44);
            this.nameBx.Margin = new System.Windows.Forms.Padding(6);
            this.nameBx.Name = "nameBx";
            this.nameBx.Size = new System.Drawing.Size(312, 41);
            this.nameBx.TabIndex = 13;
            this.nameBx.Text = "Vilkomir, Sergiy";
            // 
            // roleLbl
            // 
            this.roleLbl.AutoSize = true;
            this.roleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleLbl.Location = new System.Drawing.Point(52, 250);
            this.roleLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.roleLbl.Name = "roleLbl";
            this.roleLbl.Size = new System.Drawing.Size(85, 36);
            this.roleLbl.TabIndex = 12;
            this.roleLbl.Text = "Role:";
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLbl.Location = new System.Drawing.Point(52, 184);
            this.passwordLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(155, 36);
            this.passwordLbl.TabIndex = 11;
            this.passwordLbl.Text = "Password:";
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLbl.Location = new System.Drawing.Point(52, 114);
            this.emailLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(96, 36);
            this.emailLbl.TabIndex = 10;
            this.emailLbl.Text = "Email:";
            // 
            // userNameLbl
            // 
            this.userNameLbl.AutoSize = true;
            this.userNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLbl.Location = new System.Drawing.Point(52, 50);
            this.userNameLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.userNameLbl.Name = "userNameLbl";
            this.userNameLbl.Size = new System.Drawing.Size(100, 36);
            this.userNameLbl.TabIndex = 9;
            this.userNameLbl.Text = "Name:";
            // 
            // userMenuStrip
            // 
            this.userMenuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.userMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.userMenuStrip.Name = "userMenuStrip";
            this.userMenuStrip.Size = new System.Drawing.Size(270, 86);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(269, 38);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // UsersPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(1460, 740);
            this.Name = "UsersPage";
            this.Size = new System.Drawing.Size(1460, 740);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.classInfoPanel.ResumeLayout(false);
            this.classInfoPanel.PerformLayout();
            this.userMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView usersBx;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Panel classInfoPanel;
        private System.Windows.Forms.Button addUserBtn;
        private System.Windows.Forms.ComboBox roleCbx;
        private System.Windows.Forms.TextBox emailBx;
        private System.Windows.Forms.TextBox passwordBx;
        private System.Windows.Forms.TextBox nameBx;
        private System.Windows.Forms.Label roleLbl;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label userNameLbl;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.ContextMenuStrip userMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    }
}
