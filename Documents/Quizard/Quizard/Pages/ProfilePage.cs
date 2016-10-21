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
    public partial class ProfilePage : UserControl
    {
        string name
        {
            get
            {
                return nameVal.Text;
            }
            set
            {
                nameVal.Text = value;
            }
        }

        string email
        {
            get
            {
                return emailVal.Text;
            }
            set
            {
                emailVal.Text = value;
            }
        }

        string password
        {
            get
            {
                return passwordVal.Text;
            }
            set
            {
                passwordVal.Text = value;
            }
        }

        string role
        {
            get
            {
                return roleVal.Text;
            }
            set
            {
                roleVal.Text = value;
            }
        }

        public ProfilePage()
        {
            InitializeComponent();
        }
    }
}
