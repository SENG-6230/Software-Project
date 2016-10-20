namespace Quizard
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
            this.HomeBtn = new System.Windows.Forms.Button();
            this.ClassesBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.InfoBtn = new System.Windows.Forms.Button();
            this.usersBtn = new System.Windows.Forms.Button();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.pagePnl = new System.Windows.Forms.Panel();
            this.loginPage = new Quizard.Pages.LoginPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1.SuspendLayout();
            this.pagePnl.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // HomeBtn
            // 
            this.HomeBtn.Location = new System.Drawing.Point(20, 20);
            this.HomeBtn.Margin = new System.Windows.Forms.Padding(10);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(220, 80);
            this.HomeBtn.TabIndex = 0;
            this.HomeBtn.Text = "Home";
            this.HomeBtn.UseVisualStyleBackColor = true;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // ClassesBtn
            // 
            this.ClassesBtn.Location = new System.Drawing.Point(260, 20);
            this.ClassesBtn.Margin = new System.Windows.Forms.Padding(10);
            this.ClassesBtn.Name = "ClassesBtn";
            this.ClassesBtn.Size = new System.Drawing.Size(212, 80);
            this.ClassesBtn.TabIndex = 1;
            this.ClassesBtn.Text = "Classes";
            this.ClassesBtn.UseVisualStyleBackColor = true;
            this.ClassesBtn.Click += new System.EventHandler(this.ClassesBtn_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.HomeBtn);
            this.flowLayoutPanel1.Controls.Add(this.ClassesBtn);
            this.flowLayoutPanel1.Controls.Add(this.InfoBtn);
            this.flowLayoutPanel1.Controls.Add(this.usersBtn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 40);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1468, 120);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // InfoBtn
            // 
            this.InfoBtn.Location = new System.Drawing.Point(492, 20);
            this.InfoBtn.Margin = new System.Windows.Forms.Padding(10);
            this.InfoBtn.Name = "InfoBtn";
            this.InfoBtn.Size = new System.Drawing.Size(212, 80);
            this.InfoBtn.TabIndex = 2;
            this.InfoBtn.Text = "Profile";
            this.InfoBtn.UseVisualStyleBackColor = true;
            this.InfoBtn.Click += new System.EventHandler(this.InfoBtn_Click);
            // 
            // usersBtn
            // 
            this.usersBtn.Location = new System.Drawing.Point(724, 20);
            this.usersBtn.Margin = new System.Windows.Forms.Padding(10);
            this.usersBtn.Name = "usersBtn";
            this.usersBtn.Size = new System.Drawing.Size(212, 80);
            this.usersBtn.TabIndex = 3;
            this.usersBtn.Text = "Add Users";
            this.usersBtn.UseVisualStyleBackColor = true;
            this.usersBtn.Click += new System.EventHandler(this.usersBtn_Click);
            // 
            // logOutBtn
            // 
            this.logOutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logOutBtn.Location = new System.Drawing.Point(1192, 26);
            this.logOutBtn.Margin = new System.Windows.Forms.Padding(4);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(152, 64);
            this.logOutBtn.TabIndex = 2;
            this.logOutBtn.Text = "Log Out";
            this.logOutBtn.UseVisualStyleBackColor = true;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // pagePnl
            // 
            this.pagePnl.AutoScroll = true;
            this.pagePnl.Controls.Add(this.loginPage);
            this.pagePnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pagePnl.Location = new System.Drawing.Point(0, 160);
            this.pagePnl.Margin = new System.Windows.Forms.Padding(4);
            this.pagePnl.Name = "pagePnl";
            this.pagePnl.Size = new System.Drawing.Size(1468, 762);
            this.pagePnl.TabIndex = 3;
            // 
            // loginPage
            // 
            this.loginPage.Location = new System.Drawing.Point(4, 8);
            this.loginPage.Margin = new System.Windows.Forms.Padding(4);
            this.loginPage.MinimumSize = new System.Drawing.Size(1170, 464);
            this.loginPage.Name = "loginPage";
            this.loginPage.Size = new System.Drawing.Size(1285, 587);
            this.loginPage.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1468, 40);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(90, 36);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1468, 922);
            this.Controls.Add(this.pagePnl);
            this.Controls.Add(this.logOutBtn);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1474, 929);
            this.Name = "MainForm";
            this.Text = "Quizard";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pagePnl.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.Button ClassesBtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button InfoBtn;
        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.Panel pagePnl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private Pages.LoginPage loginPage;
        private System.Windows.Forms.Button usersBtn;
    }
}

