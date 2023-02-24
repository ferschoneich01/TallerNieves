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
    public partial class PnlOrdenes : Form
    {
        public PnlOrdenes()
        {
            InitializeComponent();
        }

        private void veOrdenesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void crearUnaOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearOrden co = new CrearOrden();
            AbrirFormEnPanel(co);
        }

        private void AbrirFormEnPanel(object formhija)
        {
            if (this.pnlContent.Controls.Count > 0)
                this.pnlContent.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnlContent.Controls.Add(fh);
            this.pnlContent.Tag = fh;
            fh.Show();

        }

        private void verOrdenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerOrdenes vo = new VerOrdenes();
            AbrirFormEnPanel(vo);
        }
    }
}
