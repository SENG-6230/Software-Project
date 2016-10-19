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
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Vilkomir, Sergiy");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Eng, Jonathan");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Akbar, Mohammed Sarim");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Pandit, Bigyan");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Anderson, David Michael");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Master, Alan");
            this.label1 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.classInfoPanel = new System.Windows.Forms.Panel();
            this.roleLbl = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.userNameLbl = new System.Windows.Forms.Label();
            this.nameBx = new System.Windows.Forms.TextBox();
            this.passwordBx = new System.Windows.Forms.TextBox();
            this.emailBx = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.addUserBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.classInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(320, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Users";
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.Location = new System.Drawing.Point(0, 44);
            this.treeView1.Name = "treeView1";
            treeNode13.Name = "Node0";
            treeNode13.Text = "Vilkomir, Sergiy";
            treeNode14.Name = "Node1";
            treeNode14.Text = "Eng, Jonathan";
            treeNode15.Name = "Node2";
            treeNode15.Text = "Akbar, Mohammed Sarim";
            treeNode16.Name = "Node3";
            treeNode16.Text = "Pandit, Bigyan";
            treeNode17.Name = "Node4";
            treeNode17.Text = "Anderson, David Michael";
            treeNode18.Name = "Node5";
            treeNode18.Text = "Master, Alan";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18});
            this.treeView1.Size = new System.Drawing.Size(250, 326);
            this.treeView1.TabIndex = 0;
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
            this.splitContainer.Panel1.Controls.Add(this.addUserBtn);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.AutoScroll = true;
            this.splitContainer.Panel2.Controls.Add(this.classInfoPanel);
            this.splitContainer.Size = new System.Drawing.Size(730, 370);
            this.splitContainer.SplitterDistance = 250;
            this.splitContainer.TabIndex = 1;
            // 
            // classInfoPanel
            // 
            this.classInfoPanel.Controls.Add(this.comboBox1);
            this.classInfoPanel.Controls.Add(this.emailBx);
            this.classInfoPanel.Controls.Add(this.passwordBx);
            this.classInfoPanel.Controls.Add(this.nameBx);
            this.classInfoPanel.Controls.Add(this.roleLbl);
            this.classInfoPanel.Controls.Add(this.passwordLbl);
            this.classInfoPanel.Controls.Add(this.emailLbl);
            this.classInfoPanel.Controls.Add(this.userNameLbl);
            this.classInfoPanel.Location = new System.Drawing.Point(3, 4);
            this.classInfoPanel.Name = "classInfoPanel";
            this.classInfoPanel.Size = new System.Drawing.Size(470, 363);
            this.classInfoPanel.TabIndex = 0;
            // 
            // roleLbl
            // 
            this.roleLbl.AutoSize = true;
            this.roleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleLbl.Location = new System.Drawing.Point(26, 125);
            this.roleLbl.Name = "roleLbl";
            this.roleLbl.Size = new System.Drawing.Size(43, 18);
            this.roleLbl.TabIndex = 12;
            this.roleLbl.Text = "Role:";
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLbl.Location = new System.Drawing.Point(26, 92);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(79, 18);
            this.passwordLbl.TabIndex = 11;
            this.passwordLbl.Text = "Password:";
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLbl.Location = new System.Drawing.Point(26, 57);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(49, 18);
            this.emailLbl.TabIndex = 10;
            this.emailLbl.Text = "Email:";
            // 
            // userNameLbl
            // 
            this.userNameLbl.AutoSize = true;
            this.userNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLbl.Location = new System.Drawing.Point(26, 25);
            this.userNameLbl.Name = "userNameLbl";
            this.userNameLbl.Size = new System.Drawing.Size(52, 18);
            this.userNameLbl.TabIndex = 9;
            this.userNameLbl.Text = "Name:";
            // 
            // nameBx
            // 
            this.nameBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBx.Location = new System.Drawing.Point(192, 22);
            this.nameBx.Name = "nameBx";
            this.nameBx.Size = new System.Drawing.Size(158, 24);
            this.nameBx.TabIndex = 13;
            this.nameBx.Text = "Vilkomir, Sergiy";
            // 
            // passwordBx
            // 
            this.passwordBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBx.Location = new System.Drawing.Point(192, 89);
            this.passwordBx.Name = "passwordBx";
            this.passwordBx.Size = new System.Drawing.Size(158, 24);
            this.passwordBx.TabIndex = 15;
            this.passwordBx.Text = "password";
            // 
            // emailBx
            // 
            this.emailBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailBx.Location = new System.Drawing.Point(192, 54);
            this.emailBx.Name = "emailBx";
            this.emailBx.Size = new System.Drawing.Size(158, 24);
            this.emailBx.TabIndex = 16;
            this.emailBx.Text = "VILKOMIRS@ecu.edu";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Administrator",
            "Department Head",
            "Teacher",
            "Teacher assistant",
            "Student"});
            this.comboBox1.Location = new System.Drawing.Point(192, 117);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(158, 33);
            this.comboBox1.TabIndex = 17;
            // 
            // addUserBtn
            // 
            this.addUserBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.addUserBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUserBtn.Location = new System.Drawing.Point(0, 0);
            this.addUserBtn.Name = "addUserBtn";
            this.addUserBtn.Size = new System.Drawing.Size(250, 44);
            this.addUserBtn.TabIndex = 1;
            this.addUserBtn.Text = "Add User";
            this.addUserBtn.UseVisualStyleBackColor = true;
            // 
            // UsersPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(730, 370);
            this.Name = "UsersPage";
            this.Size = new System.Drawing.Size(730, 370);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.classInfoPanel.ResumeLayout(false);
            this.classInfoPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Panel classInfoPanel;
        private System.Windows.Forms.Button addUserBtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox emailBx;
        private System.Windows.Forms.TextBox passwordBx;
        private System.Windows.Forms.TextBox nameBx;
        private System.Windows.Forms.Label roleLbl;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label userNameLbl;
    }
}
