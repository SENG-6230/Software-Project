using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quizard
{
    public partial class GradeForm : Form
    {
        private int id;
        private Submission selectedSubmission;

        public GradeForm(int id)
        {
            InitializeComponent();
            this.id = id;
            List<Submission> submissions = Program.Database.getSubmissionsForAssignment(id);
            foreach(Submission s in submissions)
            {
                listBoxSubmissions.Items.Add(s);
            }
            listBoxSubmissions.SetSelected(0, true);
            selectedSubmission = (Submission)listBoxSubmissions.SelectedItem;
            lblName.Text = listBoxSubmissions.GetItemText(listBoxSubmissions.SelectedItem);
        }

        private void listBoxSubmissions_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedSubmission = (Submission)listBoxSubmissions.SelectedItem;
            lblName.Text = listBoxSubmissions.GetItemText(listBoxSubmissions.SelectedItem);
            txtGrade.Text = selectedSubmission.score;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           Program.Database.GradeSubmission(selectedSubmission.userid, selectedSubmission.quizid, Convert.ToInt32(txtGrade.Text));
            List<Submission> submissions = Program.Database.getSubmissionsForAssignment(id);
            listBoxSubmissions.Items.Clear();
            foreach (Submission s in submissions)
            {
                listBoxSubmissions.Items.Add(s);
            }
            MessageBox.Show("Submission Graded!");
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK)
            {
                string file = save.FileName.ToString();
                File.Copy(selectedSubmission.path, file, true);
                MessageBox.Show("File saved as " + file);
            }
        }
    }
}
