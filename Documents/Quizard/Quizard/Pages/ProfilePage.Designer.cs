using System;

namespace Quizard.Pages
   {
    partial class ProfilePage
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

            this.userNameLbl = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.roleLbl = new System.Windows.Forms.Label();
            this.roleVal = new System.Windows.Forms.Label();
            this.passwordVal = new System.Windows.Forms.Label();
            this.emailVal = new System.Windows.Forms.Label();
            this.nameVal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userNameLbl
            // 
            this.userNameLbl.AutoSize = true;
            this.userNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLbl.Location = new System.Drawing.Point(27, 25);
            this.userNameLbl.Name = "userNameLbl";
            this.userNameLbl.Size = new System.Drawing.Size(52, 18);
            this.userNameLbl.TabIndex = 1;
            this.userNameLbl.Text = "Name:";
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLbl.Location = new System.Drawing.Point(27, 57);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(49, 18);
            this.emailLbl.TabIndex = 2;
            this.emailLbl.Text = "Email:";
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLbl.Location = new System.Drawing.Point(27, 92);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(79, 18);
            this.passwordLbl.TabIndex = 3;
            this.passwordLbl.Text = "Password:";
            // 
            // roleLbl
            // 
            this.roleLbl.AutoSize = true;
            this.roleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleLbl.Location = new System.Drawing.Point(27, 125);
            this.roleLbl.Name = "roleLbl";
            this.roleLbl.Size = new System.Drawing.Size(43, 18);
            this.roleLbl.TabIndex = 4;
            this.roleLbl.Text = "Role:";
            // 
            // roleVal
            // 
            this.roleVal.AutoSize = true;
            this.roleVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleVal.Location = new System.Drawing.Point(170, 125);
            this.roleVal.Name = "roleVal";
            this.roleVal.Size = new System.Drawing.Size(62, 18);
            this.roleVal.TabIndex = 5;
            this.roleVal.Text = "Teacher";
            // 
            // passwordVal
            // 
            this.passwordVal.AutoSize = true;
            this.passwordVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordVal.Location = new System.Drawing.Point(170, 92);
            this.passwordVal.Name = "passwordVal";
            this.passwordVal.Size = new System.Drawing.Size(62, 18);
            this.passwordVal.TabIndex = 6;
            this.passwordVal.Text = "*********";
            // 
            // emailVal
            // 
            this.emailVal.AutoSize = true;
            this.emailVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailVal.Location = new System.Drawing.Point(170, 57);
            this.emailVal.Name = "emailVal";
            this.emailVal.Size = new System.Drawing.Size(154, 18);
            this.emailVal.TabIndex = 7;
            this.emailVal.Text = "VILKOMIRS@ecu.edu";

            // 
            // nameVal
            // 
            this.nameVal.AutoSize = true;
            this.nameVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameVal.Location = new System.Drawing.Point(170, 25);
            this.nameVal.Name = "nameVal";
            this.nameVal.Size = new System.Drawing.Size(110, 18);
            this.nameVal.TabIndex = 8;
            this.nameVal.Text = "Vilkomir, Sergiy";
            // 
            // ProfilePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.nameVal);
            this.Controls.Add(this.emailVal);
            this.Controls.Add(this.passwordVal);
            this.Controls.Add(this.roleVal);
            this.Controls.Add(this.roleLbl);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.userNameLbl);
            this.MinimumSize = new System.Drawing.Size(730, 370);
            this.Name = "ProfilePage";
            this.Size = new System.Drawing.Size(730, 370);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label userNameLbl;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.Label roleLbl;
        private System.Windows.Forms.Label roleVal;
        private System.Windows.Forms.Label passwordVal;
        private System.Windows.Forms.Label emailVal;
        private System.Windows.Forms.Label nameVal;
    }
}
