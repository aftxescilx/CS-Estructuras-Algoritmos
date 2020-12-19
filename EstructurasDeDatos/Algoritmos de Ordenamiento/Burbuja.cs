using System;
using System.Windows.Forms;
using System.Diagnostics;


namespace EstructurasDeDatos
{
    public partial class Burbuja : Form
    {
        int aux;
        int comparaciones = 0;
        int intercambios = 0;
        int[] lista; 
        
        public Burbuja()
        {
            InitializeComponent();
        }

        public void Agregar(int rango, int may, int men)
        {
            lista = new int[rango];
            Random random = new Random();
            for (int i = 0; i < lista.Length; i++)
            {
                lista[i] = random.Next(men, may);
            }
        }

        public string Mostrar()
        {
            string numeros = "";
            if (lista.Length != 0)
            {
                for (int i = 0; i < lista.Length; i++)
                {
                    numeros += lista[i] + ", ";
                }
                return numeros;
            }
            else
            {
                return "LA LISTA ESTÁ VACÍA.";
            }
        }

        public void Ordenar()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 1; i < lista.Length; i++)
            {
                for (int j = 0; j < lista.Length - 1; j++)
                {
                    comparaciones++;
                    if (lista[j] > lista[j + 1])
                    {
                        aux = lista[j];
                        lista[j] = lista[j + 1];
                        lista[j + 1] = aux;
                        intercambios++;
                    }
                }
            }
            stopwatch.Stop();
            string time = $"{stopwatch.Elapsed.TotalMilliseconds } ms.";
            lblComparaciones.Text = comparaciones + "";
            lblIntercambios.Text = intercambios + "";
            lblTiempoOrdenar.Text = time + "";
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int tam = Convert.ToInt32(txtNum.Text);
            int may = Convert.ToInt32(txtMay.Text);
            int men = Convert.ToInt32(txtMen.Text);
            Agregar(tam, may, men);
            lblNum.Text = Mostrar();
            txtNum.Clear();
            txtMen.Clear();
            txtMay.Clear();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            Ordenar();
            lblOrden.Text = Mostrar();
        }

        private void Burbuja_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Array.Clear(lista, 0, lista.Length);
            lblNum.Text = "";
            lblOrden.Text = "";
            lblTiempoOrdenar.Text = "";
            lblIntercambios.Text = "";
            lblComparaciones.Text = "";
        }
    }
}
