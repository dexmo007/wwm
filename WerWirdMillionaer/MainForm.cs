using System;
using System.Windows.Forms;

namespace WerWirdMillionaer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void fragenDurchsuchenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CreatorForm().Show(this);
        }
    }
}
