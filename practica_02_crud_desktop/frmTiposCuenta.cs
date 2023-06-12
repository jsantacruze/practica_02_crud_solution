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
    public partial class frmTiposCuenta : Form
    {
        private string _filtro = string.Empty;

        public frmTiposCuenta()
        {
            InitializeComponent();
        }

        private void cargar_datos(string criterio)
        {
            Cursor.Current = Cursors.WaitCursor;
            using (Cooperativa_2023Entities
                context = new Cooperativa_2023Entities())
            {
                var lista = context.TIPO_CUENTA
                    .Where(t => t.TCUENTA_DESCRIPCION.Contains(criterio))
                    .ToList();  
                tIPO_CUENTABindingSource.DataSource = lista;
            }
            Cursor.Current = Cursors.Arrow;
        }

        private void frmTiposCuenta_Load(object sender, EventArgs e)
        {
            cargar_datos(this._filtro);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                frmTipoCuentaDetalle detalle = new frmTipoCuentaDetalle();
                if (detalle.ShowDialog() == DialogResult.OK)
                {
                    cargar_datos(this.txtFiltro.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: "
                    + ex.Message, "Personas", MessageBoxButtons.OK);
            }

        }

        private void eliminar_tipo_cuenta()
        {
            try
            {
                var tipo_actual
                    = this.tIPO_CUENTABindingSource.Current as TIPO_CUENTA;
                if (tipo_actual != null)
                {
                    if (MessageBox.Show("Está seguro de eliminar el tipo: "
                        + tipo_actual.TCUENTA_DESCRIPCION + "?", "Tipos",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        == DialogResult.Yes)
                    {
                        using (Cooperativa_2023Entities context
                        = new Cooperativa_2023Entities())
                        {
                            context.TIPO_CUENTA.Attach(tipo_actual);
                            context.Entry(tipo_actual).State
                                = System.Data.Entity.EntityState.Deleted;
                            context.TIPO_CUENTA.Remove(tipo_actual);
                            int result = context.SaveChanges();
                            if (result > 0)
                            {
                                MessageBox.Show("Tipo eliminado");
                            }
                        }
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


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar_tipo_cuenta();
        }

        private void tIPO_CUENTADataGridView_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var tipo_actual = this.tIPO_CUENTABindingSource.Current as TIPO_CUENTA;
                if (tipo_actual != null)
                {
                    frmTipoCuentaDetalle detalle = new frmTipoCuentaDetalle(tipo_actual.TCUENTA_ID);
                    if (detalle.ShowDialog() == DialogResult.OK)
                    {
                        cargar_datos(this.txtFiltro.Text);
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


        private void procesar_busqueda()
        {
            this._filtro = this.txtFiltro.Text;
            this.cargar_datos(this._filtro);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            procesar_busqueda();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            procesar_busqueda();
        }
    }
}
