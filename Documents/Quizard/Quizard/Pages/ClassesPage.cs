using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Quizard.Pages
{
    public partial class ClassesPage : UserControl, QuizardPage
    {
        User currentUser;

        public ClassesPage()
        {
            InitializeComponent();

            addClassPage.Visible = false;
            addClassPage.finishedEvent += addClassFInishedHandler;
        }

        void clearClass()
        {
            classNameValueLbl.Text = "";
            teacherValueLbl.Text = "";
            gradeValLbl.Text = "";
            attendanceValLbl.Text = "";
            quizGradeValLbl.Text = "";
            assistantsBx.Items.Clear();
            studentsBx.Items.Clear();
            assignmentsBx.Items.Clear();
        }

        private void addClassFInishedHandler(object sender, ClassArgs e)
        {
            classInfoPanel.Visible = true;
            addClassPage.Visible = false;
            addClassBtn.Visible = true;
        }

        private void addClassBtn_Click(object sender, EventArgs e)
        {
            classInfoPanel.Visible = false;
            addClassPage.Visible = true;
            addClassBtn.Visible = false;
            addClassPage.ShowPage();
        }

        private void addAssignmentBtn_Click(object sender, EventArgs e)
        {
            AssignmentForm form = AssignmentForm.uploadAssignmentForm();
            form.Show();
        }

        private void assignmentsBx_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.assignmentsBx.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                AssignmentForm form = AssignmentForm.studentAssignmentForm(0);
                form.Show();
            }
        }

        public void ShowPage(User user)
        {
            currentUser = user;
            clearClass();
            switch (user.Role)
            {
                case UserTypes.Student:
                    List<Class> studentsClasses = Program.Database.GetStudentsClasses(user);
                    populateClassList(studentsClasses);
                    break;
                case UserTypes.Teacher:
                    List<Class> teacherClasses = Program.Database.GetTeachersClasses(user);
                    populateClassList(teacherClasses);
                    break;
                case UserTypes.TeachingAssistant:
                    List<Class> assistantingClasses = Program.Database.GetTAClasses(user);
                    populateClassList(assistantingClasses);
                    break;
                case UserTypes.DepartmentHead:
                    List<Class> departmentClasses = Program.Database.GetDepartmentClasses(user);
                    populateClassList(departmentClasses);
                    break;
                case UserTypes.Administrator:
                    List<Class> allClasses = Program.Database.GetAllClasses();
                    populateClassList(allClasses);
                    break;
                //default:
                    //throw new Exception("Unable to show page because the user type is not supported");
            }

        }

        private void populateClassList(List<Class> classList)
        {
            classTV.Nodes.Clear();
            foreach (Class newCLass in classList)
            {
                TreeNode newNode = new TreeNode(newCLass.Name);
                newNode.Tag = newCLass;
                classTV.Nodes.Add(newNode);
            }
        }

        private void editMenuItem_Click(object sender, EventArgs e)
        {
            classInfoPanel.Visible = false;
            addClassPage.Visible = true;
            addClassBtn.Visible = false;
            addClassPage.ShowPage((Class)classTV.SelectedNode.Tag);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void classTV_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            Class newClass = (Class)e.Node.Tag;
            classNameValueLbl.Text = newClass.Name;
            teacherValueLbl.Text = newClass.Teacher.Name;
            //gradeValLbl.Text = "";
            //attendanceValLbl.Text = "";
            foreach (User assistant in newClass.AssistantTeachers)
            {
                assistantsBx.Items.Add(assistant.Name);
            }
            foreach (User student in newClass.Students)
            {
                studentsBx.Items.Add(student.Name);
            }
            //assignmentsBx.Items.Clear();
        }
    }
}
