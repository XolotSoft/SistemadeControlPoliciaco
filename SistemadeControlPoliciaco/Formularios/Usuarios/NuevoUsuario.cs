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
    public partial class NuevoUsuario : Form
    {
        public NuevoUsuario()
        {
            InitializeComponent();
        }
        int tipo;
        ManejoBD db = new ManejoBD();
        private static NuevoUsuario frmInst = null;

        public static NuevoUsuario Instancia()
        {
            if (((frmInst == null) || (frmInst.IsDisposed == true)))
            {
                frmInst = new NuevoUsuario();
            }
            frmInst.BringToFront();
            return frmInst;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (rdbAdmin.Checked)
            {
                tipo = 1;
            }
            if (rdbEmpleado.Checked)
            {
                tipo = 2;
            }

            if (Vacio.txb(this))
            {
                if (txbPass.Text == txbPass2.Text)
                {

                    if (db.insertar("usuarios", "noUsu,pwUsu,tpUsu,nmUsu,apUsu,tlUsu",
                        "'" + txbUser.Text + "','" + txbPass.Text + "','" + 
                        tipo + "','"+ txbNombre.Text+"','"+txbApellido.Text+"','"+txbTelefono.Text+"'"))
                    {
                        MessageBox.Show("Se ha registrado el Usuario " + txbUser.Text, "Correctamente",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Limpiar.txb(this);
                    }
                    else
                    {
                        MessageBox.Show("No se ha registrado", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No puedes dejar campos vacios", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
