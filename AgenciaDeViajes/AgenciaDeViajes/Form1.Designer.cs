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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.btnValidar = new System.Windows.Forms.Button();
            this.pnlBajo = new System.Windows.Forms.Panel();
            this.lLblMail = new System.Windows.Forms.LinkLabel();
            this.pgbCarga = new System.Windows.Forms.ProgressBar();
            this.lblHora = new System.Windows.Forms.Label();
            this.timHoraActual = new System.Windows.Forms.Timer(this.components);
            this.imgDestinos = new System.Windows.Forms.ImageList(this.components);
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.menuPrincipal.SuspendLayout();
            this.grbEstancias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPersonas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHotel)).BeginInit();
            this.pnlValidar.SuspendLayout();
            this.pnlBajo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(88, 410);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(95, 26);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
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
            // 
            // iMenuPrecios
            // 
            this.iMenuPrecios.Name = "iMenuPrecios";
            this.iMenuPrecios.Size = new System.Drawing.Size(57, 20);
            this.iMenuPrecios.Text = "Precios";
            // 
            // iMenuSalir
            // 
            this.iMenuSalir.Name = "iMenuSalir";
            this.iMenuSalir.Size = new System.Drawing.Size(41, 20);
            this.iMenuSalir.Text = "Salir";
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
            this.lsbDestinos.Location = new System.Drawing.Point(331, 77);
            this.lsbDestinos.Name = "lsbDestinos";
            this.lsbDestinos.Size = new System.Drawing.Size(167, 95);
            this.lsbDestinos.TabIndex = 2;
            // 
            // lblDestinos
            // 
            this.lblDestinos.AutoSize = true;
            this.lblDestinos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestinos.Location = new System.Drawing.Point(331, 58);
            this.lblDestinos.Name = "lblDestinos";
            this.lblDestinos.Size = new System.Drawing.Size(98, 13);
            this.lblDestinos.TabIndex = 3;
            this.lblDestinos.Text = "Elige un destino";
            // 
            // clbActividades
            // 
            this.clbActividades.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbActividades.FormattingEnabled = true;
            this.clbActividades.Items.AddRange(new object[] {
            "Cena y Espectáculo",
            "Excursiones",
            "Lavandería",
            "NaturAventura",
            "Spa"});
            this.clbActividades.Location = new System.Drawing.Point(638, 77);
            this.clbActividades.Name = "clbActividades";
            this.clbActividades.Size = new System.Drawing.Size(202, 94);
            this.clbActividades.TabIndex = 4;
            // 
            // lblActividades
            // 
            this.lblActividades.AutoSize = true;
            this.lblActividades.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActividades.Location = new System.Drawing.Point(635, 58);
            this.lblActividades.Name = "lblActividades";
            this.lblActividades.Size = new System.Drawing.Size(106, 13);
            this.lblActividades.TabIndex = 5;
            this.lblActividades.Text = "Actividades Extra";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(331, 201);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(42, 13);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "Fecha";
            // 
            // mncCalendario
            // 
            this.mncCalendario.Location = new System.Drawing.Point(334, 228);
            this.mncCalendario.Name = "mncCalendario";
            this.mncCalendario.TabIndex = 7;
            // 
            // grbEstancias
            // 
            this.grbEstancias.Controls.Add(this.rdbPensionCompleta);
            this.grbEstancias.Controls.Add(this.rdbMediaPension);
            this.grbEstancias.Controls.Add(this.rdbDormir);
            this.grbEstancias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEstancias.Location = new System.Drawing.Point(37, 290);
            this.grbEstancias.Name = "grbEstancias";
            this.grbEstancias.Size = new System.Drawing.Size(200, 100);
            this.grbEstancias.TabIndex = 8;
            this.grbEstancias.TabStop = false;
            this.grbEstancias.Text = "Tipo de Estancia";
            // 
            // rdbPensionCompleta
            // 
            this.rdbPensionCompleta.AutoSize = true;
            this.rdbPensionCompleta.Location = new System.Drawing.Point(7, 68);
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
            this.rdbMediaPension.Location = new System.Drawing.Point(7, 44);
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
            this.rdbDormir.Location = new System.Drawing.Point(7, 20);
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
            this.nudPersonas.Location = new System.Drawing.Point(638, 257);
            this.nudPersonas.Name = "nudPersonas";
            this.nudPersonas.Size = new System.Drawing.Size(75, 20);
            this.nudPersonas.TabIndex = 9;
            this.nudPersonas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPersonas
            // 
            this.lblPersonas.AutoSize = true;
            this.lblPersonas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonas.Location = new System.Drawing.Point(732, 259);
            this.lblPersonas.Name = "lblPersonas";
            this.lblPersonas.Size = new System.Drawing.Size(59, 13);
            this.lblPersonas.TabIndex = 10;
            this.lblPersonas.Text = "Personas";
            // 
            // nudHotel
            // 
            this.nudHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudHotel.Location = new System.Drawing.Point(638, 323);
            this.nudHotel.Name = "nudHotel";
            this.nudHotel.Size = new System.Drawing.Size(75, 20);
            this.nudHotel.TabIndex = 11;
            this.nudHotel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblHotel
            // 
            this.lblHotel.AutoSize = true;
            this.lblHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHotel.Location = new System.Drawing.Point(732, 323);
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
            this.pnlValidar.Controls.Add(this.textBox1);
            this.pnlValidar.Location = new System.Drawing.Point(334, 410);
            this.pnlValidar.Name = "pnlValidar";
            this.pnlValidar.Size = new System.Drawing.Size(506, 252);
            this.pnlValidar.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 14);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(476, 180);
            this.textBox1.TabIndex = 0;
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
            // pnlBajo
            // 
            this.pnlBajo.BackColor = System.Drawing.SystemColors.Highlight;
            this.pnlBajo.Controls.Add(this.lblHora);
            this.pnlBajo.Controls.Add(this.pgbCarga);
            this.pnlBajo.Controls.Add(this.lLblMail);
            this.pnlBajo.Location = new System.Drawing.Point(0, 733);
            this.pnlBajo.Name = "pnlBajo";
            this.pnlBajo.Size = new System.Drawing.Size(877, 27);
            this.pnlBajo.TabIndex = 14;
            // 
            // lLblMail
            // 
            this.lLblMail.AutoSize = true;
            this.lLblMail.Location = new System.Drawing.Point(41, 8);
            this.lLblMail.Name = "lLblMail";
            this.lLblMail.Size = new System.Drawing.Size(125, 13);
            this.lLblMail.TabIndex = 0;
            this.lLblMail.TabStop = true;
            this.lLblMail.Text = "vielcontravel@gmail.com";
            // 
            // pgbCarga
            // 
            this.pgbCarga.Location = new System.Drawing.Point(173, 3);
            this.pgbCarga.Name = "pgbCarga";
            this.pgbCarga.Size = new System.Drawing.Size(292, 21);
            this.pgbCarga.TabIndex = 1;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(681, 8);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(35, 13);
            this.lblHora.TabIndex = 2;
            this.lblHora.Text = "label1";
            // 
            // imgDestinos
            // 
            this.imgDestinos.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgDestinos.ImageStream")));
            this.imgDestinos.TransparentColor = System.Drawing.Color.Transparent;
            this.imgDestinos.Images.SetKeyName(0, "ciudad.jpg");
            this.imgDestinos.Images.SetKeyName(1, "playa.jpg");
            this.imgDestinos.Images.SetKeyName(2, "montaña.jpg");
            this.imgDestinos.Images.SetKeyName(3, "tour.jpg");
            // 
            // pcbLogo
            // 
            this.pcbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pcbLogo.Image")));
            this.pcbLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("pcbLogo.InitialImage")));
            this.pcbLogo.Location = new System.Drawing.Point(0, 457);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(328, 270);
            this.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbLogo.TabIndex = 15;
            this.pcbLogo.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 760);
            this.Controls.Add(this.pcbLogo);
            this.Controls.Add(this.pnlBajo);
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
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agencia de Viajes CIFPVG Diego";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.grbEstancias.ResumeLayout(false);
            this.grbEstancias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPersonas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHotel)).EndInit();
            this.pnlValidar.ResumeLayout(false);
            this.pnlValidar.PerformLayout();
            this.pnlBajo.ResumeLayout(false);
            this.pnlBajo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel pnlBajo;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.ProgressBar pgbCarga;
        private System.Windows.Forms.LinkLabel lLblMail;
        private System.Windows.Forms.Timer timHoraActual;
        private System.Windows.Forms.ImageList imgDestinos;
        private System.Windows.Forms.PictureBox pcbLogo;
    }
}

