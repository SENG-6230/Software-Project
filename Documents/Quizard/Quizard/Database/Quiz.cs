using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizard
{
    public class Quiz
    {
        internal int rowId = -1;
        internal int quizid  { get; set; }
        internal int classid { get; set; }
        internal string name { get; set; }
        internal DateTime duedate { get; set; }
        internal string path { get; set; }

        public override string ToString()
        {
            return name;
        }
    }
}
