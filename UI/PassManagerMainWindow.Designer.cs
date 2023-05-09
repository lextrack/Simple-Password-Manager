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
            btnAbout = new Button();
            btnsalir = new Button();
            btnelimartabla = new Button();
            btnguardar = new Button();
            cb = new ComboBox();
            txtbuscartabla = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dgvver = new DataGridView();
            tabPage2 = new TabPage();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            btncrearpass = new Button();
            listBox1 = new ListBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvver).BeginInit();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.Location = new Point(2, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(752, 484);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(64, 64, 64);
            tabPage1.Controls.Add(btnAbout);
            tabPage1.Controls.Add(btnsalir);
            tabPage1.Controls.Add(btnelimartabla);
            tabPage1.Controls.Add(btnguardar);
            tabPage1.Controls.Add(cb);
            tabPage1.Controls.Add(txtbuscartabla);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(dgvver);
            tabPage1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage1.Location = new Point(4, 26);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(744, 454);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Password Manager";
            tabPage1.Click += tabPage1_Click;
            // 
            // btnAbout
            // 
            btnAbout.BackColor = SystemColors.ButtonHighlight;
            btnAbout.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAbout.Location = new Point(540, 403);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(146, 40);
            btnAbout.TabIndex = 9;
            btnAbout.Text = "About";
            btnAbout.UseVisualStyleBackColor = false;
            btnAbout.Click += btnAbout_Click;
            // 
            // btnsalir
            // 
            btnsalir.BackColor = SystemColors.ButtonHighlight;
            btnsalir.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnsalir.Location = new Point(380, 403);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(146, 40);
            btnsalir.TabIndex = 6;
            btnsalir.Text = "Exit";
            btnsalir.UseVisualStyleBackColor = false;
            btnsalir.Click += btnsalir_Click;
            // 
            // btnelimartabla
            // 
            btnelimartabla.BackColor = SystemColors.ButtonHighlight;
            btnelimartabla.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnelimartabla.Location = new Point(219, 403);
            btnelimartabla.Name = "btnelimartabla";
            btnelimartabla.Size = new Size(146, 40);
            btnelimartabla.TabIndex = 5;
            btnelimartabla.Text = "Remove password";
            btnelimartabla.UseVisualStyleBackColor = false;
            btnelimartabla.Click += btnelimartabla_Click;
            // 
            // btnguardar
            // 
            btnguardar.BackColor = SystemColors.ButtonHighlight;
            btnguardar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnguardar.Location = new Point(59, 403);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(146, 40);
            btnguardar.TabIndex = 3;
            btnguardar.Text = "Save changes";
            btnguardar.UseVisualStyleBackColor = false;
            btnguardar.Click += btnguardar_Click;
            // 
            // cb
            // 
            cb.BackColor = SystemColors.ButtonHighlight;
            cb.Cursor = Cursors.Hand;
            cb.DropDownStyle = ComboBoxStyle.DropDownList;
            cb.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cb.FormattingEnabled = true;
            cb.Location = new Point(269, 12);
            cb.Name = "cb";
            cb.Size = new Size(431, 23);
            cb.TabIndex = 1;
            cb.SelectedIndexChanged += cb_SelectedIndexChanged_1;
            // 
            // txtbuscartabla
            // 
            txtbuscartabla.BackColor = SystemColors.ButtonHighlight;
            txtbuscartabla.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtbuscartabla.Location = new Point(269, 58);
            txtbuscartabla.Name = "txtbuscartabla";
            txtbuscartabla.Size = new Size(431, 23);
            txtbuscartabla.TabIndex = 4;
            txtbuscartabla.TextChanged += txtbuscartabla_TextChanged_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(26, 61);
            label2.Name = "label2";
            label2.Size = new Size(197, 20);
            label2.TabIndex = 8;
            label2.Text = "Search a password for its ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(26, 14);
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
            dgvver.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
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
            dgvver.GridColor = Color.IndianRed;
            dgvver.Location = new Point(3, 93);
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
            dgvver.Size = new Size(738, 298);
            dgvver.TabIndex = 2;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(64, 64, 64);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(btncrearpass);
            tabPage2.Controls.Add(listBox1);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(textBox1);
            tabPage2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage2.Location = new Point(4, 26);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(744, 454);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Add a new password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(188, 202);
            label6.Name = "label6";
            label6.Size = new Size(147, 17);
            label6.TabIndex = 12;
            label6.Text = "Columns you've added";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(273, 25);
            label5.Name = "label5";
            label5.Size = new Size(199, 23);
            label5.TabIndex = 11;
            label5.Text = "ADD A NEW PASSWORD";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(188, 137);
            label4.Name = "label4";
            label4.Size = new Size(99, 17);
            label4.TabIndex = 5;
            label4.Text = "Column names";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(188, 75);
            label3.Name = "label3";
            label3.Size = new Size(104, 17);
            label3.TabIndex = 4;
            label3.Text = "Password name";
            // 
            // btncrearpass
            // 
            btncrearpass.BackColor = SystemColors.ButtonHighlight;
            btncrearpass.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btncrearpass.Location = new Point(188, 366);
            btncrearpass.Name = "btncrearpass";
            btncrearpass.Size = new Size(375, 29);
            btncrearpass.TabIndex = 3;
            btncrearpass.Text = "Create the new password";
            btncrearpass.UseVisualStyleBackColor = false;
            btncrearpass.Click += btncrearpass_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.ButtonHighlight;
            listBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 17;
            listBox1.Location = new Point(188, 222);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(375, 123);
            listBox1.TabIndex = 3;
            listBox1.KeyDown += listBox1_KeyDown;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ButtonHighlight;
            textBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(188, 95);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(375, 25);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ButtonHighlight;
            textBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(188, 157);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Press enter to add each column to the list";
            textBox1.Size = new Size(375, 25);
            textBox1.TabIndex = 2;
            textBox1.KeyDown += textBox1_KeyDown;
            // 
            // PassManagerMainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 488);
            ControlBox = false;
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "PassManagerMainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Simple Password Manager";
            Load += frmprincipal_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvver).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dgvver;
        private ComboBox cb;
        private TextBox txtbuscartabla;
        private Label label2;
        private Label label1;
        private Button btnsalir;
        private Button btnelimartabla;
        private Button btnguardar;
        private Button btncrearpass;
        private ListBox listBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label6;
        private Button btnAbout;
    }
}