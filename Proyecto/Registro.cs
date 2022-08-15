using System;
using System.IO;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Registro : Form
    {

        public Registro()
        {
            InitializeComponent();
        }

        public class Usuario{
            private string correo;
            private string contraseña;
        }
        private void crearUsuario(String correo, String contraseña)
        {
            using (StreamWriter escritorArchivos = new StreamWriter(correo + ".txt"))
            {
                escritorArchivos.WriteLine(contraseña);

            }
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            /*Creamos las variables referentes al usuario.*/
            String mail = txtMail.Text;
            String con1 = txtCont.Text;
            String con2 = txtContConf.Text;
            if (con1.Equals(con2))
            {
                crearUsuario(mail, con1);
            }
            else
            {
                txtError2.Visible = true;
            }
        }

        private void txtMail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtError2_Click(object sender, EventArgs e)
        {

        }
    }
}
