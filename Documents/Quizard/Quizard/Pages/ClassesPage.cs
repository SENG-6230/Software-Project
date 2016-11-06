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
        Class currentClass;

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
                if(currentUser.Role == UserTypes.Teacher)
                {
                    AssignmentForm form = AssignmentForm.editAssignmentForm(0);
                    form.Show();
                }
                else
                {
                    AssignmentForm form = AssignmentForm.studentAssignmentForm(0, currentUser.rowId);
                    form.Show();
                }
            }
        }

        public void ShowPage(User user)
        {
            currentUser = user;
            resetView();
            switch (user.Role)
            {
                case UserTypes.Student:
                    List<Class> studentsClasses = Program.Database.GetStudentsClasses(user);
                    populateClassList(studentsClasses);
                    addAssignmentBtn.Visible = false;
                    break;
                case UserTypes.Teacher:
                    List<Class> teacherClasses = Program.Database.GetTeachersClasses(user);
                    populateClassList(teacherClasses);
                    break;
                case UserTypes.TeachingAssistant:
                    List<Class> assistantingClasses = Program.Database.GetTAClasses(user);
                    populateClassList(assistantingClasses);
                    addAssignmentBtn.Visible = false;
                    break;
                case UserTypes.DepartmentHead:
                    List<Class> departmentClasses = Program.Database.GetDepartmentClasses(user);
                    populateClassList(departmentClasses);
                    assistantsLbl.Visible = false;
                    assistantsBx.Visible = false;
                    studentsBx.Visible = false;
                    studentsLbl.Visible = false;
                    assignmentsBx.Visible = false;
                    assignmentsLbl.Visible = false;
                    quizGradelbl.Visible = false;
                    quizGradeValLbl.Visible = false;
                    addAssignmentBtn.Visible = false;
                    break;
                case UserTypes.Administrator:
                    List<Class> allClasses = Program.Database.GetAllClasses();
                    populateClassList(allClasses);
                    gradeLbl.Visible = false;
                    gradeValLbl.Visible = false;
                    quizGradelbl.Visible = false;
                    quizGradeValLbl.Visible = false;
                    addAssignmentBtn.Visible = false;
                    break;
                //default:
                    //throw new Exception("Unable to show page because the user type is not supported");
            }
        }

        private void resetView()
        {
            clearClass();
            classNameLbl.Visible = true;
            classNameValueLbl.Visible = true;
            teacherNameLbl.Visible = true;
            teacherValueLbl.Visible = true;
            gradeLbl.Visible = true;
            gradeValLbl.Visible = true;
            attendanceLbl.Visible = true;
            attendanceValLbl.Visible = true;
            assistantsBx.Visible = true;
            assistantsLbl.Visible = true;
            studentsBx.Visible = true;
            studentsLbl.Visible = true;
            assignmentsLbl.Visible = true;
            assignmentsBx.Visible = true;
            quizGradelbl.Visible = true;
            quizGradeValLbl.Visible = true;
            addAssignmentBtn.Visible = true;
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
            Class deleteClass = (Class)classTV.SelectedNode.Tag;
        }

        private void classTV_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            Class newClass = (Class)e.Node.Tag;
            classNameValueLbl.Text = newClass.Name;
            teacherValueLbl.Text = newClass.Teacher.Name;
            //gradeValLbl.Text = "";
            //attendanceValLbl.Text = "";
            assistantsBx.Items.Clear();
            foreach (User assistant in newClass.AssistantTeachers)
            {
                assistantsBx.Items.Add(assistant.Name);
            }
            studentsBx.Items.Clear();
            foreach (User student in newClass.Students)
            {
                studentsBx.Items.Add(student.Name);
            }
            assignmentsBx.Items.Clear();
            populateAssignmentList(newClass.rowId);

            currentClass = newClass;
        }

        private void populateAssignmentList(int rowId)
        {
        }
    }
}
