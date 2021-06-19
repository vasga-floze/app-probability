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
    public partial class ProbMultinomial : Form
    {
        public ProbMultinomial()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double ex = double.Parse(txtX.Text);
            double n1 = double.Parse(txtN1.Text);
            double n2 = double.Parse(txtN2.Text);
            double n3 = double.Parse(txtN3.Text);
            double p1 = double.Parse(txtP1.Text);
            double p2 = double.Parse(txtP2.Text);
            double p3 = double.Parse(txtP3.Text);

            double i, factn; //factorial x
            factn = ex;
            for (i = ex - 1; i >= 1; i--)
            {
                factn = factn * i;
            }
            if (factn == 0)
            {
                factn = 1;
            }

            double i1, factn1; //factorial p1
            factn1 = n1;
            for (i1 = n1 - 1; i1 >= 1; i1--)
            {
                factn1 = factn1 * i1;
            }
            if (factn1 == 0)
            {
                factn1 = 1;
            }

            double i2, factn2; //factorial p2
            factn2 = n2;
            for (i2 = n2 - 1; i2 >= 1; i2--)
            {
                factn2 = factn2 * i2;
            }
            if (factn2 == 0)
            {
                factn2 = 1;
            }

            double i3, factn3; //factorial p3
            factn3 = n3;
            for (i3 = n3 - 1; i3 >= 1; i3--)
            {
                factn3 = factn3 * i3;
            }
            if (factn3 == 0)
            {
                factn3 = 1;
            }


            double resu;
            resu = Math.Pow(p1, n1);

            double resu1;
            resu1 = Math.Pow(p2, n2);

            double resu2;
            resu2 = Math.Pow(p3, n3);

            double resultado;
            resultado = (factn / (factn1 * factn2 * factn3)) * (resu * resu1 * resu2);
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

        private void txtN1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
