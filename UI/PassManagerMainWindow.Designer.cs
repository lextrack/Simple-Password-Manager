namespace Simple_Password_Manager
{
    partial class PassManagerMainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PassManagerMainWindow));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnExit = new Button();
            btnMin = new Button();
            btnMax = new Button();
            btnAbout = new Button();
            btnDeleteTable = new Button();
            btnSave = new Button();
            cb = new ComboBox();
            txtbuscartabla = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dgvver = new DataGridView();
            tabPage2 = new TabPage();
            btnExitPass = new Button();
            btnMinPass = new Button();
            btnMaxPass = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            btncrearpass = new Button();
            listBox1 = new ListBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            tabPage3 = new TabPage();
            btnExitEncryptation = new Button();
            btnMinEncryptation = new Button();
            btnMaxEncryptation = new Button();
            label8 = new Label();
            listBoxPassDecrypt = new ListBox();
            btnClearDecrypt = new Button();
            btnPassDecrypt = new Button();
            labelPassSelectorDecrypt = new Label();
            btnClearAll = new Button();
            btnDecrypt = new Button();
            btnEncrypt = new Button();
            textBoxPassword = new TextBox();
            label7 = new Label();
            listBoxPass = new ListBox();
            btnClearPass = new Button();
            btnAddPass = new Button();
            labelPassSelector = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvver).BeginInit();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.Padding = new Point(8, 5);
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(650, 465);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(64, 64, 64);
            tabPage1.Controls.Add(btnExit);
            tabPage1.Controls.Add(btnMin);
            tabPage1.Controls.Add(btnMax);
            tabPage1.Controls.Add(btnAbout);
            tabPage1.Controls.Add(btnDeleteTable);
            tabPage1.Controls.Add(btnSave);
            tabPage1.Controls.Add(cb);
            tabPage1.Controls.Add(txtbuscartabla);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(dgvver);
            tabPage1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage1.Location = new Point(4, 30);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(642, 431);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Password manager";
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Image = Properties.Resources.exit;
            btnExit.Location = new Point(590, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(32, 30);
            btnExit.TabIndex = 15;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnMin
            // 
            btnMin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMin.FlatAppearance.BorderSize = 0;
            btnMin.FlatStyle = FlatStyle.Flat;
            btnMin.Image = Properties.Resources.minimize;
            btnMin.Location = new Point(514, 3);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(32, 30);
            btnMin.TabIndex = 14;
            btnMin.UseVisualStyleBackColor = true;
            btnMin.Click += btnMin_Click;
            // 
            // btnMax
            // 
            btnMax.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMax.FlatAppearance.BorderSize = 0;
            btnMax.FlatStyle = FlatStyle.Flat;
            btnMax.Image = Properties.Resources.maximize;
            btnMax.Location = new Point(552, 3);
            btnMax.Name = "btnMax";
            btnMax.Size = new Size(32, 30);
            btnMax.TabIndex = 13;
            btnMax.UseVisualStyleBackColor = true;
            btnMax.Click += btnMax_Click;
            // 
            // btnAbout
            // 
            btnAbout.Anchor = AnchorStyles.Top;
            btnAbout.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAbout.Location = new Point(405, 129);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(145, 35);
            btnAbout.TabIndex = 11;
            btnAbout.Text = "About";
            btnAbout.UseVisualStyleBackColor = true;
            btnAbout.Click += btnAbout_Click;
            // 
            // btnDeleteTable
            // 
            btnDeleteTable.Anchor = AnchorStyles.Top;
            btnDeleteTable.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteTable.Location = new Point(252, 129);
            btnDeleteTable.Name = "btnDeleteTable";
            btnDeleteTable.Size = new Size(145, 35);
            btnDeleteTable.TabIndex = 10;
            btnDeleteTable.Text = "Remove password";
            btnDeleteTable.UseVisualStyleBackColor = true;
            btnDeleteTable.Click += btnDeleteTable_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top;
            btnSave.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(98, 129);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(145, 35);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save changes";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // cb
            // 
            cb.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cb.BackColor = SystemColors.ButtonHighlight;
            cb.Cursor = Cursors.Hand;
            cb.DropDownStyle = ComboBoxStyle.DropDownList;
            cb.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cb.FormattingEnabled = true;
            cb.Location = new Point(257, 46);
            cb.Name = "cb";
            cb.Size = new Size(365, 23);
            cb.TabIndex = 1;
            cb.SelectedIndexChanged += cb_SelectedIndexChanged_1;
            // 
            // txtbuscartabla
            // 
            txtbuscartabla.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtbuscartabla.BackColor = SystemColors.ButtonHighlight;
            txtbuscartabla.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtbuscartabla.Location = new Point(257, 82);
            txtbuscartabla.Name = "txtbuscartabla";
            txtbuscartabla.Size = new Size(97, 23);
            txtbuscartabla.TabIndex = 4;
            txtbuscartabla.TextChanged += txtbuscartabla_TextChanged_1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(17, 82);
            label2.Name = "label2";
            label2.Size = new Size(197, 20);
            label2.TabIndex = 8;
            label2.Text = "Search a password for its ID";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(17, 46);
            label1.Name = "label1";
            label1.Size = new Size(226, 20);
            label1.TabIndex = 7;
            label1.Text = "Select a password you'd created";
            // 
            // dgvver
            // 
            dgvver.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvver.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvver.BackgroundColor = SystemColors.WindowFrame;
            dgvver.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.WindowFrame;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvver.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvver.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.WindowFrame;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.InfoText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvver.DefaultCellStyle = dataGridViewCellStyle2;
            dgvver.Dock = DockStyle.Bottom;
            dgvver.GridColor = Color.IndianRed;
            dgvver.Location = new Point(3, 191);
            dgvver.Name = "dgvver";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.WindowFrame;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.Control;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.HotTrack;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvver.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvver.RowHeadersVisible = false;
            dgvver.RowTemplate.Height = 25;
            dgvver.Size = new Size(636, 237);
            dgvver.TabIndex = 2;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(64, 64, 64);
            tabPage2.Controls.Add(btnExitPass);
            tabPage2.Controls.Add(btnMinPass);
            tabPage2.Controls.Add(btnMaxPass);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(btncrearpass);
            tabPage2.Controls.Add(listBox1);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(textBox1);
            tabPage2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage2.Location = new Point(4, 30);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(642, 431);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Add a new password";
            // 
            // btnExitPass
            // 
            btnExitPass.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExitPass.FlatAppearance.BorderSize = 0;
            btnExitPass.FlatStyle = FlatStyle.Flat;
            btnExitPass.Image = Properties.Resources.exit;
            btnExitPass.Location = new Point(590, 3);
            btnExitPass.Name = "btnExitPass";
            btnExitPass.Size = new Size(32, 30);
            btnExitPass.TabIndex = 17;
            btnExitPass.UseVisualStyleBackColor = true;
            btnExitPass.Click += btnExitPass_Click;
            // 
            // btnMinPass
            // 
            btnMinPass.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinPass.FlatAppearance.BorderSize = 0;
            btnMinPass.FlatStyle = FlatStyle.Flat;
            btnMinPass.Image = Properties.Resources.minimize;
            btnMinPass.Location = new Point(514, 3);
            btnMinPass.Name = "btnMinPass";
            btnMinPass.Size = new Size(32, 30);
            btnMinPass.TabIndex = 16;
            btnMinPass.UseVisualStyleBackColor = true;
            btnMinPass.Click += btnMinPass_Click;
            // 
            // btnMaxPass
            // 
            btnMaxPass.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaxPass.FlatAppearance.BorderSize = 0;
            btnMaxPass.FlatStyle = FlatStyle.Flat;
            btnMaxPass.Image = Properties.Resources.maximize;
            btnMaxPass.Location = new Point(552, 3);
            btnMaxPass.Name = "btnMaxPass";
            btnMaxPass.Size = new Size(32, 30);
            btnMaxPass.TabIndex = 15;
            btnMaxPass.UseVisualStyleBackColor = true;
            btnMaxPass.Click += btnMaxPass_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(117, 215);
            label6.Name = "label6";
            label6.Size = new Size(279, 17);
            label6.TabIndex = 12;
            label6.Text = "Columns you've added to the new password";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(213, 46);
            label5.Name = "label5";
            label5.Size = new Size(199, 23);
            label5.TabIndex = 11;
            label5.Text = "ADD A NEW PASSWORD";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(117, 150);
            label4.Name = "label4";
            label4.Size = new Size(99, 17);
            label4.TabIndex = 5;
            label4.Text = "Column names";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(117, 89);
            label3.Name = "label3";
            label3.Size = new Size(104, 17);
            label3.TabIndex = 4;
            label3.Text = "Password name";
            // 
            // btncrearpass
            // 
            btncrearpass.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btncrearpass.BackColor = SystemColors.ButtonHighlight;
            btncrearpass.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btncrearpass.Location = new Point(117, 379);
            btncrearpass.Name = "btncrearpass";
            btncrearpass.Size = new Size(408, 29);
            btncrearpass.TabIndex = 3;
            btncrearpass.Text = "Create the new password";
            btncrearpass.UseVisualStyleBackColor = false;
            btncrearpass.Click += btncrearpass_Click;
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBox1.BackColor = SystemColors.ButtonHighlight;
            listBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 17;
            listBox1.Location = new Point(117, 235);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(408, 123);
            listBox1.TabIndex = 3;
            listBox1.KeyDown += listBox1_KeyDown;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.BackColor = SystemColors.ButtonHighlight;
            textBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(117, 109);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(408, 25);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BackColor = SystemColors.ButtonHighlight;
            textBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(117, 170);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Press enter to add each column to the list";
            textBox1.Size = new Size(408, 25);
            textBox1.TabIndex = 2;
            textBox1.KeyDown += textBox1_KeyDown;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.FromArgb(64, 64, 64);
            tabPage3.Controls.Add(btnExitEncryptation);
            tabPage3.Controls.Add(btnMinEncryptation);
            tabPage3.Controls.Add(btnMaxEncryptation);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(listBoxPassDecrypt);
            tabPage3.Controls.Add(btnClearDecrypt);
            tabPage3.Controls.Add(btnPassDecrypt);
            tabPage3.Controls.Add(labelPassSelectorDecrypt);
            tabPage3.Controls.Add(btnClearAll);
            tabPage3.Controls.Add(btnDecrypt);
            tabPage3.Controls.Add(btnEncrypt);
            tabPage3.Controls.Add(textBoxPassword);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(listBoxPass);
            tabPage3.Controls.Add(btnClearPass);
            tabPage3.Controls.Add(btnAddPass);
            tabPage3.Controls.Add(labelPassSelector);
            tabPage3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage3.Location = new Point(4, 30);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(642, 431);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Encrypt and decrypt passwords";
            // 
            // btnExitEncryptation
            // 
            btnExitEncryptation.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExitEncryptation.FlatAppearance.BorderSize = 0;
            btnExitEncryptation.FlatStyle = FlatStyle.Flat;
            btnExitEncryptation.Image = Properties.Resources.exit;
            btnExitEncryptation.Location = new Point(590, 3);
            btnExitEncryptation.Name = "btnExitEncryptation";
            btnExitEncryptation.Size = new Size(32, 30);
            btnExitEncryptation.TabIndex = 17;
            btnExitEncryptation.UseVisualStyleBackColor = true;
            btnExitEncryptation.Click += btnExitEncryptation_Click;
            // 
            // btnMinEncryptation
            // 
            btnMinEncryptation.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinEncryptation.FlatAppearance.BorderSize = 0;
            btnMinEncryptation.FlatStyle = FlatStyle.Flat;
            btnMinEncryptation.Image = Properties.Resources.minimize;
            btnMinEncryptation.Location = new Point(514, 3);
            btnMinEncryptation.Name = "btnMinEncryptation";
            btnMinEncryptation.Size = new Size(32, 30);
            btnMinEncryptation.TabIndex = 16;
            btnMinEncryptation.UseVisualStyleBackColor = true;
            btnMinEncryptation.Click += btnMinEncryptation_Click;
            // 
            // btnMaxEncryptation
            // 
            btnMaxEncryptation.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaxEncryptation.FlatAppearance.BorderSize = 0;
            btnMaxEncryptation.FlatStyle = FlatStyle.Flat;
            btnMaxEncryptation.Image = Properties.Resources.maximize;
            btnMaxEncryptation.Location = new Point(552, 3);
            btnMaxEncryptation.Name = "btnMaxEncryptation";
            btnMaxEncryptation.Size = new Size(32, 30);
            btnMaxEncryptation.TabIndex = 15;
            btnMaxEncryptation.UseVisualStyleBackColor = true;
            btnMaxEncryptation.Click += btnMaxEncryptation_Click;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(167, 46);
            label8.Name = "label8";
            label8.Size = new Size(305, 23);
            label8.TabIndex = 13;
            label8.Text = "ENCRYPT AND DECRYPT PASSWORDS";
            // 
            // listBoxPassDecrypt
            // 
            listBoxPassDecrypt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            listBoxPassDecrypt.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxPassDecrypt.FormattingEnabled = true;
            listBoxPassDecrypt.Location = new Point(51, 230);
            listBoxPassDecrypt.Name = "listBoxPassDecrypt";
            listBoxPassDecrypt.Size = new Size(437, 69);
            listBoxPassDecrypt.TabIndex = 12;
            // 
            // btnClearDecrypt
            // 
            btnClearDecrypt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClearDecrypt.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnClearDecrypt.Location = new Point(494, 270);
            btnClearDecrypt.Name = "btnClearDecrypt";
            btnClearDecrypt.Size = new Size(103, 31);
            btnClearDecrypt.TabIndex = 11;
            btnClearDecrypt.Text = "Clear";
            btnClearDecrypt.UseVisualStyleBackColor = true;
            btnClearDecrypt.Click += btnClearDecrypt_Click;
            // 
            // btnPassDecrypt
            // 
            btnPassDecrypt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPassDecrypt.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnPassDecrypt.Location = new Point(494, 230);
            btnPassDecrypt.Name = "btnPassDecrypt";
            btnPassDecrypt.Size = new Size(103, 31);
            btnPassDecrypt.TabIndex = 10;
            btnPassDecrypt.Text = "Add";
            btnPassDecrypt.UseVisualStyleBackColor = true;
            btnPassDecrypt.Click += btnPassDecrypt_Click;
            // 
            // labelPassSelectorDecrypt
            // 
            labelPassSelectorDecrypt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelPassSelectorDecrypt.AutoSize = true;
            labelPassSelectorDecrypt.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelPassSelectorDecrypt.ForeColor = SystemColors.Control;
            labelPassSelectorDecrypt.Location = new Point(51, 210);
            labelPassSelectorDecrypt.Name = "labelPassSelectorDecrypt";
            labelPassSelectorDecrypt.Size = new Size(179, 17);
            labelPassSelectorDecrypt.TabIndex = 9;
            labelPassSelectorDecrypt.Text = "Select passwords to decrypt";
            // 
            // btnClearAll
            // 
            btnClearAll.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnClearAll.Location = new Point(376, 380);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(112, 31);
            btnClearAll.TabIndex = 8;
            btnClearAll.Text = "Clear All";
            btnClearAll.UseVisualStyleBackColor = true;
            btnClearAll.Click += btnClearAll_Click;
            // 
            // btnDecrypt
            // 
            btnDecrypt.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDecrypt.Location = new Point(200, 380);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(112, 31);
            btnDecrypt.TabIndex = 7;
            btnDecrypt.Text = "Decrypt";
            btnDecrypt.UseVisualStyleBackColor = true;
            btnDecrypt.Click += btnDecrypt_Click;
            // 
            // btnEncrypt
            // 
            btnEncrypt.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEncrypt.Location = new Point(51, 380);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(112, 31);
            btnEncrypt.TabIndex = 6;
            btnEncrypt.Text = "Encrypt";
            btnEncrypt.UseVisualStyleBackColor = true;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxPassword.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.Location = new Point(51, 349);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PlaceholderText = "Use this password for encryption and decryption";
            textBoxPassword.Size = new Size(261, 22);
            textBoxPassword.TabIndex = 5;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(51, 329);
            label7.Name = "label7";
            label7.Size = new Size(112, 17);
            label7.TabIndex = 4;
            label7.Text = "Master password";
            // 
            // listBoxPass
            // 
            listBoxPass.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            listBoxPass.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxPass.FormattingEnabled = true;
            listBoxPass.Location = new Point(51, 109);
            listBoxPass.Name = "listBoxPass";
            listBoxPass.Size = new Size(437, 69);
            listBoxPass.TabIndex = 3;
            // 
            // btnClearPass
            // 
            btnClearPass.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClearPass.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnClearPass.Location = new Point(494, 149);
            btnClearPass.Name = "btnClearPass";
            btnClearPass.Size = new Size(103, 31);
            btnClearPass.TabIndex = 2;
            btnClearPass.Text = "Clear";
            btnClearPass.UseVisualStyleBackColor = true;
            btnClearPass.Click += btnClearPass_Click;
            // 
            // btnAddPass
            // 
            btnAddPass.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddPass.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddPass.Location = new Point(494, 109);
            btnAddPass.Name = "btnAddPass";
            btnAddPass.Size = new Size(103, 31);
            btnAddPass.TabIndex = 1;
            btnAddPass.Text = "Add";
            btnAddPass.UseVisualStyleBackColor = true;
            btnAddPass.Click += btnAddPass_Click;
            // 
            // labelPassSelector
            // 
            labelPassSelector.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelPassSelector.AutoSize = true;
            labelPassSelector.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelPassSelector.ForeColor = SystemColors.Control;
            labelPassSelector.Location = new Point(51, 89);
            labelPassSelector.Name = "labelPassSelector";
            labelPassSelector.Size = new Size(179, 17);
            labelPassSelector.TabIndex = 0;
            labelPassSelector.Text = "Select passwords to encrypt";
            // 
            // PassManagerMainWindow
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(650, 465);
            ControlBox = false;
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PassManagerMainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Simple Password Manager";
            Load += PassManagerMainWindow_Load;
            Resize += PassManagerMainWindow_Resize;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvver).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dgvver;
        private ComboBox cb;
        private Label label1;
        private Button btncrearpass;
        private ListBox listBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label6;
        private TabPage tabPage3;
        private Label labelPassSelector;
        private Button btnAddPass;
        private Button btnClearPass;
        private ListBox listBoxPass;
        private TextBox textBoxPassword;
        private Label label7;
        private Button btnDecrypt;
        private Button btnEncrypt;
        private Button btnClearAll;
        private ListBox listBoxPassDecrypt;
        private Button btnClearDecrypt;
        private Button btnPassDecrypt;
        private Label labelPassSelectorDecrypt;
        private Label label8;
        private TextBox txtbuscartabla;
        private Label label2;
        private Button btnSave;
        private Button btnDeleteTable;
        private Button btnAbout;
        private Button btnMax;
        private Button btnMin;
        private Button btnMinPass;
        private Button btnMaxPass;
        private Button btnMinEncryptation;
        private Button btnMaxEncryptation;
        private Button btnExit;
        private Button btnExitPass;
        private Button btnExitEncryptation;
    }
}