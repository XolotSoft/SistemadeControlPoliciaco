﻿using System;
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
        string aPat = "";
        string aMat = "";
        string nAsp = "";
        string fNac = "";
        string eFed = "";
        string sAsp = "";
        private static Registro frmInst = null;

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
            Limpiar.txb(this);
            dtpFecNac.ResetText();
            Limpiar.cmb(this);
            aPat = "";
            aMat = "";
            nAsp = "";
            fNac = "";
            eFed = "";
            sAsp = "";
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Limpiar.txb(this);
            dtpFecNac.ResetText();
            Limpiar.cmb(this);
            aPat = "";
            aMat = "";
            nAsp = "";
            fNac = "";
            eFed = "";
            sAsp = "";
        }

        private void btnCon_Click(object sender, EventArgs e)
        {
            if(Vacio.txb(this))
            {
                if(Vacio.cmb(this))
                {
                    string aPat = txbApePat.Text;
                    string aMat = txbApeMat.Text;
                    string nAsp = txbNom.Text;
                    string fNac = dtpFecNac.Text;
                    string eFed = cbxEntFed.Text;
                    string sAsp = cbxSex.Text;
                    string dAsp = txbCurAut.Text + txbCurHom.Text;
                    string rAsp = txbRfcAut.Text + txbRfcHom.Text;
                    string ecAsp = cmbEdoCivil.Text;
                    Variables.DatosPersonales(aPat, aMat, nAsp, fNac, eFed, sAsp, dAsp, rAsp, ecAsp);
                    Limpiar.txb(this);
                    dtpFecNac.ResetText();
                    Limpiar.cmb(this);
                    this.Hide();
                    Domicilio dom = null;
                    dom = Domicilio.Instancia();
                    dom.MdiParent = AdminMDI.ActiveForm;
                    dom.MdiParent = UserMDI.ActiveForm;
                    dom.Show();
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

        private void txbApePat_Leave(object sender, EventArgs e)
        {
            if (txbApePat.Text != "")
            {
                aPat = txbApePat.Text.Substring(0, 2).ToUpper();
                txbRfcAut.Text = aPat + aMat + nAsp + fNac;
                txbCurAut.Text = aPat + aMat + nAsp + fNac + sAsp;
            }
            
        }

        private void txbApeMat_Leave(object sender, EventArgs e)
        {
            if (txbApeMat.Text != "")
            {
                aMat = txbApeMat.Text.Substring(0, 1).ToUpper();
                txbRfcAut.Text = aPat + aMat + nAsp + fNac;
                txbCurAut.Text = aPat + aMat + nAsp + fNac + sAsp;
            }           
        }

        private void txbNom_Leave(object sender, EventArgs e)
        {
            if (txbNom.Text != "")
            {
                nAsp = txbNom.Text.Substring(0, 1).ToUpper();
                txbRfcAut.Text = aPat + aMat + nAsp + fNac;
                txbCurAut.Text = aPat + aMat + nAsp + fNac + sAsp;
            }
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
            if (cbxSex.SelectedIndex != 0)
            {
                sAsp = cbxSex.Text.Substring(0, 1).ToUpper();
                txbCurAut.Text = aPat + aMat + nAsp + fNac + sAsp;
            }
        }

        private void cbxEntFed_Leave(object sender, EventArgs e)
        {
            if (cbxSex.SelectedIndex != 0)
            {
                eFed = cbxEntFed.SelectedValue.ToString();
                txbCurAut.Text = aPat + aMat + nAsp + fNac + sAsp + eFed;
            } 
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            ManejoBD bd = new ManejoBD();
            bd.buscarg("*","estados");
            cbxEntFed.DataSource = bd.ds.Tables[0].DefaultView;
            cbxEntFed.DisplayMember = "noEst";
            cbxEntFed.ValueMember = "clEst";
            Limpiar.txb(this);
            dtpFecNac.ResetText();
            Limpiar.cmb(this);
        }

        private void txbApePat_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.letrasyesp(e);
        }

        private void txbApeMat_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.letrasyesp(e);
        }

        private void txbNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.letrasyesp(e);
        }

        private void txbCurHom_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.letynum(e);
        }

        private void txbRfcHom_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.letynum(e);
        }
    }
}
