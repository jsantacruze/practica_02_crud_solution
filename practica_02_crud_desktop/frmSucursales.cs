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
    public partial class frmSucursales : frmBase
    {
        public frmSucursales()
        {
            InitializeComponent();
        }

        private void cargar_datos()
        {
            Cursor.Current = Cursors.WaitCursor;
            using (Cooperativa_2023Entities
                context = new Cooperativa_2023Entities())
            {
                var lista = 
                    context.SUCURSAL
                    .Include("EMPLEADO.PERSONA")
                    .Where(s => s.SUCURSAL_DESCRIPCION.Contains(this._filtro))
                    .ToList();
                sUCURSALBindingSource.DataSource = lista;
            }
            Cursor.Current = Cursors.Arrow;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            cargar_datos();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            this._filtro = txtFiltro.Text;
            cargar_datos();
        }

        private void frmSucursales_Load(object sender, EventArgs e)
        {
            cargar_datos();
        }

        private void sUCURSALDataGridView_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var sucursal_actual = this.sUCURSALBindingSource.Current as SUCURSAL;
                if (sucursal_actual != null)
                {
                    frmSucursalDetail detalle = new frmSucursalDetail(sucursal_actual.SUCURSAL_ID);
                    if (detalle.ShowDialog() == DialogResult.OK)
                    {
                        cargar_datos();
                    }
                }
                else
                {
                    MessageBox.Show("Ningún registro fue seleccionado", "Personas",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: "
                    + ex.Message, "Personas", MessageBoxButtons.OK);
            }


        }
    }
}
