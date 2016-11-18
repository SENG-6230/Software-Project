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
        public string Email;
        public string Password;
        public UserTypes Role;
        public string Name;

        public override string ToString()
        {
            return Name;
        }
    }
}
