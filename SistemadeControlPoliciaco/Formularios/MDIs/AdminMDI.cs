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
    public partial class AdminMDI : Form
    {
        public AdminMDI()
        {
            InitializeComponent();
        }

        private void AdminMDI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro reg = null;
            reg = Registro.Instancia();
            reg.MdiParent = this;
            reg.Show();
        }

 
        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Editar edi = null;
            edi = Editar.Instancia();
            edi.MdiParent = this;
            edi.Show();
        }
    }
}
