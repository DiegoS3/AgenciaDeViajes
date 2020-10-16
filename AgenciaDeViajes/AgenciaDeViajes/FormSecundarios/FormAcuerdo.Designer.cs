namespace AgenciaDeViajes.FormSecundarios
{
    partial class frmAcuerdo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAcuerdo));
            this.lblAcuerdo = new System.Windows.Forms.Label();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAcuerdo
            // 
            this.lblAcuerdo.AutoSize = true;
            this.lblAcuerdo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcuerdo.Location = new System.Drawing.Point(42, 46);
            this.lblAcuerdo.Name = "lblAcuerdo";
            this.lblAcuerdo.Size = new System.Drawing.Size(441, 75);
            this.lblAcuerdo.TabIndex = 0;
            this.lblAcuerdo.Text = "Esta empresa devolverá un 50% en caso de \r\nque en los días elegidos haya huelga d" +
    "e \r\nTransporters y/u hoteles y afecte al viaje";
            this.lblAcuerdo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresa.Location = new System.Drawing.Point(378, 215);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(105, 20);
            this.lblEmpresa.TabIndex = 1;
            this.lblEmpresa.Text = "La Empresa";
            // 
            // frmAcuerdo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 261);
            this.Controls.Add(this.lblEmpresa);
            this.Controls.Add(this.lblAcuerdo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAcuerdo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acuerdo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAcuerdo;
        private System.Windows.Forms.Label lblEmpresa;
    }
}