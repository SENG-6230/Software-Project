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
    public class AssignmentTests
    {
        [Test]
        public void GetAllAssignmentsTest()
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

            List<Class> classes = db.GetAllClasses();
            Console.WriteLine("Retrieved All Classes");
            Console.WriteLine("Total Class count: " + classes.Count);
            foreach (Class iClass in classes)
            {
                Console.WriteLine("CLass Name: " + iClass.Name);
                List<string> names = db.getAssignments(iClass.rowId);
                Console.WriteLine("Total Names count for " + iClass.Name + ": " + names.Count);

                using (SQLiteConnection database = new SQLiteConnection("Data Source = quizard.db"))
                {
                    database.Open();
                    using (SQLiteCommand command = database.CreateCommand())
                    {
                        command.CommandText = "SELECT COUNT(*) FROM quizzes WHERE class_ID = " + iClass.rowId + ";";
                        Console.WriteLine("SELECT COUNT(*) FROM quizzes WHERE class_ID = " + iClass.rowId + ";");
                        long allUassignmentsCount = (long)command.ExecuteScalar();
                        Console.WriteLine("current user count: " + allUassignmentsCount);
                        Assert.AreEqual(names.Count, allUassignmentsCount);
                        Console.WriteLine("Counts match with " + allUassignmentsCount);
                    }
                }
            }
        }
    }
}
