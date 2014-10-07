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
    public partial class Contacto : Form
    {
        public Contacto()
        {
            InitializeComponent();
        }
        private static Contacto frmInst = null;

        public static Contacto Instancia()
        {
            if (((frmInst == null) || (frmInst.IsDisposed == true)))
            {
                frmInst = new Contacto();
            }
            frmInst.BringToFront();
            return frmInst;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Limpiar.txb(this);
            Limpiar.cmb(this);
            this.Hide();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar.txb(this);
            Limpiar.cmb(this);
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if (Vacio.txb(this))
            {
                if (Vacio.cmb(this))
                {
                    string cn = txbCon.Text;
                    string pt = cmbPue.Text;
                    string tl = txbTel.Text;
                    string cl = txbCel.Text;
                    string em = txbMail.Text;
                    Variables.Contacto(cn, pt, tl, cl, em);
                    Limpiar.txb(this);
                    Limpiar.cmb(this);
                    this.Hide();
                    Foto fot = null;
                    fot = Foto.Instancia();
                    fot.MdiParent = AdminMDI.ActiveForm;
                    fot.MdiParent = UserMDI.ActiveForm;
                    fot.Show();
                }
                else
                {
                    MessageBox.Show("Debes de Seleccionar una opcion", "Error",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debes de llenar todos los campos", "Error",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
