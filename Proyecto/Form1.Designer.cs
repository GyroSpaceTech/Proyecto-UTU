﻿
namespace Proyecto
{
    partial class Menu1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlAnuncio2 = new System.Windows.Forms.Panel();
            this.pnlAnuncio1 = new System.Windows.Forms.Panel();
            this.tmrAnuncios = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(240, 48);
            this.label1.MinimumSize = new System.Drawing.Size(328, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 138);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(240, 303);
            this.label2.MinimumSize = new System.Drawing.Size(328, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(328, 138);
            this.label2.TabIndex = 1;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pnlAnuncio2
            // 
            this.pnlAnuncio2.BackColor = System.Drawing.Color.Transparent;
            this.pnlAnuncio2.Location = new System.Drawing.Point(12, 9);
            this.pnlAnuncio2.Name = "pnlAnuncio2";
            this.pnlAnuncio2.Size = new System.Drawing.Size(185, 429);
            this.pnlAnuncio2.TabIndex = 2;
            // 
            // pnlAnuncio1
            // 
            this.pnlAnuncio1.BackColor = System.Drawing.Color.Transparent;
            this.pnlAnuncio1.Location = new System.Drawing.Point(613, 9);
            this.pnlAnuncio1.Name = "pnlAnuncio1";
            this.pnlAnuncio1.Size = new System.Drawing.Size(185, 429);
            this.pnlAnuncio1.TabIndex = 3;
            this.pnlAnuncio1.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAnuncio1_Paint);
            // 
            // Menu1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlAnuncio1);
            this.Controls.Add(this.pnlAnuncio2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Menu1";
            this.Text = "CorePoint:Inicio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlAnuncio2;
        private System.Windows.Forms.Panel pnlAnuncio1;
        private System.Windows.Forms.Timer tmrAnuncios;
    }
}

