
namespace Proyecto
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.pnlAnuncio1 = new System.Windows.Forms.Panel();
            this.pnlAnuncio = new System.Windows.Forms.Panel();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(209, 269);
            this.label1.MinimumSize = new System.Drawing.Size(328, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 138);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnlAnuncio1
            // 
            this.pnlAnuncio1.BackColor = System.Drawing.Color.Transparent;
            this.pnlAnuncio1.Location = new System.Drawing.Point(551, 12);
            this.pnlAnuncio1.Name = "pnlAnuncio1";
            this.pnlAnuncio1.Size = new System.Drawing.Size(185, 429);
            this.pnlAnuncio1.TabIndex = 4;
            // 
            // pnlAnuncio
            // 
            this.pnlAnuncio.BackColor = System.Drawing.Color.Transparent;
            this.pnlAnuncio.Location = new System.Drawing.Point(12, 12);
            this.pnlAnuncio.Name = "pnlAnuncio";
            this.pnlAnuncio.Size = new System.Drawing.Size(185, 429);
            this.pnlAnuncio.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(748, 450);
            this.ControlBox = false;
            this.Controls.Add(this.pnlAnuncio);
            this.Controls.Add(this.pnlAnuncio1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlAnuncio1;
        private System.Windows.Forms.Panel pnlAnuncio;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}