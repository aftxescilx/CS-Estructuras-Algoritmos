using System;
using System.Windows.Forms;

namespace EstructurasDeDatos
{
    public partial class MenuPrincipal : Form
    {
        fMenu menuE = new fMenu();
        MenuAlgoritmos menuA = new MenuAlgoritmos();
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menuE.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            menuA.Show();
            Hide();
        }

        private void MenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
