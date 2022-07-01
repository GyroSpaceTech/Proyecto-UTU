using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Form1Admin : Form
    {
        public Form1Admin()
        {
            InitializeComponent();
        }

        private void lblBoton1_Click(object sender, EventArgs e)
        {
            Form2Admin plantillas = new Form2Admin();
            plantillas.Show();
            this.Hide();
        }

        private void lblBotonSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
