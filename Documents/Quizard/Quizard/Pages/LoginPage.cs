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
    public partial class LoginPage : UserControl
    {
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

            System.Data.SQLite.SQLiteConnection database = new System.Data.SQLite.SQLiteConnection("Data Source =../../quizard.db");
            database.Open();

            string checkPassword = "SELECT * FROM users WHERE email = '" + userName + "' AND password = '" +password +"';";
           //string checkPassword = "SELECT * FROM users WHERE email = 'engj@ecu.edu' AND password = 'password';";

            System.Data.SQLite.SQLiteCommand command = new System.Data.SQLite.SQLiteCommand(checkPassword, database);
            System.Data.SQLite.SQLiteDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
            System.Windows.Forms.MessageBox.Show("Success - " + userName + " password " + password);
            }else
            {
                System.Windows.Forms.MessageBox.Show("fail - " + userName + " password " + password);
            }
            //TODO add login action
        }
    }
}
