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
    public partial class Domicilio : Form
    {
        public Domicilio()
        {
            InitializeComponent();
        }
        private static Domicilio frmInst = null;

        public static Domicilio Instancia()
        {
            if (((frmInst == null) || (frmInst.IsDisposed == true)))
            {
                frmInst = new Domicilio();
            }
            frmInst.BringToFront();
            return frmInst;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Limpiar.txb(this);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxEntFed.SelectedIndex == 1)
            {
                ManejoBD bd = new ManejoBD();
                bd.buscarg("*", "municipios");
                cbxDelMun.DataSource = bd.ds.Tables[0].DefaultView;
                cbxDelMun.DisplayMember = "noMun";
            }
            if (cbxEntFed.SelectedIndex == 2)
            {
                ManejoBD bd = new ManejoBD();
                bd.buscarg("*", "delegaciones");
                cbxDelMun.DataSource = bd.ds.Tables[0].DefaultView;
                cbxDelMun.DisplayMember = "noDel";
            }
        }
    }
}
