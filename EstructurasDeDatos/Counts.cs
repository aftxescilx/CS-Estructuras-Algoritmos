using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace EstructurasDeDatos
{
    public partial class Counts : Form
    {
        Random r = new Random();
        int valorMayor = 0;
        int[] arregloInicial;
        int[] arregloAuxiliar;
        int[] arregloOrdenado;
        Stopwatch stopWatch = new Stopwatch();

        public Counts()
        {
            InitializeComponent();
        }

        public string ImprimirArreglo(int[] arreglo)
        {
            string colaString = "";
            colaString += arreglo[0];
            for (int i = 0; i < arreglo.Length - 1; i++)
            {
                colaString += "," + arreglo[i + 1];
            }
            return colaString;
        }

        public void OrdenarEInvertir(int tamaño, int minimo, int maximo)
        {
            stopWatch.Start();
            arregloInicial = new int[tamaño];
            for (int i = 0; i < arregloInicial.Length; i++)
            {
                arregloInicial[i] = r.Next(minimo, maximo);
            }
            lblOriginal.Text = ImprimirArreglo(arregloInicial);

            for (int i = 0; i < arregloInicial.Length; i++)
            {
                if (arregloInicial[i] > valorMayor)
                {
                    valorMayor = arregloInicial[i];
                }
            }

            arregloAuxiliar = new int[valorMayor + 1];

            for (int i = 0; i < arregloInicial.Length; i++)
            {
                int posicion = arregloInicial[i];
                arregloAuxiliar[posicion]++;
            }

            for (int i = 1; i < arregloAuxiliar.Length; i++)
            {
                arregloAuxiliar[i] = arregloAuxiliar[i - 1] + arregloAuxiliar[i];
            }

            for (int i = arregloAuxiliar.Length - 1; i != 0; i--)
            {
                arregloAuxiliar[i] = arregloAuxiliar[i - 1];
            }
            arregloAuxiliar[0] = 0;

            arregloOrdenado = new int[arregloInicial.Length];
            for (int i = 0; i < arregloInicial.Length; i++)
            {
                int valor = arregloInicial[i];
                int posicion = arregloAuxiliar[valor];
                arregloOrdenado[posicion] = valor;
                arregloAuxiliar[valor]++;
            }
            lblOrdenado.Text = ImprimirArreglo(arregloOrdenado);
            Array.Reverse(arregloOrdenado);
            lblInvertido.Text = ImprimirArreglo(arregloOrdenado);
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            lblTiempo.Text = ts + "";
        }

        private void btnCrearArreglo_Click(object sender, EventArgs e)
        {
            try
            {
                int maximo = int.Parse(txtMax.Text);
                int minimo = int.Parse(txtMin.Text);
                int tamaño = int.Parse(txTamaño.Text);
                if (minimo < 0)
                {
                    MessageBox.Show("El minimo no puede ser menor que 0");
                    return;
                }
                if (tamaño < 0)
                {
                    MessageBox.Show("El tamaño no puede ser un numero negativo");
                    return;
                }
                if (maximo <= minimo)
                {
                    MessageBox.Show("El maximo debe de ser mayor que el minimo");
                    return;
                }
                txtMax.Clear();
                txtMin.Clear();
                txTamaño.Clear();
                OrdenarEInvertir(tamaño, minimo, maximo);
            }
            catch
            {
                MessageBox.Show("Introduzca datos validos");
                return;
            }
        }

        private void btnAleatorio_Click(object sender, EventArgs e)
        {
            int tamaño = r.Next(3, 20);
            int minimo = r.Next(0, 5);
            int maximo = r.Next(minimo, 25);
            OrdenarEInvertir(tamaño, minimo, maximo);
        }

        private void Counts_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
