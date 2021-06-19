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
    public partial class ProbPoisson : Form
    {
        public ProbPoisson()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double L = double.Parse(txtL.Text);
            double ex = double.Parse(txtX.Text);
            double le = 2.718; // La constante le tiene un valor aproximado de 2.718.

            double resu;
            resu = Math.Pow(L, ex); //lamda elevada al numero de ocurrencia

            double res;
            res = Math.Pow(le, (-L)); // la constante e elevada a lambda negativo

            double i, factn; //factorial
            factn = ex;
            for (i = ex - 1; i >= 1; i--)
            {
                factn = factn * i;
            }
            //Validar que factorial de n sea diferente de 0

            double resultado;
            resultado = (res * resu) / factn;

            txtResultado.Text = resultado.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmInicio f = new frmInicio();
            f.Visible = true;
            this.Dispose();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close(); //cerrar ventana
        }
    }
}
