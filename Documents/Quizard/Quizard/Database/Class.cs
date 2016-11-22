using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizard
{
    public class Class
    {
        public int rowId = -1;
        public string Name;
        public string number;
        public User Teacher;
        public User DepartmentHead;
        public List<User> AssistantTeachers;
        public List<User> Students;
        public List<string> Assignments;
    }
}
