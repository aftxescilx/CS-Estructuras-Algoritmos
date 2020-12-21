using System;
using System.Windows.Forms;
using System.IO;

namespace EstructurasDeDatos
{
    public partial class ListaCircularSimple : Form
    {
        ListaCircularSimpleOperaciones MiLista = new ListaCircularSimpleOperaciones();
        NodoLCS n;
        public ListaCircularSimple()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!MiLista.BuscarDato(int.Parse(txtNodo.Text)))
                {
                    n = new NodoLCS();
                    n.Dato = int.Parse(txtNodo.Text);
                    MiLista.Agregar(n);
                    lblLista.Text = MiLista.ToString();
                    txtNodo.Clear();
                }
                else
                {
                    MessageBox.Show("El dato ya existe en la lista.");
                    txtNodo.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Introduzca un número válido.");
            }
        }

        private void BtnContar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Número de nodos en la lista: " + MiLista.ContarNodos());
        }

        private void BtnGuardarArchivo_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog Dialogo = new FolderBrowserDialog();
            if (Dialogo.ShowDialog() == DialogResult.OK)
            {
                string dato = lblLista.Text;
                string ruta = Dialogo.SelectedPath + "\\Lista Circular Simple.txt";
                using (var writer = new StreamWriter(ruta))
                {
                    writer.Close();
                }
                File.WriteAllText(ruta, dato);
                MessageBox.Show("Datos guardados.");
            }
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog Seleccionar = new OpenFileDialog();
            if (Seleccionar.ShowDialog() == DialogResult.OK)
            {
                MiLista.Head = null;
                int contador = 0;
                string ruta = Seleccionar.FileName;
                string linea = File.ReadAllText(ruta);
                string[] Lista = linea.Split(',');
                foreach (string i in Lista)
                {
                    n = new NodoLCS();
                    n.Dato = int.Parse(Lista[contador]);
                    MiLista.Agregar(n);
                    lblLista.Text = MiLista.ToString();
                    contador++;
                }
            }
        }

        private void BtnEliminarLista_Click(object sender, EventArgs e)
        {
            MiLista.Head = null;
            lblLista.Text = MiLista.ToString();
        }

        private void BtnEliminarNodo_Click_1(object sender, EventArgs e)
        {
            try
            {
                int dato = int.Parse(txtEliminar.Text);

                if (!MiLista.BuscarDato(dato))
                {
                    MessageBox.Show("No se encontró el dato");
                    lblLista.Text = MiLista.ToString();
                    txtNodo.Clear();
                    return;
                }
                MiLista.Borrar(dato);
                lblLista.Text = MiLista.ToString();
                txtEliminar.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Introduzca un número válido.");
            }

        }

        private void ListaCircularSimple_FormClosed(object sender, FormClosedEventArgs e)
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
