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
    public partial class AddClassPage : UserControl //, QuizardPage
    {
        public event EventHandler<ClassArgs> finishedEvent;
        
        public AddClassPage()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            //Program.Database.CreateClass(
            //    nameBx.Text,
            //    teacherCbx.SelectedText,
            //    headCbx.SelectedText,
            //    getListOfAssistants(),
            //    GetListOfStudents());

            finishedEvent?.Invoke(null, null);
        }

        private List<string> GetListOfStudents()
        {
            List<string> rtnList = assistantsBx.SelectedItems.OfType<string>().ToList();
            return rtnList;
        }

        private List<string> getListOfAssistants()
        {
            List<string> rtnList = studentsBx.SelectedItems.OfType<string>().ToList();
            return rtnList;
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
