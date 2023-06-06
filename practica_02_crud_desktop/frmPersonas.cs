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
    public partial class frmPersonas : Form
    {
        private string _filtro = string.Empty;
        public frmPersonas()
        {
            InitializeComponent();
        }

        private void cargar_datos(string criterio)
        {
            Cursor.Current = Cursors.WaitCursor;
            using (Cooperativa_2023Entities 
                context = new Cooperativa_2023Entities())
            {
                if (criterio == "nombres")
                {
                    var lista_personas = context
                        .PERSONA
                        .Where(p =>
                                 p.PERSONA_APELLIDOS.Contains(this._filtro) ||
                                 p.PERSONA_NOMBRES.Contains(this._filtro)
                            )
                        .ToList();
                    pERSONABindingSource.DataSource = lista_personas;
                }
                else
                {
                    var lista_personas = context
                        .PERSONA
                        .Where(p =>
                                 p.PERSONA_CEDULA_RUC.Contains(this._filtro)
                            )
                        .ToList();
                    pERSONABindingSource.DataSource = lista_personas;
                }
            }
            Cursor.Current = Cursors.Arrow;
        }

        private void procesar_busqueda()
        {
            this._filtro = this.txtFiltro.Text;
            string criterio = (this.optCedulaRuc.Checked ? "cedula" : "nombres");
            this.cargar_datos(criterio);
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            procesar_busqueda();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            procesar_busqueda();
        }

        private void frmPersonas_Load(object sender, EventArgs e)
        {
            procesar_busqueda();   
        }

        private void pERSONADataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void pERSONADataGridView_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var persona_actual = this.pERSONABindingSource.Current as PERSONA;
                if (persona_actual != null)
                {
                    frmPersonaDetail detalle = new frmPersonaDetail(persona_actual.PERSONA_ID);
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {

            try
            {
                    frmPersonaDetail detalle = new frmPersonaDetail();
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

        private void eliminar_persona()
        {
            try
            {
                var persona_actual
                    = this.pERSONABindingSource.Current as PERSONA;
                if (persona_actual != null)
                {
                    if (MessageBox.Show("Está seguro de eliminar la persona: "
                        + persona_actual.PERSONA_APELLIDOS + " "
                        + persona_actual.PERSONA_NOMBRES + "?", "Personas",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        == DialogResult.Yes)
                    {
                        using (Cooperativa_2023Entities context
                        = new Cooperativa_2023Entities())
                        {
                            context.PERSONA.Attach(persona_actual);
                            context.Entry(persona_actual).State 
                                = System.Data.Entity.EntityState.Deleted;
                            context.PERSONA.Remove(persona_actual);
                            int result = context.SaveChanges();
                            if (result > 0)
                            {
                                MessageBox.Show("Persona eliminada");
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
            this.eliminar_persona();
        }
    }
}
