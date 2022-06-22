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

namespace Proyecto
{

   
    public partial class Form3 : Form
    {

        private Image logIn= Proyecto.Properties.Resources.Log_IN ; //
        private Image iniciar = Proyecto.Properties.Resources.iniciar;
        private Menu1 menu1 = new Menu1();
        private Boolean english = false;
        public Form3()
        {

            InitializeComponent();
        }

        private void verUsuarios(String mail, String cont)
        {
            StreamReader lectorUsuario = new StreamReader(mail+".txt");
            if((lectorUsuario.ReadLine()).Equals(cont)) //busca en el archivo del usuario la primer linea que debería ser la contraseña.
            {
                if (lectorUsuario.ReadLine() != null) //En un futuro este if permitirá diferencíar los usuarios que pagan de los comunes.
                {

                }
                else
                {

                }
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == ("Admin00"))
            {
                menu1.Show();
                this.Hide();
            }
            if (Convert.ToString(txtMail)==("Admin00"))
            {
               
            }
            
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

        private void label5_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();
            ;
        }

        private void lblInvitado_Click(object sender, EventArgs e)
        {
            menu1.Show();
            this.Hide();
        }
    }
}
