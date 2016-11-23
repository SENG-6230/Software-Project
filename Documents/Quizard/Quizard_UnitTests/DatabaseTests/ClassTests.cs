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

        [Test]
        public void NegativeStudentsClassTest()
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

            List<User> students = db.GetAllUsers();
            Console.WriteLine("retrieved all students");
            Console.WriteLine("total users Count: " + students.Count);
            foreach (User student in students)
            {
                if (student.Role != UserTypes.Student)
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
                        Assert.IsFalse(found);
                        Console.WriteLine("Class does not contain the student");
                    }
                }
            }
        }

        [Test]
        public void GetAllSTAslassTest()
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

            List<User> tas = db.GetAllUsers(UserTypes.TeachingAssistant);
            Console.WriteLine("retrieved all TeachingAssistant");
            Console.WriteLine("total TeachingAssistant Count: " + tas.Count);
            foreach (User ta in tas)
            {
                Console.WriteLine("TeachingAssistant name: " + ta.Name);
                List<Class> classes = db.GetTAClasses(ta);
                Console.WriteLine("Retrieved all classes for TeachingAssistant");
                Console.WriteLine("Total class count: " + classes.Count);
                foreach (Class iClass in classes)
                {
                    Console.WriteLine("Testing class: " + iClass.Name);
                    bool found = false;
                    foreach (User cStud in iClass.AssistantTeachers)
                    {
                        if (cStud.rowId == ta.rowId)
                        {
                            found = true;
                        }
                    }
                    Assert.IsTrue(found);
                    Console.WriteLine("Class does contain the TeachingAssistant");
                }
            }
        }

        [Test]
        public void NegativetasClassTest()
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

            List<User> tas = db.GetAllUsers();
            Console.WriteLine("retrieved all TeachingAssistant");
            Console.WriteLine("total users Count: " + tas.Count);
            foreach (User ta in tas)
            {
                if (ta.Role != UserTypes.TeachingAssistant)
                {
                    Console.WriteLine("TeachingAssistant name: " + ta.Name);
                    List<Class> classes = db.GetTAClasses(ta);
                    Console.WriteLine("Retrieved all classes for TeachingAssistant");
                    Console.WriteLine("Total class count: " + classes.Count);
                    foreach (Class iClass in classes)
                    {
                        Console.WriteLine("TeachingAssistant class: " + iClass.Name);
                        bool found = false;
                        foreach (User cStud in iClass.AssistantTeachers)
                        {
                            if (cStud.rowId == ta.rowId)
                            {
                                found = true;
                            }
                        }
                        Assert.IsFalse(found);
                        Console.WriteLine("Class does not contain the TeachingAssistant");
                    }
                }
            }
        }

        [Test]
        public void NegativeTeachersClassTest()
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

            List<User> teachers = db.GetAllUsers();
            Console.WriteLine("retrieved all teachers");
            Console.WriteLine("total users Count: " + teachers.Count);
            foreach (User teacher in teachers)
            {
                if (teacher.Role != UserTypes.Teacher)
                {
                    Console.WriteLine("teacher name: " + teacher.Name);
                    List<Class> classes = db.GetTeachersClasses(teacher);
                    Console.WriteLine("Retrieved all classes for teacher");
                    Console.WriteLine("Total class count: " + classes.Count);
                    foreach (Class iClass in classes)
                    {
                        Assert.IsFalse(iClass.Teacher.rowId == teacher.rowId);
                        Console.WriteLine("Class does not contain the teacher");
                    }
                }
            }
        }
        
        [Test]
        public void GetAllTeachersClassTest()
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

            List<User> teachers = db.GetAllUsers(UserTypes.Teacher);
            Console.WriteLine("retrieved all students");
            Console.WriteLine("total users Count: " + teachers.Count);
            foreach (User teacher in teachers)
            {
                Console.WriteLine("teacher name: " + teacher.Name);
                List<Class> classes = db.GetTeachersClasses(teacher);
                Console.WriteLine("Retrieved all classes for teacher");
                Console.WriteLine("Total class count: " + classes.Count);
                foreach (Class iClass in classes)
                {
                    Assert.IsTrue(iClass.Teacher.rowId == teacher.rowId);
                    Console.WriteLine("Class does not contain the teacher");
                }
            }
        }

        [Test]
        public void NegativeDepartmentClassTest()
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

            List<User> dps = db.GetAllUsers();
            Console.WriteLine("retrieved all departmentHeads");
            Console.WriteLine("total users Count: " + dps.Count);
            foreach (User dp in dps)
            {
                if (dp.Role != UserTypes.DepartmentHead)
                {
                    Console.WriteLine("departmentHeads name: " + dp.Name);
                    List<Class> classes = db.GetDepartmentClasses(dp);
                    Console.WriteLine("Retrieved all classes for departmentHeads");
                    Console.WriteLine("Total class count: " + classes.Count);
                    foreach (Class iClass in classes)
                    {
                        Assert.IsFalse(iClass.DepartmentHead.rowId == dp.rowId);
                        Console.WriteLine("Class does not contain the departmentHeads");
                    }
                }
            }
        }

        [Test]
        public void GetAllDepartmentHeadsClassTest()
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

            List<User> dps = db.GetAllUsers(UserTypes.DepartmentHead);
            Console.WriteLine("retrieved all DepartmentHead");
            Console.WriteLine("total users Count: " + dps.Count);
            foreach (User dp in dps)
            {
                Console.WriteLine("departmentHead name: " + dp.Name);
                List<Class> classes = db.GetDepartmentClasses(dp);
                Console.WriteLine("Retrieved all classes for DepartmentHead");
                Console.WriteLine("Total class count: " + classes.Count);
                foreach (Class iClass in classes)
                {
                    Assert.IsTrue(iClass.DepartmentHead.rowId == dp.rowId);
                    Console.WriteLine("Class does not contain the DepartmentHead");
                }
            }
        }
    }
}
