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
    public partial class UsersPage : UserControl, QuizardPage
    {
        public UsersPage()
        {
            InitializeComponent();
        }

        public void ShowPage(UserTypes user)
        {

        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            //Program.Database.CreateUser(
            //        Name: nameBx.Text,
            //        email: emailBx.Text,
            //        password: passwordBx.Text,
            //        role: roleCbx.Text);
        }
    }
}
