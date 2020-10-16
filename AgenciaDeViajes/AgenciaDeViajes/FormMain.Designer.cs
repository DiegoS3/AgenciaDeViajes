namespace AgenciaDeViajes
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnCalcular = new System.Windows.Forms.Button();
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.iMenuAcuerdo = new System.Windows.Forms.ToolStripMenuItem();
            this.iMenuPrecios = new System.Windows.Forms.ToolStripMenuItem();
            this.iMenuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.lsbDestinos = new System.Windows.Forms.ListBox();
            this.lblDestinos = new System.Windows.Forms.Label();
            this.clbActividades = new System.Windows.Forms.CheckedListBox();
            this.lblActividades = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.mncCalendario = new System.Windows.Forms.MonthCalendar();
            this.grbEstancias = new System.Windows.Forms.GroupBox();
            this.rdbPensionCompleta = new System.Windows.Forms.RadioButton();
            this.rdbMediaPension = new System.Windows.Forms.RadioButton();
            this.rdbDormir = new System.Windows.Forms.RadioButton();
            this.nudPersonas = new System.Windows.Forms.NumericUpDown();
            this.lblPersonas = new System.Windows.Forms.Label();
            this.nudHotel = new System.Windows.Forms.NumericUpDown();
            this.lblHotel = new System.Windows.Forms.Label();
            this.pnlValidar = new System.Windows.Forms.Panel();
            this.btnValidar = new System.Windows.Forms.Button();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.textValidar = new System.Windows.Forms.TextBox();
            this.timHoraActual = new System.Windows.Forms.Timer(this.components);
            this.stsMain = new System.Windows.Forms.StatusStrip();
            this.lblMail = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.lblHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.pbDestinos = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.tlsMain = new System.Windows.Forms.ToolStrip();
            this.tlsBtnAcuerdo = new System.Windows.Forms.ToolStripButton();
            this.tlsBtnPrecios = new System.Windows.Forms.ToolStripButton();
            this.tlsBtnSalir = new System.Windows.Forms.ToolStripButton();
            this.imglDestinos = new System.Windows.Forms.ImageList(this.components);
            this.menuPrincipal.SuspendLayout();
            this.grbEstancias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPersonas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHotel)).BeginInit();
            this.pnlValidar.SuspendLayout();
            this.stsMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDestinos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.tlsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(117, 455);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(95, 26);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.BackColor = System.Drawing.Color.Salmon;
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iMenuAcuerdo,
            this.iMenuPrecios,
            this.iMenuSalir});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(877, 24);
            this.menuPrincipal.TabIndex = 1;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // iMenuAcuerdo
            // 
            this.iMenuAcuerdo.Name = "iMenuAcuerdo";
            this.iMenuAcuerdo.Size = new System.Drawing.Size(112, 20);
            this.iMenuAcuerdo.Text = "Acuerdo Empresa";
            this.iMenuAcuerdo.Click += new System.EventHandler(this.iMenuAcuerdo_Click);
            // 
            // iMenuPrecios
            // 
            this.iMenuPrecios.Name = "iMenuPrecios";
            this.iMenuPrecios.Size = new System.Drawing.Size(57, 20);
            this.iMenuPrecios.Text = "Precios";
            this.iMenuPrecios.Click += new System.EventHandler(this.iMenuPrecios_Click);
            // 
            // iMenuSalir
            // 
            this.iMenuSalir.Name = "iMenuSalir";
            this.iMenuSalir.Size = new System.Drawing.Size(41, 20);
            this.iMenuSalir.Text = "Salir";
            this.iMenuSalir.Click += new System.EventHandler(this.iMenuSalir_Click);
            // 
            // lsbDestinos
            // 
            this.lsbDestinos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbDestinos.FormattingEnabled = true;
            this.lsbDestinos.Items.AddRange(new object[] {
            "Ciudad",
            "Playa",
            "Montaña",
            "Tour"});
            this.lsbDestinos.Location = new System.Drawing.Point(343, 108);
            this.lsbDestinos.Name = "lsbDestinos";
            this.lsbDestinos.Size = new System.Drawing.Size(167, 95);
            this.lsbDestinos.TabIndex = 2;
            this.lsbDestinos.SelectedIndexChanged += new System.EventHandler(this.lsbDestinos_SelectedIndexChanged);
            // 
            // lblDestinos
            // 
            this.lblDestinos.AutoSize = true;
            this.lblDestinos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestinos.Location = new System.Drawing.Point(343, 89);
            this.lblDestinos.Name = "lblDestinos";
            this.lblDestinos.Size = new System.Drawing.Size(98, 13);
            this.lblDestinos.TabIndex = 3;
            this.lblDestinos.Text = "Elige un destino";
            // 
            // clbActividades
            // 
            this.clbActividades.CheckOnClick = true;
            this.clbActividades.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbActividades.FormattingEnabled = true;
            this.clbActividades.Items.AddRange(new object[] {
            "Cena y Espectáculo",
            "Excursiones",
            "Lavandería",
            "NaturAventura",
            "Spa"});
            this.clbActividades.Location = new System.Drawing.Point(650, 108);
            this.clbActividades.Name = "clbActividades";
            this.clbActividades.Size = new System.Drawing.Size(202, 94);
            this.clbActividades.TabIndex = 4;
            // 
            // lblActividades
            // 
            this.lblActividades.AutoSize = true;
            this.lblActividades.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActividades.Location = new System.Drawing.Point(647, 89);
            this.lblActividades.Name = "lblActividades";
            this.lblActividades.Size = new System.Drawing.Size(106, 13);
            this.lblActividades.TabIndex = 5;
            this.lblActividades.Text = "Actividades Extra";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(343, 232);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(42, 13);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "Fecha";
            // 
            // mncCalendario
            // 
            this.mncCalendario.Location = new System.Drawing.Point(346, 259);
            this.mncCalendario.Name = "mncCalendario";
            this.mncCalendario.TabIndex = 7;
            // 
            // grbEstancias
            // 
            this.grbEstancias.Controls.Add(this.rdbPensionCompleta);
            this.grbEstancias.Controls.Add(this.rdbMediaPension);
            this.grbEstancias.Controls.Add(this.rdbDormir);
            this.grbEstancias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEstancias.Location = new System.Drawing.Point(79, 324);
            this.grbEstancias.Name = "grbEstancias";
            this.grbEstancias.Size = new System.Drawing.Size(164, 122);
            this.grbEstancias.TabIndex = 8;
            this.grbEstancias.TabStop = false;
            this.grbEstancias.Text = "Tipo de Estancia";
            // 
            // rdbPensionCompleta
            // 
            this.rdbPensionCompleta.AutoSize = true;
            this.rdbPensionCompleta.Location = new System.Drawing.Point(25, 76);
            this.rdbPensionCompleta.Name = "rdbPensionCompleta";
            this.rdbPensionCompleta.Size = new System.Drawing.Size(126, 17);
            this.rdbPensionCompleta.TabIndex = 2;
            this.rdbPensionCompleta.TabStop = true;
            this.rdbPensionCompleta.Text = "Pensión Completa";
            this.rdbPensionCompleta.UseVisualStyleBackColor = true;
            // 
            // rdbMediaPension
            // 
            this.rdbMediaPension.AutoSize = true;
            this.rdbMediaPension.Location = new System.Drawing.Point(25, 52);
            this.rdbMediaPension.Name = "rdbMediaPension";
            this.rdbMediaPension.Size = new System.Drawing.Size(108, 17);
            this.rdbMediaPension.TabIndex = 1;
            this.rdbMediaPension.TabStop = true;
            this.rdbMediaPension.Text = "Media Pensión";
            this.rdbMediaPension.UseVisualStyleBackColor = true;
            // 
            // rdbDormir
            // 
            this.rdbDormir.AutoSize = true;
            this.rdbDormir.Location = new System.Drawing.Point(25, 28);
            this.rdbDormir.Name = "rdbDormir";
            this.rdbDormir.Size = new System.Drawing.Size(90, 17);
            this.rdbDormir.TabIndex = 0;
            this.rdbDormir.TabStop = true;
            this.rdbDormir.Text = "Solo Dormir";
            this.rdbDormir.UseVisualStyleBackColor = true;
            // 
            // nudPersonas
            // 
            this.nudPersonas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPersonas.Location = new System.Drawing.Point(650, 288);
            this.nudPersonas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPersonas.Name = "nudPersonas";
            this.nudPersonas.Size = new System.Drawing.Size(75, 20);
            this.nudPersonas.TabIndex = 9;
            this.nudPersonas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudPersonas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblPersonas
            // 
            this.lblPersonas.AutoSize = true;
            this.lblPersonas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonas.Location = new System.Drawing.Point(744, 290);
            this.lblPersonas.Name = "lblPersonas";
            this.lblPersonas.Size = new System.Drawing.Size(59, 13);
            this.lblPersonas.TabIndex = 10;
            this.lblPersonas.Text = "Personas";
            // 
            // nudHotel
            // 
            this.nudHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudHotel.Location = new System.Drawing.Point(650, 354);
            this.nudHotel.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudHotel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHotel.Name = "nudHotel";
            this.nudHotel.Size = new System.Drawing.Size(75, 20);
            this.nudHotel.TabIndex = 11;
            this.nudHotel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudHotel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblHotel
            // 
            this.lblHotel.AutoSize = true;
            this.lblHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHotel.Location = new System.Drawing.Point(744, 354);
            this.lblHotel.Name = "lblHotel";
            this.lblHotel.Size = new System.Drawing.Size(108, 13);
            this.lblHotel.TabIndex = 12;
            this.lblHotel.Text = "Estrellas del hotel";
            // 
            // pnlValidar
            // 
            this.pnlValidar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pnlValidar.Controls.Add(this.btnValidar);
            this.pnlValidar.Controls.Add(this.lblPrecio);
            this.pnlValidar.Controls.Add(this.textValidar);
            this.pnlValidar.Location = new System.Drawing.Point(346, 441);
            this.pnlValidar.Name = "pnlValidar";
            this.pnlValidar.Size = new System.Drawing.Size(506, 252);
            this.pnlValidar.TabIndex = 13;
            // 
            // btnValidar
            // 
            this.btnValidar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidar.Location = new System.Drawing.Point(416, 211);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(75, 23);
            this.btnValidar.TabIndex = 2;
            this.btnValidar.Text = "VALIDAR";
            this.btnValidar.UseVisualStyleBackColor = true;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(16, 211);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(25, 13);
            this.lblPrecio.TabIndex = 1;
            this.lblPrecio.Text = "0 €";
            // 
            // textValidar
            // 
            this.textValidar.Location = new System.Drawing.Point(16, 14);
            this.textValidar.Multiline = true;
            this.textValidar.Name = "textValidar";
            this.textValidar.Size = new System.Drawing.Size(476, 180);
            this.textValidar.TabIndex = 0;
            // 
            // stsMain
            // 
            this.stsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblMail,
            this.toolStripProgressBar1,
            this.lblHora});
            this.stsMain.Location = new System.Drawing.Point(0, 738);
            this.stsMain.Name = "stsMain";
            this.stsMain.Size = new System.Drawing.Size(877, 22);
            this.stsMain.TabIndex = 14;
            this.stsMain.Text = "statusStrip1";
            // 
            // lblMail
            // 
            this.lblMail.Image = ((System.Drawing.Image)(resources.GetObject("lblMail.Image")));
            this.lblMail.IsLink = true;
            this.lblMail.Margin = new System.Windows.Forms.Padding(10, 3, 0, 2);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(158, 17);
            this.lblMail.Text = "vielcontravel@gmail.com";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Margin = new System.Windows.Forms.Padding(20, 3, 1, 3);
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(200, 16);
            // 
            // lblHora
            // 
            this.lblHora.Image = ((System.Drawing.Image)(resources.GetObject("lblHora.Image")));
            this.lblHora.Margin = new System.Windows.Forms.Padding(200, 3, 0, 2);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(134, 17);
            this.lblHora.Text = "toolStripStatusLabel2";
            // 
            // pbDestinos
            // 
            this.pbDestinos.BackColor = System.Drawing.Color.Transparent;
            this.pbDestinos.Location = new System.Drawing.Point(24, 89);
            this.pbDestinos.Name = "pbDestinos";
            this.pbDestinos.Size = new System.Drawing.Size(285, 219);
            this.pbDestinos.TabIndex = 16;
            this.pbDestinos.TabStop = false;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(12, 511);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(319, 213);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 17;
            this.pbLogo.TabStop = false;
            // 
            // tlsMain
            // 
            this.tlsMain.AutoSize = false;
            this.tlsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsBtnAcuerdo,
            this.tlsBtnPrecios,
            this.tlsBtnSalir});
            this.tlsMain.Location = new System.Drawing.Point(0, 24);
            this.tlsMain.Name = "tlsMain";
            this.tlsMain.Size = new System.Drawing.Size(877, 46);
            this.tlsMain.TabIndex = 7;
            this.tlsMain.Text = "toolStrip1";
            // 
            // tlsBtnAcuerdo
            // 
            this.tlsBtnAcuerdo.AutoSize = false;
            this.tlsBtnAcuerdo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsBtnAcuerdo.Image = ((System.Drawing.Image)(resources.GetObject("tlsBtnAcuerdo.Image")));
            this.tlsBtnAcuerdo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tlsBtnAcuerdo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsBtnAcuerdo.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.tlsBtnAcuerdo.Name = "tlsBtnAcuerdo";
            this.tlsBtnAcuerdo.Size = new System.Drawing.Size(40, 40);
            this.tlsBtnAcuerdo.Text = "toolStripButton1";
            this.tlsBtnAcuerdo.ToolTipText = "Acuerdo Empresa";
            this.tlsBtnAcuerdo.Click += new System.EventHandler(this.tlsBtnAcuerdo_Click);
            // 
            // tlsBtnPrecios
            // 
            this.tlsBtnPrecios.AutoSize = false;
            this.tlsBtnPrecios.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsBtnPrecios.Image = ((System.Drawing.Image)(resources.GetObject("tlsBtnPrecios.Image")));
            this.tlsBtnPrecios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tlsBtnPrecios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsBtnPrecios.Margin = new System.Windows.Forms.Padding(20, 1, 0, 2);
            this.tlsBtnPrecios.Name = "tlsBtnPrecios";
            this.tlsBtnPrecios.Size = new System.Drawing.Size(40, 40);
            this.tlsBtnPrecios.Text = "toolStripButton2";
            this.tlsBtnPrecios.ToolTipText = "Precios";
            this.tlsBtnPrecios.Click += new System.EventHandler(this.tlsBtnPrecios_Click);
            // 
            // tlsBtnSalir
            // 
            this.tlsBtnSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tlsBtnSalir.AutoSize = false;
            this.tlsBtnSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsBtnSalir.Image = ((System.Drawing.Image)(resources.GetObject("tlsBtnSalir.Image")));
            this.tlsBtnSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tlsBtnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsBtnSalir.Name = "tlsBtnSalir";
            this.tlsBtnSalir.Size = new System.Drawing.Size(40, 40);
            this.tlsBtnSalir.Text = "toolStripButton3";
            this.tlsBtnSalir.Click += new System.EventHandler(this.tlsBtnSalir_Click);
            // 
            // imglDestinos
            // 
            this.imglDestinos.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglDestinos.ImageStream")));
            this.imglDestinos.TransparentColor = System.Drawing.Color.Transparent;
            this.imglDestinos.Images.SetKeyName(0, "ciudad.jpg");
            this.imglDestinos.Images.SetKeyName(1, "playa.jpg");
            this.imglDestinos.Images.SetKeyName(2, "montaña.jpg");
            this.imglDestinos.Images.SetKeyName(3, "tour.jpg");
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 760);
            this.Controls.Add(this.tlsMain);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.pbDestinos);
            this.Controls.Add(this.stsMain);
            this.Controls.Add(this.pnlValidar);
            this.Controls.Add(this.lblHotel);
            this.Controls.Add(this.nudHotel);
            this.Controls.Add(this.lblPersonas);
            this.Controls.Add(this.nudPersonas);
            this.Controls.Add(this.grbEstancias);
            this.Controls.Add(this.mncCalendario);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblActividades);
            this.Controls.Add(this.clbActividades);
            this.Controls.Add(this.lblDestinos);
            this.Controls.Add(this.lsbDestinos);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.menuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agencia de Viajes CIFPVG Diego";
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.grbEstancias.ResumeLayout(false);
            this.grbEstancias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPersonas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHotel)).EndInit();
            this.pnlValidar.ResumeLayout(false);
            this.pnlValidar.PerformLayout();
            this.stsMain.ResumeLayout(false);
            this.stsMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDestinos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.tlsMain.ResumeLayout(false);
            this.tlsMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem iMenuAcuerdo;
        private System.Windows.Forms.ToolStripMenuItem iMenuPrecios;
        private System.Windows.Forms.ToolStripMenuItem iMenuSalir;
        private System.Windows.Forms.ListBox lsbDestinos;
        private System.Windows.Forms.Label lblDestinos;
        private System.Windows.Forms.CheckedListBox clbActividades;
        private System.Windows.Forms.Label lblActividades;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.MonthCalendar mncCalendario;
        private System.Windows.Forms.GroupBox grbEstancias;
        private System.Windows.Forms.RadioButton rdbPensionCompleta;
        private System.Windows.Forms.RadioButton rdbMediaPension;
        private System.Windows.Forms.RadioButton rdbDormir;
        private System.Windows.Forms.NumericUpDown nudPersonas;
        private System.Windows.Forms.Label lblPersonas;
        private System.Windows.Forms.NumericUpDown nudHotel;
        private System.Windows.Forms.Label lblHotel;
        private System.Windows.Forms.Panel pnlValidar;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox textValidar;
        private System.Windows.Forms.Timer timHoraActual;
        private System.Windows.Forms.StatusStrip stsMain;
        private System.Windows.Forms.ToolStripStatusLabel lblMail;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel lblHora;
        private System.Windows.Forms.PictureBox pbDestinos;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.ToolStrip tlsMain;
        private System.Windows.Forms.ToolStripButton tlsBtnAcuerdo;
        private System.Windows.Forms.ToolStripButton tlsBtnPrecios;
        private System.Windows.Forms.ToolStripButton tlsBtnSalir;
        private System.Windows.Forms.ImageList imglDestinos;
    }
}

