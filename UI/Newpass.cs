using Simple_Password_Manager.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Password_Manager
{
    public partial class Newpass : Form
    {
        public Newpass()
        {
            InitializeComponent();
        }

        private void Newpass_Load(object sender, EventArgs e)
        {

        }

        string pass = Settings.Default.pass;

        private void btnSavenewpass_Click(object sender, EventArgs e)
        {
            if (textoldpass.Text == pass)
            {
                Settings.Default.pass = textnewpass.Text;
                Settings.Default.Save();
                MessageBox.Show("Password updated", "Update");
                PassManagerMainWindow frmprincipal = new PassManagerMainWindow();
                frmprincipal.Show();

            }
            else
            {
                MessageBox.Show("The current password is incorrect", "Error");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
