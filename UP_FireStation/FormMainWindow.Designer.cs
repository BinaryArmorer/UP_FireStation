namespace UP_FireStation
{
    partial class FormMainWindow
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBoxChangeTable = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btUpdate = new System.Windows.Forms.Button();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.panelDeleteID = new System.Windows.Forms.Panel();
            this.btClearTextBoxDeleteID = new System.Windows.Forms.Button();
            this.btDeleteID = new System.Windows.Forms.Button();
            this.labelDeleteId = new System.Windows.Forms.Label();
            this.textBoxDeleteID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btSearchEntryID = new System.Windows.Forms.Button();
            this.btClearTextBox1 = new System.Windows.Forms.Button();
            this.btClearTextBox2 = new System.Windows.Forms.Button();
            this.btClearTextBox6 = new System.Windows.Forms.Button();
            this.btClearTextBox5 = new System.Windows.Forms.Button();
            this.btClearTextBox4 = new System.Windows.Forms.Button();
            this.btClearTextBox3 = new System.Windows.Forms.Button();
            this.btClearTextBox7 = new System.Windows.Forms.Button();
            this.labelWatchingMode = new System.Windows.Forms.Label();
            this.comboBoxChangeMode = new System.Windows.Forms.ComboBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btClearTextBox = new System.Windows.Forms.Button();
            this.btSearchEntry = new System.Windows.Forms.Button();
            this.btUpdateEntry = new System.Windows.Forms.Button();
            this.btAddEntry = new System.Windows.Forms.Button();
            this.labelTableColumn2 = new System.Windows.Forms.Label();
            this.btDeleteEntry = new System.Windows.Forms.Button();
            this.labelTableColumn7 = new System.Windows.Forms.Label();
            this.labelTableColumn8 = new System.Windows.Forms.Label();
            this.labelTableColumn5 = new System.Windows.Forms.Label();
            this.labelTableColumn6 = new System.Windows.Forms.Label();
            this.labelTableColumn9 = new System.Windows.Forms.Label();
            this.labelTableColumn4 = new System.Windows.Forms.Label();
            this.labelTableColumn3 = new System.Windows.Forms.Label();
            this.textBoxTableColumn9 = new System.Windows.Forms.TextBox();
            this.textBoxTableColumn8 = new System.Windows.Forms.TextBox();
            this.textBoxTableColumn7 = new System.Windows.Forms.TextBox();
            this.textBoxTableColumn6 = new System.Windows.Forms.TextBox();
            this.textBoxTableColumn5 = new System.Windows.Forms.TextBox();
            this.textBoxTableColumn4 = new System.Windows.Forms.TextBox();
            this.textBoxTableColumn3 = new System.Windows.Forms.TextBox();
            this.textBoxTableColumn2 = new System.Windows.Forms.TextBox();
            this.textBoxTableColumn1 = new System.Windows.Forms.TextBox();
            this.labelTableColumn1 = new System.Windows.Forms.Label();
            this.panelAdaptiveTables = new System.Windows.Forms.Panel();
            this.panelRequestSQL = new System.Windows.Forms.Panel();
            this.textBoxRequestSQL = new System.Windows.Forms.TextBox();
            this.btClearTextBox8 = new System.Windows.Forms.Button();
            this.btClearTextBox9 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelSearch.SuspendLayout();
            this.panelDeleteID.SuspendLayout();
            this.panelAdaptiveTables.SuspendLayout();
            this.panelRequestSQL.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(947, 485);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // comboBoxChangeTable
            // 
            this.comboBoxChangeTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChangeTable.FormattingEnabled = true;
            this.comboBoxChangeTable.Items.AddRange(new object[] {
            "Пожарные",
            "Оборудование",
            "Пожарные отряды",
            "Пожарные машины"});
            this.comboBoxChangeTable.Location = new System.Drawing.Point(62, 4);
            this.comboBoxChangeTable.Name = "comboBoxChangeTable";
            this.comboBoxChangeTable.Size = new System.Drawing.Size(121, 21);
            this.comboBoxChangeTable.TabIndex = 1;
            this.comboBoxChangeTable.SelectedIndexChanged += new System.EventHandler(this.comboBoxChangeTable_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Таблица:";
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(189, 4);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(117, 21);
            this.btUpdate.TabIndex = 7;
            this.btUpdate.Text = "Обновить таблицу";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.SystemColors.Control;
            this.panelSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSearch.Controls.Add(this.btClearTextBox9);
            this.panelSearch.Controls.Add(this.btClearTextBox8);
            this.panelSearch.Controls.Add(this.panelDeleteID);
            this.panelSearch.Controls.Add(this.label2);
            this.panelSearch.Controls.Add(this.btSearchEntryID);
            this.panelSearch.Controls.Add(this.btClearTextBox1);
            this.panelSearch.Controls.Add(this.btClearTextBox2);
            this.panelSearch.Controls.Add(this.btClearTextBox6);
            this.panelSearch.Controls.Add(this.btClearTextBox5);
            this.panelSearch.Controls.Add(this.btClearTextBox4);
            this.panelSearch.Controls.Add(this.btClearTextBox3);
            this.panelSearch.Controls.Add(this.btClearTextBox7);
            this.panelSearch.Controls.Add(this.labelWatchingMode);
            this.panelSearch.Controls.Add(this.comboBoxChangeMode);
            this.panelSearch.Controls.Add(this.dateTimePicker2);
            this.panelSearch.Controls.Add(this.dateTimePicker1);
            this.panelSearch.Controls.Add(this.btClearTextBox);
            this.panelSearch.Controls.Add(this.btSearchEntry);
            this.panelSearch.Controls.Add(this.btUpdateEntry);
            this.panelSearch.Controls.Add(this.btAddEntry);
            this.panelSearch.Controls.Add(this.labelTableColumn2);
            this.panelSearch.Controls.Add(this.btDeleteEntry);
            this.panelSearch.Controls.Add(this.labelTableColumn7);
            this.panelSearch.Controls.Add(this.labelTableColumn8);
            this.panelSearch.Controls.Add(this.labelTableColumn5);
            this.panelSearch.Controls.Add(this.labelTableColumn6);
            this.panelSearch.Controls.Add(this.labelTableColumn9);
            this.panelSearch.Controls.Add(this.labelTableColumn4);
            this.panelSearch.Controls.Add(this.labelTableColumn3);
            this.panelSearch.Controls.Add(this.textBoxTableColumn9);
            this.panelSearch.Controls.Add(this.textBoxTableColumn8);
            this.panelSearch.Controls.Add(this.textBoxTableColumn7);
            this.panelSearch.Controls.Add(this.textBoxTableColumn6);
            this.panelSearch.Controls.Add(this.textBoxTableColumn5);
            this.panelSearch.Controls.Add(this.textBoxTableColumn4);
            this.panelSearch.Controls.Add(this.textBoxTableColumn3);
            this.panelSearch.Controls.Add(this.textBoxTableColumn2);
            this.panelSearch.Controls.Add(this.textBoxTableColumn1);
            this.panelSearch.Controls.Add(this.labelTableColumn1);
            this.panelSearch.ForeColor = System.Drawing.Color.Black;
            this.panelSearch.Location = new System.Drawing.Point(973, 12);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(356, 518);
            this.panelSearch.TabIndex = 13;
            // 
            // panelDeleteID
            // 
            this.panelDeleteID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDeleteID.Controls.Add(this.btClearTextBoxDeleteID);
            this.panelDeleteID.Controls.Add(this.btDeleteID);
            this.panelDeleteID.Controls.Add(this.labelDeleteId);
            this.panelDeleteID.Controls.Add(this.textBoxDeleteID);
            this.panelDeleteID.Enabled = false;
            this.panelDeleteID.Location = new System.Drawing.Point(244, 429);
            this.panelDeleteID.Name = "panelDeleteID";
            this.panelDeleteID.Size = new System.Drawing.Size(106, 56);
            this.panelDeleteID.TabIndex = 43;
            this.panelDeleteID.Visible = false;
            // 
            // btClearTextBoxDeleteID
            // 
            this.btClearTextBoxDeleteID.Location = new System.Drawing.Point(82, 3);
            this.btClearTextBoxDeleteID.Name = "btClearTextBoxDeleteID";
            this.btClearTextBoxDeleteID.Size = new System.Drawing.Size(20, 20);
            this.btClearTextBoxDeleteID.TabIndex = 43;
            this.btClearTextBoxDeleteID.Text = "X";
            this.btClearTextBoxDeleteID.UseVisualStyleBackColor = true;
            this.btClearTextBoxDeleteID.Click += new System.EventHandler(this.btClearTextBoxDeleteID_Click);
            // 
            // btDeleteID
            // 
            this.btDeleteID.Location = new System.Drawing.Point(3, 29);
            this.btDeleteID.Name = "btDeleteID";
            this.btDeleteID.Size = new System.Drawing.Size(99, 23);
            this.btDeleteID.TabIndex = 40;
            this.btDeleteID.Text = "Удалить по ID";
            this.btDeleteID.UseVisualStyleBackColor = true;
            this.btDeleteID.Click += new System.EventHandler(this.btDeleteID_Click);
            // 
            // labelDeleteId
            // 
            this.labelDeleteId.AutoSize = true;
            this.labelDeleteId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDeleteId.ForeColor = System.Drawing.Color.Black;
            this.labelDeleteId.Location = new System.Drawing.Point(-1, 3);
            this.labelDeleteId.Name = "labelDeleteId";
            this.labelDeleteId.Size = new System.Drawing.Size(26, 20);
            this.labelDeleteId.TabIndex = 42;
            this.labelDeleteId.Text = "ID";
            // 
            // textBoxDeleteID
            // 
            this.textBoxDeleteID.Location = new System.Drawing.Point(31, 3);
            this.textBoxDeleteID.Name = "textBoxDeleteID";
            this.textBoxDeleteID.Size = new System.Drawing.Size(45, 20);
            this.textBoxDeleteID.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 494);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Режим работы";
            // 
            // btSearchEntryID
            // 
            this.btSearchEntryID.Enabled = false;
            this.btSearchEntryID.Location = new System.Drawing.Point(245, 464);
            this.btSearchEntryID.Name = "btSearchEntryID";
            this.btSearchEntryID.Size = new System.Drawing.Size(106, 21);
            this.btSearchEntryID.TabIndex = 44;
            this.btSearchEntryID.Text = "Найти по ID";
            this.btSearchEntryID.UseVisualStyleBackColor = true;
            this.btSearchEntryID.Visible = false;
            this.btSearchEntryID.Click += new System.EventHandler(this.btSearchEntryID_Click);
            // 
            // btClearTextBox1
            // 
            this.btClearTextBox1.Enabled = false;
            this.btClearTextBox1.Location = new System.Drawing.Point(330, 5);
            this.btClearTextBox1.Name = "btClearTextBox1";
            this.btClearTextBox1.Size = new System.Drawing.Size(20, 20);
            this.btClearTextBox1.TabIndex = 38;
            this.btClearTextBox1.Text = "X";
            this.btClearTextBox1.UseVisualStyleBackColor = true;
            this.btClearTextBox1.Visible = false;
            this.btClearTextBox1.Click += new System.EventHandler(this.btClearTextBox1_Click);
            // 
            // btClearTextBox2
            // 
            this.btClearTextBox2.Enabled = false;
            this.btClearTextBox2.Location = new System.Drawing.Point(330, 30);
            this.btClearTextBox2.Name = "btClearTextBox2";
            this.btClearTextBox2.Size = new System.Drawing.Size(20, 20);
            this.btClearTextBox2.TabIndex = 37;
            this.btClearTextBox2.Text = "X";
            this.btClearTextBox2.UseVisualStyleBackColor = true;
            this.btClearTextBox2.Click += new System.EventHandler(this.btClearTextBox2_Click);
            // 
            // btClearTextBox6
            // 
            this.btClearTextBox6.Enabled = false;
            this.btClearTextBox6.Location = new System.Drawing.Point(330, 135);
            this.btClearTextBox6.Name = "btClearTextBox6";
            this.btClearTextBox6.Size = new System.Drawing.Size(20, 20);
            this.btClearTextBox6.TabIndex = 36;
            this.btClearTextBox6.Text = "X";
            this.btClearTextBox6.UseVisualStyleBackColor = true;
            this.btClearTextBox6.Click += new System.EventHandler(this.btClearTextBox6_Click);
            // 
            // btClearTextBox5
            // 
            this.btClearTextBox5.Enabled = false;
            this.btClearTextBox5.Location = new System.Drawing.Point(330, 109);
            this.btClearTextBox5.Name = "btClearTextBox5";
            this.btClearTextBox5.Size = new System.Drawing.Size(20, 20);
            this.btClearTextBox5.TabIndex = 35;
            this.btClearTextBox5.Text = "X";
            this.btClearTextBox5.UseVisualStyleBackColor = true;
            this.btClearTextBox5.Click += new System.EventHandler(this.btClearTextBox5_Click);
            // 
            // btClearTextBox4
            // 
            this.btClearTextBox4.Enabled = false;
            this.btClearTextBox4.Location = new System.Drawing.Point(330, 83);
            this.btClearTextBox4.Name = "btClearTextBox4";
            this.btClearTextBox4.Size = new System.Drawing.Size(20, 20);
            this.btClearTextBox4.TabIndex = 34;
            this.btClearTextBox4.Text = "X";
            this.btClearTextBox4.UseVisualStyleBackColor = true;
            this.btClearTextBox4.Click += new System.EventHandler(this.btClearTextBox4_Click);
            // 
            // btClearTextBox3
            // 
            this.btClearTextBox3.Enabled = false;
            this.btClearTextBox3.Location = new System.Drawing.Point(330, 57);
            this.btClearTextBox3.Name = "btClearTextBox3";
            this.btClearTextBox3.Size = new System.Drawing.Size(20, 20);
            this.btClearTextBox3.TabIndex = 33;
            this.btClearTextBox3.Text = "X";
            this.btClearTextBox3.UseVisualStyleBackColor = true;
            this.btClearTextBox3.Click += new System.EventHandler(this.btClearTextBox3_Click);
            // 
            // btClearTextBox7
            // 
            this.btClearTextBox7.Enabled = false;
            this.btClearTextBox7.Location = new System.Drawing.Point(330, 161);
            this.btClearTextBox7.Name = "btClearTextBox7";
            this.btClearTextBox7.Size = new System.Drawing.Size(20, 20);
            this.btClearTextBox7.TabIndex = 32;
            this.btClearTextBox7.Text = "X";
            this.btClearTextBox7.UseVisualStyleBackColor = true;
            this.btClearTextBox7.Click += new System.EventHandler(this.btClearTextBox7_Click);
            // 
            // labelWatchingMode
            // 
            this.labelWatchingMode.AutoSize = true;
            this.labelWatchingMode.Location = new System.Drawing.Point(267, 495);
            this.labelWatchingMode.Name = "labelWatchingMode";
            this.labelWatchingMode.Size = new System.Drawing.Size(58, 13);
            this.labelWatchingMode.TabIndex = 31;
            this.labelWatchingMode.Text = "Просмотр";
            // 
            // comboBoxChangeMode
            // 
            this.comboBoxChangeMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChangeMode.FormattingEnabled = true;
            this.comboBoxChangeMode.Items.AddRange(new object[] {
            "Просмотр",
            "Поиск",
            "Добавление",
            "Обновление",
            "Удаление"});
            this.comboBoxChangeMode.Location = new System.Drawing.Point(94, 491);
            this.comboBoxChangeMode.Name = "comboBoxChangeMode";
            this.comboBoxChangeMode.Size = new System.Drawing.Size(121, 21);
            this.comboBoxChangeMode.TabIndex = 30;
            this.comboBoxChangeMode.SelectedIndexChanged += new System.EventHandler(this.comboBoxChangeMode_SelectedIndexChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Enabled = false;
            this.dateTimePicker2.Location = new System.Drawing.Point(305, 214);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(20, 20);
            this.dateTimePicker2.TabIndex = 29;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(305, 188);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(20, 20);
            this.dateTimePicker1.TabIndex = 28;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btClearTextBox
            // 
            this.btClearTextBox.Location = new System.Drawing.Point(203, 239);
            this.btClearTextBox.Name = "btClearTextBox";
            this.btClearTextBox.Size = new System.Drawing.Size(147, 23);
            this.btClearTextBox.TabIndex = 0;
            this.btClearTextBox.Text = "Очистить все поля";
            this.btClearTextBox.UseVisualStyleBackColor = true;
            this.btClearTextBox.Click += new System.EventHandler(this.btClearTextBox_Click);
            // 
            // btSearchEntry
            // 
            this.btSearchEntry.Location = new System.Drawing.Point(245, 491);
            this.btSearchEntry.Name = "btSearchEntry";
            this.btSearchEntry.Size = new System.Drawing.Size(106, 21);
            this.btSearchEntry.TabIndex = 27;
            this.btSearchEntry.Text = "Найти запись";
            this.btSearchEntry.UseVisualStyleBackColor = true;
            this.btSearchEntry.Visible = false;
            this.btSearchEntry.Click += new System.EventHandler(this.btSearchEntry_Click);
            // 
            // btUpdateEntry
            // 
            this.btUpdateEntry.Location = new System.Drawing.Point(245, 491);
            this.btUpdateEntry.Name = "btUpdateEntry";
            this.btUpdateEntry.Size = new System.Drawing.Size(106, 21);
            this.btUpdateEntry.TabIndex = 15;
            this.btUpdateEntry.Text = "Обновить запись";
            this.btUpdateEntry.UseVisualStyleBackColor = true;
            this.btUpdateEntry.Visible = false;
            this.btUpdateEntry.Click += new System.EventHandler(this.btUpdateEntry_Click);
            // 
            // btAddEntry
            // 
            this.btAddEntry.Location = new System.Drawing.Point(245, 491);
            this.btAddEntry.Name = "btAddEntry";
            this.btAddEntry.Size = new System.Drawing.Size(106, 21);
            this.btAddEntry.TabIndex = 16;
            this.btAddEntry.Text = "Добавить запись";
            this.btAddEntry.UseVisualStyleBackColor = true;
            this.btAddEntry.Visible = false;
            this.btAddEntry.Click += new System.EventHandler(this.btAddEntry_Click);
            // 
            // labelTableColumn2
            // 
            this.labelTableColumn2.AutoSize = true;
            this.labelTableColumn2.Enabled = false;
            this.labelTableColumn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTableColumn2.ForeColor = System.Drawing.Color.Black;
            this.labelTableColumn2.Location = new System.Drawing.Point(4, 32);
            this.labelTableColumn2.Name = "labelTableColumn2";
            this.labelTableColumn2.Size = new System.Drawing.Size(34, 20);
            this.labelTableColumn2.TabIndex = 26;
            this.labelTableColumn2.Text = "-----";
            // 
            // btDeleteEntry
            // 
            this.btDeleteEntry.Location = new System.Drawing.Point(244, 491);
            this.btDeleteEntry.Name = "btDeleteEntry";
            this.btDeleteEntry.Size = new System.Drawing.Size(106, 21);
            this.btDeleteEntry.TabIndex = 14;
            this.btDeleteEntry.Text = "Удалить запись";
            this.btDeleteEntry.UseVisualStyleBackColor = true;
            this.btDeleteEntry.Visible = false;
            this.btDeleteEntry.Click += new System.EventHandler(this.btDeleteEntry_Click);
            // 
            // labelTableColumn7
            // 
            this.labelTableColumn7.AutoSize = true;
            this.labelTableColumn7.Enabled = false;
            this.labelTableColumn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTableColumn7.ForeColor = System.Drawing.Color.Black;
            this.labelTableColumn7.Location = new System.Drawing.Point(4, 161);
            this.labelTableColumn7.Name = "labelTableColumn7";
            this.labelTableColumn7.Size = new System.Drawing.Size(34, 20);
            this.labelTableColumn7.TabIndex = 25;
            this.labelTableColumn7.Text = "-----";
            // 
            // labelTableColumn8
            // 
            this.labelTableColumn8.AutoSize = true;
            this.labelTableColumn8.Enabled = false;
            this.labelTableColumn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTableColumn8.ForeColor = System.Drawing.Color.Black;
            this.labelTableColumn8.Location = new System.Drawing.Point(4, 188);
            this.labelTableColumn8.Name = "labelTableColumn8";
            this.labelTableColumn8.Size = new System.Drawing.Size(34, 20);
            this.labelTableColumn8.TabIndex = 24;
            this.labelTableColumn8.Text = "-----";
            // 
            // labelTableColumn5
            // 
            this.labelTableColumn5.AutoSize = true;
            this.labelTableColumn5.Enabled = false;
            this.labelTableColumn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTableColumn5.ForeColor = System.Drawing.Color.Black;
            this.labelTableColumn5.Location = new System.Drawing.Point(4, 110);
            this.labelTableColumn5.Name = "labelTableColumn5";
            this.labelTableColumn5.Size = new System.Drawing.Size(34, 20);
            this.labelTableColumn5.TabIndex = 23;
            this.labelTableColumn5.Text = "-----";
            // 
            // labelTableColumn6
            // 
            this.labelTableColumn6.AutoSize = true;
            this.labelTableColumn6.Enabled = false;
            this.labelTableColumn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTableColumn6.ForeColor = System.Drawing.Color.Black;
            this.labelTableColumn6.Location = new System.Drawing.Point(4, 136);
            this.labelTableColumn6.Name = "labelTableColumn6";
            this.labelTableColumn6.Size = new System.Drawing.Size(34, 20);
            this.labelTableColumn6.TabIndex = 22;
            this.labelTableColumn6.Text = "-----";
            // 
            // labelTableColumn9
            // 
            this.labelTableColumn9.AutoSize = true;
            this.labelTableColumn9.Enabled = false;
            this.labelTableColumn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTableColumn9.ForeColor = System.Drawing.Color.Black;
            this.labelTableColumn9.Location = new System.Drawing.Point(4, 214);
            this.labelTableColumn9.Name = "labelTableColumn9";
            this.labelTableColumn9.Size = new System.Drawing.Size(34, 20);
            this.labelTableColumn9.TabIndex = 21;
            this.labelTableColumn9.Text = "-----";
            // 
            // labelTableColumn4
            // 
            this.labelTableColumn4.AutoSize = true;
            this.labelTableColumn4.Enabled = false;
            this.labelTableColumn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTableColumn4.ForeColor = System.Drawing.Color.Black;
            this.labelTableColumn4.Location = new System.Drawing.Point(4, 84);
            this.labelTableColumn4.Name = "labelTableColumn4";
            this.labelTableColumn4.Size = new System.Drawing.Size(34, 20);
            this.labelTableColumn4.TabIndex = 20;
            this.labelTableColumn4.Text = "-----";
            // 
            // labelTableColumn3
            // 
            this.labelTableColumn3.AutoSize = true;
            this.labelTableColumn3.Enabled = false;
            this.labelTableColumn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTableColumn3.ForeColor = System.Drawing.Color.Black;
            this.labelTableColumn3.Location = new System.Drawing.Point(4, 58);
            this.labelTableColumn3.Name = "labelTableColumn3";
            this.labelTableColumn3.Size = new System.Drawing.Size(34, 20);
            this.labelTableColumn3.TabIndex = 18;
            this.labelTableColumn3.Text = "-----";
            // 
            // textBoxTableColumn9
            // 
            this.textBoxTableColumn9.Location = new System.Drawing.Point(203, 213);
            this.textBoxTableColumn9.Name = "textBoxTableColumn9";
            this.textBoxTableColumn9.ReadOnly = true;
            this.textBoxTableColumn9.Size = new System.Drawing.Size(96, 20);
            this.textBoxTableColumn9.TabIndex = 17;
            // 
            // textBoxTableColumn8
            // 
            this.textBoxTableColumn8.Location = new System.Drawing.Point(203, 187);
            this.textBoxTableColumn8.Name = "textBoxTableColumn8";
            this.textBoxTableColumn8.ReadOnly = true;
            this.textBoxTableColumn8.Size = new System.Drawing.Size(96, 20);
            this.textBoxTableColumn8.TabIndex = 15;
            // 
            // textBoxTableColumn7
            // 
            this.textBoxTableColumn7.Location = new System.Drawing.Point(203, 161);
            this.textBoxTableColumn7.Name = "textBoxTableColumn7";
            this.textBoxTableColumn7.ReadOnly = true;
            this.textBoxTableColumn7.Size = new System.Drawing.Size(121, 20);
            this.textBoxTableColumn7.TabIndex = 13;
            // 
            // textBoxTableColumn6
            // 
            this.textBoxTableColumn6.Location = new System.Drawing.Point(203, 135);
            this.textBoxTableColumn6.Name = "textBoxTableColumn6";
            this.textBoxTableColumn6.ReadOnly = true;
            this.textBoxTableColumn6.Size = new System.Drawing.Size(122, 20);
            this.textBoxTableColumn6.TabIndex = 11;
            // 
            // textBoxTableColumn5
            // 
            this.textBoxTableColumn5.Location = new System.Drawing.Point(203, 109);
            this.textBoxTableColumn5.Name = "textBoxTableColumn5";
            this.textBoxTableColumn5.ReadOnly = true;
            this.textBoxTableColumn5.Size = new System.Drawing.Size(122, 20);
            this.textBoxTableColumn5.TabIndex = 9;
            // 
            // textBoxTableColumn4
            // 
            this.textBoxTableColumn4.Location = new System.Drawing.Point(203, 83);
            this.textBoxTableColumn4.Name = "textBoxTableColumn4";
            this.textBoxTableColumn4.ReadOnly = true;
            this.textBoxTableColumn4.Size = new System.Drawing.Size(122, 20);
            this.textBoxTableColumn4.TabIndex = 7;
            // 
            // textBoxTableColumn3
            // 
            this.textBoxTableColumn3.Location = new System.Drawing.Point(203, 57);
            this.textBoxTableColumn3.Name = "textBoxTableColumn3";
            this.textBoxTableColumn3.ReadOnly = true;
            this.textBoxTableColumn3.Size = new System.Drawing.Size(122, 20);
            this.textBoxTableColumn3.TabIndex = 5;
            // 
            // textBoxTableColumn2
            // 
            this.textBoxTableColumn2.Location = new System.Drawing.Point(203, 31);
            this.textBoxTableColumn2.Name = "textBoxTableColumn2";
            this.textBoxTableColumn2.ReadOnly = true;
            this.textBoxTableColumn2.Size = new System.Drawing.Size(122, 20);
            this.textBoxTableColumn2.TabIndex = 3;
            // 
            // textBoxTableColumn1
            // 
            this.textBoxTableColumn1.Location = new System.Drawing.Point(203, 5);
            this.textBoxTableColumn1.Name = "textBoxTableColumn1";
            this.textBoxTableColumn1.ReadOnly = true;
            this.textBoxTableColumn1.Size = new System.Drawing.Size(122, 20);
            this.textBoxTableColumn1.TabIndex = 1;
            // 
            // labelTableColumn1
            // 
            this.labelTableColumn1.AutoSize = true;
            this.labelTableColumn1.Enabled = false;
            this.labelTableColumn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTableColumn1.ForeColor = System.Drawing.Color.Black;
            this.labelTableColumn1.Location = new System.Drawing.Point(4, 6);
            this.labelTableColumn1.Name = "labelTableColumn1";
            this.labelTableColumn1.Size = new System.Drawing.Size(34, 20);
            this.labelTableColumn1.TabIndex = 0;
            this.labelTableColumn1.Text = "-----";
            // 
            // panelAdaptiveTables
            // 
            this.panelAdaptiveTables.BackColor = System.Drawing.SystemColors.Control;
            this.panelAdaptiveTables.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAdaptiveTables.Controls.Add(this.label1);
            this.panelAdaptiveTables.Controls.Add(this.dataGridView1);
            this.panelAdaptiveTables.Controls.Add(this.comboBoxChangeTable);
            this.panelAdaptiveTables.Controls.Add(this.btUpdate);
            this.panelAdaptiveTables.Location = new System.Drawing.Point(12, 12);
            this.panelAdaptiveTables.Name = "panelAdaptiveTables";
            this.panelAdaptiveTables.Size = new System.Drawing.Size(955, 518);
            this.panelAdaptiveTables.TabIndex = 17;
            // 
            // panelRequestSQL
            // 
            this.panelRequestSQL.BackColor = System.Drawing.SystemColors.Control;
            this.panelRequestSQL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRequestSQL.Controls.Add(this.textBoxRequestSQL);
            this.panelRequestSQL.Location = new System.Drawing.Point(12, 536);
            this.panelRequestSQL.Name = "panelRequestSQL";
            this.panelRequestSQL.Size = new System.Drawing.Size(1317, 30);
            this.panelRequestSQL.TabIndex = 18;
            // 
            // textBoxRequestSQL
            // 
            this.textBoxRequestSQL.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxRequestSQL.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRequestSQL.Location = new System.Drawing.Point(3, 3);
            this.textBoxRequestSQL.Name = "textBoxRequestSQL";
            this.textBoxRequestSQL.ReadOnly = true;
            this.textBoxRequestSQL.Size = new System.Drawing.Size(1309, 22);
            this.textBoxRequestSQL.TabIndex = 0;
            this.textBoxRequestSQL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btClearTextBox8
            // 
            this.btClearTextBox8.Enabled = false;
            this.btClearTextBox8.Location = new System.Drawing.Point(330, 188);
            this.btClearTextBox8.Name = "btClearTextBox8";
            this.btClearTextBox8.Size = new System.Drawing.Size(20, 20);
            this.btClearTextBox8.TabIndex = 45;
            this.btClearTextBox8.Text = "X";
            this.btClearTextBox8.UseVisualStyleBackColor = true;
            this.btClearTextBox8.Click += new System.EventHandler(this.btClearTextBox8_Click);
            // 
            // btClearTextBox9
            // 
            this.btClearTextBox9.Enabled = false;
            this.btClearTextBox9.Location = new System.Drawing.Point(330, 214);
            this.btClearTextBox9.Name = "btClearTextBox9";
            this.btClearTextBox9.Size = new System.Drawing.Size(20, 20);
            this.btClearTextBox9.TabIndex = 46;
            this.btClearTextBox9.Text = "X";
            this.btClearTextBox9.UseVisualStyleBackColor = true;
            this.btClearTextBox9.Click += new System.EventHandler(this.btClearTextBox9_Click);
            // 
            // FormMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1341, 576);
            this.Controls.Add(this.panelRequestSQL);
            this.Controls.Add(this.panelAdaptiveTables);
            this.Controls.Add(this.panelSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormMainWindow";
            this.Text = "FormMainWindow";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.panelDeleteID.ResumeLayout(false);
            this.panelDeleteID.PerformLayout();
            this.panelAdaptiveTables.ResumeLayout(false);
            this.panelAdaptiveTables.PerformLayout();
            this.panelRequestSQL.ResumeLayout(false);
            this.panelRequestSQL.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxChangeTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Button btDeleteEntry;
        private System.Windows.Forms.Button btUpdateEntry;
        private System.Windows.Forms.Button btAddEntry;
        private System.Windows.Forms.Label labelTableColumn1;
        private System.Windows.Forms.TextBox textBoxTableColumn1;
        private System.Windows.Forms.TextBox textBoxTableColumn6;
        private System.Windows.Forms.TextBox textBoxTableColumn5;
        private System.Windows.Forms.TextBox textBoxTableColumn4;
        private System.Windows.Forms.TextBox textBoxTableColumn3;
        private System.Windows.Forms.TextBox textBoxTableColumn2;
        private System.Windows.Forms.TextBox textBoxTableColumn9;
        private System.Windows.Forms.TextBox textBoxTableColumn8;
        private System.Windows.Forms.TextBox textBoxTableColumn7;
        private System.Windows.Forms.Label labelTableColumn2;
        private System.Windows.Forms.Label labelTableColumn7;
        private System.Windows.Forms.Label labelTableColumn8;
        private System.Windows.Forms.Label labelTableColumn5;
        private System.Windows.Forms.Label labelTableColumn6;
        private System.Windows.Forms.Label labelTableColumn9;
        private System.Windows.Forms.Label labelTableColumn4;
        private System.Windows.Forms.Label labelTableColumn3;
        private System.Windows.Forms.Button btSearchEntry;
        private System.Windows.Forms.Panel panelAdaptiveTables;
        private System.Windows.Forms.Button btClearTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox comboBoxChangeMode;
        private System.Windows.Forms.Label labelWatchingMode;
        private System.Windows.Forms.Button btClearTextBox2;
        private System.Windows.Forms.Button btClearTextBox6;
        private System.Windows.Forms.Button btClearTextBox5;
        private System.Windows.Forms.Button btClearTextBox4;
        private System.Windows.Forms.Button btClearTextBox3;
        private System.Windows.Forms.Button btClearTextBox7;
        private System.Windows.Forms.Button btClearTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelDeleteID;
        private System.Windows.Forms.Button btDeleteID;
        private System.Windows.Forms.Label labelDeleteId;
        private System.Windows.Forms.TextBox textBoxDeleteID;
        private System.Windows.Forms.Button btClearTextBoxDeleteID;
        private System.Windows.Forms.Panel panelRequestSQL;
        private System.Windows.Forms.TextBox textBoxRequestSQL;
        private System.Windows.Forms.Button btSearchEntryID;
        private System.Windows.Forms.Button btClearTextBox9;
        private System.Windows.Forms.Button btClearTextBox8;
    }
}