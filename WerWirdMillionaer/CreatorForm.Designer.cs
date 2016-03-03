namespace WerWirdMillionaer
{
    partial class CreatorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.qstnDBDataSet = new WerWirdMillionaer.qstnDBDataSet();
            this.questionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.questionTableAdapter = new WerWirdMillionaer.qstnDBDataSetTableAdapters.QuestionTableAdapter();
            this.tableAdapterManager = new WerWirdMillionaer.qstnDBDataSetTableAdapters.TableAdapterManager();
            this.questionDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.gewinnstufenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saveButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.gewinnstufenTableAdapter = new WerWirdMillionaer.qstnDBDataSetTableAdapters.GewinnstufenTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.qstnDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gewinnstufenBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // qstnDBDataSet
            // 
            this.qstnDBDataSet.DataSetName = "qstnDBDataSet";
            this.qstnDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // questionBindingSource
            // 
            this.questionBindingSource.DataMember = "Question";
            this.questionBindingSource.DataSource = this.qstnDBDataSet;
            // 
            // questionTableAdapter
            // 
            this.questionTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GewinnstufenTableAdapter = null;
            this.tableAdapterManager.PrioritiesTableAdapter = null;
            this.tableAdapterManager.QuestionTableAdapter = this.questionTableAdapter;
            this.tableAdapterManager.UpdateOrder = WerWirdMillionaer.qstnDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // questionDataGridView
            // 
            this.questionDataGridView.AllowUserToAddRows = false;
            this.questionDataGridView.AutoGenerateColumns = false;
            this.questionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.questionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.questionDataGridView.DataSource = this.questionBindingSource;
            this.questionDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.questionDataGridView.Location = new System.Drawing.Point(0, 0);
            this.questionDataGridView.Name = "questionDataGridView";
            this.questionDataGridView.Size = new System.Drawing.Size(1129, 419);
            this.questionDataGridView.TabIndex = 1;
            this.questionDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.questionDataGridView_CellEndEdit);
            this.questionDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.questionDataGridView_DataError);
            this.questionDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.questionDataGridView_UserDeletingRow);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "question_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "question_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "question_text";
            this.dataGridViewTextBoxColumn2.HeaderText = "Frage";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 59;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "correct_answer";
            this.dataGridViewTextBoxColumn3.HeaderText = "Richtige Antwort";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 101;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "false_answer1";
            this.dataGridViewTextBoxColumn4.HeaderText = "1. Falsche Antwort";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 110;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "false_answer2";
            this.dataGridViewTextBoxColumn5.HeaderText = "2. Falsche Antwort";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 110;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "false_answer3";
            this.dataGridViewTextBoxColumn6.HeaderText = "3. Falsche Antwort";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 110;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "gewinnstufe";
            this.dataGridViewTextBoxColumn7.DataSource = this.gewinnstufenBindingSource;
            this.dataGridViewTextBoxColumn7.DisplayMember = "gewinnstufe_euro";
            this.dataGridViewTextBoxColumn7.HeaderText = "Gewinnstufe";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn7.ValueMember = "gewinnstufe_id";
            this.dataGridViewTextBoxColumn7.Width = 91;
            // 
            // gewinnstufenBindingSource
            // 
            this.gewinnstufenBindingSource.DataMember = "Gewinnstufen";
            this.gewinnstufenBindingSource.DataSource = this.qstnDBDataSet;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(108, 442);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Speichern";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(12, 442);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(75, 23);
            this.newButton.TabIndex = 3;
            this.newButton.Text = "Neue Frage";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // gewinnstufenTableAdapter
            // 
            this.gewinnstufenTableAdapter.ClearBeforeFill = true;
            // 
            // CreatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 483);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.questionDataGridView);
            this.Name = "CreatorForm";
            this.Text = "Fragen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreatorForm_FormClosing);
            this.Load += new System.EventHandler(this.CreatorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qstnDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gewinnstufenBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource questionBindingSource;
        private qstnDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView questionDataGridView;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button newButton;
        internal qstnDBDataSetTableAdapters.QuestionTableAdapter questionTableAdapter;
        internal qstnDBDataSet qstnDBDataSet;
        private System.Windows.Forms.BindingSource gewinnstufenBindingSource;
        private qstnDBDataSetTableAdapters.GewinnstufenTableAdapter gewinnstufenTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn7;
    }
}