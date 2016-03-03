namespace WerWirdMillionaer
{
    partial class NewQuestionForm
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
            System.Windows.Forms.Label question_textLabel;
            System.Windows.Forms.Label correct_answerLabel;
            System.Windows.Forms.Label false_answer1Label;
            System.Windows.Forms.Label false_answer2Label;
            System.Windows.Forms.Label false_answer3Label;
            System.Windows.Forms.Label gewinnstufeLabel;
            this.qstnDBDataSet = new WerWirdMillionaer.qstnDBDataSet();
            this.questionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.questionTableAdapter = new WerWirdMillionaer.qstnDBDataSetTableAdapters.QuestionTableAdapter();
            this.tableAdapterManager = new WerWirdMillionaer.qstnDBDataSetTableAdapters.TableAdapterManager();
            this.question_textTextBox = new System.Windows.Forms.TextBox();
            this.correct_answerTextBox = new System.Windows.Forms.TextBox();
            this.false_answer1TextBox = new System.Windows.Forms.TextBox();
            this.false_answer2TextBox = new System.Windows.Forms.TextBox();
            this.false_answer3TextBox = new System.Windows.Forms.TextBox();
            this.gewinnstufeTextBox = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            question_textLabel = new System.Windows.Forms.Label();
            correct_answerLabel = new System.Windows.Forms.Label();
            false_answer1Label = new System.Windows.Forms.Label();
            false_answer2Label = new System.Windows.Forms.Label();
            false_answer3Label = new System.Windows.Forms.Label();
            gewinnstufeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qstnDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingSource)).BeginInit();
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
            // question_textLabel
            // 
            question_textLabel.AutoSize = true;
            question_textLabel.Location = new System.Drawing.Point(33, 58);
            question_textLabel.Name = "question_textLabel";
            question_textLabel.Size = new System.Drawing.Size(70, 13);
            question_textLabel.TabIndex = 3;
            question_textLabel.Text = "question text:";
            // 
            // question_textTextBox
            // 
            this.question_textTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.questionBindingSource, "question_text", true));
            this.question_textTextBox.Location = new System.Drawing.Point(119, 55);
            this.question_textTextBox.Name = "question_textTextBox";
            this.question_textTextBox.Size = new System.Drawing.Size(100, 20);
            this.question_textTextBox.TabIndex = 4;
            // 
            // correct_answerLabel
            // 
            correct_answerLabel.AutoSize = true;
            correct_answerLabel.Location = new System.Drawing.Point(33, 84);
            correct_answerLabel.Name = "correct_answerLabel";
            correct_answerLabel.Size = new System.Drawing.Size(80, 13);
            correct_answerLabel.TabIndex = 5;
            correct_answerLabel.Text = "correct answer:";
            // 
            // correct_answerTextBox
            // 
            this.correct_answerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.questionBindingSource, "correct_answer", true));
            this.correct_answerTextBox.Location = new System.Drawing.Point(119, 81);
            this.correct_answerTextBox.Name = "correct_answerTextBox";
            this.correct_answerTextBox.Size = new System.Drawing.Size(100, 20);
            this.correct_answerTextBox.TabIndex = 6;
            // 
            // false_answer1Label
            // 
            false_answer1Label.AutoSize = true;
            false_answer1Label.Location = new System.Drawing.Point(33, 110);
            false_answer1Label.Name = "false_answer1Label";
            false_answer1Label.Size = new System.Drawing.Size(75, 13);
            false_answer1Label.TabIndex = 7;
            false_answer1Label.Text = "false answer1:";
            // 
            // false_answer1TextBox
            // 
            this.false_answer1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.questionBindingSource, "false_answer1", true));
            this.false_answer1TextBox.Location = new System.Drawing.Point(119, 107);
            this.false_answer1TextBox.Name = "false_answer1TextBox";
            this.false_answer1TextBox.Size = new System.Drawing.Size(100, 20);
            this.false_answer1TextBox.TabIndex = 8;
            // 
            // false_answer2Label
            // 
            false_answer2Label.AutoSize = true;
            false_answer2Label.Location = new System.Drawing.Point(33, 136);
            false_answer2Label.Name = "false_answer2Label";
            false_answer2Label.Size = new System.Drawing.Size(75, 13);
            false_answer2Label.TabIndex = 9;
            false_answer2Label.Text = "false answer2:";
            // 
            // false_answer2TextBox
            // 
            this.false_answer2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.questionBindingSource, "false_answer2", true));
            this.false_answer2TextBox.Location = new System.Drawing.Point(119, 133);
            this.false_answer2TextBox.Name = "false_answer2TextBox";
            this.false_answer2TextBox.Size = new System.Drawing.Size(100, 20);
            this.false_answer2TextBox.TabIndex = 10;
            // 
            // false_answer3Label
            // 
            false_answer3Label.AutoSize = true;
            false_answer3Label.Location = new System.Drawing.Point(33, 162);
            false_answer3Label.Name = "false_answer3Label";
            false_answer3Label.Size = new System.Drawing.Size(75, 13);
            false_answer3Label.TabIndex = 11;
            false_answer3Label.Text = "false answer3:";
            // 
            // false_answer3TextBox
            // 
            this.false_answer3TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.questionBindingSource, "false_answer3", true));
            this.false_answer3TextBox.Location = new System.Drawing.Point(119, 159);
            this.false_answer3TextBox.Name = "false_answer3TextBox";
            this.false_answer3TextBox.Size = new System.Drawing.Size(100, 20);
            this.false_answer3TextBox.TabIndex = 12;
            // 
            // gewinnstufeLabel
            // 
            gewinnstufeLabel.AutoSize = true;
            gewinnstufeLabel.Location = new System.Drawing.Point(33, 188);
            gewinnstufeLabel.Name = "gewinnstufeLabel";
            gewinnstufeLabel.Size = new System.Drawing.Size(67, 13);
            gewinnstufeLabel.TabIndex = 13;
            gewinnstufeLabel.Text = "gewinnstufe:";
            // 
            // gewinnstufeTextBox
            // 
            this.gewinnstufeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.questionBindingSource, "gewinnstufe", true));
            this.gewinnstufeTextBox.Location = new System.Drawing.Point(119, 185);
            this.gewinnstufeTextBox.Name = "gewinnstufeTextBox";
            this.gewinnstufeTextBox.Size = new System.Drawing.Size(100, 20);
            this.gewinnstufeTextBox.TabIndex = 14;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(119, 227);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 15;
            this.createButton.Text = "Erstellen";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // NewQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 293);
            this.Controls.Add(this.createButton);
            this.Controls.Add(question_textLabel);
            this.Controls.Add(this.question_textTextBox);
            this.Controls.Add(correct_answerLabel);
            this.Controls.Add(this.correct_answerTextBox);
            this.Controls.Add(false_answer1Label);
            this.Controls.Add(this.false_answer1TextBox);
            this.Controls.Add(false_answer2Label);
            this.Controls.Add(this.false_answer2TextBox);
            this.Controls.Add(false_answer3Label);
            this.Controls.Add(this.false_answer3TextBox);
            this.Controls.Add(gewinnstufeLabel);
            this.Controls.Add(this.gewinnstufeTextBox);
            this.Name = "NewQuestionForm";
            this.Text = "NewQuestionForm";
            this.Load += new System.EventHandler(this.NewQuestionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qstnDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private qstnDBDataSet qstnDBDataSet;
        private System.Windows.Forms.BindingSource questionBindingSource;
        private qstnDBDataSetTableAdapters.QuestionTableAdapter questionTableAdapter;
        private qstnDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox question_textTextBox;
        private System.Windows.Forms.TextBox correct_answerTextBox;
        private System.Windows.Forms.TextBox false_answer1TextBox;
        private System.Windows.Forms.TextBox false_answer2TextBox;
        private System.Windows.Forms.TextBox false_answer3TextBox;
        private System.Windows.Forms.TextBox gewinnstufeTextBox;
        private System.Windows.Forms.Button createButton;
    }
}