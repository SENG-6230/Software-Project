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

        public string assignmentFormText
        {
            get { return this.Text; }
            set { this.Text = value;}
        }

        public string assignmentNameText
        {
            get { return this.txtName.Text; }
            set { this.txtName.Text = value;}
        }

        public DateTime assignmentDueDate
        {
            get { return this.dueDatePicker.Value; }
            set { this.dueDatePicker.Value = value;}
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
