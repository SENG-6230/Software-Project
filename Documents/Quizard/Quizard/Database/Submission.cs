using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizard
{
    public class Submission
    {
        internal int rowId = -1;
        internal int quizid { get; set; }
        internal int classid { get; set; }
        internal int userid { get; set; }
        internal string path { get; set; }
        internal string score { get; set; }

        public override string ToString()
        {
            return Program.Database.getUserNameForSubmission(userid);
        }
    }
}
