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
        private int coin;
        private Random ran = new Random();
        public Menu1()
        {
            InitializeComponent();
            coin = ran.Next(0, 2);
            if (coin == 1)
            {
                pnlAnuncio2.BackgroundImage = Proyecto.Properties.Resources.Anuncio1;
                pnlAnuncio1.BackgroundImage = Proyecto.Properties.Resources.Anuncio1;
            }
            else
            {
                pnlAnuncio2.BackgroundImage = Proyecto.Properties.Resources.Anuncio2;
                pnlAnuncio1.BackgroundImage = Proyecto.Properties.Resources.Anuncio2;
            }
            tmrAnuncios.Interval = 120000;
            tmrAnuncios.Tick += new EventHandler(timer_Tick);
            tmrAnuncios.Start();
}


        private void label1_Click(object sender, EventArgs e)
        {
            form2.Show();
            this.Hide();
        }

        private void idle()
        {

            tmrAnuncios.Interval = 120000;
            tmrAnuncios.Start();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        
        private void pnlAnuncio1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void timer_Tick(object sender, EventArgs e)
        {
            coin = ran.Next(1, 3);
            switch (coin)// Switch que cambia el fondo de panel que mestra los anuncios. los miskmospueden ser aumntados en cantidad, agregados en variedad y más en u n futuro pero del momento solo quería saber sie mismo funciona 
            {
                case 1:
                    pnlAnuncio2.BackgroundImage = Proyecto.Properties.Resources.Anuncio1;
                    pnlAnuncio1.BackgroundImage = Proyecto.Properties.Resources.Anuncio1;
                    break;
                case 2:
                    pnlAnuncio2.BackgroundImage = Proyecto.Properties.Resources.Anuncio2;
                    pnlAnuncio1.BackgroundImage = Proyecto.Properties.Resources.Anuncio2;
                    break;

            }
            this.idle();
        }
    }
}
