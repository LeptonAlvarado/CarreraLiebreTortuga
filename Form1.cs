using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarreraLiebreTortuga
{
    public partial class iniCarrera : Form
    {
        public iniCarrera()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void iniciarCarrera_Click(object sender, EventArgs e)
        {
            Liebre l1 = new Liebre(2);
            Tortuga t1 = new Tortuga(4);

            // Se genera un ciclo para que la liebre y la tortuga corran
            do
            {
                l1.Correr();
                t1.Correr();
                carrera.Text += l1.ToString() + Environment.NewLine + t1.ToString() + Environment.NewLine;
            } while (l1.Posicion < 100 && t1.Posicion < 100);

            // Se generan las condiciones para ver quien gano
            if (l1.Posicion >= 100 && t1.Posicion >= 100)
                carrera.Text += "Hubo un empate";
            else if (l1.Posicion > t1.Posicion)
                carrera.Text += "La liebre gano la carrera";
            else
                carrera.Text += "La tortuga gano la carrera";
        }
    }
}
