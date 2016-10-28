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
    public partial class ProfilePage : UserControl, QuizardPage
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


            System.Data.SQLite.SQLiteConnection database = new System.Data.SQLite.SQLiteConnection("Data Source =../../quizard.db");
            database.Open();
            string sqlCommand = "SELECT * FROM users WHERE user_ID = 1;"; // need some sort of variable to represent what user is loged in

            System.Data.SQLite.SQLiteCommand command = new System.Data.SQLite.SQLiteCommand(sqlCommand, database);
            System.Data.SQLite.SQLiteDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                this.emailVal.Text = reader["email"].ToString(); ;
                this.passwordVal.Text = reader["password"].ToString();
                this.nameVal.Text = reader["Fname"].ToString() + " " + reader["LName"].ToString();

                int typeInt = Convert.ToInt32(reader["user_type"].ToString());
                UserTypes thisUser = (UserTypes)typeInt;
                this.roleVal.Text = thisUser.ToString();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("There is an issue with your application, please contact an administrator/developer");
            }
        }

        public void ShowPage(UserTypes user)
        {

        }
    }
}
