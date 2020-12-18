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
    }
}
