using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizard
{
    public class QuizardDatabase
    {
        internal void Open()
        {
            try
            {
                //add database file path login here
            }
            catch { }
        }

        private void executeCommand(Action<SQLiteCommand> commandAction)
        {
            using (SQLiteConnection database = new System.Data.SQLite.SQLiteConnection("Data Source =../../quizard.db"))
            {
                database.Open();
                using (SQLiteCommand command = database.CreateCommand())
                {
                    commandAction.Invoke(command);
                }
            }
        }

        internal List<User> GetAllUsers()
        {
            //insert user parsing here
            return new List<User>();
        }

        internal int CreateUser(string Name, string email, string password, string role)
        {
            int results = 0;
            //add sql database code here to add a user
            executeCommand(delegate(SQLiteCommand command) 
            {
                command.CommandText =
                    "INSERT INTO users(rowid, fname, lname, email, user_type, password) "
                    + "VALUES(NULL, " + Name + ", " + Name + ", " + email + ", " + (UserTypes)Enum.Parse(typeof(UserTypes), role) + ", " + password + ");";

                results = command.ExecuteNonQuery();
            });
            return results;
        }

        internal void CreateClass(string text, string selectedText1, string selectedText2, List<string> list1, List<string> list2)
        {
            //add sql code here to add a class
        }
    }
}
