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
        //Variables
        frmPrecios precios = new frmPrecios();
        private DateTime inicial;
        private DateTime final;
        private int precio;

        public frmMain()
        {
            InitializeComponent();
        }

        //Cuando se cierra la ventana, cerramos la aplicacion
        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {

            Application.Exit();

        }

        //Al hacer click en el item del menu nos abre un nuevo Form
        private void iMenuAcuerdo_Click(object sender, EventArgs e)
        {

            frmAcuerdo acuerdo = new frmAcuerdo();
            acuerdo.ShowDialog();

        }

        //Al hacer click en el item del menu nos abre un nuevo Form
        private void tlsBtnAcuerdo_Click(object sender, EventArgs e)
        {

            frmAcuerdo acuerdo = new frmAcuerdo();
            acuerdo.ShowDialog();

        }

        //Al hacer click en el item del menu nos abre un nuevo Form
        private void iMenuPrecios_Click(object sender, EventArgs e)
        {
            precios.ShowDialog();
        }
        //Al hacer click en el item del menu nos abre un nuevo Form
        private void tlsBtnPrecios_Click(object sender, EventArgs e)
        {
            precios.ShowDialog();
        }
        //Al hacer click en el item del menu nos cierra el form principal
        private void tlsBtnSalir_Click(object sender, EventArgs e)
        {
            cerrar();

        }
        //Al hacer click en el item del menu nos cierra el form principal
        private void iMenuSalir_Click(object sender, EventArgs e)
        {
            cerrar();
        }

        //Depende del item del list box seleccionado muestra una imagen u otra
        private void lsbDestinos_SelectedIndexChanged(object sender, EventArgs e)
        {

            pbDestinos.Image = imglDestinos.Images[lsbDestinos.SelectedIndex];

        }

        //AL pulsar en el boton calcular nos muestra la informacion de compra
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            
            textValidar.Text = "";

            if (!seleccionado())
            {

                MessageBox.Show("Se debe seleccionar Destino y Estancia", "Información",
               MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                iniciarTimer();//iniciamos barra de progreso
                imprimirPrecios();//mostramos precios en el text box
                lblPrecio.Text = precioFinal().ToString() + " €";//Ponemos el precio final en el label

            }

        }

        //Mensaje mostrado al cerrar el Form principal
        private void cerrar()
        {
            DialogResult respuesta = MessageBox.Show("¿Estas seguro que quieres salir de la aplicación?", "Advertencia",
               MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (respuesta.Equals(DialogResult.Yes))
            {

                Application.Exit();

            }
        }
        //comprobamos el minimo de selecciones necesarias para calcular el precio
        private Boolean seleccionado()
        {

            if (lsbDestinos.SelectedIndex > 0 && comprobarGroupBox())
                 
            {

                return true;

            }
            else
            {
                return false;
            }

        }
        //comprobamos que haya algo checkeado en el group box
        private Boolean comprobarGroupBox()
        {

            return rdbMediaPension.Checked || rdbDormir.Checked || rdbPensionCompleta.Checked;

        }
        //Claculamos el precio del destino elegido
        private int precioDestino()
        {
            //Segun el item seleccionado nos devuelve un precio u otro
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
        //Calculamos el precio de la estancia elegida segun el radio button checked
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
        //Calculamos el precio del hotel segun la cantidad de estrellas seleccionada
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
        //Calculamos el precio del total de personas seleccionadas en el numeric up down
        private int precioPersona()
        {

            return (((int)nudPersonas.Value) * (int.Parse(precios.textPersona.Text)));

        }

        //Calculamos el precio de la temporada segun el mes elegido
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

        //Calculamos el total de dias seleccionados
        private int difDias()
        {
            inicial = mncCalendario.SelectionStart;
            final = mncCalendario.SelectionEnd;
            var dif = final - inicial;

            return dif.Days + 1;
        }

        //Calculamos el precio final de los dias seleccionados
        private int precioDias()
        {            
            precio = 0;

            //recorremos el total de dias comprobando el mes del dia y sumando el precio de esa temporada
            for (int i = 0; i < difDias(); i++)
            {

                precio += precioTemporada((int)inicial.AddDays(i).Month);

            }

            return precio; 

        }

        //Calculamos el precio de las actividades seleccionadas
        private int precioActividad()
        {

            precio = 0;
            int act = 0;

            //recorremos la check list comprobando que actividades han sido seleccionadas
            foreach(int i in clbActividades.CheckedIndices) { 
                //segun el indice de la actividad seleccionada entramos en un caso u otro
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
                //sumamos el precio de cada actividad al precio final
                precio += act;
            }

            return precio;

        }

        //Obtenemos el nombre de la estancia que ha seleccionado el usuario para posteriormente imprimirlo
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
        //Imprimimos en un Text Box los datos seleccionados y los precios
        private void imprimirPrecios()
        {
            
            textValidar.AppendText("Destino " + lsbDestinos.SelectedItem.ToString() + " tiene un precio de " + precioDestino() + "€\r\n");
            textValidar.AppendText("Hotel de " + nudHotel.Value + " estrellas tiene un precio de " + precioHotel() + "€\r\n");
            textValidar.AppendText("Total de personas " + nudPersonas.Value + " tiene un precio de " + precioPersona() + "€\r\n");
            textValidar.AppendText("Tipo de estancia " + nombreEstancia() + " tiene un precio de " + precioEstancia() + "€\r\n");
            textValidar.AppendText("Total de personas " + nudPersonas.Value + " tiene un precio de " + precioPersona() + "€\r\n");
            textValidar.AppendText("Total de dias " + difDias() + " tiene un precio de " + precioDias() + "€\r\n");
            imprimirActi();            

        }
        //Imprimimos las actividades que ha seleccionado, tanto nombre como precio total
        private void imprimirActi()
        {
            textValidar.AppendText("Actividad seleccionadas ");
            if (clbActividades.CheckedItems.Count > 0)
            {

                foreach (int i in clbActividades.CheckedIndices)
                {
                    try
                    {
                        textValidar.AppendText(clbActividades.CheckedItems[i].ToString() + ", ");
                    }
                    catch (Exception e) { }

                }
                textValidar.AppendText("las activdidades seleccionadas tienen un precio de " + precioActividad() + "€");

            }
            else
            {

                textValidar.AppendText("Ninguna Actividad Seleccionada ");

            }

        }
        //Calculo del precio final 
        private int precioFinal()
        {

            return precioEstancia() + precioDestino() + precioPersona() + precioHotel() + precioDias() + precioActividad();

        }

        //Iniciamos el timer de la barra de progreso
        private void iniciarTimer()
        {

            timBarraProgreso.Tick += new EventHandler(incrementarBarra);
            timBarraProgreso.Start();

        }
        //Metodo que incrementa la barra de progreso con el avance del timer
        private void incrementarBarra(object sender, EventArgs e)
        {

            pgbCarga.Increment(1);

            //comprobamos si el valor de la progress bar es el maximo y lo ponemos a 0
            if (pgbCarga.Value == pgbCarga.Maximum)
            {

                pgbCarga.Value = 0;

            }

        }
        //Al pulsar el boton de validad para el timer y muestra un mensaje emergente de compra realizada
        private void btnValidar_Click(object sender, EventArgs e)
        {

            timBarraProgreso.Stop();
            pgbCarga.Value = 100;
            MessageBox.Show("Compra realizada con exito", "Información",
               MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        //Iniciamos el timer de la hora cuando el Form aparece
        private void frmMain_Shown(object sender, EventArgs e)
        {
            timHoraActual.Start();
        }
        //Metodo que actualiza la hora cada segundo
        private void timHoraActual_Tick(object sender, EventArgs e)
        {
            lblHora.Text =  DateTime.Now.ToString("hh:mm:ss");
        }
    }
    
}
