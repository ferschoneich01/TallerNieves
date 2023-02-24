using System;
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
    public partial class PnlConfiguracion : Form
    {
        public PnlConfiguracion()
        {
            InitializeComponent();
            lblCC.Visible = false;
            lblCcontraseña.Visible = false;
            lblContraseña.Visible = false;
            txtCcontraseña.Visible = false;
            txtContraseña.Visible = false;
            btnGuardar.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            RegUsuario ru = new RegUsuario();
            ru.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vtnUsuarios us = new vtnUsuarios();
            us.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblCC.Visible = true;
            lblCcontraseña.Visible = true;
            lblContraseña.Visible = true;
            txtCcontraseña.Visible = true;
            txtContraseña.Visible = true;
            btnGuardar.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblCC.Visible = false;
            lblCcontraseña.Visible = false;
            lblContraseña.Visible = false;
            txtCcontraseña.Visible = false;
            txtContraseña.Visible = false;
            btnGuardar.Visible = false;
        }
    }
}
