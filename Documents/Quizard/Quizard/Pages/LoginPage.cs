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
    public partial class LoginPage : UserControl // QuizardPage
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

            string checkPassword = "SELECT user_type FROM users WHERE email = '" + userName + "' AND password = '" +password +"';";
           //string checkPassword = "SELECT * FROM users WHERE email = 'engj@ecu.edu' AND password = 'password';";

            System.Data.SQLite.SQLiteCommand command = new System.Data.SQLite.SQLiteCommand(checkPassword, database);
            System.Data.SQLite.SQLiteDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                if (reader.GetInt32(0) == 1){
                    System.Windows.Forms.MessageBox.Show("User is an Student");     //set session for student
                }else if (reader.GetInt32(0) == 2){
                    System.Windows.Forms.MessageBox.Show("User is an Teacher");     //set session for teacher 
                }else if (reader.GetInt32(0) == 3){
                    System.Windows.Forms.MessageBox.Show("User is an Teacher's Assistant"); //etc...
                }else if (reader.GetInt32(0) == 4){
                    System.Windows.Forms.MessageBox.Show("User is an Department Head");
                }else if (reader.GetInt32(0) == 5){
                    System.Windows.Forms.MessageBox.Show("User is an Administrator");
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("User name - " + userName + " does not match password " + password);
            }
            database.Close();
            //TODO add login action
        }

        public void ShowPage(UserTypes user)
        {

        }
    }
}
