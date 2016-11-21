using NUnit.Framework;
using Quizard;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizard_UnitTests.DatabaseTests
{
    [TestFixture]
    public class UserTests
    {
        [Test]
        public void GetALlUsersTest()
        {
            QuizardDatabase db = null;
            Assert.DoesNotThrow(delegate
            {
                db = new QuizardDatabase();
                db.Open();
                if (!File.Exists("quizard.db"))
                {
                    int x = db.buildDB();
                    Assert.AreEqual(x, 0);
                }
            });
            Console.WriteLine("Database created");

            List<User> allCUsers = db.GetAllUsers();
            Console.WriteLine("users count  = " + allCUsers.Count);

            //Assert.DoesNotThrow(delegate
            //{
            using (SQLiteConnection database = new SQLiteConnection("Data Source = quizard.db"))
            {
                database.Open();
                using (SQLiteCommand command = database.CreateCommand())
                {
                    command.CommandText = "SELECT COUNT(*) FROM users;";
                    Console.WriteLine("SELECT COUNT(*) FROM users;");
                    Assert.AreEqual(command.ExecuteScalar(), allCUsers.Count);
                    Console.WriteLine("counts are equal!");
                }
            }
            //});
        }

        [Test]
        public void EnsureAdministratorsTest()
        {
            List<User> users = null;
            Assert.DoesNotThrow(delegate
            {
                QuizardDatabase db = new QuizardDatabase();
                db.Open();
                if (!File.Exists("quizard.db"))
                {
                    int x = db.buildDB();
                    Assert.AreEqual(x, 0);
                }
                Console.WriteLine("database created");
                users = db.GetAllUsers(UserTypes.Administrator);
                Console.WriteLine("all Administrator count = " + users.Count);
            });

            Assert.IsNotNull(users);
            foreach (User user in users)
            {
                Console.WriteLine("Testing " + user.Name);
                Assert.AreEqual(UserTypes.Administrator, user.Role);
                Console.WriteLine(user.Name + " is an Administrator");
            }
        }

        [Test]
        public void EnsureDepartmentHeadTest()
        {
            List<User> users = null;
            Assert.DoesNotThrow(delegate
            {
                QuizardDatabase db = new QuizardDatabase();
                db.Open();
                if (!File.Exists("quizard.db"))
                {
                    int x = db.buildDB();
                    Assert.AreEqual(x, 0);
                }
                Console.WriteLine("database created");
                users = db.GetAllUsers(UserTypes.DepartmentHead);
                Console.WriteLine("all DepartmentHead count = " + users.Count);
            });

            Assert.IsNotNull(users);
            foreach (User user in users)
            {
                Console.WriteLine("Testing " + user.Name);
                Assert.AreEqual(UserTypes.DepartmentHead, user.Role);
                Console.WriteLine(user.Name + " is a DepartmentHead");
            }
        }

        [Test]
        public void EnsureStudentsTest()
        {
            List<User> users = null;
            Assert.DoesNotThrow(delegate
            {
                QuizardDatabase db = new QuizardDatabase();
                db.Open();
                if (!File.Exists("quizard.db"))
                {
                    int x = db.buildDB();
                    Assert.AreEqual(x, 0);
                }
                Console.WriteLine("database created");
                users = db.GetAllUsers(UserTypes.Student);
                Console.WriteLine("all Student count = " + users.Count);
            });

            Assert.IsNotNull(users);
            foreach (User user in users)
            {
                Console.WriteLine("Testing " + user.Name);
                Assert.AreEqual(UserTypes.Student, user.Role);
                Console.WriteLine(user.Name + " is a Student");
            }
        }

        [Test]
        public void EnsureTeachersTest()
        {
            List<User> users = null;
            Assert.DoesNotThrow(delegate
            {
                QuizardDatabase db = new QuizardDatabase();
                db.Open();
                if (!File.Exists("quizard.db"))
                {
                    int x = db.buildDB();
                    Assert.AreEqual(x, 0);
                }
                Console.WriteLine("database created");
                users = db.GetAllUsers(UserTypes.Teacher);
                Console.WriteLine("all teacher count = " + users.Count);
            });

            Assert.IsNotNull(users);
            foreach (User user in users)
            {
                Console.WriteLine("Testing " + user.Name);
                Assert.AreEqual(UserTypes.Teacher, user.Role);
                Console.WriteLine(user.Name + " is a teacher");
            }
        }

        [Test]
        public void EnsureTeachingAssistantsTest()
        {
            List<User> users = null;
            Assert.DoesNotThrow(delegate
            {
                QuizardDatabase db = new QuizardDatabase();
                db.Open();
                if (!File.Exists("quizard.db"))
                {
                    int x = db.buildDB();
                    Assert.AreEqual(x, 0);
                }
                Console.WriteLine("database created");
                users = db.GetAllUsers(UserTypes.TeachingAssistant);
                Console.WriteLine("all TeachingAssistant count = " + users.Count);
            });

            Assert.IsNotNull(users);
            foreach (User user in users)
            {
                Console.WriteLine("Testing " + user.Name);
                Assert.AreEqual(UserTypes.TeachingAssistant, user.Role);
                Console.WriteLine(user.Name + " is a TeachingAssistant");
            }
        }
    }
}
