using System;  
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estadisticaApp
{

    public partial class frmProbBinomial : Form
    {
        public frmProbBinomial()
        {
            InitializeComponent();
        }
        
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            playSalir();
            this.Close(); //cerrar ventana
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
         
            //Capturamos los datos de insumo para el calculo de la probabilidad
            double p = double.Parse(txt_pExito.Text);
            double q = 1 - p;
            int x = int.Parse(txt_xVariable.Text);
            double n = double.Parse(txt_nMuestra.Text);
            txt_qFracaso.Text = q.ToString();

            //Validar entrada de datos (solo numeros positivos)
            if (double.Parse(txt_pExito.Text) < 0 )
            {
                MessageBox.Show("No se puede ingresar numeros negativos o mayores a 1!", "¡ENTRADA DE DATO INVALIDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_pExito.Clear();
                txt_xVariable.Clear();
                txt_nMuestra.Clear();
                txt_qFracaso.Clear(); //*****************
                txt_pExito.Focus();
            }
            if (int.Parse(txt_xVariable.Text) < 0)
            {
                MessageBox.Show("No se puede ingresar numeros negativos!", "¡ENTRADA DE DATO INVALIDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_xVariable.Clear();
                txt_pExito.Clear();
                txt_nMuestra.Clear();
                txt_xVariable.Focus();
            }

            if (double.Parse(txt_nMuestra.Text) < 0)
            {
                MessageBox.Show("No se puede ingresar numeros negativos!", "¡ENTRADA DE DATO INVALIDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nMuestra.Clear();
                txt_xVariable.Clear();
                txt_pExito.Clear();
                txt_nMuestra.Focus();
            }

            if ( double.Parse(txt_pExito.Text) > 1)
            {
                MessageBox.Show("No se puede ingresar mayores a 1 en p", "¡ENTRADA DE DATO INVALIDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_pExito.Clear();
                txt_xVariable.Clear();
                txt_nMuestra.Clear();
                txt_pExito.Focus();
            }

            //Validar entrada de datos
            const string mensaje1 = "No puedes ingresar un valor para x mayor que n";
            const string caption_1 = "¡ENTRADA DE DATO INVALIDA!";
            if (x > n)
            {
                MessageBox.Show(mensaje1, caption_1, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_xVariable.Clear();
                txt_nMuestra.Clear();
                txtResultado.Clear();
            }

            //Calcular factorial de n
            double i, factn; //i solo la esta haciendo de contador y factn esta almacenando el factorial de n
            factn = n;
            for (i = n - 1; i >= 1; i--)
            {
                factn = factn * i;
            }

            //Validar que factorial de n sea diferente de 0
            if (factn == 0)
            {
                factn = 1;
            }

            //Calcular factorial de x
            double a, factx; //a solo la esta haciendo de contador y factx esta almacenando el factorial de x
             factx = x;
             for (a = x - 1; a >= 1; a--)
             {
               factx = factx * a;
             }

            //Validar que factorial de x sea diferente de 0
            if (factx == 0)
            {
                factx = 1 ;
            }

            //Resta de n-x
            double restaExp = n - x ; //Este valor se utilizara para sacar su factorial y luego como exponente

            //Calcular factorial de (n-x)
            double o, factResta; //o solo la esta haciendo de contador y factResta esta almacenando el factorial de (n-x)
            factResta = restaExp; 
            for (o = restaExp - 1; o>= 1; o--)
            {
                factResta = factResta * o;
            }

            //Validar que factorial de n-x sea diferente de 0
            if (factResta == 0)
            {
                factResta = 1;
            }


            double div, denominador, numerador, result, parentesisUno, parentesisDos, parentesisTres;

            //Cálculo por partes de la formula
            numerador = factn;
            denominador = (factx * factResta);
            div = Math.Round(numerador / denominador, 4);
            parentesisUno = Math.Round(div,4);
            parentesisDos = Math.Round(Math.Pow(p, x),4);
            parentesisTres = Math.Round(Math.Pow(q, restaExp),4);
            result = Math.Round((parentesisUno * parentesisDos * parentesisTres) * 100,4);
            txtResultado.Text = Math.Round(result, 4).ToString();

            /*
            Pasar los datos de los textbox a los label, 
            para representar el proceso interno graficamente
            */
            lblN.Text = txt_nMuestra.Text;
            lblX.Text = txt_xVariable.Text;
            lblX_.Text = txt_xVariable.Text;
            lblQ.Text = txt_qFracaso.Text;
            lblP.Text = txt_pExito.Text;
            lblN_X.Text = restaExp.ToString();

            lblParentesis1.Text = parentesisUno.ToString();
            lblParentesis2.Text = parentesisDos.ToString();
            lblParentesis3.Text = parentesisTres.ToString();
        }

        private void playSalir()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\gabri\source\repos\estadisticaApp\salir.wav");
            simpleSound.Play();
        }
        private void playAtras()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\gabri\source\repos\estadisticaApp\atras.wav");
            simpleSound.Play();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            playAtras();
            frmInicio f = new frmInicio();
            f.Visible = true;
            this.Dispose();
        }

        private void frmProbBinomial_Load(object sender, EventArgs e)
        {
           // agregamos unos consejos sobre los controles, para orientar al usuario.
            ToolTip consejoflotante = new ToolTip();
            consejoflotante.AutoPopDelay = 5000;
            consejoflotante.InitialDelay = 1;
            consejoflotante.ReshowDelay = 1000;

            consejoflotante.SetToolTip(this.txt_pExito, "escriba aquí la probabilidad de éxito");
            consejoflotante.SetToolTip(this.txt_qFracaso, "escriba aquí la probabilidad de fracaso");
            consejoflotante.SetToolTip(this.txt_nMuestra, "escriba aquí la muestra");
            consejoflotante.SetToolTip(this.txt_xVariable, "escriba aquí la cantidad de eventos");

        }


        private void txt_pExito_Validating(object sender, CancelEventArgs e)
        {
            //Validar que no hayan campos vacíos 
            if (txt_pExito.Text == string.Empty)
            {
                errorProvider.SetError(txt_pExito, "Debe introducir un valor");

            }
        }

        private void txt_nMuestra_Validating(object sender, CancelEventArgs e)
        {
            if(txt_nMuestra.Text == string.Empty)
            {
                errorProvider.SetError(txt_nMuestra, "Debe introducir un valor");
            }
        }

        private void txt_xVariable_Validating(object sender, CancelEventArgs e)
        {
            if (txt_xVariable.Text == string.Empty)
            {
                errorProvider.SetError(txt_xVariable, "Debe introducir un valor");
            }
        }
    }


    
}



