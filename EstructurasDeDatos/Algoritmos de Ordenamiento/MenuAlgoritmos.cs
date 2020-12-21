using EstructurasDeDatos.Algoritmos_de_Ordenamiento;
using System;
using System.Windows.Forms;

namespace EstructurasDeDatos
{
    public partial class MenuAlgoritmos : Form
    {
        Burbuja burbuja = new Burbuja();
        CocktailSort cocktail = new CocktailSort();
        Counts counts = new Counts();
        Shell shell = new Shell();
        Radix radix = new Radix();
        
        public MenuAlgoritmos()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            burbuja.Show();
            Hide();
        }


        private void MenuAlgoritmos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cocktail.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            counts.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            shell.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            radix.Show();
            Hide();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {

            MenuPrincipal m = new MenuPrincipal();
            m.Show();
            Hide();

        }
    }
}
