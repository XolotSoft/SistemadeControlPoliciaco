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
    public partial class EliminarUsuario : Form
    {
        public EliminarUsuario()
        {
            InitializeComponent();
        }
        private static EliminarUsuario frmInst = null;

        public static EliminarUsuario Instancia()
        {
            if (((frmInst == null) || (frmInst.IsDisposed == true)))
            {
                frmInst = new EliminarUsuario();
            }
            frmInst.BringToFront();
            return frmInst;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
