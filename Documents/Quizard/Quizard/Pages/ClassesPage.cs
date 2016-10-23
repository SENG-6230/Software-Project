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
            addClassPage.finishedEvent += addClassFInishedHandler;
        }

        private void addClassFInishedHandler(object sender, ClassArgs e)
        {
            classInfoPanel.Visible = true;
            addClassPage.Visible = false;
            addClassBtn.Visible = true;
        }

        private void addClassBtn_Click(object sender, EventArgs e)
        {
            classInfoPanel.Visible = false;
            addClassPage.Visible = true;
            addClassBtn.Visible = false;
            classInfoPanel.Visible = false;
        }

        private void addAssignmentBtn_Click(object sender, EventArgs e)
        {
            AssignmentForm form = AssignmentForm.uploadAssignmentForm();
            form.Show();
        }

        private void assignmentsBx_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.assignmentsBx.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                AssignmentForm form = AssignmentForm.studentAssignmentForm(0);
                form.Show();
            }
        }
    }
}
