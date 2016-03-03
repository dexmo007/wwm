using System;
using System.Windows.Forms;

namespace WerWirdMillionaer
{
    public partial class NewQuestionForm : Form
    {
        public NewQuestionForm()
        {
            InitializeComponent();
        }

        private void NewQuestionForm_Load(object sender, EventArgs e)
        {
//            questionTableAdapter.Fill(qstnDBDataSet.Question);
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            Validate();
            questionTableAdapter.Insert(question_textTextBox.Text, correct_answerTextBox.Text, false_answer1TextBox.Text,
                false_answer2TextBox.Text, false_answer3TextBox.Text, int.Parse(gewinnstufeTextBox.Text));
            questionBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(qstnDBDataSet);
            // update the data grid view
            var gridTable = ((CreatorForm) Owner).qstnDBDataSet.Question;
            questionTableAdapter.Fill(gridTable);
            Close();
        }
    }
}
