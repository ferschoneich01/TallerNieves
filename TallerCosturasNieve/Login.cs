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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lblAlertaC.Visible = false;
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if (txtNombreUsuario.Text == "")
            {
                lblAlertNU.Visible = true;
            }else if (txtClave.Text == "")
            {
                lblAlertaC.Visible = true;
            }
            else
            {
                //validacion de usuario y contraseña
                Main main = new Main();
                main.Show();
                this.Hide();
            }
        }

        private void txtNombreUsuario_TextChanged(object sender, EventArgs e)
        {
            lblAlertNU.Visible = false;
        }
    }
}
