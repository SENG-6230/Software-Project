using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizard
{
    public class Submission
    {
        public int rowId = -1;
        public int quizid { get; set; }
        public int classid { get; set; }
        public int userid { get; set; }
        public string path { get; set; }
        public string score { get; set; }

        public override string ToString()
        {
            return Program.Database.getUserNameForSubmission(userid);
        }
    }
}
