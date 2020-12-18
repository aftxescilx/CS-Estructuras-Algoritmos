using System;
using System.Windows.Forms;
using System.IO;

namespace EstructurasDeDatos
{
    public partial class ListaDobleSimple : Form
    {
        ListaDoblementeEnlazadaOperaciones miLista = new ListaDoblementeEnlazadaOperaciones();
        NodoLDE n;
        public ListaDobleSimple()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!miLista.BuscarDato(int.Parse(txtNodo.Text)))
                {
                    n = new NodoLDE();
                    n.Dato = int.Parse(txtNodo.Text);
                    miLista.Insertar(n);
                    lblLista.Text = miLista.ToString();
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

        private void BtnEliminarNodo_Click(object sender, EventArgs e)
        {
            try
            {
                int dato = int.Parse(txtEliminar.Text);

                if (!miLista.BuscarDato(dato))
                {
                    MessageBox.Show("No se encontró el dato");
                    lblLista.Text = miLista.ToString();
                    txtNodo.Clear();
                    return;
                }
                miLista.Eliminar(dato);
                lblLista.Text = miLista.ToString();
                txtEliminar.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Introduzca un número válido.");
            }
        }

        private void BtnContar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Numero de nodos en la lista: " + miLista.ContarNodos());
        }

        private void BtnGuardarArchivo_Click(object sender, EventArgs e)
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


        private void BtnCargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog Seleccionar = new OpenFileDialog();
            if (Seleccionar.ShowDialog() == DialogResult.OK)
            {
                miLista.Head = null;
                int contador = 0;
                string ruta = Seleccionar.FileName;
                string linea = File.ReadAllText(ruta);
                string[] Lista = linea.Split(',');
                foreach (string i in Lista)
                {
                    n = new NodoLDE();
                    n.Dato = int.Parse(Lista[contador]);
                    miLista.Insertar(n);
                    lblLista.Text = miLista.ToString();
                    contador++;
                }
            }
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            lblMostrar.Text = miLista.ToString();
        }

        private void BtnEliminarLista_Click(object sender, EventArgs e)
        {
            miLista.Head = null;
            lblLista.Text = miLista.ToString();
        }
    }
}