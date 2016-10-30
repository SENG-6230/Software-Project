using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizard
{
    class Quiz
    {
        internal int rowId = -1;
        private int quizid  { get; set; }
        private int classid { get; set; }
        private string name { get; set; }
        private DateTime duedate { get; set; }
        private string path { get; set; }
    }
}
