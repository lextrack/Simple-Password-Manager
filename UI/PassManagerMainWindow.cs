using Microsoft.VisualBasic;
using Simple_Password_Manager.UI;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Simple_Password_Manager
{
    public partial class PassManagerMainWindow : Form
    {
        private bool isMaximized = false;
        string tabla = "";
        private string encryptedFolder = Path.Combine(Application.StartupPath, "Encrypted");
        private string dbFolder = Path.Combine(Application.StartupPath, "db");
        char[] mychar = { '!', '.', 'L', 'O', 'C', 'K', 'E', 'D' };

        public PassManagerMainWindow()
        {
            InitializeComponent();
            new BaseDeDatos("");

            CrearCarpetaDb();
            CrearCarpetaEncrypted();

            Actualizar(0);
            btnSave.Enabled = false;
        }


        private void PassManagerMainWindow_Load(object sender, EventArgs e)
        {

        }

        private void PassManagerMainWindow_Resize(object sender, EventArgs e)
        {
            tabControl1.Size = new Size(ClientSize.Width - 20, ClientSize.Height - 40);
            tabControl1.Location = new Point(10, 30);
        }

        private void MinimizeWin()
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void MaximizeWin()
        {
            if (isMaximized)
            {

                this.WindowState = FormWindowState.Normal;
                isMaximized = false;
            }
            else
            {

                this.WindowState = FormWindowState.Maximized;
                isMaximized = true;
            }
        }

        private void ExitApp()
        {
            if ((int)MessageBox.Show("Are you sure you want to exit? If you haven't saved your changes, you will lose all unsaved data.", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == (int)Constants.vbYes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void CrearCarpetaDb()
        {
            string dbFolderPath = Path.Combine(Application.StartupPath, "db");
            if (!Directory.Exists(dbFolderPath))
            {
                try
                {
                    Directory.CreateDirectory(dbFolderPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error creating 'db' folder: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CrearCarpetaEncrypted()
        {
            string encryptedFolderPath = Path.Combine(Application.StartupPath, "Encrypted");
            if (!Directory.Exists(encryptedFolderPath))
            {
                try
                {
                    Directory.CreateDirectory(encryptedFolderPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error creating 'Encrypted' folder: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BaseDeDatos db = new BaseDeDatos(tabla);
            db.Guardar(db.DGVaLista(dgvver));
            db.VerEnDGV(dgvver, db.Abrir());

            MessageBox.Show("The data was saved successfully.", "Save");
        }

        private void btnDeleteTable_Click(object sender, EventArgs e)
        {
            if (cb.SelectedIndex > 0)
            {

                if ((int)MessageBox.Show("Are you sure you want to delete this password from the Password Manager?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == (int)Constants.vbYes)
                {
                    BaseDeDatos.EliminarTabla(cb.SelectedItem.ToString());
                    cb.SelectedIndex = 0;
                    tabla = "";
                    btnSave.Enabled = false;
                    Actualizar(0);
                }
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            Aboutform Aboutformnew = new Aboutform();
            Aboutformnew.ShowDialog();
        }

        private void Actualizar(int index)
        {
            cb.Items.Clear();
            cb.Items.Add("Select a password or create a new one");
            cb.Items.AddRange(Directory.GetFiles(Application.StartupPath + "db", "*.dll").ToList().Select(Path.GetFileNameWithoutExtension).ToArray());
            cb.SelectedIndex = index;
        }

        private void cb_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cb.SelectedIndex > 0)
            {
                txtbuscartabla.Enabled = true;
                btnSave.Enabled = true;
                tabla = cb.SelectedItem.ToString();

                BaseDeDatos db = new BaseDeDatos(tabla);
                List<List<string>> _tabla = db.Abrir();
                db.VerEnDGV(dgvver, _tabla);
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrWhiteSpace(textBox1.Text))
            {
                listBox1.Items.Add(textBox1.Text);
                textBox1.Clear();
            }

        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (listBox1.SelectedIndex > -1 && e.KeyCode == Keys.Delete)
                if (MessageBox.Show("Are you sure you want to remove the column \"" + listBox1.SelectedItem.ToString() + "\"?", "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                { listBox1.Items.RemoveAt(listBox1.SelectedIndex); textBox1.Focus(); }

        }

        private void btncrearpass_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("At a minimum, a password should have a name and a set of associated data, such as an ID, a nickname, an email address, and the password itself. For example, for a YouTube password, you could use 'YouTube' as the name and organize the information into columns that include: 'ID' (using the number 1 for the first entry, then 2, 3, and so on), 'Nickname', 'Email', and 'Password'.", "Error");
            }
            else
            {
                BaseDeDatos.CrearTabla(textBox2.Text, listBox1.Items.OfType<string>().ToArray());
                Actualizar(0);
                MessageBox.Show("Password successfully created.", "Create");
                textBox2.Clear();
                listBox1.Items.Clear();
            }
        }

        private void txtbuscartabla_TextChanged_1(object sender, EventArgs e)
        {
            if (tabla != "")
            {
                BaseDeDatos db = new BaseDeDatos(tabla);
                db.VerEnDGV(dgvver, db.Buscar(x => x.Contains(txtbuscartabla.Text), 0, true));
            }
        }

        private void EncryptFile(string inputFile, string outputFile, string password)
        {
            try
            {
                UnicodeEncoding UE = new UnicodeEncoding();
                byte[] key = UE.GetBytes(password);

                using (FileStream fsCrypt = new FileStream(outputFile, FileMode.Create))
                {
                    RijndaelManaged RMCrypto = new();

                    using (CryptoStream cs = new CryptoStream(fsCrypt, RMCrypto.CreateEncryptor(key, key), CryptoStreamMode.Write))
                    {
                        using (FileStream fsIn = new FileStream(inputFile, FileMode.Open))
                        {
                            int data;
                            while ((data = fsIn.ReadByte()) != -1)
                                cs.WriteByte((byte)data);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool DecryptFile(string inputFile, string outputFile, string password)
        {
            try
            {
                UnicodeEncoding UE = new UnicodeEncoding();
                byte[] key = UE.GetBytes(password);

                using (FileStream fsCrypt = new FileStream(inputFile, FileMode.Open))
                {
                    RijndaelManaged RMCrypto = new RijndaelManaged();

                    using (CryptoStream cs = new CryptoStream(fsCrypt, RMCrypto.CreateDecryptor(key, key), CryptoStreamMode.Read))
                    {
                        using (FileStream fsOut = new FileStream(outputFile, FileMode.Create))
                        {
                            int data;
                            while ((data = cs.ReadByte()) != -1)
                                fsOut.WriteByte((byte)data);
                        }
                    }
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        private void btnAddPass_Click(object sender, EventArgs e)
        {
            OpenFileDialog filepath = new OpenFileDialog();
            filepath.Title = "Select File";
            filepath.InitialDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "db");
            filepath.Filter = "All files (*.*)|*.*";
            filepath.Multiselect = true;
            filepath.FilterIndex = 1;
            filepath.ShowDialog();

            foreach (String file in filepath.FileNames)
            {
                listBoxPass.Items.Add(file);
            }

        }

        private void btnClearPass_Click(object sender, EventArgs e)
        {
            listBoxPass.Items.Clear();
        }

        private void btnClearDecrypt_Click(object sender, EventArgs e)
        {
            listBoxPassDecrypt.Items.Clear();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            listBoxPass.Items.Clear();
            textBoxPassword.Text = "";
            listBoxPassDecrypt.Items.Clear();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab != tabPage1)
            {
                dgvver.Rows.Clear();
                dgvver.Columns.Clear();
                dgvver.ClearSelection();
                cb.SelectedIndex = 0;
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text.Length < 8)
            {
                MessageBox.Show("Password must have 8 characters!", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (listBoxPass.Items.Count == 0)
            {
                MessageBox.Show("Select at least one file to encrypt!", "No Files Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int filesEncrypted = 0;

            for (int num = 0; num < listBoxPass.Items.Count; num++)
            {
                string inputFile = "" + listBoxPass.Items[num];
                string outputFile = Path.Combine(encryptedFolder, Path.GetFileName(inputFile) + ".!LOCKED");

                if (!inputFile.Trim().EndsWith(".!LOCKED") && File.Exists(inputFile))
                {
                    EncryptFile(inputFile, outputFile, textBoxPassword.Text);
                    File.Delete(inputFile);
                    filesEncrypted++;
                }
            }


            if (filesEncrypted > 0)
            {
                MessageBox.Show($"Password encrypted successfully for {filesEncrypted} files", "Encrypt");
            }

            listBoxPass.Items.Clear();

            dgvver.Refresh();
            cb.Refresh();
            Actualizar(0);
            textBoxPassword.Clear();
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text.Length < 8)
            {
                MessageBox.Show("Password must have 8 characters!", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (listBoxPassDecrypt.Items.Count == 0)
            {
                MessageBox.Show("Select at least one file to decrypt!", "No Files Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int filesDecrypted = 0;

            for (int num = 0; num < listBoxPassDecrypt.Items.Count; num++)
            {
                string inputFile = "" + listBoxPassDecrypt.Items[num];
                string outputFile = Path.Combine(dbFolder, Path.GetFileNameWithoutExtension(inputFile).TrimEnd(mychar));

                if (inputFile.Trim().EndsWith(".!LOCKED") && File.Exists(inputFile))
                {
                    bool decryptionSuccessful = DecryptFile(inputFile, outputFile, textBoxPassword.Text);
                    if (decryptionSuccessful)
                    {
                        File.Delete(inputFile);
                        filesDecrypted++;
                    }
                    else
                    {
                        MessageBox.Show($"Incorrect password for file {inputFile}", "Decryption Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            if (filesDecrypted > 0)
            {
                MessageBox.Show($"Password decrypted successfully for {filesDecrypted} files", "Decrypt");
            }

            listBoxPassDecrypt.Items.Clear();

            dgvver.Refresh();
            cb.Refresh();
            Actualizar(0);
            textBoxPassword.Clear();
        }


        private void btnPassDecrypt_Click(object sender, EventArgs e)
        {
            OpenFileDialog filepath = new OpenFileDialog();
            filepath.Title = "Select File";
            filepath.InitialDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Encrypted");
            filepath.Filter = "All files (*.*)|*.*";
            filepath.Multiselect = true;
            filepath.FilterIndex = 1;
            filepath.ShowDialog();

            foreach (String file in filepath.FileNames)
            {
                listBoxPassDecrypt.Items.Add(file);
            }
        }

        #region ControlBoxButtons

        private void btnMax_Click(object sender, EventArgs e)
        {
            MaximizeWin();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            MinimizeWin();
        }

        private void btnMinPass_Click(object sender, EventArgs e)
        {
            MinimizeWin();
        }

        private void btnMaxPass_Click(object sender, EventArgs e)
        {
            MaximizeWin();
        }

        private void btnMinEncryptation_Click(object sender, EventArgs e)
        {
            MinimizeWin();
        }

        private void btnMaxEncryptation_Click(object sender, EventArgs e)
        {
            MaximizeWin();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitApp();
        }

        private void btnExitPass_Click(object sender, EventArgs e)
        {
            ExitApp();
        }

        private void btnExitEncryptation_Click(object sender, EventArgs e)
        {
            ExitApp();
        }

        #endregion

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}