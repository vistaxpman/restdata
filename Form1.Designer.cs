namespace AutoBrowser
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnClipboard = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnGeneration = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnGenXML = new System.Windows.Forms.Button();
            this.btnGenDynamicClass = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.checkBoxCustomColumn = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.txtStoreProcedure = new System.Windows.Forms.TextBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.txtSPResult = new System.Windows.Forms.TextBox();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.txtBindData = new System.Windows.Forms.TextBox();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.textBoxCustomColumn = new System.Windows.Forms.TextBox();
            this.btnCreateStore = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxListTables = new System.Windows.Forms.ComboBox();
            this.btnGetAllTable = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.textBoxSplitJoinText = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.radioButtonJoin = new System.Windows.Forms.RadioButton();
            this.radioButtonSplit = new System.Windows.Forms.RadioButton();
            this.txtOutputText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtInputText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.statusStripMessage = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIncludeText = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage9.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.tabPage10.SuspendLayout();
            this.statusStripMessage.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Controls.Add(this.tabPage10);
            this.tabControl1.Location = new System.Drawing.Point(12, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(901, 509);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.btnClipboard);
            this.tabPage1.Controls.Add(this.btnDecrypt);
            this.tabPage1.Controls.Add(this.btnGeneration);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.txtInput);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(893, 480);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Encrypt Connection";
            // 
            // btnClipboard
            // 
            this.btnClipboard.Location = new System.Drawing.Point(754, 443);
            this.btnClipboard.Name = "btnClipboard";
            this.btnClipboard.Size = new System.Drawing.Size(132, 30);
            this.btnClipboard.TabIndex = 4;
            this.btnClipboard.Text = "Copy to Clipboard";
            this.btnClipboard.UseVisualStyleBackColor = true;
            this.btnClipboard.Click += new System.EventHandler(this.btnClipboard_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(779, 131);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(107, 30);
            this.btnDecrypt.TabIndex = 3;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnGeneration
            // 
            this.btnGeneration.Location = new System.Drawing.Point(666, 131);
            this.btnGeneration.Name = "btnGeneration";
            this.btnGeneration.Size = new System.Drawing.Size(107, 30);
            this.btnGeneration.TabIndex = 1;
            this.btnGeneration.Text = "Encrypt";
            this.btnGeneration.UseVisualStyleBackColor = true;
            this.btnGeneration.Click += new System.EventHandler(this.btnGeneration_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.txtResult);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(9, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(878, 277);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Result";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(6, 21);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResult.Size = new System.Drawing.Size(866, 244);
            this.txtResult.TabIndex = 0;
            this.txtResult.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtResult_KeyDown);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(121, 17);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtInput.Size = new System.Drawing.Size(760, 108);
            this.txtInput.TabIndex = 1;
            this.txtInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInput_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connection String";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(893, 480);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Data Dictionary";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(162, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(605, 23);
            this.textBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(773, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 26);
            this.button1.TabIndex = 2;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Generate Data Dictionary";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.btnGenXML);
            this.tabPage3.Controls.Add(this.btnGenDynamicClass);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(893, 480);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Gen Dynamic Class";
            // 
            // btnGenXML
            // 
            this.btnGenXML.Location = new System.Drawing.Point(15, 50);
            this.btnGenXML.Name = "btnGenXML";
            this.btnGenXML.Size = new System.Drawing.Size(114, 26);
            this.btnGenXML.TabIndex = 4;
            this.btnGenXML.Text = "Gen XML";
            this.btnGenXML.UseVisualStyleBackColor = true;
            this.btnGenXML.Click += new System.EventHandler(this.btnGenXML_Click);
            // 
            // btnGenDynamicClass
            // 
            this.btnGenDynamicClass.Location = new System.Drawing.Point(15, 18);
            this.btnGenDynamicClass.Name = "btnGenDynamicClass";
            this.btnGenDynamicClass.Size = new System.Drawing.Size(114, 26);
            this.btnGenDynamicClass.TabIndex = 3;
            this.btnGenDynamicClass.Text = "Start";
            this.btnGenDynamicClass.UseVisualStyleBackColor = true;
            this.btnGenDynamicClass.Click += new System.EventHandler(this.btnGenDynamicClass_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage4.Controls.Add(this.checkBoxCustomColumn);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.tabControl2);
            this.tabPage4.Controls.Add(this.btnCreateStore);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.comboBoxListTables);
            this.tabPage4.Controls.Add(this.btnGetAllTable);
            this.tabPage4.Controls.Add(this.textBox2);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(893, 480);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Gen Store Procedure";
            // 
            // checkBoxCustomColumn
            // 
            this.checkBoxCustomColumn.AutoSize = true;
            this.checkBoxCustomColumn.Location = new System.Drawing.Point(141, 91);
            this.checkBoxCustomColumn.Name = "checkBoxCustomColumn";
            this.checkBoxCustomColumn.Size = new System.Drawing.Size(15, 14);
            this.checkBoxCustomColumn.TabIndex = 9;
            this.checkBoxCustomColumn.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Custom column:";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Controls.Add(this.tabPage7);
            this.tabControl2.Controls.Add(this.tabPage9);
            this.tabControl2.Location = new System.Drawing.Point(6, 124);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(881, 350);
            this.tabControl2.TabIndex = 7;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage5.Controls.Add(this.txtStoreProcedure);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(873, 321);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "Class";
            // 
            // txtStoreProcedure
            // 
            this.txtStoreProcedure.Location = new System.Drawing.Point(6, 6);
            this.txtStoreProcedure.Multiline = true;
            this.txtStoreProcedure.Name = "txtStoreProcedure";
            this.txtStoreProcedure.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtStoreProcedure.Size = new System.Drawing.Size(861, 309);
            this.txtStoreProcedure.TabIndex = 5;
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage6.Controls.Add(this.txtSPResult);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(873, 321);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "Store Procedure";
            // 
            // txtSPResult
            // 
            this.txtSPResult.Location = new System.Drawing.Point(6, 6);
            this.txtSPResult.Multiline = true;
            this.txtSPResult.Name = "txtSPResult";
            this.txtSPResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSPResult.Size = new System.Drawing.Size(861, 309);
            this.txtSPResult.TabIndex = 6;
            // 
            // tabPage7
            // 
            this.tabPage7.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage7.Controls.Add(this.txtBindData);
            this.tabPage7.Location = new System.Drawing.Point(4, 25);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(873, 321);
            this.tabPage7.TabIndex = 2;
            this.tabPage7.Text = "Bind Data";
            // 
            // txtBindData
            // 
            this.txtBindData.Location = new System.Drawing.Point(6, 6);
            this.txtBindData.Multiline = true;
            this.txtBindData.Name = "txtBindData";
            this.txtBindData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBindData.Size = new System.Drawing.Size(861, 309);
            this.txtBindData.TabIndex = 6;
            // 
            // tabPage9
            // 
            this.tabPage9.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage9.Controls.Add(this.textBoxCustomColumn);
            this.tabPage9.Location = new System.Drawing.Point(4, 25);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Size = new System.Drawing.Size(873, 321);
            this.tabPage9.TabIndex = 3;
            this.tabPage9.Text = "Custom Column";
            // 
            // textBoxCustomColumn
            // 
            this.textBoxCustomColumn.Location = new System.Drawing.Point(6, 6);
            this.textBoxCustomColumn.Multiline = true;
            this.textBoxCustomColumn.Name = "textBoxCustomColumn";
            this.textBoxCustomColumn.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxCustomColumn.Size = new System.Drawing.Size(861, 309);
            this.textBoxCustomColumn.TabIndex = 7;
            // 
            // btnCreateStore
            // 
            this.btnCreateStore.Location = new System.Drawing.Point(756, 51);
            this.btnCreateStore.Name = "btnCreateStore";
            this.btnCreateStore.Size = new System.Drawing.Size(109, 31);
            this.btnCreateStore.TabIndex = 6;
            this.btnCreateStore.Text = "Create Store";
            this.btnCreateStore.UseVisualStyleBackColor = true;
            this.btnCreateStore.Click += new System.EventHandler(this.btnCreateStore_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Table:";
            // 
            // comboBoxListTables
            // 
            this.comboBoxListTables.FormattingEnabled = true;
            this.comboBoxListTables.Location = new System.Drawing.Point(141, 55);
            this.comboBoxListTables.Name = "comboBoxListTables";
            this.comboBoxListTables.Size = new System.Drawing.Size(609, 24);
            this.comboBoxListTables.TabIndex = 3;
            // 
            // btnGetAllTable
            // 
            this.btnGetAllTable.Location = new System.Drawing.Point(756, 12);
            this.btnGetAllTable.Name = "btnGetAllTable";
            this.btnGetAllTable.Size = new System.Drawing.Size(109, 32);
            this.btnGetAllTable.TabIndex = 2;
            this.btnGetAllTable.Text = "Get Tables";
            this.btnGetAllTable.UseVisualStyleBackColor = true;
            this.btnGetAllTable.Click += new System.EventHandler(this.btnGetAllTable_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(141, 17);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(609, 23);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Data Source=VNHQSQLCLU02\\DMSDB;Initial Catalog=DMS_TEST_HS2;User ID=dmsweb;Passwo" +
    "rd=DMS12345";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Connection String:";
            // 
            // tabPage8
            // 
            this.tabPage8.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage8.Controls.Add(this.txtIncludeText);
            this.tabPage8.Controls.Add(this.label8);
            this.tabPage8.Controls.Add(this.textBoxSplitJoinText);
            this.tabPage8.Controls.Add(this.buttonStart);
            this.tabPage8.Controls.Add(this.radioButtonJoin);
            this.tabPage8.Controls.Add(this.radioButtonSplit);
            this.tabPage8.Controls.Add(this.txtOutputText);
            this.tabPage8.Controls.Add(this.label6);
            this.tabPage8.Controls.Add(this.txtInputText);
            this.tabPage8.Controls.Add(this.label5);
            this.tabPage8.Location = new System.Drawing.Point(4, 25);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(893, 480);
            this.tabPage8.TabIndex = 4;
            this.tabPage8.Text = "Split - Join Text";
            // 
            // textBoxSplitJoinText
            // 
            this.textBoxSplitJoinText.Location = new System.Drawing.Point(620, 8);
            this.textBoxSplitJoinText.Name = "textBoxSplitJoinText";
            this.textBoxSplitJoinText.Size = new System.Drawing.Size(26, 23);
            this.textBoxSplitJoinText.TabIndex = 7;
            this.textBoxSplitJoinText.Text = ",";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(765, 6);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(119, 28);
            this.buttonStart.TabIndex = 6;
            this.buttonStart.Text = "Process";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // radioButtonJoin
            // 
            this.radioButtonJoin.AutoSize = true;
            this.radioButtonJoin.Location = new System.Drawing.Point(566, 10);
            this.radioButtonJoin.Name = "radioButtonJoin";
            this.radioButtonJoin.Size = new System.Drawing.Size(48, 20);
            this.radioButtonJoin.TabIndex = 5;
            this.radioButtonJoin.Text = "Join";
            this.radioButtonJoin.UseVisualStyleBackColor = true;
            this.radioButtonJoin.CheckedChanged += new System.EventHandler(this.radioButtonJoin_CheckedChanged);
            // 
            // radioButtonSplit
            // 
            this.radioButtonSplit.AutoSize = true;
            this.radioButtonSplit.Checked = true;
            this.radioButtonSplit.Location = new System.Drawing.Point(509, 10);
            this.radioButtonSplit.Name = "radioButtonSplit";
            this.radioButtonSplit.Size = new System.Drawing.Size(51, 20);
            this.radioButtonSplit.TabIndex = 4;
            this.radioButtonSplit.TabStop = true;
            this.radioButtonSplit.Text = "Split";
            this.radioButtonSplit.UseVisualStyleBackColor = true;
            this.radioButtonSplit.CheckedChanged += new System.EventHandler(this.radioButtonSplit_CheckedChanged);
            // 
            // txtOutputText
            // 
            this.txtOutputText.Location = new System.Drawing.Point(454, 40);
            this.txtOutputText.Multiline = true;
            this.txtOutputText.Name = "txtOutputText";
            this.txtOutputText.Size = new System.Drawing.Size(430, 412);
            this.txtOutputText.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(451, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Output:";
            // 
            // txtInputText
            // 
            this.txtInputText.Location = new System.Drawing.Point(11, 40);
            this.txtInputText.Multiline = true;
            this.txtInputText.Name = "txtInputText";
            this.txtInputText.Size = new System.Drawing.Size(430, 412);
            this.txtInputText.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Input:";
            // 
            // tabPage10
            // 
            this.tabPage10.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage10.Controls.Add(this.button2);
            this.tabPage10.Location = new System.Drawing.Point(4, 25);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage10.Size = new System.Drawing.Size(893, 480);
            this.tabPage10.TabIndex = 5;
            this.tabPage10.Text = "Upload File";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(41, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 40);
            this.button2.TabIndex = 0;
            this.button2.Text = "Download File";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // statusStripMessage
            // 
            this.statusStripMessage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelMessage});
            this.statusStripMessage.Location = new System.Drawing.Point(0, 528);
            this.statusStripMessage.Name = "statusStripMessage";
            this.statusStripMessage.Size = new System.Drawing.Size(925, 22);
            this.statusStripMessage.TabIndex = 1;
            // 
            // toolStripStatusLabelMessage
            // 
            this.toolStripStatusLabelMessage.Name = "toolStripStatusLabelMessage";
            this.toolStripStatusLabelMessage.Size = new System.Drawing.Size(0, 17);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(99, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(98, 22);
            this.toolStripMenuItem1.Text = "Save";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(652, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "With";
            // 
            // txtIncludeText
            // 
            this.txtIncludeText.Enabled = false;
            this.txtIncludeText.Location = new System.Drawing.Point(692, 8);
            this.txtIncludeText.Name = "txtIncludeText";
            this.txtIncludeText.Size = new System.Drawing.Size(67, 23);
            this.txtIncludeText.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 550);
            this.Controls.Add(this.statusStripMessage);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encrypt Connection";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.tabPage9.ResumeLayout(false);
            this.tabPage9.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            this.tabPage10.ResumeLayout(false);
            this.statusStripMessage.ResumeLayout(false);
            this.statusStripMessage.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnGeneration;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnClipboard;
        private System.Windows.Forms.StatusStrip statusStripMessage;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelMessage;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnGenDynamicClass;
        private System.Windows.Forms.Button btnGenXML;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGetAllTable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxListTables;
        private System.Windows.Forms.TextBox txtStoreProcedure;
        private System.Windows.Forms.Button btnCreateStore;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TextBox txtSPResult;
        private System.Windows.Forms.TextBox txtBindData;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOutputText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtInputText;
        private System.Windows.Forms.RadioButton radioButtonJoin;
        private System.Windows.Forms.RadioButton radioButtonSplit;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textBoxSplitJoinText;
        private System.Windows.Forms.CheckBox checkBoxCustomColumn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.TextBox textBoxCustomColumn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtIncludeText;
        private System.Windows.Forms.Label label8;
    }
}

