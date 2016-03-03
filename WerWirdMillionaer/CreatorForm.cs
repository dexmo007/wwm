using System;
using System.Windows.Forms;

namespace WerWirdMillionaer
{
    public partial class CreatorForm : Form
    {
        public CreatorForm()
        {
            InitializeComponent();
        }

        private void questionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            questionBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(qstnDBDataSet);

        }

        private void CreatorForm_Load(object sender, EventArgs e)
        {
            questionTableAdapter.Fill(qstnDBDataSet.Question);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Validate();
            questionBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(qstnDBDataSet);
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            var res = new NewQuestionForm().ShowDialog(this);
        }
    }
}
