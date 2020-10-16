using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgenciaDeViajes
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void timSplash_Tick(object sender, EventArgs e)
        {

            timSplash.Stop();
            frmMain mainForm = new frmMain();
            mainForm.Show();
            this.Hide();

        }

        private void SplashScreen_Shown(object sender, EventArgs e)
        {

            timSplash.Start();

        }
    }
}
