using Quizard.Pages;
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
    public partial class MainForm : Form
    {
        #region Variables
        public bool Loaded
        {
            get
            {
                return loaded;
            }
        }
        bool loaded = false;

        ClassesPage classes = new ClassesPage();
        HomePage home = new HomePage();
        LoginPage login = new LoginPage();
        ProfilePage profile = new ProfilePage();
        UsersPage user = new UsersPage();
        AddClassPage addClass = new AddClassPage();
        User userLoggedIn = new User();

        #endregion

        #region Methods
        public MainForm()
        {
            InitializeComponent();
            loginPage.LoginSuccessful += userLogin;
            showPage(loginPage);
            loaded = true;
            menuStrip1.Visible = false;
            HomeBtn.Visible = false;
            clearAllPages();
        }

        void showPage(Control page)
        {
            pagePnl.Controls.Clear();
            page.Dock = DockStyle.Fill;
            pagePnl.Controls.Add(page);
            //This will tie into the results from the login page when we set that up
            ((QuizardPage)page).ShowPage(userLoggedIn);
        }

        #region Event Handlers
        private void ClassesBtn_Click(object sender, EventArgs e)
        {
            showPage(classes);
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            showPage(home);
        }

        private void InfoBtn_Click(object sender, EventArgs e)
        {
            showPage(profile);
        }

        private void usersBtn_Click(object sender, EventArgs e)
        {
            showPage(user);
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            userLoggedIn = new User(); //set userlogged in to no one
            clearAllPages();
            showPage(loginPage);
        }

        private void clearAllPages()
        {
            InfoBtn.Visible = false;
            HomeBtn.Visible = false;
            ClassesBtn.Visible = false;
            usersBtn.Visible = false;
            logOutBtn.Visible = false;
        }

        private void userLogin(User user)
        {
            userLoggedIn = user; //Stores the info of the user logged in
            if(user.Role == UserTypes.Administrator)
            {
                usersBtn.Visible = true;
            }
            InfoBtn.Visible = true;
            ClassesBtn.Visible = true;
            logOutBtn.Visible = true;
            this.PerformLayout();
            showPage(profile);
        }
        #endregion
        #endregion
    }
}
