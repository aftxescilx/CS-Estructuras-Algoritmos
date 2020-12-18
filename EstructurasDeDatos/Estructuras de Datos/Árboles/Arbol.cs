using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EstructurasDeDatos
{
    public partial class Arbol : Form
    {
        public Arbol()
        {
            InitializeComponent();
        }

        string r = "";
        string[] arreglo;
        int Dato = 0;
        int massimo = 0;
        int minino = 0;
        ArbolBinario miArbol = new ArbolBinario(null);
        Graphics g;
        int enc = 0;
        int multiplo = 0;
        bool iden = false;
        bool enor = false;
        bool preor = false;
        bool posor = false;
        bool alt = false;

        private void Arbol_Paint(object sender, PaintEventArgs en)
        {
            en.Graphics.Clear(this.BackColor);
            en.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            en.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g = en.Graphics;
            if (enor == true || posor == true || preor == true)
            {
                miArbol.Colorear(g, this.Font, Brushes.DarkBlue, Brushes.White, Pens.White, miArbol.RaizArbol(), enor, preor, posor);
            }
            else if (iden == true)
            {
                miArbol.DibujarArbol(g, this.Font, Brushes.DarkBlue, Brushes.White, Pens.Black, Brushes.Black, enc, multiplo, massimo, minino);
            }
            else if (alt == true)
            {
                MessageBox.Show("Altura: " + (miArbol.altura));
            }
            else
            {
                miArbol.DibujarArbol(g, this.Font, Brushes.DarkBlue, Brushes.White, Pens.Black, Brushes.Black, enc, multiplo, 0, 0);
            }
            preor = false;
            enor = false;
            posor = false;
            iden = false;
            alt = false;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (txtDato.Text == "")
            {
                MessageBox.Show("Debe ingresar un valor ");
            }
            else
            {
                Dato = int.Parse(txtDato.Text);
                r += Dato.ToString() + " ";
                if (massimo == 0)
                {
                    massimo = Dato;
                    minino = Dato;
                }
                else
                {
                    if (massimo < Dato)
                    {
                        massimo = Dato;
                    }
                    if (minino > Dato)
                    {
                        minino = Dato;
                    }
                }
                if (Dato <= 0 || Dato >= 100)
                    MessageBox.Show("Solo Recibe Valores desde 1 hasta 99", "Error de Ingreso");
                else
                {

                    miArbol.Insertar(Dato);
                    txtDato.Clear();
                    txtDato.Focus();

                    enc = 0;
                    Refresh();
                    Refresh();

                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtDato.Text == "")
            {
                MessageBox.Show("Debe ingresar un valor ");
            }
            else
            {
                Dato = int.Parse(txtDato.Text);
                miArbol.Eliminar(Dato);
                txtDato.Clear();
                txtDato.Focus();

                enc = 0;
                Refresh();
                Refresh();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtDato.Text == "")
            {
                MessageBox.Show("Debe Ingresar un Valor");
            }
            else
            {
                Dato = int.Parse(txtDato.Text);
                enc = Dato;
                miArbol.Buscar(Dato);
                txtDato.Clear();
                txtDato.Focus();
                Refresh();
                Refresh();
            }

        }

        private void btnRecorrer_Click(object sender, EventArgs e)
        {
            int tamano = (r.Length) / 2;

            arreglo = r.Split(' ');

            ArbolBinarioOrdenado abo = new ArbolBinarioOrdenado();

            for (int i = 0; i < arreglo.Length - 1; i++)
            {
                abo.Insertar(Int32.Parse(arreglo[i]));
            }

            if (rbtnOrden.Checked == true)
            {
                preor = true;
                abo.PreOrden();
            }

            else if (rbtnPreOrden.Checked == true)
            {
                posor = true;
                abo.PostOrden();
            }
            else if (rbtnPostOrden.Checked == true)
            {
                enor = true;
                abo.EnOrden();
            }
            Refresh();
            Refresh();
        }

        private void btnIdentificar_Click(object sender, EventArgs e)
        {
            iden = true;
            Refresh();
        }

        private void btnAltura_Click(object sender, EventArgs e)
        {
            alt = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName + ".txt", r);
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string DatosGuardados = File.ReadAllText(openFileDialog1.FileName);
                string[] arreglo = DatosGuardados.Split();
                string[] arregloborrar = r.Split();

                for (int i = 0; i <= arregloborrar.Length - 2; i++)
                {
                    miArbol.Eliminar(Convert.ToInt32(arregloborrar[i]));
                    Refresh();
                    Refresh();
                }


                for (int i = 0; i <= arreglo.Length - 2; i++)
                {
                    r += arreglo[i].ToString();
                    miArbol.Insertar(Convert.ToInt32(arreglo[i]));

                    Refresh();
                    Refresh();
                }
            }
        }

        private void Arbol_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }
    }
}
