namespace Proyecto
{
    partial class InicioRegistro
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
            this.pnlInicioSesion = new System.Windows.Forms.Panel();
            this.pnlRegistro = new System.Windows.Forms.Panel();
            this.pnlOtro = new System.Windows.Forms.Panel();
            this.btnConfirmar = new System.Windows.Forms.Label();
            this.txtElectronico = new System.Windows.Forms.TextBox();
            this.cbxDominio = new System.Windows.Forms.ComboBox();
            this.txtError2 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblConfCOnt = new System.Windows.Forms.Label();
            this.txtContConf = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblCOnt = new System.Windows.Forms.Label();
            this.txtContRegistro = new System.Windows.Forms.TextBox();
            this.txtCorreoRegistro = new System.Windows.Forms.TextBox();
            this.txtRegistrarme = new System.Windows.Forms.Label();
            this.lblInvitado = new System.Windows.Forms.Label();
            this.lblCorr = new System.Windows.Forms.Label();
            this.lblContr = new System.Windows.Forms.Label();
            this.txtCont = new System.Windows.Forms.TextBox();
            this.cbxLenguaje = new System.Windows.Forms.CheckBox();
            this.btnIniciar = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.pnlInicioSesion.SuspendLayout();
            this.pnlRegistro.SuspendLayout();
            this.pnlOtro.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInicioSesion
            // 
            this.pnlInicioSesion.BackColor = System.Drawing.Color.LimeGreen;
            this.pnlInicioSesion.Controls.Add(this.pnlRegistro);
            this.pnlInicioSesion.Controls.Add(this.txtRegistrarme);
            this.pnlInicioSesion.Controls.Add(this.lblInvitado);
            this.pnlInicioSesion.Controls.Add(this.lblCorr);
            this.pnlInicioSesion.Controls.Add(this.lblContr);
            this.pnlInicioSesion.Controls.Add(this.txtCont);
            this.pnlInicioSesion.Controls.Add(this.cbxLenguaje);
            this.pnlInicioSesion.Controls.Add(this.btnIniciar);
            this.pnlInicioSesion.Controls.Add(this.txtMail);
            this.pnlInicioSesion.Location = new System.Drawing.Point(1, -9);
            this.pnlInicioSesion.Name = "pnlInicioSesion";
            this.pnlInicioSesion.Size = new System.Drawing.Size(695, 269);
            this.pnlInicioSesion.TabIndex = 1;
            this.pnlInicioSesion.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlInicioSesion_Paint);
            // 
            // pnlRegistro
            // 
            this.pnlRegistro.Controls.Add(this.pnlOtro);
            this.pnlRegistro.Controls.Add(this.cbxDominio);
            this.pnlRegistro.Controls.Add(this.txtError2);
            this.pnlRegistro.Controls.Add(this.btnRegistrar);
            this.pnlRegistro.Controls.Add(this.lblConfCOnt);
            this.pnlRegistro.Controls.Add(this.txtContConf);
            this.pnlRegistro.Controls.Add(this.lblCorreo);
            this.pnlRegistro.Controls.Add(this.lblCOnt);
            this.pnlRegistro.Controls.Add(this.txtContRegistro);
            this.pnlRegistro.Controls.Add(this.txtCorreoRegistro);
            this.pnlRegistro.Location = new System.Drawing.Point(398, 0);
            this.pnlRegistro.Name = "pnlRegistro";
            this.pnlRegistro.Size = new System.Drawing.Size(307, 268);
            this.pnlRegistro.TabIndex = 17;
            this.pnlRegistro.Visible = false;
            this.pnlRegistro.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlRegistro_Paint);
            // 
            // pnlOtro
            // 
            this.pnlOtro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOtro.Controls.Add(this.btnConfirmar);
            this.pnlOtro.Controls.Add(this.txtElectronico);
            this.pnlOtro.Location = new System.Drawing.Point(160, 74);
            this.pnlOtro.Name = "pnlOtro";
            this.pnlOtro.Size = new System.Drawing.Size(119, 35);
            this.pnlOtro.TabIndex = 24;
            this.pnlOtro.Visible = false;
            this.pnlOtro.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlOtro_Paint);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.AutoSize = true;
            this.btnConfirmar.BackColor = System.Drawing.Color.CadetBlue;
            this.btnConfirmar.Location = new System.Drawing.Point(97, 19);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(19, 13);
            this.btnConfirmar.TabIndex = 1;
            this.btnConfirmar.Text = "ok";
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // txtElectronico
            // 
            this.txtElectronico.Location = new System.Drawing.Point(0, 2);
            this.txtElectronico.Name = "txtElectronico";
            this.txtElectronico.Size = new System.Drawing.Size(100, 20);
            this.txtElectronico.TabIndex = 0;
            // 
            // cbxDominio
            // 
            this.cbxDominio.FormattingEnabled = true;
            this.cbxDominio.Items.AddRange(new object[] {
            "@gmail.com",
            "@hotmail.com",
            "@outlook.com",
            "Otro/Other"});
            this.cbxDominio.Location = new System.Drawing.Point(205, 49);
            this.cbxDominio.Name = "cbxDominio";
            this.cbxDominio.Size = new System.Drawing.Size(73, 21);
            this.cbxDominio.TabIndex = 23;
            this.cbxDominio.SelectedIndexChanged += new System.EventHandler(this.cbxDominio_SelectedIndexChanged);
            // 
            // txtError2
            // 
            this.txtError2.AutoSize = true;
            this.txtError2.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtError2.Location = new System.Drawing.Point(51, 156);
            this.txtError2.Name = "txtError2";
            this.txtError2.Size = new System.Drawing.Size(183, 16);
            this.txtError2.TabIndex = 22;
            this.txtError2.Text = "*Error contrseñas no coinciden*";
            this.txtError2.Visible = false;
            this.txtError2.Click += new System.EventHandler(this.txtError2_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(54, 186);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 21;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lblConfCOnt
            // 
            this.lblConfCOnt.AutoSize = true;
            this.lblConfCOnt.BackColor = System.Drawing.Color.Transparent;
            this.lblConfCOnt.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfCOnt.Location = new System.Drawing.Point(51, 114);
            this.lblConfCOnt.Name = "lblConfCOnt";
            this.lblConfCOnt.Size = new System.Drawing.Size(124, 16);
            this.lblConfCOnt.TabIndex = 20;
            this.lblConfCOnt.Text = "Confirmar Contraseña";
            // 
            // txtContConf
            // 
            this.txtContConf.Location = new System.Drawing.Point(54, 133);
            this.txtContConf.Name = "txtContConf";
            this.txtContConf.Size = new System.Drawing.Size(100, 20);
            this.txtContConf.TabIndex = 19;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.BackColor = System.Drawing.Color.Transparent;
            this.lblCorreo.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(87, 32);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(111, 16);
            this.lblCorreo.TabIndex = 18;
            this.lblCorreo.Text = "Correo Electronico";
            // 
            // lblCOnt
            // 
            this.lblCOnt.AutoSize = true;
            this.lblCOnt.BackColor = System.Drawing.Color.Transparent;
            this.lblCOnt.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCOnt.Location = new System.Drawing.Point(51, 74);
            this.lblCOnt.Name = "lblCOnt";
            this.lblCOnt.Size = new System.Drawing.Size(68, 16);
            this.lblCOnt.TabIndex = 17;
            this.lblCOnt.Text = "Contraseña";
            this.lblCOnt.Click += new System.EventHandler(this.lblCOnt_Click);
            // 
            // txtContRegistro
            // 
            this.txtContRegistro.Location = new System.Drawing.Point(54, 91);
            this.txtContRegistro.Name = "txtContRegistro";
            this.txtContRegistro.Size = new System.Drawing.Size(100, 20);
            this.txtContRegistro.TabIndex = 16;
            // 
            // txtCorreoRegistro
            // 
            this.txtCorreoRegistro.Location = new System.Drawing.Point(54, 51);
            this.txtCorreoRegistro.Name = "txtCorreoRegistro";
            this.txtCorreoRegistro.Size = new System.Drawing.Size(144, 20);
            this.txtCorreoRegistro.TabIndex = 15;
            // 
            // txtRegistrarme
            // 
            this.txtRegistrarme.AutoSize = true;
            this.txtRegistrarme.BackColor = System.Drawing.Color.Transparent;
            this.txtRegistrarme.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegistrarme.Location = new System.Drawing.Point(88, 99);
            this.txtRegistrarme.Name = "txtRegistrarme";
            this.txtRegistrarme.Size = new System.Drawing.Size(71, 16);
            this.txtRegistrarme.TabIndex = 16;
            this.txtRegistrarme.Text = "Registrarme";
            this.txtRegistrarme.Click += new System.EventHandler(this.txtRegistrarme_Click);
            // 
            // lblInvitado
            // 
            this.lblInvitado.AutoSize = true;
            this.lblInvitado.BackColor = System.Drawing.Color.Transparent;
            this.lblInvitado.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvitado.Location = new System.Drawing.Point(88, 133);
            this.lblInvitado.Name = "lblInvitado";
            this.lblInvitado.Size = new System.Drawing.Size(162, 16);
            this.lblInvitado.TabIndex = 15;
            this.lblInvitado.Text = "Inisciar sesión como invitado";
            // 
            // lblCorr
            // 
            this.lblCorr.AutoSize = true;
            this.lblCorr.BackColor = System.Drawing.Color.Transparent;
            this.lblCorr.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorr.Location = new System.Drawing.Point(33, 9);
            this.lblCorr.Name = "lblCorr";
            this.lblCorr.Size = new System.Drawing.Size(111, 16);
            this.lblCorr.TabIndex = 14;
            this.lblCorr.Text = "Correo Electronico";
            // 
            // lblContr
            // 
            this.lblContr.AutoSize = true;
            this.lblContr.BackColor = System.Drawing.Color.Transparent;
            this.lblContr.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContr.Location = new System.Drawing.Point(33, 51);
            this.lblContr.Name = "lblContr";
            this.lblContr.Size = new System.Drawing.Size(68, 16);
            this.lblContr.TabIndex = 13;
            this.lblContr.Text = "Contraseña";
            // 
            // txtCont
            // 
            this.txtCont.Location = new System.Drawing.Point(91, 70);
            this.txtCont.Name = "txtCont";
            this.txtCont.Size = new System.Drawing.Size(100, 20);
            this.txtCont.TabIndex = 12;
            // 
            // cbxLenguaje
            // 
            this.cbxLenguaje.AutoSize = true;
            this.cbxLenguaje.BackColor = System.Drawing.Color.Transparent;
            this.cbxLenguaje.Location = new System.Drawing.Point(311, 8);
            this.cbxLenguaje.Name = "cbxLenguaje";
            this.cbxLenguaje.Size = new System.Drawing.Size(60, 17);
            this.cbxLenguaje.TabIndex = 11;
            this.cbxLenguaje.Text = "English";
            this.cbxLenguaje.UseVisualStyleBackColor = false;
            // 
            // btnIniciar
            // 
            this.btnIniciar.AutoSize = true;
            this.btnIniciar.BackColor = System.Drawing.Color.Transparent;
            this.btnIniciar.Image = global::Proyecto.Properties.Resources.iniciar;
            this.btnIniciar.Location = new System.Drawing.Point(283, 186);
            this.btnIniciar.MinimumSize = new System.Drawing.Size(75, 23);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar.TabIndex = 10;
            this.btnIniciar.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(91, 28);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(194, 20);
            this.txtMail.TabIndex = 9;
            // 
            // InicioRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 231);
            this.Controls.Add(this.pnlInicioSesion);
            this.Name = "InicioRegistro";
            this.Text = "Form1";
            this.pnlInicioSesion.ResumeLayout(false);
            this.pnlInicioSesion.PerformLayout();
            this.pnlRegistro.ResumeLayout(false);
            this.pnlRegistro.PerformLayout();
            this.pnlOtro.ResumeLayout(false);
            this.pnlOtro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlInicioSesion;
        private System.Windows.Forms.Panel pnlRegistro;
        private System.Windows.Forms.Label txtError2;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblConfCOnt;
        private System.Windows.Forms.TextBox txtContConf;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblCOnt;
        private System.Windows.Forms.TextBox txtContRegistro;
        private System.Windows.Forms.TextBox txtCorreoRegistro;
        private System.Windows.Forms.Label txtRegistrarme;
        private System.Windows.Forms.Label lblInvitado;
        private System.Windows.Forms.Label lblCorr;
        private System.Windows.Forms.Label lblContr;
        private System.Windows.Forms.TextBox txtCont;
        private System.Windows.Forms.CheckBox cbxLenguaje;
        private System.Windows.Forms.Label btnIniciar;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Panel pnlOtro;
        private System.Windows.Forms.TextBox txtElectronico;
        private System.Windows.Forms.ComboBox cbxDominio;
        private System.Windows.Forms.Label btnConfirmar;
    }
}