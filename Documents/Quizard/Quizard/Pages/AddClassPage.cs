using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quizard.Pages
{
    public partial class AddClassPage : UserControl
    {
        public event EventHandler<ClassArgs> finishedEvent;

        public AddClassPage()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (finishedEvent != null)
            {
                finishedEvent(null, null);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            if (finishedEvent != null)
            {
                finishedEvent(null, null);
            }
        }
    }

    public class ClassArgs : EventArgs
    {

    }
}
