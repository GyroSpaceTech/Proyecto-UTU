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
    public partial class Menu1 : Form
    {
        private Form2 form2 = new Form2();
        public Menu1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            form2.Show();
            this.Hide();
        }

        private void idle()
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
