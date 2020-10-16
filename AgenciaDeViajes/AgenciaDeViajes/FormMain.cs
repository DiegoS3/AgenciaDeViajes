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
        private DateTime inicial;
        private DateTime final;
        private int precio;

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

        private int precioPersona()
        {

            return (((int)nudPersonas.Value) * precios.persona);

        }

        private int precioTemporada(int mes)
        {

            switch (mes)
            {

                case 7: case 8:

                    return precios.fechas[0];

                case 1: case 9: case 10: case 11: case 12:

                    return precios.fechas[1];

                case 2: case 3: case 4: case 5: case 6:

                    return precios.fechas[2];

                default:

                    return 0;

            }

        }

        private int difDias()
        {
            inicial = mncCalendario.SelectionStart;
            final = mncCalendario.SelectionEnd;
            var dif = final - inicial;

            return dif.Days + 1;
        }

        private int precioDias()
        {            
            precio = 0;

            for (int i = 0; i < difDias(); i++)
            {

                precio += precioTemporada((int)inicial.AddDays(i).Month);

            }

            return precio; 

        }

        private int precioActividad()
        {

            precio = 0;
            int cont = clbActividades.SelectedItems.Count;

            while (cont > 0) {

                switch (clbActividades.SelectedIndex)
                {

                    case 0:

                        precio += precios.actividades[0];
                        break;

                    case 1:

                        precio += precios.actividades[1];
                        break;

                    case 2:

                        precio += precios.actividades[2];
                        break;

                    case 3:

                        precio += precios.actividades[3];
                        break;

                    case 4:

                        precio += precios.actividades[4];
                        break;
                }

                cont--;
            }

            return precio;

        }

        private string nombreEstancia()
        {

            if (rdbDormir.Checked)
            {

                return rdbDormir.Text;

            }
            else if (rdbMediaPension.Checked)
            {

                return rdbMediaPension.Text;
            }
            else
            {

                return rdbPensionCompleta.Text;

            }

        }

        private void imprimirPrecios()
        {

            int cont = 0;

            textValidar.AppendText("Destino " + lsbDestinos.SelectedItem.ToString() + " tiene un precio de " + precioDestino() + "€\n");
            textValidar.AppendText("Hotel de " + nudHotel.Value + " tiene un precio de " + precioHotel() + "€\n");
            textValidar.AppendText("Total de personas " + nudPersonas.Value + " tiene un precio de " + precioPersona() + "€\n");
            textValidar.AppendText("Tipo de estancia " + nombreEstancia() + " tiene un precio de " + precioEstancia() + "€\n");
            textValidar.AppendText("Total de personas " + nudPersonas.Value + " tiene un precio de " + precioPersona() + "€\n");
            while (cont < clbActividades.SelectedItems.Count)
            {

                textValidar.AppendText("Actividad seleccionadas " + clbActividades.SelectedItems[cont].ToString() + ", ");

                cont++;
            }
            textValidar.AppendText("Las activdidades seleccionadas tienen un precio de " + precioActividad() + "€");

        }


    }
    
}
