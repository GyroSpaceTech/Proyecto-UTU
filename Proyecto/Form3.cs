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

   
    public partial class Form3 : Form
    {

        private Image logIn= Image.FromFile("C:/Users/usuario/Desktop/Articulos de proyecto/Log-IN.png") ; //
        private Image iniciar = Image.FromFile("C:/Users/usuario/Desktop/Articulos de proyecto/iniciar.png");
        private Menu1 menu1 = new Menu1();
        private Boolean english = false;
        public Form3()
        {

            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
            menu1.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            /*El siguiente codigo cambia si el lenguaje del programa está en ingles
              */
            if (english) //Si el valor de english es verdadero lo cambia a falso
            {
                english = false;
            }
            else //Si el mismo es falso lo vuelve verdadero
            {
                english = true;
            }
            if (english) // si el valor es verdadero marcando que inglés está siendo solicitado 
            {
                this.label1.Image = logIn;
            }
            else 
            {
                this.label1.Image = iniciar;
            }
        }
    }
}
