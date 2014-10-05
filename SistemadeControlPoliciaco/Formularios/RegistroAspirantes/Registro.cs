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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
            
            
        }
        private static Registro frmInst = null;
        string aPat = "";
        string aMat = "";
        string nAsp = "";
        string fNac = "";
        string eFed = "";
        string sAsp = "";
        string cAsp = "";
        string rAsp = "";

        public static Registro Instancia()
        {
            if (((frmInst == null) || (frmInst.IsDisposed == true)))
            {
                frmInst = new Registro();
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

        private void btnCon_Click(object sender, EventArgs e)
        {
            string aPat = txbApePat.Text;
            string aMat = txbApeMat.Text;
            string nAsp = txbNom.Text;
            string fNac = dtpFecNac.Text;
            string eFed = cbxEntFed.Text;
            string sAsp = cbxSex.Text;
            string cAsp = txbCurAut.Text + txbCurHom.Text;
            string rAsp = txbRfcAut.Text + txbRfcHom.Text;
            Variables.DatosPersonales(aPat, aMat, nAsp, fNac, eFed, sAsp, cAsp, rAsp);
            this.Hide();
            Domicilio dom = null;
            dom = Domicilio.Instancia();
            dom.MdiParent = AdminMDI.ActiveForm;
            dom.Show();
        }

        private void txbApePat_Leave(object sender, EventArgs e)
        {
            aPat = txbApePat.Text.Substring(0, 2).ToUpper();
            txbRfcAut.Text = aPat+aMat+nAsp+fNac;
            txbCurAut.Text = aPat + aMat + nAsp + fNac + sAsp;
        }

        private void txbApeMat_Leave(object sender, EventArgs e)
        {
            aMat = txbApeMat.Text.Substring(0, 1).ToUpper();
            txbRfcAut.Text = aPat + aMat + nAsp + fNac;
            txbCurAut.Text = aPat + aMat + nAsp + fNac + sAsp;
        }

        private void txbNom_Leave(object sender, EventArgs e)
        {
            nAsp = txbNom.Text.Substring(0, 1).ToUpper();
            txbRfcAut.Text = aPat + aMat + nAsp + fNac;
            txbCurAut.Text = aPat + aMat + nAsp + fNac + sAsp;
        }

        private void dtpFecNac_Leave(object sender, EventArgs e)
        {
            dtpFecNac.Format = DateTimePickerFormat.Custom;
            dtpFecNac.CustomFormat = "yyMMdd";
            fNac = dtpFecNac.Text;
            txbRfcAut.Text = aPat + aMat + nAsp + fNac;
            txbCurAut.Text = aPat + aMat + nAsp + fNac + sAsp;
        }

        private void cbxSex_Leave(object sender, EventArgs e)
        {
            sAsp = cbxSex.Text.Substring(0, 1).ToUpper();
            txbCurAut.Text = aPat + aMat + nAsp + fNac + sAsp;
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            ManejoBD bd = new ManejoBD();
            bd.buscarg("*","Estados");
            cbxEntFed.DataSource = bd.ds.Tables[0].DefaultView;
            cbxEntFed.DisplayMember = "noEstado";
            cbxEntFed.ValueMember = "clEstado";
        }

        private void cbxEntFed_Leave(object sender, EventArgs e)
        {
            eFed = cbxEntFed.SelectedValue.ToString();
            txbCurAut.Text = aPat + aMat + nAsp + fNac + sAsp + eFed;

        }
    }
}
