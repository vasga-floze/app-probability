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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnBinomial_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmProbBinomial myNewForm = new frmProbBinomial();
            myNewForm.Visible = true;
            //this.Dispose();  //No permite cerrar totalmente
        }

        private void btnHipergeometrica_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmProbHipergeometrica hipergeometrica = new frmProbHipergeometrica();

            hipergeometrica.Visible = true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            playSalir();
            this.Dispose();
        }

        //Metodos para administrar el sonido
        private void playEnterMouse()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\gabri\Documents\CII-2020\Estadistica Computacional\enterMouse.wav");
            simpleSound.Play();
        }
        private void playSalir()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\gabri\Documents\CII-2020\Estadistica Computacional\salir.wav");
            simpleSound.Play();
        }

        private void btnMultinomial_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPoisson_Click(object sender, EventArgs e)
        {
            
        }

        private void btnHipergeometrica_MouseEnter(object sender, EventArgs e)
        {
            playEnterMouse();
        }

        private void btnMultinomial_MouseEnter(object sender, EventArgs e)
        {
            playEnterMouse();
        }


        private void btnPoisson_MouseEnter(object sender, EventArgs e)
        {
            playEnterMouse();
        }

        private void btnBinomial_MouseEnter_1(object sender, EventArgs e)
        {
            playEnterMouse();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            // agregamos unos consejos sobre los controles, para orientar al usuario.
            ToolTip consejoflotante = new ToolTip();
            consejoflotante.AutoPopDelay = 5000;
            consejoflotante.InitialDelay = 1;
            consejoflotante.ReshowDelay = 1000;

            consejoflotante.SetToolTip(this.btnCerrar, "Salir de la aplicación");
        }
    }
}
