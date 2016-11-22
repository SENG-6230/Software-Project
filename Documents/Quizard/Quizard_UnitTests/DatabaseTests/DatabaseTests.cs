using NUnit.Framework;
using Quizard;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizard_UnitTests.DatabaseTests
{
    [TestFixture]
    public class DatabaseTests
    {
        [Test]
        public void OpenTest()
        {
            Assert.DoesNotThrow(delegate
            {
                QuizardDatabase Database = new QuizardDatabase();
                Console.WriteLine("DB instatiated");
                Database.Open();
                Console.WriteLine("DB opened");
            });
        }

        [Test]
        public void BuildTest()
        {
            Assert.DoesNotThrow(delegate
            {
                QuizardDatabase Database = new QuizardDatabase();
                Database.Open();
                Console.WriteLine("DB opened");
                if (File.Exists("quizard.db"))
                {
                    File.Delete("quizard.db");
                    Console.WriteLine("DB deleted");
                }
                int x = Database.buildDB();
                Console.WriteLine("DB built");
                Assert.Greater(x, 0);
                Assert.IsTrue(File.Exists("quizard.db"));
                Console.WriteLine("DB built correctly");
            });
        }
    }
}
