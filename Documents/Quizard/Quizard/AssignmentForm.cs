using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        public static AssignmentForm uploadAssignmentForm()
        {
            AssignmentForm form = new AssignmentForm();
            form.Text = "Upload a new assignment";
            form.txtName.Text = "Enter Name";
            form.dueDatePicker.Value = DateTime.Now;
            form.groupBoxStudentFile.Visible = false;
            form.btnDownload.Enabled = false;
            form.btnDownload.Visible = false;
            return form;
        }

        public static AssignmentForm editAssignmentForm(int id)
        {
            // TODO: pull assignment info from database for assignment matching id
            AssignmentForm form = new AssignmentForm();
            form.Text = "Editing existing assignment";
            form.txtName.Text = "Placeholder";
            form.dueDatePicker.Value = DateTime.Now;
            form.groupBoxStudentFile.Visible = false;
            return form;
        }

        public static AssignmentForm studentAssignmentForm(int id)
        {
            // TODO: pull assignment info from database for assignment matching id
            AssignmentForm form = new AssignmentForm();
            form.Text = "Upload student assignment submission";
            form.txtName.Text = "Placeholder";
            form.dueDatePicker.Value = DateTime.Now;
            form.txtName.Enabled = false;
            form.dueDatePicker.Enabled = false;
            form.btnUpload.Enabled = false;
            form.btnUpload.Visible = false;
            form.btnSave.Enabled = false;
            form.btnSave.Visible = false;
            return form;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            // TODO: modify this to upload assignment file to database
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

        private void btnDownload_Click(object sender, EventArgs e)
        {
            // TODO: modify this to download assignment from database
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK)
            {
                string file = save.FileName.ToString();
                MessageBox.Show("File saved as " + file);
            }
        }

        private void btnStudentUpload_Click(object sender, EventArgs e)
        {
            // TODO: modify this to upload submission to database
            if(DateTime.Now <= this.dueDatePicker.Value)
            {
                OpenFileDialog fileChooser = new OpenFileDialog();
                fileChooser.Title = "Select Your Submission File";
                fileChooser.InitialDirectory = @"C:\";
                fileChooser.CheckFileExists = true;
                fileChooser.CheckPathExists = true;
                if (fileChooser.ShowDialog() == DialogResult.OK)
                {
                    string file = fileChooser.FileName.ToString();
                    MessageBox.Show("File " + file + " Successfully Uploaded!");
                    lblSubmission.Text = file;
                }
            }
            else
            {
                MessageBox.Show("The due date for this assignment has passed and submissions may no longer be uploaded.");
            }
        }

        private void btnStudentDownload_Click(object sender, EventArgs e)
        {
            // TODO: modify this to download submission from database
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK)
            {
                string file = save.FileName.ToString();
                MessageBox.Show("File saved as " + file);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Quiz quiz = new Quiz();
            quiz.classid = 0;
            quiz.name = txtName.Text;
            quiz.duedate = dueDatePicker.Value;
            quiz.path = Path.Combine(Directory.GetCurrentDirectory(), quiz.name + ".txt");
            File.Copy(lblFile.Text, quiz.path, true);
            Program.Database.CreateQuiz(quiz);
            MessageBox.Show("Assignment Uploaded!");
            this.Close();
        }
    }
}
