﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizard
{
    public class Class
    {
        internal int rowId = -1;
        internal string Name;
        internal string number;
        internal User Teacher;
        internal User DepartmentHead;
        internal List<User> AssistantTeachers;
        internal List<User> Students;
        internal List<string> Assignments;
    }
}
