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
        [Test]
        public void GetAllClassesTest()
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

            List<Class> allClasses = db.GetAllClasses();
            Console.WriteLine("Query successful");

            Console.WriteLine("Class count = " + allClasses.Count);
            Assert.DoesNotThrow(delegate
            {
                using (SQLiteConnection database = new System.Data.SQLite.SQLiteConnection("Data Source = quizard.db"))
                {
                    database.Open();
                    using (SQLiteCommand command = database.CreateCommand())
                    {
                        Console.WriteLine("SELECT COUNT(*) FROM classes;");
                        command.CommandText = "SELECT COUNT(*) FROM classes;";
                        Assert.AreEqual(command.ExecuteScalar(), allClasses.Count);

                        Console.WriteLine("Count was equal");
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
