using NUnit.Framework;
using Quizard;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Quizard_UnitTests.DatabaseTests
{
    [TestFixture]
    public class ClassTests
    {
        public void GetALlClassesTest()
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

            List<Class> allClasses = db.GetAllClasses();

            Assert.DoesNotThrow(delegate
            {
                using (SQLiteConnection database = new System.Data.SQLite.SQLiteConnection("Data Source = quizard.db"))
                {
                    database.Open();
                    using (SQLiteCommand command = database.CreateCommand())
                    {
                        command.CommandText = "SELECT COUNT(*) FROM classes;";
                        Assert.Equals(command.ExecuteScalar(), allClasses.Count);
                    }
                }
            });
        }

        [Test]
        public void GetAllStudents()
        {

        }
    }
}
