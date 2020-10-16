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

            textValidar.Text = "";

            if (!seleccionado())
            {

                MessageBox.Show("Todos los campos deben estar completos", "Información",
               MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {

                imprimirPrecios();

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
                 && clbActividades.CheckedItems.Count > 0)
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

                    return int.Parse(precios.textCiudad.Text);

                case 1:

                    return int.Parse(precios.textPlaya.Text);                    

                case 2:

                    return int.Parse(precios.textMontain.Text);                    

                case 3:

                    return int.Parse(precios.textTour.Text);

                default:

                    return 0;

            }

        }

        private int precioEstancia()
        {

            if (rdbDormir.Checked) 
            {

                return int.Parse(precios.textDormir.Text);

            }else if (rdbMediaPension.Checked)
            {

                return int.Parse(precios.textMedia.Text);
            }
            else
            {

                return int.Parse(precios.textCompleta.Text);

            }

        }

        private int precioHotel()
        {

            switch((int) nudHotel.Value)
            {
                    case 1:

                    return int.Parse(precios.textUnaEstrella.Text);

                    case 2:

                    return int.Parse(precios.textDosEstrella.Text);

                    case 3:

                    return int.Parse(precios.textTresEstrella.Text);

                    case 4:

                    return int.Parse(precios.textCuatroEstrella.Text);

                    case 5:

                    return int.Parse(precios.textCincoEstrella.Text);

                    default:

                    return 0;
            }

        }

        private int precioPersona()
        {

            return (((int)nudPersonas.Value) * (int.Parse(precios.textPersona.Text)));

        }

        private int precioTemporada(int mes)
        {

            switch (mes)
            {

                case 7: case 8:

                    return int.Parse(precios.textAlta.Text);

                case 1: case 9: case 10: case 11: case 12:

                    return int.Parse(precios.textMediaTem.Text);

                case 2: case 3: case 4: case 5: case 6:

                    return int.Parse(precios.textBaja.Text);

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
            int act = 0;

            foreach(int i in clbActividades.CheckedIndices) { 
                switch (i)
                {

                    case 0:

                        act = int.Parse(precios.textCena.Text);
                        break;

                    case 1:

                        act = int.Parse(precios.textExcursion.Text);
                        break;

                    case 2:

                        act = int.Parse(precios.textLavanderia.Text);
                        break;

                    case 3:

                        act = int.Parse(precios.textNaturAventura.Text);
                        break;

                    case 4:

                        act = int.Parse(precios.textSpa.Text);
                        break;

                    default:

                        act = 0;
                        break;
                }

                precio += act;
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

            textValidar.AppendText("Destino " + lsbDestinos.SelectedItem.ToString() + " tiene un precio de " + precioDestino() + "€\r\n");
            textValidar.AppendText("Hotel de " + nudHotel.Value + " estrellas tiene un precio de " + precioHotel() + "€\r\n");
            textValidar.AppendText("Total de personas " + nudPersonas.Value + " tiene un precio de " + precioPersona() + "€\r\n");
            textValidar.AppendText("Tipo de estancia " + nombreEstancia() + " tiene un precio de " + precioEstancia() + "€\r\n");
            textValidar.AppendText("Total de personas " + nudPersonas.Value + " tiene un precio de " + precioPersona() + "€\r\n");
            textValidar.AppendText("Total de dias " + difDias() + " tiene un precio de " + precioDias() + "€\r\n");
            textValidar.AppendText("Actividad seleccionadas ");
            foreach (int i in clbActividades.CheckedIndices)
            {

                textValidar.AppendText(clbActividades.CheckedItems[i].ToString() + ", ");

                cont++;
            }
            textValidar.AppendText("las activdidades seleccionadas tienen un precio de " + precioActividad() + "€");

        }


    }
    
}
