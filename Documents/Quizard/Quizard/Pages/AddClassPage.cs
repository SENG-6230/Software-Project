using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quizard.Pages
{
    public partial class AddClassPage : UserControl , QuizardPage
    {
        public event EventHandler<ClassArgs> finishedEvent;
        
        public AddClassPage()
        {
            InitializeComponent();
            populateAllAssitants();
            populateAllTeachers();
            populateAllDpHeads();
            populateAllStudents();
        }

        private void populateAllStudents()
        {
            studentsBx.Items.Clear();
            List<User> students = Program.Database.GetAllUsers(UserTypes.Student);
            foreach (User student in students)
            {
                studentsBx.Items.Add(student);
            }
        }

        private void populateAllDpHeads()
        {
            headCbx.Items.Clear();
            List<User> dpHead = Program.Database.GetAllUsers(UserTypes.DepartmentHead);
            foreach (User head in dpHead)
            {
                headCbx.Items.Add(head);
            }
        }

        private void populateAllTeachers()
        {
            teacherCbx.Items.Clear();
            List<User> teachers = Program.Database.GetAllUsers(UserTypes.Teacher);
            foreach (User teacher in teachers)
            {
                teacherCbx.Items.Add(teacher);
            }
        }

        private void populateAllAssitants()
        {
            assistantsBx.Items.Clear();
            List<User> assistants = Program.Database.GetAllUsers(UserTypes.TeachingAssistant);
            foreach (User assistant in assistants)
            {
                assistantsBx.Items.Add(assistant);
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Program.Database.CreateClass(
                nameBx.Text,
                (User)teacherCbx.SelectedItem,
                (User)headCbx.SelectedItem,
                getListOfAssistants(),
                GetListOfStudents());

            finishedEvent?.Invoke(null, null);
        }

        private List<User> GetListOfStudents()
        {
            List<User> users = new List<User>();
            foreach (User userIndx in studentsBx.CheckedItems)
            {
                users.Add(userIndx);
            }
            return users;
        }

        private List<User> getListOfAssistants()
        {
            List<User> assist = new List<User>();
            foreach (User userIndx in assistantsBx.CheckedItems)
            {
                assist.Add(userIndx);
            }
            return assist;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            finishedEvent?.Invoke(null, null);
        }

        public void ShowPage(UserTypes user)
        {

        }
    }

    public class ClassArgs : EventArgs
    {

    }
}
