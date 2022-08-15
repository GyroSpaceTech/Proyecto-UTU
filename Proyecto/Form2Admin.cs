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
using System.Collections;
namespace Proyecto
{
    public partial class Form2Admin : Form
    {
        private ArrayList agregar = new ArrayList();
        public Form2Admin()
        {
            InitializeComponent();
            pnlPuntos.Visible = false;
            pnlSets.Visible = false;
            pnlTiempo.Visible = false;
        }

        private void Listar()
        {
            using (StreamWriter escritor = new StreamWriter("Resultados.txt")) //escribe los multiples 
            {
                foreach(String s in agregar)
                {
                    escritor.WriteLine(s);
                }
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar1_Click(object sender, EventArgs e)
        {
            agregar.Add("Evento: " + txtEvento1.Text + " nº: " + txtInstancia1.Text + " Puntos: " + NUDPunto1.Value + "/" + NUDPunto2.Value + " Hora inicio / Hora final: " + txtHoraIn1.Text + "/" + txtHoraFn1.Text);
            mostrar();
        }

       private void mostrar()
        {
            foreach(String s in agregar)
            {
                lstResultados.Items.Add(s);
            }
        }
        private void btnAgregar2_Click(object sender, EventArgs e)
        {
            agregar.Add("Evento: " + txtEvento2.Text + " nº: " + txtInstancia2.Text + " Set: " + NUDSet1.Value + "/" + NUDSet2.Value + " Hora inicio / Hora final: " + txtHoraIn2.Text + "/" + txtHoraFn2.Text);
            mostrar();
        }

        private void btnAgregar3_Click(object sender, EventArgs e)
        {
            agregar.Add("Evento: " + txtEvento3.Text + " nº: " + txtInstancia3.Text + " Tiempo: Oro:" + txtOro.Text + "| Plata:" + txtPlata.Text+"| Bronce:"+txtBronce.Text+ " Hora inicio / Hora final: " + txtHoraIn3.Text + "/" + txtHoraFn3.Text);
            mostrar();
        }
        private void visualizar()
        {
            switch (cbxTipo.SelectedItem.ToString())
            {
                case "Deporte puntos":
                    pnlPuntos.Visible = true;
                    pnlSets.Visible = false;
                    pnlTiempo.Visible = false;
                    break;
                case "Deporte sets":
                    pnlPuntos.Visible = false;
                    pnlSets.Visible = true;
                    pnlTiempo.Visible = false;
                    break;
                case "Deporte tiempo":
                    pnlPuntos.Visible = false;
                    pnlSets.Visible = false;
                    pnlTiempo.Visible = true;
                    break;
            }
        }

        private void cbxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            visualizar();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void lstResultados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
