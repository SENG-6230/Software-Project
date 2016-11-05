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
        internal int assignmentid;
        internal int userid;

        public AssignmentForm()
        {
            InitializeComponent();
        }

        public AssignmentForm(int uid, int aid)
        {
            InitializeComponent();
            assignmentid = aid;
            userid = uid;
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
            form.lblFile.Text = "No File Chosen";
            form.groupBoxGrades.Enabled = false;
            form.groupBoxGrades.Visible = false;
            return form;
        }

        public static AssignmentForm editAssignmentForm(int assignmentid)
        {
            // TODO: pull assignment info from database for assignment matching id
            AssignmentForm form = new AssignmentForm();
            form.Text = "Editing existing assignment";
            form.txtName.Text = "Placeholder";
            form.dueDatePicker.Value = new DateTime(2099, 3, 1, 7, 0, 0);
            form.groupBoxStudentFile.Text = "Edit Student Grades";
            form.btnStudentDownload.Enabled = false;
            form.btnStudentDownload.Visible = false;
            form.btnStudentUpload.Enabled = false;
            form.btnStudentUpload.Enabled = false;
            form.groupBoxGrades.Text = "Grades";
            form.lblMyGrade.Enabled = false;
            form.lblMyGrade.Visible = false;
            return form;
        }

        public static AssignmentForm studentAssignmentForm(int assignmentid, int userid)
        {
            // TODO: pull assignment info from database for assignment matching id
            AssignmentForm form = new AssignmentForm(assignmentid, userid);
            form.Text = "Upload student assignment submission";
            form.txtName.Text = "Placeholder";
            form.dueDatePicker.Value = new DateTime(2099, 3, 1, 7, 0, 0);
            form.txtName.Enabled = false;
            form.dueDatePicker.Enabled = false;
            form.btnUpload.Enabled = false;
            form.btnUpload.Visible = false;
            form.btnSave.Enabled = false;
            form.btnSave.Visible = false;
            form.groupBoxGrades.Text = "My Grade";
            form.btnGrade.Enabled = false;
            form.btnGrade.Visible = false;
            return form;
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
                    lblSubmission.Text = fileChooser.FileName;
                    Submission submission = new Submission();
                    // modify to get id for quiz and class
                    submission.quizid = 0;
                    submission.classid = 0;
                    var fileInfo = new FileInfo(lblSubmission.Text);
                    string extention = fileInfo.Extension;
                    submission.path = Path.Combine("../../assignments", lblFile.Text + userid + extention);
                    submission.score = "ungraded";
                    Program.Database.CreateSubmission(submission);
                    MessageBox.Show("Submission Uploaded!");
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
            var fileInfo = new FileInfo(lblFile.Text);
            string extention = fileInfo.Extension;
            quiz.path = Path.Combine("../../assignments", quiz.name + extention);
            File.Copy(lblFile.Text, quiz.path, true);
            Program.Database.CreateQuiz(quiz);
            MessageBox.Show("Assignment Uploaded!");
            this.Close();
        }
    }
}
