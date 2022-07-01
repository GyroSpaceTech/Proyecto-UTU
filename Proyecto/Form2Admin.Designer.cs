namespace Proyecto
{
    partial class Form2Admin
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
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstResultados = new System.Windows.Forms.ListBox();
            this.pnlTiempo = new System.Windows.Forms.Panel();
            this.btnAgregar3 = new System.Windows.Forms.Button();
            this.txtHoraFn3 = new System.Windows.Forms.TextBox();
            this.txtHoraIn3 = new System.Windows.Forms.TextBox();
            this.txtEvento3 = new System.Windows.Forms.TextBox();
            this.txtInstancia3 = new System.Windows.Forms.TextBox();
            this.txtBronce = new System.Windows.Forms.TextBox();
            this.txtPlata = new System.Windows.Forms.TextBox();
            this.txtOro = new System.Windows.Forms.TextBox();
            this.lblBronce = new System.Windows.Forms.Label();
            this.lblPlata = new System.Windows.Forms.Label();
            this.lblOro = new System.Windows.Forms.Label();
            this.lblHoraFn3 = new System.Windows.Forms.Label();
            this.lblHoraIn3 = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.lblInstancia3 = new System.Windows.Forms.Label();
            this.lblEvento3 = new System.Windows.Forms.Label();
            this.pnlSets = new System.Windows.Forms.Panel();
            this.btnAgregar2 = new System.Windows.Forms.Button();
            this.txtHoraFn2 = new System.Windows.Forms.TextBox();
            this.txtHoraIn2 = new System.Windows.Forms.TextBox();
            this.txtInstancia2 = new System.Windows.Forms.TextBox();
            this.txtEvento2 = new System.Windows.Forms.TextBox();
            this.NUDSet2 = new System.Windows.Forms.NumericUpDown();
            this.NUDSet1 = new System.Windows.Forms.NumericUpDown();
            this.lblHoraFn2 = new System.Windows.Forms.Label();
            this.lblHoraIn2 = new System.Windows.Forms.Label();
            this.lblSets = new System.Windows.Forms.Label();
            this.lblInstancia2 = new System.Windows.Forms.Label();
            this.lblEvento2 = new System.Windows.Forms.Label();
            this.pnlPuntos = new System.Windows.Forms.Panel();
            this.btnAgregar1 = new System.Windows.Forms.Button();
            this.txtHoraFn1 = new System.Windows.Forms.TextBox();
            this.txtHoraIn1 = new System.Windows.Forms.TextBox();
            this.txtInstancia1 = new System.Windows.Forms.TextBox();
            this.txtEvento1 = new System.Windows.Forms.TextBox();
            this.NUDPunto1 = new System.Windows.Forms.NumericUpDown();
            this.NUDPunto2 = new System.Windows.Forms.NumericUpDown();
            this.lblHoraFn1 = new System.Windows.Forms.Label();
            this.lblHoraIn1 = new System.Windows.Forms.Label();
            this.lblPuntos = new System.Windows.Forms.Label();
            this.lblInstancia1 = new System.Windows.Forms.Label();
            this.lblEvento1 = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlTiempo.SuspendLayout();
            this.pnlSets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDSet1)).BeginInit();
            this.pnlPuntos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDPunto1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDPunto2)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxTipo
            // 
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Items.AddRange(new object[] {
            "Deporte puntos",
            "Deporte sets",
            "Deporte tiempo"});
            this.cbxTipo.Location = new System.Drawing.Point(379, 39);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(121, 21);
            this.cbxTipo.TabIndex = 0;
            this.cbxTipo.SelectedIndexChanged += new System.EventHandler(this.cbxTipo_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lstResultados);
            this.panel1.Controls.Add(this.pnlTiempo);
            this.panel1.Controls.Add(this.pnlSets);
            this.panel1.Controls.Add(this.pnlPuntos);
            this.panel1.Location = new System.Drawing.Point(-2, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 333);
            this.panel1.TabIndex = 1;
            // 
            // lstResultados
            // 
            this.lstResultados.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstResultados.FormattingEnabled = true;
            this.lstResultados.Location = new System.Drawing.Point(550, 0);
            this.lstResultados.Name = "lstResultados";
            this.lstResultados.Size = new System.Drawing.Size(275, 333);
            this.lstResultados.TabIndex = 3;
            this.lstResultados.SelectedIndexChanged += new System.EventHandler(this.lstResultados_SelectedIndexChanged);
            // 
            // pnlTiempo
            // 
            this.pnlTiempo.Controls.Add(this.btnAgregar3);
            this.pnlTiempo.Controls.Add(this.txtHoraFn3);
            this.pnlTiempo.Controls.Add(this.txtHoraIn3);
            this.pnlTiempo.Controls.Add(this.txtEvento3);
            this.pnlTiempo.Controls.Add(this.txtInstancia3);
            this.pnlTiempo.Controls.Add(this.txtBronce);
            this.pnlTiempo.Controls.Add(this.txtPlata);
            this.pnlTiempo.Controls.Add(this.txtOro);
            this.pnlTiempo.Controls.Add(this.lblBronce);
            this.pnlTiempo.Controls.Add(this.lblPlata);
            this.pnlTiempo.Controls.Add(this.lblOro);
            this.pnlTiempo.Controls.Add(this.lblHoraFn3);
            this.pnlTiempo.Controls.Add(this.lblHoraIn3);
            this.pnlTiempo.Controls.Add(this.lblTiempo);
            this.pnlTiempo.Controls.Add(this.lblInstancia3);
            this.pnlTiempo.Controls.Add(this.lblEvento3);
            this.pnlTiempo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTiempo.Location = new System.Drawing.Point(370, 0);
            this.pnlTiempo.Name = "pnlTiempo";
            this.pnlTiempo.Size = new System.Drawing.Size(180, 333);
            this.pnlTiempo.TabIndex = 2;
            // 
            // btnAgregar3
            // 
            this.btnAgregar3.Location = new System.Drawing.Point(105, 301);
            this.btnAgregar3.Name = "btnAgregar3";
            this.btnAgregar3.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar3.TabIndex = 18;
            this.btnAgregar3.Text = "Agregar";
            this.btnAgregar3.UseVisualStyleBackColor = true;
            this.btnAgregar3.Click += new System.EventHandler(this.btnAgregar3_Click);
            // 
            // txtHoraFn3
            // 
            this.txtHoraFn3.Location = new System.Drawing.Point(11, 240);
            this.txtHoraFn3.Name = "txtHoraFn3";
            this.txtHoraFn3.Size = new System.Drawing.Size(53, 20);
            this.txtHoraFn3.TabIndex = 16;
            // 
            // txtHoraIn3
            // 
            this.txtHoraIn3.Location = new System.Drawing.Point(92, 208);
            this.txtHoraIn3.Name = "txtHoraIn3";
            this.txtHoraIn3.Size = new System.Drawing.Size(53, 20);
            this.txtHoraIn3.TabIndex = 15;
            // 
            // txtEvento3
            // 
            this.txtEvento3.Location = new System.Drawing.Point(45, 31);
            this.txtEvento3.Name = "txtEvento3";
            this.txtEvento3.Size = new System.Drawing.Size(97, 20);
            this.txtEvento3.TabIndex = 14;
            // 
            // txtInstancia3
            // 
            this.txtInstancia3.Location = new System.Drawing.Point(45, 73);
            this.txtInstancia3.Name = "txtInstancia3";
            this.txtInstancia3.Size = new System.Drawing.Size(97, 20);
            this.txtInstancia3.TabIndex = 13;
            // 
            // txtBronce
            // 
            this.txtBronce.Location = new System.Drawing.Point(79, 176);
            this.txtBronce.Name = "txtBronce";
            this.txtBronce.Size = new System.Drawing.Size(53, 20);
            this.txtBronce.TabIndex = 12;
            // 
            // txtPlata
            // 
            this.txtPlata.Location = new System.Drawing.Point(61, 152);
            this.txtPlata.Name = "txtPlata";
            this.txtPlata.Size = new System.Drawing.Size(53, 20);
            this.txtPlata.TabIndex = 11;
            // 
            // txtOro
            // 
            this.txtOro.Location = new System.Drawing.Point(45, 118);
            this.txtOro.Name = "txtOro";
            this.txtOro.Size = new System.Drawing.Size(53, 20);
            this.txtOro.TabIndex = 10;
            // 
            // lblBronce
            // 
            this.lblBronce.AutoSize = true;
            this.lblBronce.Location = new System.Drawing.Point(32, 183);
            this.lblBronce.Name = "lblBronce";
            this.lblBronce.Size = new System.Drawing.Size(41, 13);
            this.lblBronce.TabIndex = 9;
            this.lblBronce.Text = "Bronce";
            // 
            // lblPlata
            // 
            this.lblPlata.AutoSize = true;
            this.lblPlata.Location = new System.Drawing.Point(24, 152);
            this.lblPlata.Name = "lblPlata";
            this.lblPlata.Size = new System.Drawing.Size(31, 13);
            this.lblPlata.TabIndex = 8;
            this.lblPlata.Text = "Plata";
            // 
            // lblOro
            // 
            this.lblOro.AutoSize = true;
            this.lblOro.Location = new System.Drawing.Point(11, 118);
            this.lblOro.Name = "lblOro";
            this.lblOro.Size = new System.Drawing.Size(24, 13);
            this.lblOro.TabIndex = 7;
            this.lblOro.Text = "Oro";
            this.lblOro.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblHoraFn3
            // 
            this.lblHoraFn3.AutoSize = true;
            this.lblHoraFn3.Location = new System.Drawing.Point(77, 240);
            this.lblHoraFn3.Name = "lblHoraFn3";
            this.lblHoraFn3.Size = new System.Drawing.Size(103, 13);
            this.lblHoraFn3.TabIndex = 6;
            this.lblHoraFn3.Text = "Hora de Finalización";
            // 
            // lblHoraIn3
            // 
            this.lblHoraIn3.AutoSize = true;
            this.lblHoraIn3.Location = new System.Drawing.Point(8, 208);
            this.lblHoraIn3.Name = "lblHoraIn3";
            this.lblHoraIn3.Size = new System.Drawing.Size(72, 13);
            this.lblHoraIn3.TabIndex = 5;
            this.lblHoraIn3.Text = "Hora de inicio";
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Location = new System.Drawing.Point(42, 96);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(100, 13);
            this.lblTiempo.TabIndex = 4;
            this.lblTiempo.Text = "Tiempos del evento";
            // 
            // lblInstancia3
            // 
            this.lblInstancia3.AutoSize = true;
            this.lblInstancia3.Location = new System.Drawing.Point(42, 54);
            this.lblInstancia3.Name = "lblInstancia3";
            this.lblInstancia3.Size = new System.Drawing.Size(103, 13);
            this.lblInstancia3.TabIndex = 2;
            this.lblInstancia3.Text = "Instancia del evento";
            // 
            // lblEvento3
            // 
            this.lblEvento3.AutoSize = true;
            this.lblEvento3.Location = new System.Drawing.Point(42, 0);
            this.lblEvento3.Name = "lblEvento3";
            this.lblEvento3.Size = new System.Drawing.Size(90, 13);
            this.lblEvento3.TabIndex = 1;
            this.lblEvento3.Text = "Evento Deportivo";
            // 
            // pnlSets
            // 
            this.pnlSets.Controls.Add(this.btnAgregar2);
            this.pnlSets.Controls.Add(this.txtHoraFn2);
            this.pnlSets.Controls.Add(this.txtHoraIn2);
            this.pnlSets.Controls.Add(this.txtInstancia2);
            this.pnlSets.Controls.Add(this.txtEvento2);
            this.pnlSets.Controls.Add(this.NUDSet2);
            this.pnlSets.Controls.Add(this.NUDSet1);
            this.pnlSets.Controls.Add(this.lblHoraFn2);
            this.pnlSets.Controls.Add(this.lblHoraIn2);
            this.pnlSets.Controls.Add(this.lblSets);
            this.pnlSets.Controls.Add(this.lblInstancia2);
            this.pnlSets.Controls.Add(this.lblEvento2);
            this.pnlSets.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSets.Location = new System.Drawing.Point(194, 0);
            this.pnlSets.Name = "pnlSets";
            this.pnlSets.Size = new System.Drawing.Size(176, 333);
            this.pnlSets.TabIndex = 1;
            // 
            // btnAgregar2
            // 
            this.btnAgregar2.Location = new System.Drawing.Point(101, 301);
            this.btnAgregar2.Name = "btnAgregar2";
            this.btnAgregar2.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar2.TabIndex = 18;
            this.btnAgregar2.Text = "Agregar";
            this.btnAgregar2.UseVisualStyleBackColor = true;
            this.btnAgregar2.Click += new System.EventHandler(this.btnAgregar2_Click);
            // 
            // txtHoraFn2
            // 
            this.txtHoraFn2.Location = new System.Drawing.Point(9, 239);
            this.txtHoraFn2.Name = "txtHoraFn2";
            this.txtHoraFn2.Size = new System.Drawing.Size(53, 20);
            this.txtHoraFn2.TabIndex = 16;
            // 
            // txtHoraIn2
            // 
            this.txtHoraIn2.Location = new System.Drawing.Point(97, 205);
            this.txtHoraIn2.Name = "txtHoraIn2";
            this.txtHoraIn2.Size = new System.Drawing.Size(53, 20);
            this.txtHoraIn2.TabIndex = 11;
            // 
            // txtInstancia2
            // 
            this.txtInstancia2.Location = new System.Drawing.Point(50, 70);
            this.txtInstancia2.Name = "txtInstancia2";
            this.txtInstancia2.Size = new System.Drawing.Size(97, 20);
            this.txtInstancia2.TabIndex = 15;
            // 
            // txtEvento2
            // 
            this.txtEvento2.Location = new System.Drawing.Point(50, 16);
            this.txtEvento2.Name = "txtEvento2";
            this.txtEvento2.Size = new System.Drawing.Size(97, 20);
            this.txtEvento2.TabIndex = 14;
            // 
            // NUDSet2
            // 
            this.NUDSet2.Location = new System.Drawing.Point(112, 131);
            this.NUDSet2.Name = "NUDSet2";
            this.NUDSet2.Size = new System.Drawing.Size(58, 20);
            this.NUDSet2.TabIndex = 8;
            // 
            // NUDSet1
            // 
            this.NUDSet1.Location = new System.Drawing.Point(20, 131);
            this.NUDSet1.Name = "NUDSet1";
            this.NUDSet1.Size = new System.Drawing.Size(58, 20);
            this.NUDSet1.TabIndex = 7;
            // 
            // lblHoraFn2
            // 
            this.lblHoraFn2.AutoSize = true;
            this.lblHoraFn2.Location = new System.Drawing.Point(73, 242);
            this.lblHoraFn2.Name = "lblHoraFn2";
            this.lblHoraFn2.Size = new System.Drawing.Size(103, 13);
            this.lblHoraFn2.TabIndex = 5;
            this.lblHoraFn2.Text = "Hora de Finalización";
            // 
            // lblHoraIn2
            // 
            this.lblHoraIn2.AutoSize = true;
            this.lblHoraIn2.Location = new System.Drawing.Point(6, 208);
            this.lblHoraIn2.Name = "lblHoraIn2";
            this.lblHoraIn2.Size = new System.Drawing.Size(72, 13);
            this.lblHoraIn2.TabIndex = 4;
            this.lblHoraIn2.Text = "Hora de inicio";
            // 
            // lblSets
            // 
            this.lblSets.AutoSize = true;
            this.lblSets.Location = new System.Drawing.Point(36, 96);
            this.lblSets.Name = "lblSets";
            this.lblSets.Size = new System.Drawing.Size(134, 13);
            this.lblSets.TabIndex = 3;
            this.lblSets.Text = "Sets del evento del evento";
            // 
            // lblInstancia2
            // 
            this.lblInstancia2.AutoSize = true;
            this.lblInstancia2.Location = new System.Drawing.Point(47, 54);
            this.lblInstancia2.Name = "lblInstancia2";
            this.lblInstancia2.Size = new System.Drawing.Size(103, 13);
            this.lblInstancia2.TabIndex = 2;
            this.lblInstancia2.Text = "Instancia del evento";
            // 
            // lblEvento2
            // 
            this.lblEvento2.AutoSize = true;
            this.lblEvento2.Location = new System.Drawing.Point(47, 0);
            this.lblEvento2.Name = "lblEvento2";
            this.lblEvento2.Size = new System.Drawing.Size(90, 13);
            this.lblEvento2.TabIndex = 1;
            this.lblEvento2.Text = "Evento Deportivo";
            // 
            // pnlPuntos
            // 
            this.pnlPuntos.Controls.Add(this.btnAgregar1);
            this.pnlPuntos.Controls.Add(this.txtHoraFn1);
            this.pnlPuntos.Controls.Add(this.txtHoraIn1);
            this.pnlPuntos.Controls.Add(this.txtInstancia1);
            this.pnlPuntos.Controls.Add(this.txtEvento1);
            this.pnlPuntos.Controls.Add(this.NUDPunto1);
            this.pnlPuntos.Controls.Add(this.NUDPunto2);
            this.pnlPuntos.Controls.Add(this.lblHoraFn1);
            this.pnlPuntos.Controls.Add(this.lblHoraIn1);
            this.pnlPuntos.Controls.Add(this.lblPuntos);
            this.pnlPuntos.Controls.Add(this.lblInstancia1);
            this.pnlPuntos.Controls.Add(this.lblEvento1);
            this.pnlPuntos.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlPuntos.Location = new System.Drawing.Point(0, 0);
            this.pnlPuntos.Name = "pnlPuntos";
            this.pnlPuntos.Size = new System.Drawing.Size(194, 333);
            this.pnlPuntos.TabIndex = 0;
            // 
            // btnAgregar1
            // 
            this.btnAgregar1.Location = new System.Drawing.Point(111, 301);
            this.btnAgregar1.Name = "btnAgregar1";
            this.btnAgregar1.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar1.TabIndex = 17;
            this.btnAgregar1.Text = "Agregar";
            this.btnAgregar1.UseVisualStyleBackColor = true;
            this.btnAgregar1.Click += new System.EventHandler(this.btnAgregar1_Click);
            // 
            // txtHoraFn1
            // 
            this.txtHoraFn1.Location = new System.Drawing.Point(28, 239);
            this.txtHoraFn1.Name = "txtHoraFn1";
            this.txtHoraFn1.Size = new System.Drawing.Size(53, 20);
            this.txtHoraFn1.TabIndex = 16;
            // 
            // txtHoraIn1
            // 
            this.txtHoraIn1.Location = new System.Drawing.Point(98, 208);
            this.txtHoraIn1.Name = "txtHoraIn1";
            this.txtHoraIn1.Size = new System.Drawing.Size(53, 20);
            this.txtHoraIn1.TabIndex = 15;
            // 
            // txtInstancia1
            // 
            this.txtInstancia1.Location = new System.Drawing.Point(49, 73);
            this.txtInstancia1.Name = "txtInstancia1";
            this.txtInstancia1.Size = new System.Drawing.Size(97, 20);
            this.txtInstancia1.TabIndex = 15;
            // 
            // txtEvento1
            // 
            this.txtEvento1.Location = new System.Drawing.Point(49, 16);
            this.txtEvento1.Name = "txtEvento1";
            this.txtEvento1.Size = new System.Drawing.Size(97, 20);
            this.txtEvento1.TabIndex = 14;
            // 
            // NUDPunto1
            // 
            this.NUDPunto1.Location = new System.Drawing.Point(28, 131);
            this.NUDPunto1.Name = "NUDPunto1";
            this.NUDPunto1.Size = new System.Drawing.Size(58, 20);
            this.NUDPunto1.TabIndex = 6;
            // 
            // NUDPunto2
            // 
            this.NUDPunto2.Location = new System.Drawing.Point(93, 131);
            this.NUDPunto2.Name = "NUDPunto2";
            this.NUDPunto2.Size = new System.Drawing.Size(58, 20);
            this.NUDPunto2.TabIndex = 5;
            // 
            // lblHoraFn1
            // 
            this.lblHoraFn1.AutoSize = true;
            this.lblHoraFn1.Location = new System.Drawing.Point(91, 240);
            this.lblHoraFn1.Name = "lblHoraFn1";
            this.lblHoraFn1.Size = new System.Drawing.Size(100, 13);
            this.lblHoraFn1.TabIndex = 4;
            this.lblHoraFn1.Text = "Hora de finalización";
            // 
            // lblHoraIn1
            // 
            this.lblHoraIn1.AutoSize = true;
            this.lblHoraIn1.Location = new System.Drawing.Point(14, 208);
            this.lblHoraIn1.Name = "lblHoraIn1";
            this.lblHoraIn1.Size = new System.Drawing.Size(72, 13);
            this.lblHoraIn1.TabIndex = 3;
            this.lblHoraIn1.Text = "Hora de inicio";
            // 
            // lblPuntos
            // 
            this.lblPuntos.AutoSize = true;
            this.lblPuntos.Location = new System.Drawing.Point(48, 96);
            this.lblPuntos.Name = "lblPuntos";
            this.lblPuntos.Size = new System.Drawing.Size(93, 13);
            this.lblPuntos.TabIndex = 2;
            this.lblPuntos.Text = "Puntos del evento";
            // 
            // lblInstancia1
            // 
            this.lblInstancia1.AutoSize = true;
            this.lblInstancia1.Location = new System.Drawing.Point(48, 54);
            this.lblInstancia1.Name = "lblInstancia1";
            this.lblInstancia1.Size = new System.Drawing.Size(103, 13);
            this.lblInstancia1.TabIndex = 1;
            this.lblInstancia1.Text = "Instancia del evento";
            // 
            // lblEvento1
            // 
            this.lblEvento1.AutoSize = true;
            this.lblEvento1.Location = new System.Drawing.Point(48, 0);
            this.lblEvento1.Name = "lblEvento1";
            this.lblEvento1.Size = new System.Drawing.Size(90, 13);
            this.lblEvento1.TabIndex = 0;
            this.lblEvento1.Text = "Evento Deportivo";
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(642, 44);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 2;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // Form2Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbxTipo);
            this.Name = "Form2Admin";
            this.Text = "Form2Admin";
            this.panel1.ResumeLayout(false);
            this.pnlTiempo.ResumeLayout(false);
            this.pnlTiempo.PerformLayout();
            this.pnlSets.ResumeLayout(false);
            this.pnlSets.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDSet1)).EndInit();
            this.pnlPuntos.ResumeLayout(false);
            this.pnlPuntos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDPunto1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDPunto2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lstResultados;
        private System.Windows.Forms.Panel pnlTiempo;
        private System.Windows.Forms.Label lblBronce;
        private System.Windows.Forms.Label lblPlata;
        private System.Windows.Forms.Label lblOro;
        private System.Windows.Forms.Label lblHoraFn3;
        private System.Windows.Forms.Label lblHoraIn3;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label lblInstancia3;
        private System.Windows.Forms.Label lblEvento3;
        private System.Windows.Forms.Panel pnlSets;
        private System.Windows.Forms.NumericUpDown NUDSet2;
        private System.Windows.Forms.NumericUpDown NUDSet1;
        private System.Windows.Forms.Label lblHoraFn2;
        private System.Windows.Forms.Label lblHoraIn2;
        private System.Windows.Forms.Label lblSets;
        private System.Windows.Forms.Label lblInstancia2;
        private System.Windows.Forms.Label lblEvento2;
        private System.Windows.Forms.Panel pnlPuntos;
        private System.Windows.Forms.NumericUpDown NUDPunto1;
        private System.Windows.Forms.NumericUpDown NUDPunto2;
        private System.Windows.Forms.Label lblHoraFn1;
        private System.Windows.Forms.Label lblHoraIn1;
        private System.Windows.Forms.Label lblPuntos;
        private System.Windows.Forms.Label lblInstancia1;
        private System.Windows.Forms.Label lblEvento1;
        private System.Windows.Forms.TextBox txtHoraFn3;
        private System.Windows.Forms.TextBox txtHoraIn3;
        private System.Windows.Forms.TextBox txtEvento3;
        private System.Windows.Forms.TextBox txtInstancia3;
        private System.Windows.Forms.TextBox txtBronce;
        private System.Windows.Forms.TextBox txtPlata;
        private System.Windows.Forms.TextBox txtOro;
        private System.Windows.Forms.TextBox txtHoraFn2;
        private System.Windows.Forms.TextBox txtHoraIn2;
        private System.Windows.Forms.TextBox txtInstancia2;
        private System.Windows.Forms.TextBox txtEvento2;
        private System.Windows.Forms.TextBox txtHoraFn1;
        private System.Windows.Forms.TextBox txtHoraIn1;
        private System.Windows.Forms.TextBox txtInstancia1;
        private System.Windows.Forms.TextBox txtEvento1;
        private System.Windows.Forms.Button btnAgregar3;
        private System.Windows.Forms.Button btnAgregar2;
        private System.Windows.Forms.Button btnAgregar1;
        private System.Windows.Forms.Button btnListar;
    }
}