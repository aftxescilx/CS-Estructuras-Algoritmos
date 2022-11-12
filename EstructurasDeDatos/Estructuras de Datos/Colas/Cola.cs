using System;
using System.Windows.Forms;
using System.IO;

namespace EstructurasDeDatos
{
    public partial class Cola : Form
    {
        ColaOperaciones MiCola = new ColaOperaciones();
        Nodo n;
        public Cola()
        {
            InitializeComponent();
        }

        private void BtnEncolar_Click(object sender, EventArgs e)
        {
            try
            {
                n = new Nodo();
                n.Dato = int.Parse(txtNodo.Text);
                MiCola.Encolar(n);
                lblCola.Text = MiCola.ToString();
                txtNodo.Clear();
            }
            catch
            {
                MessageBox.Show("Bruh");
                txtNodo.Clear();
            }
        }

        private void BtnDesencolar_Click(object sender, EventArgs e)
        {
            MiCola.Desencolar();
            lblCola.Text = MiCola.ToString();
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El dato frontal es : " + MiCola.Front());
        }

        private void BtnGuardarArchivo_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog Dialogo = new FolderBrowserDialog();
            if (Dialogo.ShowDialog() == DialogResult.OK)
            {
                string dato = lblCola.Text;
                string ruta = Dialogo.SelectedPath + "\\Cola.txt";
                using (var writer = new StreamWriter(ruta))
                {
                    writer.Close();
                }
                File.WriteAllText(ruta, dato);
                MessageBox.Show("Datos guardados");
            }
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog Seleccionar = new OpenFileDialog();
                if (Seleccionar.ShowDialog() == DialogResult.OK)
                {
                    MiCola.Head = null;
                    int contador = 0;
                    string ruta = Seleccionar.FileName;
                    string linea = File.ReadAllText(ruta);
                    string[] Lista = linea.Split(',');
                    foreach (string i in Lista)
                    {
                        n = new Nodo();
                        n.Dato = int.Parse(Lista[contador]);
                        MiCola.Encolar(n);
                        contador++;
                    }
                    lblCola.Text = MiCola.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Error al cargar");
            }
        }

        private void BtnEliminarLista_Click(object sender, EventArgs e)
        {
            MiCola.Head = null;
            lblCola.Text = MiCola.ToString();
        }

        private void Cola_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            fMenu m = new fMenu();
            m.Show();
            Hide();
        }
    }
}
