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
    public partial class EditarAspirante : Form
    {
        public EditarAspirante()
        {
            InitializeComponent();
        }
        private static EditarAspirante frmInst = null;

        public static EditarAspirante Instancia()
        {
            if (((frmInst == null) || (frmInst.IsDisposed == true)))
            {
                frmInst = new EditarAspirante();
            }
            frmInst.BringToFront();
            return frmInst;
        }

        private void btnCer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
