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
    public partial class MenuAlgoritmos : Form
    {
        Burbuja burbuja = new Burbuja();
        public MenuAlgoritmos()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            burbuja.Show();
            Hide();
        }
    }
}
