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
    public partial class frmSucursalDetail : Form
    {
        private long _sucursal_id;
        private bool _is_new = false;

        private SUCURSAL _sucursal;
        public frmSucursalDetail()
        {
            InitializeComponent();
            this._is_new = true;
        }

        public frmSucursalDetail(long sucursal_id)
        {
            InitializeComponent();
            this._is_new = false;
            this._sucursal_id = sucursal_id;
        }


        public void cargar_datos()
        {
            try
            {
                using (Cooperativa_2023Entities context
                    = new Cooperativa_2023Entities())
                {
                    var sucursal = context.SUCURSAL.Find(this._sucursal_id);
                    sUCURSALBindingSource.DataSource = sucursal;
                    this._sucursal = sucursal;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: "
                    + ex.Message, "Personas", MessageBoxButtons.OK);
            }
        }


        public void cargar_empleados()
        {
            try
            {
                using (Cooperativa_2023Entities context
                    = new Cooperativa_2023Entities())
                {
                    var lista = context.EMPLEADO
                        .Include("PERSONA")
                        .OrderBy(e => e.PERSONA.PERSONA_APELLIDOS)
                        .ToList();
                    eMPLEADOBindingSource.DataSource = lista;   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: "
                    + ex.Message, "Personas", MessageBoxButtons.OK);
            }
        }


        private void frmSucursalDetail_Load(object sender, EventArgs e)
        {
            try
            {
                cargar_empleados();
                if (_is_new)
                {
                    //this.nuevo();
                }
                else
                {
                    this.cargar_datos();
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
