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
            this.addClassLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addClassLbl
            // 
            this.addClassLbl.AutoSize = true;
            this.addClassLbl.Location = new System.Drawing.Point(214, 142);
            this.addClassLbl.Name = "addClassLbl";
            this.addClassLbl.Size = new System.Drawing.Size(110, 25);
            this.addClassLbl.TabIndex = 2;
            this.addClassLbl.Text = "Add Class";
            // 
            // AddClassPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addClassLbl);
            this.MinimumSize = new System.Drawing.Size(730, 370);
            this.Name = "AddClassPage";
            this.Size = new System.Drawing.Size(730, 370);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addClassLbl;
    }
}
