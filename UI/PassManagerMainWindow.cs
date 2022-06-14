using Microsoft.VisualBasic;
using System.IO;

namespace Simple_Password_Manager
{
    public partial class PassManagerMainWindow : Form
    {
        string tabla = "";
        public PassManagerMainWindow()
        {
            InitializeComponent();
            new BaseDeDatos("");

            actualizar(0);
            btnguardar.Enabled = false;
        }

        void actualizar(int index)
        {
            cb.Items.Clear();
            cb.Items.Add("Select a password or create a new one");
            cb.Items.AddRange(Directory.GetFiles(Application.StartupPath + "\\db\\", "*.zip").ToList().Select(Path.GetFileNameWithoutExtension).ToArray());
            cb.SelectedIndex = index;
        }

        private void cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb.SelectedIndex > 0)
            {
                txtbuscartabla.Enabled = true;
                btnguardar.Enabled = true;
                tabla = cb.SelectedItem.ToString();

                BaseDeDatos db = new BaseDeDatos(tabla);
                List<List<string>> _tabla = db.Abrir();
                db.VerEnDGV(dgvver, _tabla);
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            BaseDeDatos db = new BaseDeDatos(tabla);
            db.Guardar(db.DGVaLista(dgvver));
            db.VerEnDGV(dgvver, db.Abrir());
        }


        private void txtbuscartabla_TextChanged(object sender, EventArgs e)
        {
            if (tabla != "")
            {
                BaseDeDatos db = new BaseDeDatos(tabla);
                db.VerEnDGV(dgvver, db.Buscar(x => x.Contains(txtbuscartabla.Text), 0, true));
            }
        }

        private void btnelimartabla_Click(object sender, EventArgs e)
        {
            if (cb.SelectedIndex > 0)
            {

                if ((int)MessageBox.Show("Are you sure you want to delete this password from the database?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == (int)Constants.vbYes)
                {
                    BaseDeDatos.EliminarTabla(cb.SelectedItem.ToString());
                    cb.SelectedIndex = 0;
                    tabla = "";
                    btnguardar.Enabled = false;
                    actualizar(0);

                }
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            if ((int)MessageBox.Show("Are you sure you want to exit? If you don't have saved the changes, you will lose all your data", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == (int)Constants.vbYes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void cb_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cb.SelectedIndex > 0)
            {
                txtbuscartabla.Enabled = true;
                btnguardar.Enabled = true;
                tabla = cb.SelectedItem.ToString();

                BaseDeDatos db = new BaseDeDatos(tabla);
                List<List<string>> _tabla = db.Abrir();
                db.VerEnDGV(dgvver, _tabla);
            }
        }

        private void frmprincipal_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

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
                if (MessageBox.Show("Are you sure you want to remove this column \"" + listBox1.SelectedItem.ToString() + "\"?", "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
               { listBox1.Items.RemoveAt(listBox1.SelectedIndex); textBox1.Focus(); }

        }

        private void btncrearpass_Click(object sender, EventArgs e)
        {
            BaseDeDatos.CrearTabla(textBox2.Text, listBox1.Items.OfType<string>().ToArray());
            actualizar(0);
            MessageBox.Show("Password successfully created");
        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Add column names and press Enter to add them", textBox1);
        }

        private void btncrearpass_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Add this password to the database!", btncrearpass);
        }

        private void txtbuscartabla_TextChanged_1(object sender, EventArgs e)
        {
            if (tabla != "")
            {
                BaseDeDatos db = new BaseDeDatos(tabla);
                db.VerEnDGV(dgvver, db.Buscar(x => x.Contains(txtbuscartabla.Text), 0, true));
            }
        }
    }
}