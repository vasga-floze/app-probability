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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBinomial_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmProbBinomial myNewForm = new frmProbBinomial();

            myNewForm.Visible = true;
        }

        private void btnHipergeometrica_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmProbHipergeometrica hipergeometrica = new frmProbHipergeometrica();

            hipergeometrica.Visible = true;
        }
    }
}
