using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizard
{
    internal interface QuizardPage
    {
        //This will go to a user object when we develop the database more
        void ShowPage(User user);
    }
}
