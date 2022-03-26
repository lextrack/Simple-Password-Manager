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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textnewpass = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSavenewpass = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textoldpass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(50, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "New password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(26, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "CHANGE YOUR CURRENT PASSWORD";
            // 
            // textnewpass
            // 
            this.textnewpass.Location = new System.Drawing.Point(50, 180);
            this.textnewpass.Name = "textnewpass";
            this.textnewpass.PasswordChar = '*';
            this.textnewpass.Size = new System.Drawing.Size(254, 23);
            this.textnewpass.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.Location = new System.Drawing.Point(180, 226);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(124, 31);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSavenewpass
            // 
            this.btnSavenewpass.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSavenewpass.Location = new System.Drawing.Point(50, 226);
            this.btnSavenewpass.Name = "btnSavenewpass";
            this.btnSavenewpass.Size = new System.Drawing.Size(124, 31);
            this.btnSavenewpass.TabIndex = 3;
            this.btnSavenewpass.Text = "Save changes";
            this.btnSavenewpass.UseVisualStyleBackColor = true;
            this.btnSavenewpass.Click += new System.EventHandler(this.btnSavenewpass_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(50, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Current password";
            // 
            // textoldpass
            // 
            this.textoldpass.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textoldpass.Location = new System.Drawing.Point(50, 112);
            this.textoldpass.Name = "textoldpass";
            this.textoldpass.PasswordChar = '*';
            this.textoldpass.Size = new System.Drawing.Size(254, 25);
            this.textoldpass.TabIndex = 1;
            // 
            // Newpass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(356, 274);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textoldpass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textnewpass);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSavenewpass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Newpass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Newpass";
            this.Load += new System.EventHandler(this.Newpass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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