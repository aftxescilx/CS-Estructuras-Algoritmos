using System;
using System.Windows.Forms;
using System.Diagnostics;


namespace EstructurasDeDatos.Algoritmos_de_Ordenamiento
{
    public partial class CocktailSort : Form
    {
        public CocktailSort()
        {
            InitializeComponent();
        }

        int[] vector;
        int n;
        int min;
        int max;
        int i;
        Stopwatch contador = new Stopwatch();

        public void GenerarDatos(int n, int min, int max)
        {
            vector = new int[n];
            Random aleatorio = new Random();
            for (i = 0; i < vector.Length; i++)
            {
                vector[i] = aleatorio.Next(min, max);
            }
        }

        public void BurbujaBidireccional(int n)
        {

            int der = vector.Length - 1;
            int izq = 0;
            int ultimo = 0;
            int aux;
            int comparaciones = 0;
            int intercambio = 0;
            do
            {
                for (int i = izq; i < der; i++)
                {
                    comparaciones++;
                    if (vector[i] > vector[i + 1])
                    {
                        aux = vector[i];
                        vector[i] = vector[i + 1];
                        vector[i + 1] = aux;
                        ultimo = i;
                        intercambio++;
                    }
                }
                der = ultimo;

                for (int j = der; j > izq; j--)
                {
                    comparaciones++;
                    if (vector[j - 1] > vector[j])
                    {
                        aux = vector[j];
                        vector[j] = vector[j - 1];
                        vector[j - 1] = aux;
                        ultimo = j;
                        intercambio++;
                    }

                }
                izq = ultimo;

            } while (izq < der);

            lblComparaciones.Text = comparaciones.ToString() + " Comparaciones";
            lblIntercambios.Text = intercambio.ToString() + " Intercambios";
            return;
        }

        public void Mostrar(ListBox l)
        {
            for (i = 0; i < vector.Length; i++)
            {
                l.Items.Add(vector[i]);
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                lbNum.Items.Clear();
                lbOrdenar.Items.Clear();
                n = int.Parse(txtNum.Text);
                min = int.Parse(txtMin.Text);
                max = int.Parse(txtMax.Text);
                GenerarDatos(n, min, max);
                Mostrar(lbNum);
                btnGenerar.Enabled = false;
                btnOrdenar.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Introduzca un numero valido");
            }
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            contador.Restart();
            BurbujaBidireccional(n);
            contador.Stop();
            lblTiempoOrdenar.Text = contador.Elapsed.TotalMilliseconds.ToString() + " Milisegundos";
            Mostrar(lbOrdenar);
            btnGenerar.Enabled = true;
            btnOrdenar.Enabled = false;
        }

        private void CocktailSort_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Array.Clear(vector, 0, vector.Length);
            lbNum.Items.Clear();
            lbOrdenar.Items.Clear();
            lblTiempoOrdenar.Text = "";
            lblIntercambios.Text = "";
            lblComparaciones.Text = "";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            fMenu m = new fMenu();
            m.Show();
            Hide();
        }
    }
}
