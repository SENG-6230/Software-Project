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
                SQLiteConnection database = new System.Data.SQLite.SQLiteConnection("Data Source =../../quizard.db");
            }
            catch {
                // create Database instrcutions here... //Jonathan
            }
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

        internal List<User> GetAllUsers(UserTypes type)
        {
            List<User> users = GetAllUsers();
            List<User> rtnList = new List<User>();
            foreach (User possible in users)
            {
                if (possible.Role == type)
                {
                    rtnList.Add(possible);
                }
            }
            return rtnList;
        }

        internal List<User> GetAllUsers()
        {
            List<User> rtnList = new List<User>();
            string command = "SELECT * FROM users;";
            using (SQLiteDataReader reader = retrieveCommands(command))
            {
                while (reader.HasRows)
                {
                    User newUser = parseUserFromReader(reader);
                    if (newUser != null)
                    {
                        rtnList.Add(newUser);
                    }
                }
            }
            return rtnList;
        }

        internal int CreateUser(string Name, string email, string password, string role)
        {
            int results = 0;
            //add sql database code here to add a user
            executeCommand(delegate (SQLiteCommand command)
            {
                command.CommandText =
                   "INSERT INTO users(rowid, name, email, user_type, password) "
                    + "VALUES(NULL, \"" + Name + "\", \"" + email + "\", \"" + (UserTypes)Enum.Parse(typeof(UserTypes), role) + "\", \"" + password + "\");";
                //"INSERT INTO users(rowid, fname, lname, email, user_type, password) "
                //+ "VALUES(NULL, \"\", \"" + Name + "\", \"" + email + "\", \"" + (UserTypes)Enum.Parse(typeof(UserTypes), role) + "\", \"" + password + "\");";

                results = command.ExecuteNonQuery();
            });
            return results;
        }

        internal List<Class> GetStudentsClasses(User user)
        {
            List<Class> allCLasses = GetAllClasses();
            List<Class> rtnCLasses = new List<Class>();
            foreach (Class potential in allCLasses)
            {
                foreach (User student in potential.Students)
                {
                    if (student.rowId == user.rowId)
                    {
                        rtnCLasses.Add(potential);
                    }
                }
            }

            return rtnCLasses;
        }

        internal List<Class> GetDepartmentClasses(User user)
        {
            List<Class> allCLasses = GetAllClasses();
            List<Class> rtnCLasses = new List<Class>();
            foreach (Class potential in allCLasses)
            {
                    if (potential.DepartmentHead.rowId == user.rowId)
                    {
                        rtnCLasses.Add(potential);
                    }
            }

            return rtnCLasses;
        }

        internal List<Class> GetTeachersClasses(User user)
        {
            List<Class> allCLasses = GetAllClasses();
            List<Class> rtnCLasses = new List<Class>();
            foreach (Class potential in allCLasses)
            {
                    if (potential.Teacher.rowId == user.rowId)
                    {
                        rtnCLasses.Add(potential);
                    }
            }

            return rtnCLasses;
        }

        internal List<Class> GetTAClasses(User user)
        {
            List<Class> allCLasses = GetAllClasses();
            List<Class> rtnCLasses = new List<Class>();
            foreach (Class potential in allCLasses)
            {
                foreach (User assistant in potential.AssistantTeachers)
                {
                    if (assistant.rowId == user.rowId)
                    {
                        rtnCLasses.Add(potential);
                    }
                }
            }

            return rtnCLasses;
        }

        internal List<Class> GetAllClasses()
        {
            List<Class> rtnList = new List<Class>();
            string command = "SELECT * FROM classes;";
            using (SQLiteDataReader reader = retrieveCommands(command))
            {
                while (reader.HasRows)
                {
                    try
                    {
                        Class newClass = new Class();
                        reader.Read();
                        int classID = Convert.ToInt32(reader["class_ID"].ToString());
                        newClass.rowId = classID;
                        newClass.number = reader["class_number"].ToString();
                        newClass.Name = reader["class_name"].ToString();
                        newClass.Teacher = getTeacher(classID);
                        newClass.DepartmentHead = getDeptHead(classID);
                        newClass.AssistantTeachers = getTAs(classID);
                        newClass.Students = getStudents(classID);
                        rtnList.Add(newClass);
                    }
                    catch
                    {
                        return rtnList;
                    }


            }
                return rtnList;
            }
        }

        internal User getTeacher(int classID)
        {
            //int userID;
            User whoIs = new User();
            string command = "SELECT * FROM users, class_members WHERE users.user_ID = class_members.user_ID AND user_type = 3 AND class_ID =" + classID + ";";
            using (SQLiteDataReader reader = retrieveCommands(command))
            {
                if (reader.HasRows)
                {
                    whoIs = parseUserFromReader(reader);
                }
                else
                {
                    return null;
                }
            }
            return whoIs;
        }

        internal User getDeptHead(int classID){
            //int userID;
            User whoIs = new User();
            string command = "SELECT * FROM users, class_members WHERE users.user_ID = class_members.user_ID AND user_type = 4 AND class_ID =" + classID +";";
            using (SQLiteDataReader reader = retrieveCommands(command)){
                if (reader.HasRows){
                  whoIs = parseUserFromReader(reader);
                }else
                {
                    return null;
                }
            }
            return whoIs;
        }

        internal List<User> getTAs(int classID)
        {
            //int userID;
            List<User> whoIs = new List<User>();
            string command = "SELECT * FROM users, class_members WHERE users.user_ID = class_members.user_ID AND user_type = 2 AND class_ID =" + classID + ";";
            using (SQLiteDataReader reader = retrieveCommands(command))
            {
                while (reader.HasRows)
                {
                    User newTA = parseUserFromReader(reader);
                    if(newTA != null)
                    {
                        whoIs.Add(newTA);
                    }
                }
            }
            return whoIs;
        }

        internal List<User> getStudents(int classID)
        {
            //int userID;
            List<User> whoIs = new List<User>();
            string command = "SELECT * FROM users, class_members WHERE users.user_ID = class_members.user_ID AND user_type = 1 AND class_ID =" + classID + ";";
            using (SQLiteDataReader reader = retrieveCommands(command))
            {
                while (reader.HasRows)
                {
                    User newStudent = parseUserFromReader(reader);
                    if (newStudent != null)
                    {
                        whoIs.Add(newStudent);
                    }
                }
            }
            return whoIs;
        }



        internal int EditUser(User currentUser, string Name, string email, string password, string role)
        {
            int results = 0;
            executeCommand(delegate (SQLiteCommand command)
            {
                command.CommandText =
                    "UPDATE users"
                    + " SET"
                    + " name=\"" + Name + "\","
                    + " email=\"" + email + "\", password=\"" + password + "\", user_type=\"" + (int)Enum.Parse(typeof(UserTypes), role) + "\""
                    + " WHERE user_ID=\"" + currentUser.rowId + "\";";

                results = command.ExecuteNonQuery();
            });
            return results;
        }

        internal void CreateClass(string name, User teacher, User DpHead, List<User> assistants, List<User> students)
        {
            //add sql code here to add a class
        }

        internal int CreateQuiz(Quiz quiz)
        {
            int results = 0;
            executeCommand(delegate (SQLiteCommand command)
            {
                command.CommandText =
                    "INSERT INTO quizzes(classid, quizname, duedate, path) "
                    + "VALUES(" + "\"" + quiz.classid + "\",\"" + quiz.name + "\",\"" + quiz.duedate.ToString() + "\",\"" + quiz.path + "\");";

                results = command.ExecuteNonQuery();
            });
            return results;
        }

        internal int RemoveUser(User currentUser)
        {
            int results = 0;
            executeCommand(delegate (SQLiteCommand command)
            {
                command.CommandText =
                    "DELETE FROM users"
                    + " WHERE user_ID=\"" + currentUser.rowId + "\";";

                results = command.ExecuteNonQuery();
            });
            return results;
        }

        internal int CreateSubmission(Submission submission)
        {
            int results = 0;
            executeCommand(delegate (SQLiteCommand command)
            {
                command.CommandText =
                    "INSERT INTO submissions(quizid, classid, userid, score, path) "
                    + "VALUES(" + "\"" + submission.quizid + "\",\"" + submission.classid + "\",\"" + submission.userid + "\",\"" + submission.score + "\",\"" + submission.path + "\");";

                results = command.ExecuteNonQuery();
            });
            return results;
        }

        internal int GradeSubmission(int id, string grade)
        {
            int results = 0;
            executeCommand(delegate (SQLiteCommand command)
            {
                command.CommandText =
                    "UPDATE submissions "
                    + "SET score = " + grade
                    + "WHERE submission_ID = " + id + ";";

                results = command.ExecuteNonQuery();
            });
            return results;
        }

        private User parseUserFromReader(SQLiteDataReader reader)
        {
            User user = null;
            if (reader.HasRows)
            {
                try
                {
                    user = new User();
                    reader.Read();
                    user.rowId = Convert.ToInt32(reader["user_ID"].ToString());
                    user.Email = reader["email"].ToString();
                    user.Password = reader["password"].ToString();
                    user.Name = reader["Name"].ToString();
                    user.Role = (UserTypes)reader["user_type"];
                }
                catch
                {
                    //bad reader. return null
                    return null;
                }
            }
            return user;
        }

        private SQLiteDataReader retrieveCommands(string query)
        {
            SQLiteDataReader reader;
            SQLiteConnection database = new SQLiteConnection("Data Source =../../quizard.db");
            database.Open();

            SQLiteCommand command = new SQLiteCommand(query, database);
            reader = command.ExecuteReader();
            return reader;

        }

        internal User loginCheck(string userName, string password)
        {
            string command = "SELECT * FROM users WHERE email = '" + userName + "' AND password = '" + password + "';";
            User rtnUser = null;
            using (SQLiteDataReader reader = retrieveCommands(command))
            {
                rtnUser = parseUserFromReader(reader);
            }
            return rtnUser;
        }

    }
}
