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
            this.timHoraActual = new System.Windows.Forms.Timer(this.components);
            this.imgDestinos = new System.Windows.Forms.ImageList(this.components);
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.menuPrincipal.SuspendLayout();
            this.grbEstancias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPersonas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHotel)).BeginInit();
            this.pnlValidar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
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
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 738);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(877, 22);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(877, 25);
            this.toolStrip1.TabIndex = 17;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 760);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pcbLogo);
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
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
        private System.Windows.Forms.Timer timHoraActual;
        private System.Windows.Forms.ImageList imgDestinos;
        private System.Windows.Forms.PictureBox pcbLogo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
    }
}

