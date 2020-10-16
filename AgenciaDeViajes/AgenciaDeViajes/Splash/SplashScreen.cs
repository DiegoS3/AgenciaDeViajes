using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgenciaDeViajes.Splash
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        //Tras pasar el tiempo indicado en el intervalo del timer mostramos el form principal y ocultamos este
        private void timSplash_Tick(object sender, EventArgs e)
        {

            timSplash.Stop();
            frmMain main = new frmMain();
            main.Show();
            this.Hide();

        }

        //Iniciamos el timer
        private void frmSplash_Shown(object sender, EventArgs e)
        {
            timSplash.Start();
        }
    }
}
