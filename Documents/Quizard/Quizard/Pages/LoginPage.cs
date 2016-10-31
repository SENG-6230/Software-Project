using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Quizard.Pages
{
    public partial class LoginPage : UserControl, QuizardPage
    {

        //ProfilePage profile = new ProfilePage();

        string userName
        {
            get
            {
                return this.usernameBx.Text;
            }
            set
            {
                usernameBx.Text = value;
            }
        }

        string password
        {
            get
            {
                return passwordBx.Text;
            }
            set
            {
                passwordBx.Text = value;
            }
        }

        public LoginPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuizardDatabase validate = new QuizardDatabase();
            User check = validate.loginCheck(userName, password);

            if (check != null)
            {
                MessageBox.Show("Welcome" + " who is logged in ? " + check.Name);
                ShowPage(check);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("User name - " + userName + " does not match password " + password);
            }

            //TODO add login action
        }

        public void ShowPage(User user)
        {
           //user object holds all the logged in users info (userId, email, p/w, role, name)
        }
    }
}
