using Quizard.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizard
{
    public class QuizardDatabase
    {
        public void Open()
        {
            try
            {
                //add database file path login here
                SQLiteConnection database = new System.Data.SQLite.SQLiteConnection("Data Source = quizard.db");
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Error with database, please contact your Administrator");
                // create Database instrcutions here... //Jonathan
            }
        }

        private void executeCommand(Action<SQLiteCommand> commandAction)
        {
            using (SQLiteConnection database = new System.Data.SQLite.SQLiteConnection("Data Source = quizard.db"))
            {
                database.Open();
                using (SQLiteCommand command = database.CreateCommand())
                {
                    commandAction.Invoke(command);
                }
            }
        }

        public List<User> GetAllUsers(UserTypes type)
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

        public List<User> GetAllUsers()
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

        public int CreateUser(string Name, string email, string password, string role)
        {
            int results = 0;
            //add sql database code here to add a user
            executeCommand(delegate (SQLiteCommand command)
            {
                command.CommandText =
                   "INSERT INTO users(rowid, name, email, user_type, password) "
                    + "VALUES(NULL, \"" + Name + "\", \"" + email + "\", \"" + (int)Enum.Parse(typeof(UserTypes), role) + "\", \"" + password + "\");";
                //"INSERT INTO users(rowid, fname, lname, email, user_type, password) "
                //+ "VALUES(NULL, \"\", \"" + Name + "\", \"" + email + "\", \"" + (UserTypes)Enum.Parse(typeof(UserTypes), role) + "\", \"" + password + "\");";

                results = command.ExecuteNonQuery();
            });
            return results;
        }

        public List<Class> GetStudentsClasses(User user)
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

        public List<Class> GetDepartmentClasses(User user)
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

        public List<Class> GetTeachersClasses(User user)
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

        public List<Class> GetTAClasses(User user)
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

        public List<Class> GetAllClasses()
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
                        newClass.Assignments = getAssignments(classID);
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

        internal int EditSubmission(string fileName, int userid, int quizid)
        {
            int results = 0;
            executeCommand(delegate (SQLiteCommand command)
            {
                command.CommandText =
                    "UPDATE scores"
                    + " SET submission_path= \"" + fileName +  "\" WHERE quiz_ID = \"" + quizid + "\" AND user_ID = \"" + userid +"\";";

                results = command.ExecuteNonQuery();
            });
            return results;
        }

        public User getTeacher(int classID)
        {
            //int userID;
            User whoIs = new User();
            string command = "SELECT * FROM users, class_members WHERE users.user_ID = class_members.user_ID AND user_type = 2 AND class_ID =" + classID + ";";
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

        internal int UpdateQuiz(Quiz quiz)
        {
            int results = 0;
            executeCommand(delegate (SQLiteCommand command)
            {
                command.CommandText =
                    "UPDATE quizzes"
                    + " SET quiz_name=\"" + quiz.name + "\", location =\"" + quiz.path + "\", due_date =\"" + quiz.duedate + "\" WHERE quiz_ID = \"" + quiz.quizid + "\";";

                results = command.ExecuteNonQuery();
            });
            return results;
        }

        public User getDeptHead(int classID)
        {
            //int userID;
            User whoIs = new User();
            string command = "SELECT * FROM users, class_members WHERE users.user_ID = class_members.user_ID AND user_type = 4 AND class_ID =" + classID + ";";
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

        public List<User> getTAs(int classID)
        {
            //int userID;
            List<User> whoIs = new List<User>();
            string command = "SELECT * FROM users, class_members WHERE users.user_ID = class_members.user_ID AND user_type = 3 AND class_ID =" + classID + ";";
            using (SQLiteDataReader reader = retrieveCommands(command))
            {
                while (reader.HasRows)
                {
                    User newTA = parseUserFromReader(reader);
                    if (newTA != null)
                    {
                        whoIs.Add(newTA);
                    }
                }
            }
            return whoIs;
        }

        public List<User> getStudents(int classID)
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

        public List<string> getAssignments(int classID)
        {
            //int userID;
            List<string> whatAre = new List<string>();
            string command = "SELECT quiz_name FROM quizzes WHERE class_ID = " + classID + ";";
            using (SQLiteDataReader reader = retrieveCommands(command))
            {
                reader.Read();
                while (reader.HasRows)
                {

                    string newAssignment = reader["quiz_name"].ToString();//  as string;
                    if (newAssignment != null)
                    {
                        whatAre.Add(newAssignment);
                    }
                    reader.Read();
                }
            }
            return whatAre;
        }




        public int EditUser(User currentUser, string Name, string email, string password, string role)
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

        public int CreateClass(string name, string number, User teacher, User DpHead, List<User> assistants, List<User> students)
        {
            int results = -1;
            Int64 id = -1;
            executeCommand(delegate (SQLiteCommand command)
            {
                command.CommandText =
                    "INSERT INTO classes(rowID, class_number, class_name)"
                    + " VALUES(NULL, \"" + name + "\", \"" + number + "\");"
                    + " select last_insert_rowid()";
                id = (Int64)command.ExecuteScalar();
            });

            executeCommand(delegate (SQLiteCommand command)
            {
                command.CommandText =
                    "INSERT INTO class_members(class_ID, user_ID)"
                    + "VALUES (" + id + ", " + teacher.rowId + ");";
                results = command.ExecuteNonQuery();
            });

            executeCommand(delegate (SQLiteCommand command)
            {
                command.CommandText =
                    "INSERT INTO class_members(class_ID, user_ID)"
                    + "VALUES (" + id + ", " + DpHead.rowId + ");";
                results = command.ExecuteNonQuery();
            });

            foreach (User assistant in assistants)
            {
                executeCommand(delegate (SQLiteCommand command)
                {
                    command.CommandText =
                        "INSERT INTO class_members(class_ID, user_ID)"
                        + "VALUES (" + id + ", " + assistant.rowId + ");";
                    results = command.ExecuteNonQuery();
                });
            }

            foreach (User student in students)
            {
                executeCommand(delegate (SQLiteCommand command)
                {
                    command.CommandText =
                        "INSERT INTO class_members(class_ID, user_ID)"
                        + "VALUES (" + id + ", " + student.rowId + ");";
                    results = command.ExecuteNonQuery();
                });
            }

            return results;
        }

        public int CreateQuiz(Quiz quiz)
        {
            int results = 0;
            executeCommand(delegate (SQLiteCommand command)
            {
                command.CommandText =
                    "INSERT INTO quizzes(class_ID, quiz_name, location, due_date) "
                    + "VALUES(" + "\"" + quiz.classid + "\",\"" + quiz.name + "\",\"" +  quiz.path + "\",\"" + quiz.duedate.ToString() + "\");";

                results = command.ExecuteNonQuery();
            });
            return results;
        }

        public Quiz getAssignmentFromName(string name, int classID)
        {

            //int userID;
            Quiz q = new Quiz();
            string command = "SELECT * FROM quizzes WHERE class_ID =\"" + classID +"\" AND quiz_name = \"" + name + "\";";
            using (SQLiteDataReader reader = retrieveCommands(command))
            {
                reader.Read();
                while (reader.HasRows)
                {
                    q.quizid = Convert.ToInt32(reader["quiz_ID"].ToString());
                    q.classid = Convert.ToInt32(reader["class_ID"].ToString());
                    q.name = reader["quiz_name"].ToString();
                    q.path = reader["location"].ToString();
                    q.duedate = Convert.ToDateTime(reader["due_date"].ToString());
                    reader.Read();
                }
            }
            return q;
        }

        public int RemoveUser(User currentUser)
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

        public int CreateSubmission(Submission submission)
        {
            int results = 0;
            executeCommand(delegate (SQLiteCommand command)
            {
                command.CommandText =
                    "INSERT INTO scores(quiz_ID, class_ID, user_ID, score, submission_path) "
                    + "VALUES(" + "\"" + submission.quizid + "\",\"" + submission.classid + "\",\"" + submission.userid + "\",\"" + submission.score + "\",\"" + submission.path + "\");";

                results = command.ExecuteNonQuery();
            });
            return results;
        }

        public int GradeSubmission(int userid, int quizid, int grade)
        {
            int results = 0;
            executeCommand(delegate (SQLiteCommand command)
            {
                command.CommandText =
                    "UPDATE scores "
                    + "SET score = \"" + grade
                    + "\" WHERE quiz_ID = \"" + quizid 
                    + "\" AND user_ID = \"" + userid + "\";";

                results = command.ExecuteNonQuery();
            });
            return results;
        }

        public List<Submission> getSubmissionsForAssignment(int quizid)
        {
            List<Submission> rtnList = new List<Submission>();
            string command = "SELECT * FROM scores WHERE quiz_ID =\"" + quizid + "\";";
            using (SQLiteDataReader reader = retrieveCommands(command))
            {
                while (reader.HasRows)
                {
                    Submission newSubmission = parseSubmissionFromReader(reader);
                    if (newSubmission != null)
                    {
                        rtnList.Add(newSubmission);
                    }
                }
            }
            return rtnList;
        }

        public Submission getSubmissionForUserAndAssignment(int assignmentid, int userid)
        {
            string command = "SELECT * FROM scores WHERE quiz_ID =\"" + assignmentid + "\" AND user_ID =\"" + userid + "\";";
            using (SQLiteDataReader reader = retrieveCommands(command))
            {
                while (reader.HasRows)
                {
                    Submission newSubmission = parseSubmissionFromReader(reader);
                    if (newSubmission != null)
                    {
                        return newSubmission;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            return null;
        }

        public float getAvgGrade(User user, int classID)
        {
            string command = null;
            float average = 0;
            int numScores = 0;
            if (user.Role.ToString() == "Student")
            {
                command = "SELECT score FROM scores WHERE class_ID =" + classID + " AND user_ID = " + user.rowId + ";";
            }
            else
            {
                command = "SELECT score FROM scores WHERE class_ID =" + classID + ";";
            }
            using (SQLiteDataReader reader = retrieveCommands(command))
            {
                reader.Read();
                while (reader.HasRows)
                {
                    numScores++;
                    average = average + Convert.ToInt32(reader["score"].ToString());
                    reader.Read();
                }
            }
            return average / numScores;
        }

        public string getUserNameForSubmission(int userid)
        {
            string command = "SELECT * FROM users WHERE user_ID =\"" + userid + "\";";
            using (SQLiteDataReader reader = retrieveCommands(command))
            {
                while (reader.HasRows)
                {
                    User user = parseUserFromReader(reader);
                    if (user != null)
                    {
                        return user.Name;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            return null;
        }

        public User parseUserFromReader(SQLiteDataReader reader)
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

        public Submission parseSubmissionFromReader(SQLiteDataReader reader)
        {
            Submission sub = null;
            if (reader.HasRows)
            {
                try
                {
                    sub = new Submission();
                    reader.Read();
                    sub.quizid = Convert.ToInt32(reader["quiz_ID"].ToString());
                    sub.classid = Convert.ToInt32(reader["class_ID"].ToString());
                    sub.userid = Convert.ToInt32(reader["user_ID"].ToString());
                    sub.path = reader["submission_path"].ToString();
                    sub.score = reader["score"].ToString();
                }
                catch
                {
                    //bad reader. return null
                    return null;
                }
            }
            return sub;
        }

        private SQLiteDataReader retrieveCommands(string query)
        {
            SQLiteDataReader reader;
            SQLiteConnection database = new SQLiteConnection("Data Source = quizard.db");
            database.Open();

            SQLiteCommand command = new SQLiteCommand(query, database);
            reader = command.ExecuteReader();
            return reader;

        }

        public User loginCheck(string userName, string password)
        {
            User rtnUser = null;
            if (userName != null && password != null)
            {
                string command = "SELECT * FROM users WHERE email = '" + userName + "' AND password = '" + password + "';";
                using (SQLiteDataReader reader = retrieveCommands(command))
                {
                    rtnUser = parseUserFromReader(reader);
                }
            }
            return rtnUser;
        }

        public int buildDB()
        {
            int results = 0;
            string line;
            SQLiteConnection.CreateFile("quizard.db");
            StringReader file = new StringReader(Resources.buildDB);
            while ((line = file.ReadLine()) != null)
            {
                executeCommand(delegate (SQLiteCommand command)
                {
                    command.CommandText = line;
                    results += command.ExecuteNonQuery();
                });

            }
            return results;
        }
    }
}
