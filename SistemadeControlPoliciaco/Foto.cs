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
    public partial class Foto : Form
    {
        public Foto()
        {
            InitializeComponent();
        }
        private static Foto frmInst = null;

        public static Foto Instancia()
        {
            if (((frmInst == null) || (frmInst.IsDisposed == true)))
            {
                frmInst = new Foto();
            }
            frmInst.BringToFront();
            return frmInst;
        }

        private void Foto_Load(object sender, EventArgs e)
        {

        }
    }
}
