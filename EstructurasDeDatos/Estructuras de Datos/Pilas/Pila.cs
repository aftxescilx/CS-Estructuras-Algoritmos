using System;
using System.Windows.Forms;
using System.IO;

namespace EstructurasDeDatos
{

    public partial class Pila : Form
    {
        PilasOperaciones miPila = new PilasOperaciones();
        NodoP n = new NodoP();

        public Pila()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NodoP n = new NodoP(int.Parse(textBox1.Text));
            miPila.Push(n);
            lblPila.Text = miPila.ToString();
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            miPila.Pop();
            lblPila.Text = miPila.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(miPila.Count + "");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog Dialogo = new FolderBrowserDialog();
                if (Dialogo.ShowDialog() == DialogResult.OK)
                {
                    string dato = lblPila.Text;
                    string ruta = Dialogo.SelectedPath + "\\Pila.txt";
                    using (var writer = new StreamWriter(ruta))
                    {
                        writer.Close();
                    }
                    File.WriteAllText(ruta, dato);
                    MessageBox.Show("Datos guardados en el archivo : " + "Pila.txt");
                }
            }
            catch
            {
                MessageBox.Show("Error al guardar");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog Seleccionar = new OpenFileDialog();
                if (Seleccionar.ShowDialog() == DialogResult.OK)
                {
                    miPila.Top = null;
                    string ruta = Seleccionar.FileName;
                    string linea = File.ReadAllText(ruta);
                    string[] Pila = linea.Split(',');
                    int contador = Pila.Length - 1;
                    foreach (string i in Pila)
                    {
                        n = new NodoP();
                        n.Dato = int.Parse(Pila[contador]);
                        miPila.Push(n);
                        contador--;
                    }
                    lblPila.Text = miPila.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Error al cargar");
                miPila.Top = null;
                lblPila.Text = miPila.ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            miPila.Top = null;
            lblPila.Text = miPila.ToString();
        }

        private void Pila_FormClosed(object sender, FormClosedEventArgs e)
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
