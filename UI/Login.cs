using Simple_Password_Manager.Properties;

namespace Simple_Password_Manager
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        string enterpass = Settings.Default.pass;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtLog.Text == enterpass)
            {
                this.Hide();
                PassManagerMainWindow fm = new PassManagerMainWindow();
                fm.Show();

            }
            else
            {
                MessageBox.Show("Password incorrect", "Error");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            Newpass np = new Newpass();
            np.Show();
            this.Hide();
        }
    }
}
