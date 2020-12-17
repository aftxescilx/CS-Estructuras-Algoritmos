using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructurasDeDatos
{
    public partial class fMenu : Form
    {
        ListaCircularSimple listaCircular = new ListaCircularSimple();
        ListaDobleSimple listaDoble = new ListaDobleSimple();
        ListaDobleCircular dobleCircular = new ListaDobleCircular();
        Cola cola = new Cola();
        Grafos1 graf = new Grafos1();
        Arbol arbol = new Arbol();

        public fMenu()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            listaCircular.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            listaDoble.Show();
            this.Hide();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            cola.Show();
            this.Hide();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            dobleCircular.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            graf.Show();
            Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            arbol.Show();
            Hide();
        }
    }
}
