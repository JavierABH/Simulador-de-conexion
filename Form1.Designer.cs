namespace Traceability_Simu
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.buttonExportFile = new System.Windows.Forms.Button();
            this.buttonReadFile = new System.Windows.Forms.Button();
            this.txtFileCSV = new System.Windows.Forms.TextBox();
            this.buttonSelImportFile = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonCreateFiles = new System.Windows.Forms.Button();
            this.radioButtonCreateSerial = new System.Windows.Forms.RadioButton();
            this.radioButtonCreateProcess = new System.Windows.Forms.RadioButton();
            this.radioButtonCreateBase = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dbTable = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonUpload = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPartNumbReg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtSerialReg = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DbVali = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.buttonPartNumber = new System.Windows.Forms.Button();
            this.ButtonTest = new System.Windows.Forms.Button();
            this.buttonRefreshVali = new System.Windows.Forms.Button();
            this.buttonBackcheck = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxTSerialVali = new System.Windows.Forms.TextBox();
            this.StationVali = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.functionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabPage2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbTable)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DbVali)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(861, 411);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Register";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.buttonExportFile);
            this.groupBox6.Controls.Add(this.buttonReadFile);
            this.groupBox6.Controls.Add(this.txtFileCSV);
            this.groupBox6.Controls.Add(this.buttonSelImportFile);
            this.groupBox6.Location = new System.Drawing.Point(6, 79);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(509, 77);
            this.groupBox6.TabIndex = 49;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Read and Write Data";
            // 
            // buttonExportFile
            // 
            this.buttonExportFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExportFile.Location = new System.Drawing.Point(449, 48);
            this.buttonExportFile.Name = "buttonExportFile";
            this.buttonExportFile.Size = new System.Drawing.Size(54, 23);
            this.buttonExportFile.TabIndex = 5;
            this.buttonExportFile.Text = "Write";
            this.toolTip1.SetToolTip(this.buttonExportFile, "Updates the data in the selected file with the data in the table.");
            this.buttonExportFile.UseVisualStyleBackColor = true;
            this.buttonExportFile.Click += new System.EventHandler(this.buttonExportFile_Click);
            // 
            // buttonReadFile
            // 
            this.buttonReadFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReadFile.Location = new System.Drawing.Point(6, 45);
            this.buttonReadFile.Name = "buttonReadFile";
            this.buttonReadFile.Size = new System.Drawing.Size(54, 23);
            this.buttonReadFile.TabIndex = 52;
            this.buttonReadFile.Text = "Read";
            this.toolTip1.SetToolTip(this.buttonReadFile, "Read the selected file for editing");
            this.buttonReadFile.UseVisualStyleBackColor = true;
            this.buttonReadFile.Click += new System.EventHandler(this.buttonReadFile_Click);
            // 
            // txtFileCSV
            // 
            this.txtFileCSV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileCSV.Location = new System.Drawing.Point(6, 19);
            this.txtFileCSV.Name = "txtFileCSV";
            this.txtFileCSV.Size = new System.Drawing.Size(458, 20);
            this.txtFileCSV.TabIndex = 46;
            // 
            // buttonSelImportFile
            // 
            this.buttonSelImportFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelImportFile.Location = new System.Drawing.Point(470, 16);
            this.buttonSelImportFile.Name = "buttonSelImportFile";
            this.buttonSelImportFile.Size = new System.Drawing.Size(33, 23);
            this.buttonSelImportFile.TabIndex = 51;
            this.buttonSelImportFile.Text = "...";
            this.toolTip1.SetToolTip(this.buttonSelImportFile, "Select the file to edit");
            this.buttonSelImportFile.UseVisualStyleBackColor = true;
            this.buttonSelImportFile.Click += new System.EventHandler(this.buttonSelImportFile_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonCreateFiles);
            this.groupBox3.Controls.Add(this.radioButtonCreateSerial);
            this.groupBox3.Controls.Add(this.radioButtonCreateProcess);
            this.groupBox3.Controls.Add(this.radioButtonCreateBase);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(509, 67);
            this.groupBox3.TabIndex = 48;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Create default files";
            // 
            // buttonCreateFiles
            // 
            this.buttonCreateFiles.Location = new System.Drawing.Point(354, 24);
            this.buttonCreateFiles.Name = "buttonCreateFiles";
            this.buttonCreateFiles.Size = new System.Drawing.Size(68, 23);
            this.buttonCreateFiles.TabIndex = 49;
            this.buttonCreateFiles.Text = "Create";
            this.toolTip1.SetToolTip(this.buttonCreateFiles, "Creates the selected file to its initial state. All data is deleted.");
            this.buttonCreateFiles.UseVisualStyleBackColor = true;
            this.buttonCreateFiles.Click += new System.EventHandler(this.buttonCreateFiles_Click);
            // 
            // radioButtonCreateSerial
            // 
            this.radioButtonCreateSerial.AutoSize = true;
            this.radioButtonCreateSerial.Location = new System.Drawing.Point(208, 27);
            this.radioButtonCreateSerial.Name = "radioButtonCreateSerial";
            this.radioButtonCreateSerial.Size = new System.Drawing.Size(73, 17);
            this.radioButtonCreateSerial.TabIndex = 2;
            this.radioButtonCreateSerial.Text = "Serial logs";
            this.toolTip1.SetToolTip(this.radioButtonCreateSerial, "Here the registered serial numbers are stored");
            this.radioButtonCreateSerial.UseVisualStyleBackColor = true;
            // 
            // radioButtonCreateProcess
            // 
            this.radioButtonCreateProcess.AutoSize = true;
            this.radioButtonCreateProcess.Location = new System.Drawing.Point(111, 27);
            this.radioButtonCreateProcess.Name = "radioButtonCreateProcess";
            this.radioButtonCreateProcess.Size = new System.Drawing.Size(63, 17);
            this.radioButtonCreateProcess.TabIndex = 1;
            this.radioButtonCreateProcess.Text = "Process";
            this.toolTip1.SetToolTip(this.radioButtonCreateProcess, "Here are stored the names of the processes");
            this.radioButtonCreateProcess.UseVisualStyleBackColor = true;
            // 
            // radioButtonCreateBase
            // 
            this.radioButtonCreateBase.AutoSize = true;
            this.radioButtonCreateBase.Location = new System.Drawing.Point(6, 27);
            this.radioButtonCreateBase.Name = "radioButtonCreateBase";
            this.radioButtonCreateBase.Size = new System.Drawing.Size(70, 17);
            this.radioButtonCreateBase.TabIndex = 0;
            this.radioButtonCreateBase.Text = "Basedata";
            this.toolTip1.SetToolTip(this.radioButtonCreateBase, "This is where the PCB history is stored");
            this.radioButtonCreateBase.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dbTable);
            this.groupBox5.Location = new System.Drawing.Point(6, 162);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(842, 243);
            this.groupBox5.TabIndex = 47;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Modify";
            // 
            // dbTable
            // 
            this.dbTable.AllowUserToAddRows = false;
            this.dbTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbTable.Location = new System.Drawing.Point(3, 16);
            this.dbTable.Name = "dbTable";
            this.dbTable.Size = new System.Drawing.Size(836, 224);
            this.dbTable.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonUpload);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.TxtPartNumbReg);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.TxtSerialReg);
            this.groupBox4.Location = new System.Drawing.Point(521, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(327, 150);
            this.groupBox4.TabIndex = 46;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Register new PCB";
            // 
            // buttonUpload
            // 
            this.buttonUpload.Location = new System.Drawing.Point(140, 118);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(53, 23);
            this.buttonUpload.TabIndex = 40;
            this.buttonUpload.Text = "Upload";
            this.toolTip1.SetToolTip(this.buttonUpload, "Register a PCB to access traceability options");
            this.buttonUpload.UseVisualStyleBackColor = true;
            this.buttonUpload.Click += new System.EventHandler(this.buttonUpload_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Part Number";
            // 
            // TxtPartNumbReg
            // 
            this.TxtPartNumbReg.Location = new System.Drawing.Point(6, 84);
            this.TxtPartNumbReg.Name = "TxtPartNumbReg";
            this.TxtPartNumbReg.Size = new System.Drawing.Size(315, 20);
            this.TxtPartNumbReg.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Serial New";
            // 
            // TxtSerialReg
            // 
            this.TxtSerialReg.Location = new System.Drawing.Point(6, 38);
            this.TxtSerialReg.Name = "TxtSerialReg";
            this.TxtSerialReg.Size = new System.Drawing.Size(315, 20);
            this.TxtSerialReg.TabIndex = 33;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(861, 411);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Validation";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(407, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 38;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DbVali);
            this.groupBox2.Location = new System.Drawing.Point(6, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(846, 324);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data Saved";
            // 
            // DbVali
            // 
            this.DbVali.AllowUserToAddRows = false;
            this.DbVali.AllowUserToDeleteRows = false;
            this.DbVali.AllowUserToResizeColumns = false;
            this.DbVali.AllowUserToResizeRows = false;
            this.DbVali.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DbVali.ColumnHeadersVisible = false;
            this.DbVali.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.DbVali.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DbVali.Location = new System.Drawing.Point(3, 16);
            this.DbVali.Name = "DbVali";
            this.DbVali.ReadOnly = true;
            this.DbVali.RowHeadersVisible = false;
            this.DbVali.RowHeadersWidth = 37;
            this.DbVali.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DbVali.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DbVali.Size = new System.Drawing.Size(840, 305);
            this.DbVali.TabIndex = 36;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "PartNumber";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 5;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.HeaderText = "Serial";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 5;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.HeaderText = "Station";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn3.Width = 5;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.HeaderText = "Process";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn4.Width = 5;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn5.HeaderText = "Pass/fail";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn5.Width = 5;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn6.HeaderText = "TimesTested";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn6.Width = 5;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn7.HeaderText = "EntranceTime";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn7.Width = 5;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn8.HeaderText = "ExitTime";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn8.Width = 5;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn9.HeaderText = "FailString";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn9.Width = 5;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn10.HeaderText = "UserName";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn10.Width = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxTSerialVali);
            this.groupBox1.Controls.Add(this.StationVali);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(846, 69);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PCB Data";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.buttonPartNumber);
            this.groupBox7.Controls.Add(this.ButtonTest);
            this.groupBox7.Controls.Add(this.buttonRefreshVali);
            this.groupBox7.Controls.Add(this.buttonBackcheck);
            this.groupBox7.Location = new System.Drawing.Point(489, 16);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(339, 47);
            this.groupBox7.TabIndex = 46;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Test y Preset";
            // 
            // buttonPartNumber
            // 
            this.buttonPartNumber.Location = new System.Drawing.Point(97, 21);
            this.buttonPartNumber.Name = "buttonPartNumber";
            this.buttonPartNumber.Size = new System.Drawing.Size(76, 20);
            this.buttonPartNumber.TabIndex = 46;
            this.buttonPartNumber.Text = "PartNumber";
            this.toolTip1.SetToolTip(this.buttonPartNumber, "Return PartNumber");
            this.buttonPartNumber.UseVisualStyleBackColor = true;
            this.buttonPartNumber.Click += new System.EventHandler(this.buttonPartNumber_Click);
            // 
            // ButtonTest
            // 
            this.ButtonTest.Location = new System.Drawing.Point(194, 21);
            this.ButtonTest.Name = "ButtonTest";
            this.ButtonTest.Size = new System.Drawing.Size(62, 20);
            this.ButtonTest.TabIndex = 45;
            this.ButtonTest.Text = "Test";
            this.toolTip1.SetToolTip(this.ButtonTest, "Add a test to PCB history");
            this.ButtonTest.UseVisualStyleBackColor = true;
            this.ButtonTest.Click += new System.EventHandler(this.ButtonTest_Click_1);
            // 
            // buttonRefreshVali
            // 
            this.buttonRefreshVali.Location = new System.Drawing.Point(279, 22);
            this.buttonRefreshVali.Name = "buttonRefreshVali";
            this.buttonRefreshVali.Size = new System.Drawing.Size(54, 20);
            this.buttonRefreshVali.TabIndex = 33;
            this.buttonRefreshVali.Text = "Refresh";
            this.toolTip1.SetToolTip(this.buttonRefreshVali, "Updates the database and stations");
            this.buttonRefreshVali.UseVisualStyleBackColor = true;
            this.buttonRefreshVali.Click += new System.EventHandler(this.buttonRefreshVali_Click_1);
            // 
            // buttonBackcheck
            // 
            this.buttonBackcheck.Location = new System.Drawing.Point(6, 20);
            this.buttonBackcheck.Name = "buttonBackcheck";
            this.buttonBackcheck.Size = new System.Drawing.Size(75, 21);
            this.buttonBackcheck.TabIndex = 43;
            this.buttonBackcheck.Text = "BackCheck";
            this.toolTip1.SetToolTip(this.buttonBackcheck, "Check if the station is correct in the process.");
            this.buttonBackcheck.UseVisualStyleBackColor = true;
            this.buttonBackcheck.Click += new System.EventHandler(this.buttonBackcheck_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Serial";
            // 
            // TxTSerialVali
            // 
            this.TxTSerialVali.Location = new System.Drawing.Point(6, 37);
            this.TxTSerialVali.Name = "TxTSerialVali";
            this.TxTSerialVali.Size = new System.Drawing.Size(275, 20);
            this.TxTSerialVali.TabIndex = 33;
            // 
            // StationVali
            // 
            this.StationVali.FormattingEnabled = true;
            this.StationVali.Location = new System.Drawing.Point(287, 37);
            this.StationVali.Name = "StationVali";
            this.StationVali.Size = new System.Drawing.Size(196, 21);
            this.StationVali.TabIndex = 34;
            this.toolTip1.SetToolTip(this.StationVali, "Displays the stations. Can be changed in the register menu");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Station";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(869, 437);
            this.tabControl1.TabIndex = 45;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(892, 24);
            this.menuStrip1.TabIndex = 46;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plantToolStripMenuItem});
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionToolStripMenuItem.Text = "Options";
            // 
            // plantToolStripMenuItem
            // 
            this.plantToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.plantToolStripMenuItem.Name = "plantToolStripMenuItem";
            this.plantToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.plantToolStripMenuItem.Text = "Plant";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "Plant 1",
            "Plant 2"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(75, 23);
            this.toolStripComboBox1.ToolTipText = "Select the plant to be used. Change the answers.";
            this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.toolStripMenuItem1.Text = "Help";
            // 
            // manualToolStripMenuItem
            // 
            this.manualToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.appToolStripMenuItem,
            this.functionsToolStripMenuItem});
            this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            this.manualToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.manualToolStripMenuItem.Text = "How to use";
            // 
            // appToolStripMenuItem
            // 
            this.appToolStripMenuItem.Name = "appToolStripMenuItem";
            this.appToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.appToolStripMenuItem.Text = "App";
            this.appToolStripMenuItem.Click += new System.EventHandler(this.appToolStripMenuItem_Click);
            // 
            // functionsToolStripMenuItem
            // 
            this.functionsToolStripMenuItem.Name = "functionsToolStripMenuItem";
            this.functionsToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.functionsToolStripMenuItem.Text = "DLL Functions";
            this.functionsToolStripMenuItem.Click += new System.EventHandler(this.functionsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.aboutToolStripMenuItem.Text = "About Traceability Simu";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Information";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(892, 467);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Traceability Simu V1.1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dbTable)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DbVali)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button buttonExportFile;
        private System.Windows.Forms.Button buttonReadFile;
        private System.Windows.Forms.TextBox txtFileCSV;
        private System.Windows.Forms.Button buttonSelImportFile;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonCreateFiles;
        private System.Windows.Forms.RadioButton radioButtonCreateSerial;
        private System.Windows.Forms.RadioButton radioButtonCreateProcess;
        private System.Windows.Forms.RadioButton radioButtonCreateBase;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dbTable;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonUpload;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtPartNumbReg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtSerialReg;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DbVali;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ButtonTest;
        private System.Windows.Forms.Button buttonRefreshVali;
        private System.Windows.Forms.Button buttonBackcheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxTSerialVali;
        private System.Windows.Forms.ComboBox StationVali;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button buttonPartNumber;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plantToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem functionsToolStripMenuItem;
    }
}

