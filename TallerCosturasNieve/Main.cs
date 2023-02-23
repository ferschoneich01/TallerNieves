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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            PnlOrdenes ordenes = new PnlOrdenes();
            AbrirFormEnPanel(ordenes);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            PnlConfiguracion configuracion = new PnlConfiguracion();
            AbrirFormEnPanel(configuracion);
        }

        private void AbrirFormEnPanel(object formhija)
        {
            if (this.pnlContentView.Controls.Count > 0)
                this.pnlContentView.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnlContentView.Controls.Add(fh);
            this.pnlContentView.Tag = fh;
            fh.Show();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            PnlMateriaPrima materiaP = new PnlMateriaPrima();
            AbrirFormEnPanel(materiaP);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            PnlEnvios envios = new PnlEnvios();
            AbrirFormEnPanel(envios);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show(@"Esta seguro que desea cerrar la sesion?", @"Atención",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();
                this.Hide();
            }
            
        }
    }
}
