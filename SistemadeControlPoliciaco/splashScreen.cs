using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemadeControlPoliciaco
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
            pgbCargando.Maximum = 100;
            pgbCargando.Minimum = 0;
            pgbCargando.Value = 0;
            pgbCargando.Step = 1;
            tiempo.Enabled = true;
        }

        private void tiempo_Tick(object sender, EventArgs e)
        {
            if (pgbCargando.Value < 100)
            {
                pgbCargando.Value += 2;

                switch (pgbCargando.Value)
                {
                    case 2:
                        lblMensaje.Text = "Tomando el sol en la playa...";
                        break;
                    case 20:
                        lblMensaje.Text = "Regando plantas del patio...";
                        break;
                    case 40:
                        lblMensaje.Text = "Cosechando frutos ya maduros...";
                        break;
                    case 60:
                        lblMensaje.Text = "Buscando una chica a lo lejos...";
                        break;
                    case 80:
                        lblMensaje.Text = "Terminando de decir tonterias...";
                        break;
                    case 100:
                        tiempo.Enabled = false;
                        this.Hide();
                        Login login = new Login();
                        login.Show();
                        break;
                }
            }      
        }
    }
}
