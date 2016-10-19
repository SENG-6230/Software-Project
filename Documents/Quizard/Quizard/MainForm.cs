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
        #endregion

        #region Methods
        public MainForm()
        {
            InitializeComponent();
            loaded = false;
            menuStrip1.Visible = false;
            HomeBtn.Visible = false;
        }

        void showPage(Control page)
        {
            pagePnl.Controls.Clear();
            page.Dock = DockStyle.Fill;
            pagePnl.Controls.Add(page);
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
            showPage(login);
        }
        #endregion
        #endregion
    }
}
