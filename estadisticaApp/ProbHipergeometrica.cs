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
    public partial class frmProbHipergeometrica : Form
    {
        public frmProbHipergeometrica()
        {
            InitializeComponent();
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {

            //Capturamos los datos de insumo para el calculo de la probabilidad
            double nPobl = double.Parse(txt_nPoblacion.Text);
            double nMuest = double.Parse(txt_nMuestraPobl.Text);
            double aCaract = double.Parse(txt_aCaracteristica.Text);
            double xCant = double.Parse(txt_xCantExitos.Text);

            
            //Validar entrada de datos
            const string mensaje1 = "La muestra NO puede ser mayor a la cantidad de elementos con característica deseada.";
            const string caption_1 = "¡ENTRADA DE DATO INVALIDA!";
            if (nMuest > aCaract)
            {
                MessageBox.Show(mensaje1, caption_1, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nMuestraPobl.Clear();
            }

            const string mensaje2 = "La cantidad de éxitos 'x' NO puede ser mayor a la cantidad de la muestra";
            const string caption_2 = "¡ENTRADA DE DATO INVALIDA!";
            if (xCant > nMuest)
            {
                MessageBox.Show(mensaje2, caption_2, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_xCantExitos.Clear();
            }


            //****************************************************************

            //Calcular factorial de a
            double i, fact_a; //i solo la esta haciendo de contador y factn esta almacenando el factorial de n
            fact_a = aCaract;
            for (i = aCaract - 1; i >= 1; i--)
            {
                fact_a = fact_a * i;
            }


            //Calcular factorial de x
            double o, fact_x; //o solo la esta haciendo de contador y factn esta almacenando el factorial de n
            fact_x = xCant;
            for (o = xCant - 1; i >= 1; o--)
            {
                fact_x = fact_x * o;
            }

            //Resta de a-x
            double restaa_x = aCaract - xCant;

            //Calcular factorial de a-x
            double b, factResta_ax; //w solo la esta haciendo de contador y factn esta almacenando el factorial de n
            factResta_ax = restaa_x;
            for (b = restaa_x - 1; b >= 1; b--)
            {
                factResta_ax = factResta_ax * b;
            }

            //Cálculo parentesis uno
            double numerador, denominador, numerador2, denominador2, numerador3, denominador3, parentesisUno, parentesisDos, parentesisTres, div1, div2, div3;
            numerador = fact_a;
            denominador = (fact_x * factResta_ax);
            div1 = Math.Round(numerador / denominador, 4);
            parentesisUno = Math.Round(div1, 4);
            lblFactorialParentesis1.Text = Math.Round(parentesisUno, 4).ToString();

            //****************************************************************

            //Resta de N-a   ----> n!
            double restaNa = nPobl - aCaract;

            //Calcular factorial de N-a ----> n!
            double w, fact_N_a; //w solo la esta haciendo de contador y factn esta almacenando el factorial de n
            fact_N_a = restaNa;
            for (w = restaNa - 1; w >= 1; w--)
            {
                fact_N_a = fact_N_a * w;
            }

            //Resta n-x   ----> x!
            double restanx = nMuest - xCant;

            //Calcular factorial de n-x ----> x!
            double s, fact_N_x; //s solo la esta haciendo de contador y factn esta almacenando el factorial de n
            fact_N_x = restanx;
            for (s = restanx - 1; s >= 1; s--)
            {
                fact_N_x = fact_N_x * s;
            }

            //Resta de Na - nx   ---->  (n-x)!
            double restaNa_nx = restaNa - restanx;

            //Factorial de Na - nx  ---->  (n-x)!
            double t, factResta_Na_nx; //t solo la esta haciendo de contador y factn esta almacenando el factorial de n
            factResta_Na_nx = restaNa_nx;
            for (t = restaNa_nx - 1; t >= 1; t--)
            {
                factResta_Na_nx = factResta_Na_nx * t;
            }

            //Calculo parentesis dos
            numerador2 = fact_N_a;
            denominador2 = (fact_N_x * factResta_Na_nx);
            div2 = Math.Round(numerador2 / denominador2, 4);
            parentesisDos = Math.Round(div2, 4);
            lblFactorialParentesis2.Text = Math.Round(parentesisDos, 4).ToString();

            //****************************************************************

            //Calcular factorial de N ----> n!
            double u, fact_N; //u solo la esta haciendo de contador y factn esta almacenando el factorial de n
            fact_N = nPobl;
            for (u = nPobl - 1; u >= 1; u--)
            {
                fact_N = fact_N * u;
            }
            MessageBox.Show(fact_N.ToString(), "Factorial de NPobl");

            //Calcular factorial de n  ----> x!
            double a, fact_n; //o solo la esta haciendo de contador y factn esta almacenando el factorial de n
            fact_n = nMuest;
            for (a = nMuest - 1; a >= 1; a--)
            {
                fact_n = fact_n * a;
            }
            MessageBox.Show(fact_n.ToString(), "Factorial de nMuest");

            //Resta de N-n  ---->  (n-x)!
            double restaN_n;
            restaN_n = nPobl - nMuest;
            MessageBox.Show(restaN_n.ToString(), "Resta de N-n");

            //Calcular factorial de N-n ---->  (n-x)!
            double r, factResta_N_n; //r solo la esta haciendo de contador y factn esta almacenando el factorial de n
            factResta_N_n = restaN_n;
            for (r = restaN_n - 1; r >= 1; r--)
            {
                factResta_N_n = factResta_N_n * r;
            }
            MessageBox.Show(factResta_N_n.ToString(), "Factorial de N-n");

            //Calculo parentesis tres
            numerador3 = fact_N;
            denominador3 = (fact_n * factResta_N_n);
            div3 = Math.Round(numerador3 / denominador3, 4);
            parentesisTres = Math.Round(div3, 4);
            lblFactorialParentesis3.Text = Math.Round(parentesisTres, 4).ToString();
            

            //**************Calculo formula completa***************

            txtResultado.Text = Math.Round(((parentesisUno * parentesisDos) / parentesisTres),4).ToString();

            //Pasar datos a los label para simular proceso interno
            lbl_a.Text = txt_aCaracteristica.Text;
            lbln_x.Text =  restanx.ToString();
            lblN_a.Text = restaNa.ToString();
            lbl_x.Text = txt_xCantExitos.Text;
            lbl_N.Text = txt_nPoblacion.Text;
            lblN_.Text = txt_nMuestraPobl.Text;
            
                       
        }

        private void playAtras()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\gabri\Documents\CII-2020\Estadistica Computacional\atras.wav");
            simpleSound.Play();
        }

        private void playSalir()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\gabri\Documents\CII-2020\Estadistica Computacional\salir.wav");
            simpleSound.Play();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            playSalir();
            this.Dispose();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //Regresar al menu principal 
            playAtras();
            frmInicio f = new frmInicio();
            f.Visible = true;
            this.Dispose();
        }

        

        private void frmProbHipergeometrica_Load(object sender, EventArgs e)
        {
            // agregamos unos consejos sobre los controles, para el usuario.
            ToolTip consejoflotante = new ToolTip();
            consejoflotante.AutoPopDelay = 5000;
            consejoflotante.InitialDelay = 1;
            consejoflotante.ReshowDelay = 1000;

            consejoflotante.SetToolTip(this.txt_nPoblacion, "escriba aquí el tamaño de la población.");
            consejoflotante.SetToolTip(this.txt_nMuestraPobl, "escriba aquí el tamaño de la muestra");
            consejoflotante.SetToolTip(this.txt_aCaracteristica, "escriba aquí la cantidad que cumple con la característica deseada.");
            consejoflotante.SetToolTip(this.txt_xCantExitos , "escriba aquí la cantidad de éxitos");
        }
    }
}
