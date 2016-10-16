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
        LoginPage login = this.loginPage;
        #endregion

        #region Methods
        public MainForm()
        {
            InitializeComponent();
            loaded = false;
        }

        void showPage(Control page)
        {
            pagePnl.Controls.Clear();
            pagePnl.Controls.Add(page);
        }

        #region Event Handlers
        private void ClassesBtn_Click(object sender, EventArgs e)
        {
            showPage();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {

        }

        private void InfoBtn_Click(object sender, EventArgs e)
        {

        }

        private void usersBtn_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #endregion
    }
}
