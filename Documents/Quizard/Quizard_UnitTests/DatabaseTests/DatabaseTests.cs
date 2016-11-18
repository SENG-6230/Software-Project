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
                Database.Open();
            });
        }

        public void BuildTest()
        {
            Assert.DoesNotThrow(delegate
            {
                QuizardDatabase Database = new QuizardDatabase();
                Database.Open();
                if (!File.Exists("quizard.db"))
                {
                    int x = Database.buildDB();
                    Assert.Equals(x, 0);
                }
            });
        }
    }
}
