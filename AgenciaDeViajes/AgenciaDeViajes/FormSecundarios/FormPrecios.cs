using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgenciaDeViajes.FormSecundarios
{
    public partial class frmPrecios : Form
    {
        //Variables
        private int[] destinos = new int[4];
        private int[] estancia = new int[3];
        private int[] estrellas = new int[5];
        private int persona;
        private int[] actividades = new int[5];
        private int[] fechas = new int[3];
        private int num;

        public frmPrecios()
        {
            InitializeComponent();

        }

        private void tlsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        /**
         * 
         * Este metodo almacena los valores que contienen los diferentes TextBox
         * al mostrarse el Form de precios
         * 
         */ 
        private void frmPrecios_Shown(object sender, EventArgs e)
        {
            //Almacenamos valores iniciales del group box de destinos
            destinos[0] = int.Parse(textCiudad.Text);
            destinos[1] = int.Parse(textPlaya.Text);
            destinos[2] = int.Parse(textMontain.Text);
            destinos[3] = int.Parse(textTour.Text);

            //Almacenamos valores iniciales del group box de estancia
            estancia[0] = int.Parse(textDormir.Text);
            estancia[1] = int.Parse(textMedia.Text);
            estancia[2] = int.Parse(textCompleta.Text);

            //Almacenamos valores iniciales del group box de las estrellas
            estrellas[0] = int.Parse(textUnaEstrella.Text);
            estrellas[1] = int.Parse(textDosEstrella.Text);
            estrellas[2] = int.Parse(textTresEstrella.Text);
            estrellas[3] = int.Parse(textCuatroEstrella.Text);
            estrellas[4] = int.Parse(textCincoEstrella.Text);

            //Almacenamos valores iniciales del precio por persona
            persona = int.Parse(textPersona.Text);

            //Almacenamos valores iniciales del group box de las actividades
            actividades[0] = int.Parse(textCena.Text);
            actividades[1] = int.Parse(textExcursion.Text);
            actividades[2] = int.Parse(textLavanderia.Text);
            actividades[3] = int.Parse(textNaturAventura.Text);
            actividades[4] = int.Parse(textSpa.Text);

            //Almacenamos valores iniciales del group box de fechas
            fechas[0] = int.Parse(textAlta.Text);
            fechas[1] = int.Parse(textMediaTem.Text);
            fechas[2] = int.Parse(textBaja.Text);
        }

        /*
         * 
         * Los siguientes metodos llaman a el metodo comprobarNumero()
         * cada vez que se cambia el contenido del TextBox correspondiente
         * y almacenan y muestran el numero valor
         * 
         */ 
        private void textCiudad_TextChanged(object sender, EventArgs e)
        {

            comprobarNumero(destinos[0], textCiudad);
            destinos[0] = int.Parse(textCiudad.Text);

        }

        private void textPlaya_TextChanged(object sender, EventArgs e)
        {

            comprobarNumero(destinos[1], textPlaya);
            destinos[1] = int.Parse(textPlaya.Text);

        }

        private void textMontain_TextChanged(object sender, EventArgs e)
        {
            comprobarNumero(destinos[2], textMontain);
            destinos[2] = int.Parse(textMontain.Text);
        }

        private void textTour_TextChanged(object sender, EventArgs e)
        {
            comprobarNumero(destinos[3], textTour);
            destinos[4] = int.Parse(textTour.Text);
        }

        private void textDormir_TextChanged(object sender, EventArgs e)
        {
            comprobarNumero(estancia[0], textDormir);
            estancia[0] = int.Parse(textDormir.Text);
        }

        private void textMedia_TextChanged(object sender, EventArgs e)
        {
            comprobarNumero(estancia[1], textMedia);
            estancia[1] = int.Parse(textMedia.Text);
        }

        private void textCompleta_TextChanged(object sender, EventArgs e)
        {
            comprobarNumero(estancia[2], textCompleta);
            estancia[2] = int.Parse(textCompleta.Text);
        }
        
        private void textUnaEstrella_TextChanged(object sender, EventArgs e)
        {
            comprobarNumero(estrellas[0], textUnaEstrella);
            estancia[0] = int.Parse(textUnaEstrella.Text);
        }

        private void textDosEstrella_TextChanged(object sender, EventArgs e)
        {
            comprobarNumero(estrellas[1], textDosEstrella);
            estancia[1] = int.Parse(textDosEstrella.Text);
        }

        private void textTresEstrella_TextChanged(object sender, EventArgs e)
        {
            comprobarNumero(estrellas[2], textTresEstrella);
            estancia[2] = int.Parse(textTresEstrella.Text);
        }

        private void textCuatroEstrella_TextChanged(object sender, EventArgs e)
        {
            comprobarNumero(estrellas[3], textCuatroEstrella);
            estancia[3] = int.Parse(textCuatroEstrella.Text);

        }

        private void textCincoEstrella_TextChanged(object sender, EventArgs e)
        {
            comprobarNumero(estrellas[4], textCincoEstrella);
            estancia[4] = int.Parse(textCincoEstrella.Text);
        }

        private void textPersona_TextChanged(object sender, EventArgs e)
        {
            comprobarNumero(persona, textPersona);
            persona = int.Parse(textPersona.Text);
        }

        private void textCena_TextChanged(object sender, EventArgs e)
        {
            comprobarNumero(actividades[0], textCena);
            actividades[0] = int.Parse(textCena.Text);
        }

        private void textExcursion_TextChanged(object sender, EventArgs e)
        {
            comprobarNumero(actividades[1], textExcursion);
            actividades[1] = int.Parse(textExcursion.Text);
        }

        private void textLavanderia_TextChanged(object sender, EventArgs e)
        {
            comprobarNumero(actividades[2], textLavanderia);
            actividades[2] = int.Parse(textLavanderia.Text);
        }

        private void textNaturAventura_TextChanged(object sender, EventArgs e)
        {
            comprobarNumero(actividades[3], textNaturAventura);
            actividades[3] = int.Parse(textNaturAventura.Text);
        }

        private void textSpa_TextChanged(object sender, EventArgs e)
        {
            comprobarNumero(actividades[4], textSpa);
            actividades[4] = int.Parse(textSpa.Text);
        }

        private void textAlta_TextChanged(object sender, EventArgs e)
        {
            comprobarNumero(fechas[0], textAlta);
            fechas[0] = int.Parse(textAlta.Text);
        }

        private void textMediaTem_TextChanged(object sender, EventArgs e)
        {
            comprobarNumero(fechas[1], textMediaTem);
            fechas[1] = int.Parse(textMediaTem.Text);
        }

        private void textBaja_TextChanged(object sender, EventArgs e)
        {
            comprobarNumero(fechas[2], textBaja);
            fechas[2] = int.Parse(textBaja.Text);
        }
        //Fin metodos que comprueban el valor del TextBox


        /**
         * 
         * Metodo que comprueba si se esta insertando un número o un string
         * en caso de no ser un numero muestra un mensaje emergente diciendo
         * que solo acepta numeros
         * 
         */
        private void comprobarNumero(int numero, TextBox texto)
        {

            Boolean valido = int.TryParse(texto.Text, out num);

            if (texto.Text.Equals(String.Empty))
            {

                MessageBox.Show("Este campo no puede estar vacio", "Advertencia",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                texto.Text = numero.ToString();

            }
            else if (!valido)
            {

                MessageBox.Show("Solo puedes introducir valores númericos", "Advertencia",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                texto.Text = numero.ToString();

            }
            else
            {

                texto.Text = num.ToString();
            }

        }

    }
}
