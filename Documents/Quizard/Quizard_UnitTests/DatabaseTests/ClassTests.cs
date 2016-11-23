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
        public void GetAllStudentsClassTest()
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

            List<User> students = db.GetAllUsers(UserTypes.Student);
            Console.WriteLine("retrieved all students");
            Console.WriteLine("total StudentsCount: " + students.Count);
            foreach (User student in students)
            {
                Console.WriteLine("student name: " + student.Name);
                List<Class> classes = db.GetStudentsClasses(student);
                Console.WriteLine("Retrieved all classes for student");
                Console.WriteLine("Total class count: " + classes.Count);
                foreach (Class iClass in classes)
                {
                    Console.WriteLine("Testing class: " + iClass.Name);
                    bool found = false;
                    foreach (User cStud in iClass.Students)
                    {
                        if (cStud.rowId == student.rowId)
                        {
                            found = true;
                        }
                    }
                    Assert.IsTrue(found);
                    Console.WriteLine("Class does contain the student");
                }
            }
        }
    }
}
