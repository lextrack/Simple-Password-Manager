namespace Simple_Password_Manager.UI
{
    partial class Aboutform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aboutform));
            label1 = new Label();
            LbAbout2 = new Label();
            LbAbout1 = new Label();
            label3 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(64, 64);
            label1.TabIndex = 0;
            // 
            // LbAbout2
            // 
            LbAbout2.AutoSize = true;
            LbAbout2.ForeColor = SystemColors.Control;
            LbAbout2.Location = new Point(24, 185);
            LbAbout2.Name = "LbAbout2";
            LbAbout2.Size = new Size(182, 30);
            LbAbout2.TabIndex = 13;
            LbAbout2.Text = "This software is made possible by\r\nGerryStudios.";
            // 
            // LbAbout1
            // 
            LbAbout1.AutoSize = true;
            LbAbout1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LbAbout1.ForeColor = SystemColors.Control;
            LbAbout1.Location = new Point(24, 110);
            LbAbout1.Name = "LbAbout1";
            LbAbout1.Size = new Size(272, 60);
            LbAbout1.TabIndex = 12;
            LbAbout1.Text = "You can find this project on GitHub, its name\r\nis \"Simple-Password-Manager\", and my nickname\r\nis \"Lextrack\". Keep an eye on this project, more\r\nupdates coming soon!";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(95, 21);
            label3.Name = "label3";
            label3.Size = new Size(170, 38);
            label3.TabIndex = 11;
            label3.Text = "Simple Password Manager\r\nv1.0.5";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(24, 81);
            label2.Name = "label2";
            label2.Size = new Size(151, 15);
            label2.TabIndex = 10;
            label2.Text = "Copyright © 2023 Lextrack.";
            // 
            // Aboutform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(309, 231);
            Controls.Add(LbAbout2);
            Controls.Add(LbAbout1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Aboutform";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "About";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label LbAbout2;
        private Label LbAbout1;
        private Label label3;
        private Label label2;
    }
}