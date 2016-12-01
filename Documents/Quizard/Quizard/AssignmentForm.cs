using Quizard.Pages;
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
        internal Quiz quiz;
        internal int userid;
        internal int classid;

        public AssignmentForm()
        {
            InitializeComponent();
        }

        public static AssignmentForm uploadAssignmentForm(int cid)
        {
            AssignmentForm form = new AssignmentForm();
            form.classid = cid;
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

        public static AssignmentForm editAssignmentForm(Quiz q)
        {
            AssignmentForm form = new AssignmentForm();
            form.Text = "Editing existing assignment";
            form.quiz = q;
            form.txtName.Text = q.name;
            form.lblFile.Text = q.path;
            form.dueDatePicker.Value = q.duedate;
            form.groupBoxStudentFile.Enabled = false;
            form.groupBoxStudentFile.Visible = false;
            form.btnStudentDownload.Enabled = false;
            form.btnStudentDownload.Visible = false;
            form.btnStudentUpload.Enabled = false;
            form.btnStudentUpload.Enabled = false;
            form.groupBoxGrades.Text = "Grades";
            form.lblMyGrade.Enabled = false;
            form.lblMyGrade.Visible = false;
            return form;
        }

        public static AssignmentForm studentAssignmentForm(Quiz q, int uid)
        {
            AssignmentForm form = new AssignmentForm();
            form.userid = uid;
            form.quiz = q;
            form.Text = "Upload student assignment submission";
            form.Text = "Editing existing assignment";
            form.txtName.Text = q.name;
            form.lblFile.Text = q.path;
            form.dueDatePicker.Value = q.duedate;
            form.txtName.Enabled = false;
            form.dueDatePicker.Enabled = false;
            form.btnUpload.Enabled = false;
            form.btnUpload.Visible = false;
            form.btnSave.Enabled = false;
            form.btnSave.Visible = false;
            form.groupBoxGrades.Text = "My Grade";
            form.btnGrade.Enabled = false;
            form.btnGrade.Visible = false;

            Submission s = Program.Database.getSubmissionForUserAndAssignment(q.quizid, uid);
            if(s != null)
            {
                form.lblSubmission.Text = s.path;
                if(s.score == "")
                {
                    form.lblMyGrade.Text = "This assignment is not yet graded";
                }
                else
                {
                    form.lblMyGrade.Text = s.score;
                }
            }
            else
            {
                form.lblSubmission.Text = "You have not submitted";
                form.lblMyGrade.Text = "This assignment is not yet graded";
            }
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
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK)
            {
                string file = save.FileName.ToString();
                File.Copy(lblFile.Text, file, true);
                MessageBox.Show("File saved as " + file);
            }
        }

        private void btnStudentUpload_Click(object sender, EventArgs e)
        {
            if(!lblMyGrade.Text.Equals("This assignment is not yet graded"))
            {
                MessageBox.Show("This assignment has already been graded so you may not submit.");
            }
            else if (DateTime.Now <= this.dueDatePicker.Value)
            {
                OpenFileDialog fileChooser = new OpenFileDialog();
                fileChooser.Title = "Select Your Submission File";
                fileChooser.InitialDirectory = @"C:\";
                fileChooser.CheckFileExists = true;
                fileChooser.CheckPathExists = true;
                if (fileChooser.ShowDialog() == DialogResult.OK)
                {
                    lblSubmission.Text = fileChooser.FileName;
                    Submission s = Program.Database.getSubmissionForUserAndAssignment(quiz.quizid, userid);
                    if(s == null)
                    {
                        Submission sub = new Submission();
                        sub.quizid = quiz.quizid;
                        sub.userid = this.userid;
                        sub.classid = this.classid;

                        string studentName = Program.Database.getUserNameForSubmission(sub.userid);
                        var fileInfo = new FileInfo(lblSubmission.Text);
                        string extention = fileInfo.Extension;
                        sub.path = Path.Combine("../../submissions", quiz.name + " " + studentName + extention);
                        if (!File.Exists(sub.path))
                        {
                            File.Copy(lblSubmission.Text, sub.path, true);
                        }

                        Program.Database.CreateSubmission(sub);
                        MessageBox.Show("Submission Uploaded!");
                    }
                    else
                    {
                        Program.Database.EditSubmission(fileChooser.FileName, userid, quiz.quizid);
                        MessageBox.Show("Submission Uploaded!");
                    }   
                }
            }
            else
            {
                MessageBox.Show("The due date for this assignment has passed and submissions may no longer be uploaded.");
            }
        }

        private void btnStudentDownload_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK)
            {
                string file = save.FileName.ToString();
                File.Copy(lblSubmission.Text, file, true);
                MessageBox.Show("File saved as " + file);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(quiz == null)
            {
                quiz = new Quiz();
                quiz.classid = this.classid;
            }
            quiz.name = txtName.Text;
            quiz.duedate = dueDatePicker.Value;
            var fileInfo = new FileInfo(lblFile.Text);
            string extention = fileInfo.Extension;
            quiz.path = Path.Combine("../../assignments", quiz.name + extention);
            if (!File.Exists(quiz.path))
            {
                File.Copy(lblFile.Text, quiz.path, true);
            }
            if(this.Text.Equals("Upload a new assignment"))
            {
                Program.Database.CreateQuiz(quiz);
            }
            else
            {
                Program.Database.UpdateQuiz(quiz);
            }
            MessageBox.Show("Assignment Uploaded!");
            this.Close();
        }

        private void btnGrade_Click(object sender, EventArgs e)
        {
            GradeForm form = new Quizard.GradeForm(quiz.quizid);
            form.Text = "Grading Assignment: " + quiz.name;
            form.Show();
        }

        private void AssignmentForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
