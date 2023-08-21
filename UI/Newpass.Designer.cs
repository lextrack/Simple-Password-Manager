namespace Simple_Password_Manager
{
    partial class Newpass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Newpass));
            label2 = new Label();
            label1 = new Label();
            textnewpass = new TextBox();
            btnCancel = new Button();
            btnSavenewpass = new Button();
            label3 = new Label();
            textoldpass = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(50, 158);
            label2.Name = "label2";
            label2.Size = new Size(97, 17);
            label2.TabIndex = 11;
            label2.Text = "New password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(34, 23);
            label1.Name = "label1";
            label1.Size = new Size(291, 23);
            label1.TabIndex = 10;
            label1.Text = "CHANGE THE CURRENT PASSWORD";
            // 
            // textnewpass
            // 
            textnewpass.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textnewpass.Location = new Point(50, 178);
            textnewpass.Name = "textnewpass";
            textnewpass.PasswordChar = '*';
            textnewpass.Size = new Size(254, 25);
            textnewpass.TabIndex = 2;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ButtonHighlight;
            btnCancel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.Location = new Point(180, 216);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(124, 31);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSavenewpass
            // 
            btnSavenewpass.BackColor = SystemColors.ButtonHighlight;
            btnSavenewpass.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSavenewpass.Location = new Point(50, 216);
            btnSavenewpass.Name = "btnSavenewpass";
            btnSavenewpass.Size = new Size(124, 31);
            btnSavenewpass.TabIndex = 3;
            btnSavenewpass.Text = "Save changes";
            btnSavenewpass.UseVisualStyleBackColor = false;
            btnSavenewpass.Click += btnSavenewpass_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(50, 90);
            label3.Name = "label3";
            label3.Size = new Size(116, 17);
            label3.TabIndex = 13;
            label3.Text = "Current password";
            // 
            // textoldpass
            // 
            textoldpass.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textoldpass.Location = new Point(50, 110);
            textoldpass.Name = "textoldpass";
            textoldpass.PasswordChar = '*';
            textoldpass.Size = new Size(254, 25);
            textoldpass.TabIndex = 1;
            // 
            // Newpass
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(356, 274);
            ControlBox = false;
            Controls.Add(label3);
            Controls.Add(textoldpass);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textnewpass);
            Controls.Add(btnCancel);
            Controls.Add(btnSavenewpass);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Newpass";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Newpass";
            Load += Newpass_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox textnewpass;
        private Button btnCancel;
        private Button btnSavenewpass;
        private Label label3;
        private TextBox textoldpass;
    }
}