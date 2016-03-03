using System;
using System.Windows.Forms;
using WerWirdMillionaer.Properties;

namespace WerWirdMillionaer
{
    public partial class CreatorForm : Form
    {
        private bool _unsavedChange;

        public CreatorForm()
        {
            InitializeComponent();
        }

        private void CreatorForm_Load(object sender, EventArgs e)
        {
            gewinnstufenTableAdapter.Fill(qstnDBDataSet.Gewinnstufen);
            questionTableAdapter.Fill(qstnDBDataSet.Question);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveDatabase();
            MessageBox.Show(Resources.saved_db, Resources.message, MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void SaveDatabase()
        {
            Validate();
            questionBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(qstnDBDataSet);
            _unsavedChange = false;
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            new NewQuestionForm().ShowDialog(this);
        }

        private void questionDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var question = e.Row.Cells[1].Value;
            var confirm = MessageBox.Show(Resources.qstn_delete_confim + Environment.NewLine
                + Resources.quote + question + Resources.quote,
                    Resources.message, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                SaveDatabase();
            }
        }

        private void questionDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // determines if the error is the mysterious combobox from fk table data error occured
            if (e.Exception is ArgumentException && e.Exception.Message == "DataGridViewComboBoxCell value is not valid.")
            {
                // suppress DataError
            }
            else
            {
                MessageBox.Show(e + Environment.NewLine + e.Exception.Message);
            }
        }

        private void questionDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            _unsavedChange = true;
        }

        private void CreatorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_unsavedChange)
            {
                var res = MessageBox.Show("Ungespeicherte Änderung vorhanden. Wollen Sie diese speichern?",
                    Resources.message, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                switch (res)
                {
                    case DialogResult.Yes:
                        SaveDatabase();
                        break;
                    case DialogResult.No:
                        e.Cancel = false;
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                }
            }
        }
    }
}
