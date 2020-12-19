using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace EstructurasDeDatos
{
    public partial class Radix : Form
    {

        int[] vector;
        int n;
        int min;
        int max;
        int i;
        Stopwatch contador = new Stopwatch();

        public Radix()
        {
            InitializeComponent();
        }

        public void GenerarDatos(int n, int min, int max)
        {
            vector = new int[n];
            Random aleatorio = new Random();
            for (i = 0; i < vector.Length; i++)
            {
                vector[i] = aleatorio.Next(min, max);

            }
        }

        public void Mostrar(ListBox l)
        {
            for (i = 0; i < vector.Length; i++)
            {
                l.Items.Add(vector[i]);
            }
        }

        public void OrdenRadix (int [] vector)
        {
            int[] aux = new int[vector.Length];
            int r = 2;
            int b = 32;
            int[] count = new int[1 << r];
            int[] pref = new int[1 << r];
            int groups = (int)Math.Ceiling((double)b / (double)r);
            int mask = (1 << r) - 1;


            for (int c = 0, shift = 0; c < groups; c++, shift += r)
            {
                for (int j = 0; j < count.Length; j++)
                {
                    count[j] = 0;
                }
                for (int i = 0; i < vector.Length; i++)
                {
                    count[(vector[i] >> shift) & mask]++;
                }
                pref[0] = 0;
                for (int i = 1; i < count.Length; i++)
                {
                    pref[i] = pref[i - 1] + count[i - 1];
                }
                for (int i = 0; i < vector.Length; i++)
                {
                    aux[pref[(vector[i] >> shift) & mask]++] = vector[i];
                }
                aux.CopyTo(vector, 0);
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
            OrdenRadix(vector);
            contador.Stop();
            lblTiempoOrdenar.Text = contador.Elapsed.TotalMilliseconds.ToString() + " Milisegundos";
            Mostrar(lbOrdenar);
            btnGenerar.Enabled = true;
            btnOrdenar.Enabled = false;

        }

        private void Radix_FormClosed(object sender, FormClosedEventArgs e)
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
    }
}
