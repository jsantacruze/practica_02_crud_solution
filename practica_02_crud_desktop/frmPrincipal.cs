using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica_02_crud_desktop
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void personasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonas form = new frmPersonas();
            form.MdiParent = this;
            form.Show();
        }

        private void tiposDeCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTiposCuenta form = new frmTiposCuenta();
            form.MdiParent = this;
            form.Show();
        }
    }
}
