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
    public partial class ClassesPage : UserControl
    {
        public ClassesPage()
        {
            InitializeComponent();

            addClassPage.Visible = false;
        }

        private void addClassBtn_Click(object sender, EventArgs e)
        {
            classInfoPanel.Visible = false;
            addClassPage.Visible = true;
            addClassBtn.Visible = false;
        }
    }
}
