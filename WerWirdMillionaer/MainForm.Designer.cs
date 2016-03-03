namespace WerWirdMillionaer
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuesSpielToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fragenImportierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frageErstellenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fragenDurchsuchenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.steuerungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jokerZurücksetzenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.publikumsjokerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telefonjokerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zusatzjokerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.überToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qstnDBDataSet = new WerWirdMillionaer.qstnDBDataSet();
            this.questionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.questionTableAdapter = new WerWirdMillionaer.qstnDBDataSetTableAdapters.QuestionTableAdapter();
            this.tableAdapterManager = new WerWirdMillionaer.qstnDBDataSetTableAdapters.TableAdapterManager();
            this.gewinnstufenTableAdapter = new WerWirdMillionaer.qstnDBDataSetTableAdapters.GewinnstufenTableAdapter();
            this.prioritiesTableAdapter = new WerWirdMillionaer.qstnDBDataSetTableAdapters.PrioritiesTableAdapter();
            this.gewinnstufenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKPrioritiesQuestionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKPrioritiesQuestionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qstnDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gewinnstufenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPrioritiesQuestionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPrioritiesQuestionBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.steuerungToolStripMenuItem,
            this.hilfeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1006, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuesSpielToolStripMenuItem,
            this.fragenImportierenToolStripMenuItem,
            this.frageErstellenToolStripMenuItem,
            this.fragenDurchsuchenToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.fileToolStripMenuItem.Text = "Start";
            // 
            // neuesSpielToolStripMenuItem
            // 
            this.neuesSpielToolStripMenuItem.Name = "neuesSpielToolStripMenuItem";
            this.neuesSpielToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.neuesSpielToolStripMenuItem.Text = "Neues Spiel";
            // 
            // fragenImportierenToolStripMenuItem
            // 
            this.fragenImportierenToolStripMenuItem.Name = "fragenImportierenToolStripMenuItem";
            this.fragenImportierenToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.fragenImportierenToolStripMenuItem.Text = "Fragen importieren";
            // 
            // frageErstellenToolStripMenuItem
            // 
            this.frageErstellenToolStripMenuItem.Name = "frageErstellenToolStripMenuItem";
            this.frageErstellenToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.frageErstellenToolStripMenuItem.Text = "Frage erstellen";
            // 
            // fragenDurchsuchenToolStripMenuItem
            // 
            this.fragenDurchsuchenToolStripMenuItem.Name = "fragenDurchsuchenToolStripMenuItem";
            this.fragenDurchsuchenToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.fragenDurchsuchenToolStripMenuItem.Text = "Fragen durchsuchen";
            this.fragenDurchsuchenToolStripMenuItem.Click += new System.EventHandler(this.fragenDurchsuchenToolStripMenuItem_Click);
            // 
            // steuerungToolStripMenuItem
            // 
            this.steuerungToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jokerZurücksetzenToolStripMenuItem});
            this.steuerungToolStripMenuItem.Name = "steuerungToolStripMenuItem";
            this.steuerungToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.steuerungToolStripMenuItem.Text = "Steuerung";
            // 
            // jokerZurücksetzenToolStripMenuItem
            // 
            this.jokerZurücksetzenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.publikumsjokerToolStripMenuItem,
            this.telefonjokerToolStripMenuItem,
            this.zusatzjokerToolStripMenuItem});
            this.jokerZurücksetzenToolStripMenuItem.Name = "jokerZurücksetzenToolStripMenuItem";
            this.jokerZurücksetzenToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.jokerZurücksetzenToolStripMenuItem.Text = "Joker zurücksetzen";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(156, 22);
            this.toolStripMenuItem2.Text = "50:50";
            // 
            // publikumsjokerToolStripMenuItem
            // 
            this.publikumsjokerToolStripMenuItem.Name = "publikumsjokerToolStripMenuItem";
            this.publikumsjokerToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.publikumsjokerToolStripMenuItem.Text = "Publikumsjoker";
            // 
            // telefonjokerToolStripMenuItem
            // 
            this.telefonjokerToolStripMenuItem.Name = "telefonjokerToolStripMenuItem";
            this.telefonjokerToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.telefonjokerToolStripMenuItem.Text = "Telefonjoker";
            // 
            // zusatzjokerToolStripMenuItem
            // 
            this.zusatzjokerToolStripMenuItem.Name = "zusatzjokerToolStripMenuItem";
            this.zusatzjokerToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.zusatzjokerToolStripMenuItem.Text = "Zusatzjoker";
            // 
            // hilfeToolStripMenuItem
            // 
            this.hilfeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.überToolStripMenuItem});
            this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            this.hilfeToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.hilfeToolStripMenuItem.Text = "Hilfe";
            // 
            // überToolStripMenuItem
            // 
            this.überToolStripMenuItem.Name = "überToolStripMenuItem";
            this.überToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.überToolStripMenuItem.Text = "Über";
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
            this.tableAdapterManager.GewinnstufenTableAdapter = this.gewinnstufenTableAdapter;
            this.tableAdapterManager.PrioritiesTableAdapter = this.prioritiesTableAdapter;
            this.tableAdapterManager.QuestionTableAdapter = this.questionTableAdapter;
            this.tableAdapterManager.UpdateOrder = WerWirdMillionaer.qstnDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gewinnstufenTableAdapter
            // 
            this.gewinnstufenTableAdapter.ClearBeforeFill = true;
            // 
            // prioritiesTableAdapter
            // 
            this.prioritiesTableAdapter.ClearBeforeFill = true;
            // 
            // gewinnstufenBindingSource
            // 
            this.gewinnstufenBindingSource.DataMember = "Gewinnstufen";
            this.gewinnstufenBindingSource.DataSource = this.qstnDBDataSet;
            // 
            // fKPrioritiesQuestionBindingSource
            // 
            this.fKPrioritiesQuestionBindingSource.DataMember = "FK_Priorities_Question";
            this.fKPrioritiesQuestionBindingSource.DataSource = this.questionBindingSource;
            // 
            // fKPrioritiesQuestionBindingSource1
            // 
            this.fKPrioritiesQuestionBindingSource1.DataMember = "FK_Priorities_Question";
            this.fKPrioritiesQuestionBindingSource1.DataSource = this.questionBindingSource;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 626);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Wer wird Millionär?";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qstnDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gewinnstufenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPrioritiesQuestionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPrioritiesQuestionBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neuesSpielToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fragenImportierenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frageErstellenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fragenDurchsuchenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem steuerungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jokerZurücksetzenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem publikumsjokerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem telefonjokerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zusatzjokerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem überToolStripMenuItem;
        private qstnDBDataSet qstnDBDataSet;
        private System.Windows.Forms.BindingSource questionBindingSource;
        private qstnDBDataSetTableAdapters.QuestionTableAdapter questionTableAdapter;
        private qstnDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private qstnDBDataSetTableAdapters.PrioritiesTableAdapter prioritiesTableAdapter;
        private System.Windows.Forms.BindingSource fKPrioritiesQuestionBindingSource;
        private qstnDBDataSetTableAdapters.GewinnstufenTableAdapter gewinnstufenTableAdapter;
        private System.Windows.Forms.BindingSource fKPrioritiesQuestionBindingSource1;
        private System.Windows.Forms.BindingSource gewinnstufenBindingSource;
    }
}

