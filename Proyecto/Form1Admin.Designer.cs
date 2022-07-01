namespace Proyecto
{
    partial class Form1Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1Admin));
            this.lblBotonSalir = new System.Windows.Forms.Label();
            this.lblBoton1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBotonSalir
            // 
            this.lblBotonSalir.AutoSize = true;
            this.lblBotonSalir.BackColor = System.Drawing.Color.Transparent;
            this.lblBotonSalir.Image = ((System.Drawing.Image)(resources.GetObject("lblBotonSalir.Image")));
            this.lblBotonSalir.Location = new System.Drawing.Point(236, 284);
            this.lblBotonSalir.MinimumSize = new System.Drawing.Size(328, 138);
            this.lblBotonSalir.Name = "lblBotonSalir";
            this.lblBotonSalir.Size = new System.Drawing.Size(328, 138);
            this.lblBotonSalir.TabIndex = 3;
            this.lblBotonSalir.Click += new System.EventHandler(this.lblBotonSalir_Click);
            // 
            // lblBoton1
            // 
            this.lblBoton1.AutoSize = true;
            this.lblBoton1.BackColor = System.Drawing.Color.Transparent;
            this.lblBoton1.Image = ((System.Drawing.Image)(resources.GetObject("lblBoton1.Image")));
            this.lblBoton1.Location = new System.Drawing.Point(236, 29);
            this.lblBoton1.MinimumSize = new System.Drawing.Size(328, 138);
            this.lblBoton1.Name = "lblBoton1";
            this.lblBoton1.Size = new System.Drawing.Size(328, 138);
            this.lblBoton1.TabIndex = 2;
            this.lblBoton1.Click += new System.EventHandler(this.lblBoton1_Click);
            // 
            // Form1Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBotonSalir);
            this.Controls.Add(this.lblBoton1);
            this.Name = "Form1Admin";
            this.Text = "CorePointAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBotonSalir;
        private System.Windows.Forms.Label lblBoton1;
    }
}