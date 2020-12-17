using System;
using System.Windows.Forms;
using System.IO;

namespace EstructurasDeDatos
{
    public partial class ListaEnlazadaSimple : Form
    {
        NodoLES n;
        ListaEnlazadaSimpleOperaciones MiLista = new ListaEnlazadaSimpleOperaciones();
        public ListaEnlazadaSimple()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!MiLista.BuscarDato(int.Parse(txtNodo.Text)))
                {
                    n = new NodoLES();
                    n.Dato = int.Parse(txtNodo.Text);
                    MiLista.Agregar(n);
                    lblLista.Text = MiLista.ToString();
                    txtNodo.Clear();
                    return;
                }
                MessageBox.Show("El dato ya existe en la lista");
                txtNodo.Clear();
            }
            catch
            {
                MessageBox.Show("Introduzca un numero valido");
            }
        }

        private void btnEliminarNodo_Click(object sender, EventArgs e)
        {
            int dato = int.Parse(txtEliminar.Text);
            if (!MiLista.BuscarDato(dato))
            {
                MessageBox.Show("No se encontro el dato");
                lblLista.Text = MiLista.ToString();
                return;
            }
            MiLista.Borrar(dato);
            lblLista.Text = MiLista.ToString();
            txtEliminar.Clear();
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Numero de nodos en la lista: " + MiLista.ContarNodos());
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            lblMostrar.Text = MiLista.ToString();
        }

        private void btnGuardarArchivo_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog Dialogo = new FolderBrowserDialog();
            if (Dialogo.ShowDialog() == DialogResult.OK)
            {
                string dato = lblLista.Text;
                string ruta = Dialogo.SelectedPath + "\\Lista.txt";
                using (var writer = new StreamWriter(ruta))
                {
                    writer.Close();
                }
                File.WriteAllText(ruta, dato);
                MessageBox.Show("Datos guardados");
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
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
                    n = new NodoLES();
                    n.Dato = int.Parse(Lista[contador]);
                    MiLista.Agregar(n);
                    lblLista.Text = MiLista.ToString();
                    contador++;
                }
            }
        }

        private void btnEliminarLista_Click(object sender, EventArgs e)
        {
            MiLista.Head = null;
            lblLista.Text = MiLista.ToString();
        }
    }
}
