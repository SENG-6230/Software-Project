using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quizard
{
    public partial class MainForm : Form
    {
        public bool Loaded
        {
            get
            {
                return loaded;
            }
        }
        bool loaded = false;

        public MainForm()
        {
            InitializeComponent();
            loaded = false;
        }
    }
}
