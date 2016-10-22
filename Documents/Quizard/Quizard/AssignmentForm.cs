using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quizard
{
    public partial class AssignmentForm : Form
    {
        public AssignmentForm()
        {
            InitializeComponent();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileChooser = new OpenFileDialog();
            fileChooser.Title = "Select An Assignment to Upload";
            fileChooser.InitialDirectory = @"C:\";
            fileChooser.CheckFileExists = true;
            fileChooser.CheckPathExists = true;
            if (fileChooser.ShowDialog() == DialogResult.OK)
            {
                string file = fileChooser.FileName.ToString();
                MessageBox.Show("File " + file + " Successfully Uploaded!");
                lblFile.Text = file;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //TODO: modify this to push the new assignment to the database
            MessageBox.Show("Changes Saved!");
            this.Close();
        }
    }
}
