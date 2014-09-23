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
    }
}
