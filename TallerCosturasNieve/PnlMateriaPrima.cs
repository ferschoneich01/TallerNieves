﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TallerCosturasNieve
{
    public partial class PnlMateriaPrima : Form
    {
        public PnlMateriaPrima()
        {
            InitializeComponent();
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            vtnCantidad ca = new vtnCantidad();
            ca.Show();
        }
    }
}
