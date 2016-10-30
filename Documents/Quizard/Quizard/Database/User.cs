using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizard
{
    public class User
    {
        internal int rowId = -1;
        internal string Email;
        internal string Password;
        internal UserTypes Role;
        internal string Name;

        public override string ToString()
        {
            return Name;
        }
    }
}
