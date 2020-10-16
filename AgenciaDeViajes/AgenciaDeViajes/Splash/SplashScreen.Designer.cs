namespace AgenciaDeViajes.Splash
{
    partial class frmSplash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
            this.pcbSplash = new System.Windows.Forms.PictureBox();
            this.timSplash = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pcbSplash)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbSplash
            // 
            this.pcbSplash.Image = ((System.Drawing.Image)(resources.GetObject("pcbSplash.Image")));
            this.pcbSplash.Location = new System.Drawing.Point(0, -2);
            this.pcbSplash.Name = "pcbSplash";
            this.pcbSplash.Size = new System.Drawing.Size(801, 454);
            this.pcbSplash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcbSplash.TabIndex = 0;
            this.pcbSplash.TabStop = false;
            // 
            // timSplash
            // 
            this.timSplash.Enabled = true;
            this.timSplash.Interval = 3000;
            this.timSplash.Tick += new System.EventHandler(this.timSplash_Tick);
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pcbSplash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.Shown += new System.EventHandler(this.frmSplash_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pcbSplash)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbSplash;
        private System.Windows.Forms.Timer timSplash;
    }
}