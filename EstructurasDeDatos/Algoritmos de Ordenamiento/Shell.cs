using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace EstructurasDeDatos
{
    public partial class Shell : Form
    {

        int[] vector;
        int n;
        int min;
        int max;
        int i;
        int salto = 0;
        int sw = 0;
        int auxiliar = 0;
        int e = 0;
        int pasadas = 0;

        Stopwatch contador = new Stopwatch();

        public Shell()
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

        public int MetodoShell(int[] arreglo)
        {
            salto = arreglo.Length / 2;

            while (salto > 0) 
            {
                sw = 1;     
                while (sw != 0) 
                {
                    sw = 0;
                    e = 1;
                    while (e <= (arreglo.Length - salto)) 
                    {
                        if (arreglo[e - 1] > arreglo[(e - 1) + salto]) 
                        {
                            auxiliar = arreglo[(e - 1) + salto];
                            arreglo[(e - 1) + salto] = arreglo[e - 1];
                            arreglo[e - 1] = auxiliar;
                            sw = 1;
                        }
                        e++;
                        pasadas++;
                    }
                }
                salto = salto / 2; //salto /2... 5/2 = 2
            }
            return pasadas;
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
            MetodoShell(vector);
            contador.Stop();
            lblIntercambios.Text = pasadas + "";
            lblTiempoOrdenar.Text = contador.Elapsed.TotalMilliseconds.ToString() + " Milisegundos";
            btnGenerar.Enabled = true;
            Mostrar(lbOrdenar);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Array.Clear(vector, 0, vector.Length);
            lbNum.Items.Clear();
            lbOrdenar.Items.Clear();
            lblTiempoOrdenar.Text = "";
            lblIntercambios.Text = "";
        }

        private void Shell_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
