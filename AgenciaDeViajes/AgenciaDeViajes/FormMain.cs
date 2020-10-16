using AgenciaDeViajes.FormSecundarios;
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
    public partial class frmMain : Form
    {

        frmPrecios precios = new frmPrecios();

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {

            Application.Exit();

        }

        private void iMenuAcuerdo_Click(object sender, EventArgs e)
        {

            frmAcuerdo acuerdo = new frmAcuerdo();
            acuerdo.ShowDialog();

        }

        private void tlsBtnAcuerdo_Click(object sender, EventArgs e)
        {

            frmAcuerdo acuerdo = new frmAcuerdo();
            acuerdo.ShowDialog();

        }

        private void iMenuPrecios_Click(object sender, EventArgs e)
        {
            precios.ShowDialog();
        }

        private void tlsBtnPrecios_Click(object sender, EventArgs e)
        {
            precios.ShowDialog();
        }

        private void tlsBtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iMenuSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
