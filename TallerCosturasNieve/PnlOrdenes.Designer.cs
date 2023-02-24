
namespace TallerCosturasNieve
{
    partial class PnlOrdenes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.crearUnaOrdenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verOrdenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkOrchid;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearUnaOrdenToolStripMenuItem,
            this.verOrdenesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(701, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // crearUnaOrdenToolStripMenuItem
            // 
            this.crearUnaOrdenToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.crearUnaOrdenToolStripMenuItem.Name = "crearUnaOrdenToolStripMenuItem";
            this.crearUnaOrdenToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.crearUnaOrdenToolStripMenuItem.Text = "Crear una orden";
            this.crearUnaOrdenToolStripMenuItem.Click += new System.EventHandler(this.crearUnaOrdenToolStripMenuItem_Click);
            // 
            // verOrdenesToolStripMenuItem
            // 
            this.verOrdenesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.verOrdenesToolStripMenuItem.Name = "verOrdenesToolStripMenuItem";
            this.verOrdenesToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.verOrdenesToolStripMenuItem.Text = "Ver ordenes";
            this.verOrdenesToolStripMenuItem.Click += new System.EventHandler(this.verOrdenesToolStripMenuItem_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Location = new System.Drawing.Point(0, 27);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(701, 386);
            this.pnlContent.TabIndex = 2;
            // 
            // PnlOrdenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 414);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PnlOrdenes";
            this.Text = "PnlOrdenes";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem crearUnaOrdenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verOrdenesToolStripMenuItem;
        private System.Windows.Forms.Panel pnlContent;
    }
}