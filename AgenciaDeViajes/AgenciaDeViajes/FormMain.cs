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
        private int num;

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
            cerrar();

        }

        private void iMenuSalir_Click(object sender, EventArgs e)
        {
            cerrar();
        }

        private void lsbDestinos_SelectedIndexChanged(object sender, EventArgs e)
        {

            pbDestinos.Image = imglDestinos.Images[lsbDestinos.SelectedIndex];

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int res = 0;

            if (!seleccionado())
            {

                MessageBox.Show("Todos los campos deben estar completos", "Información",
               MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }


        private void cerrar()
        {
            DialogResult respuesta = MessageBox.Show("¿Estas seguro que quieres salir de la aplicación?", "Advertencia",
               MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (respuesta.Equals(DialogResult.Yes))
            {

                Application.Exit();

            }
        }

        private Boolean seleccionado()
        {

            if (lsbDestinos.SelectedIndex > 0 && comprobarGroupBox()
                 && clbActividades.SelectedItems.Count > 0)
            {

                return true;

            }
            else
            {
                return false;
            }

        }

        private Boolean comprobarGroupBox()
        {

            return rdbMediaPension.Checked || rdbDormir.Checked || rdbPensionCompleta.Checked;

        }

        private int precioDestino()
        {

            switch (lsbDestinos.SelectedIndex)
            {

                case 0:

                    return precios.destinos[0];

                case 1:

                    return precios.destinos[1];                    

                case 2:

                    return precios.destinos[2];                    

                case 3:

                    return precios.destinos[3];

                default:

                    return 0;

            }

        }

        private int precioEstancia()
        {

            if (rdbDormir.Checked) 
            {

                return precios.estancia[0];

            }else if (rdbMediaPension.Checked)
            {

                return precios.estancia[1];
            }
            else
            {

                return precios.estancia[2];

            }

        }

        private int precioHotel()
        {

            switch((int) nudHotel.Value)
            {
                    case 1:

                    return precios.estrellas[0];

                    case 2:

                    return precios.estrellas[1];

                    case 3:

                    return precios.estrellas[2];

                    case 4:

                    return precios.estrellas[3];

                    case 5:

                    return precios.estrellas[4];

                    default:

                    return 0;
            }

        }

        private int 
    }
}
