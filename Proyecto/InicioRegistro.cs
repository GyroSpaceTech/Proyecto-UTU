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
    public partial class InicioRegistro : Form
    {
        public InicioRegistro()
        {
            InitializeComponent();
            
        }

        private void pnlInicioSesion_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtMail.Text == null || txtCont.Text == null || txtContConf.Text == null)
            {
                txtError2.Visible = true;
                txtError2.Text = "*Error espacio/os sin llenar*";
            }
            else
            {
                if (txtCont.Text != txtContConf.Text)
                {
                    txtError2.Text = "*Error contrseñas no coinciden*";
                }
            }
            if (txtCont.Text == txtContConf.Text)
            {

            }
        }

        private void txtError2_Click(object sender, EventArgs e)
        {

        }

        private void pnlRegistro_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtRegistrarme_Click(object sender, EventArgs e)
        {
            pnlRegistro.Visible = true;
        }

        private void cbxDominio_SelectedIndexChanged(object sender, EventArgs e)
        {
            String selectedIt=Convert.ToString(cbxDominio.SelectedItem);
            switch (selectedIt)
            {
                case "Otro/Other":
                    pnlOtro.Visible = true;
                    break;
                default:
                    pnlOtro.Visible = false;
                    break;
            }
        }

        private void label8_Click(object sender, EventArgs e) //al precionar iniciar:
        {
            int test = 0;
            int confirm;
            char[] caracteres;
            caracteres = txtMail.Text.ToCharArray();

            foreach (char s in caracteres)
            {
                test = test + 1;
                if (s == '@')
                {
                    confirm = test+1;
                }
                else {
                    test = test + 1;
                     }
                }
            Console.WriteLine(test);

            if (txtMail.Text != null)
            {

            }
        }

        private void lblCOnt_Click(object sender, EventArgs e)
        {

        }

        private void pnlOtro_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            int test = 0;
            char[] caracteres;
            caracteres =txtElectronico.Text.ToCharArray();

            foreach(char s in caracteres)
            {
                test = test + 1;
            }
            Console.WriteLine(test);
            if (txtElectronico.Text != null&& caracteres[0].Equals('@') && caracteres[test-4].Equals('.') )
            {
                cbxDominio.Items.Add(txtElectronico.Text);
            }
            else
            {
                txtError2.Visible=true;
                txtError2.Text = "*Error Dominio erroneo*";
            }
            pnlOtro.Visible = false;
        }
    }
}
