using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            this.Close(); //cerrar ventana
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Agregamos unos consejos sobre los controles, para el usuario.
            ToolTip consejoFlotante = new ToolTip();
            consejoFlotante.SetToolTip(this.txt_pExito , "Escriba aquí la probabilidad de éxito");
            consejoFlotante.SetToolTip(this.txt_qFracaso, "Escriba aquí la probabilidad de fracaso");
            consejoFlotante.SetToolTip(this.txt_nMuestra, "Escriba aquí la muestra");
            consejoFlotante.SetToolTip(this.txt_qFracaso, "Escriba aquí la cantidad de eventos");

            double q = double.Parse(txt_qFracaso.Text);
            double p = double.Parse(txt_pExito.Text);
            double x = double.Parse(txt_xVariable.Text);
            double n = double.Parse(txt_nMuestra.Text);

            double i, factn;
            factn = n;
            for (i = n - 1; i >= 1; i--)
            {
                factn = factn * i;
            }

            double a, factx;
            factx = x;
            for (a = x - 1; a >= 1; a--)
            {
                factx = factx * a;
            }

            double restaExp = n - x ;
            double o, factRestaExp;
            factRestaExp = restaExp;
            for (o = restaExp - 1; o>= 1; o--)
            {
                factRestaExp = factRestaExp * o;
            }

            double div;
            div = factn / (factx* factRestaExp);
            double nu = div * ((Math.Pow(p, x)) * (Math.Pow(q, restaExp))) * 100;
            txtResultado.Text = nu.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
            Form1 f = new Form1();
            f.Visible = true;
            this.Dispose();
        }
    }
}
