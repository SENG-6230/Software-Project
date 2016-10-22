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
            OpenFileDialog fileChooser = new OpenFileDialog();
            fileChooser.Title = "Select Assignment to Upload";
            fileChooser.InitialDirectory = @"C:\";
            fileChooser.CheckFileExists = true;
            DialogResult result = fileChooser.ShowDialog();
            if (result == DialogResult.OK)
            {
                // This just adds the name of the selected file to the assignments ListBox.
                // WHen the database is created, this will update the database and the
                // Assignments ListBox will pull from the database
                string file = fileChooser.FileName;
                MessageBox.Show("Assignment Successfully Uploaded");
                assignmentsBx.Items.Add(file);
            }
        }

        private void assignmentsBx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
