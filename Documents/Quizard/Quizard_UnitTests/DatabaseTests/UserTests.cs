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
                    Assert.Equals(x, 0);
                }
            });

            List<User> allCUsers = db.GetAllUsers();

            Assert.DoesNotThrow(delegate
            {
                using (SQLiteConnection database = new SQLiteConnection("Data Source = quizard.db"))
                {
                    database.Open();
                    using (SQLiteCommand command = database.CreateCommand())
                    {
                        command.CommandText = "SELECT COUNT(*) FROM users;";
                        Assert.Equals(command.ExecuteScalar(), allCUsers.Count);
                    }
                }
            });
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
                    Assert.Equals(x, 0);
                }
                users = db.GetAllUsers(UserTypes.Teacher);
            });

            Assert.IsNotNull(users);
            foreach (User user in users)
            {
                Assert.Equals(UserTypes.Teacher, user.Role);
            }
        }
    }
}
