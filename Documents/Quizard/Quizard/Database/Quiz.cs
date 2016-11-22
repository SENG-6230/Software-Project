using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizard
{
    public class Quiz
    {
        public int rowId = -1;
        public int quizid  { get; set; }
        public int classid { get; set; }
        public string name { get; set; }
        public DateTime duedate { get; set; }
        public string path { get; set; }

        public override string ToString()
        {
            return name;
        }
    }
}
