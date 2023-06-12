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
    public partial class frmTipoCuentaDetalle : Form
    {
        private int _tipo_cuenta_id;
        private bool _is_new = false;
        private TIPO_CUENTA _tipo_cuenta;

        public frmTipoCuentaDetalle()
        {
            InitializeComponent();
            this._is_new = true;
        }

        public frmTipoCuentaDetalle(int tipo_id)
        {
            InitializeComponent();
            this._tipo_cuenta_id = tipo_id;
            this._is_new = false;
        }

        public void cargar_datos()
        {
            try
            {
                using (Cooperativa_2023Entities context
                    = new Cooperativa_2023Entities())
                {
                    var tipo_cuenta = context.TIPO_CUENTA.Find(this._tipo_cuenta_id);
                    tIPO_CUENTABindingSource.DataSource = tipo_cuenta;
                    this._tipo_cuenta = tipo_cuenta;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: "
                    + ex.Message, "Personas", MessageBoxButtons.OK);
            }
        }

        private void nuevo()
        {
            try
            {
                this._tipo_cuenta = new TIPO_CUENTA();
                this._tipo_cuenta.TCUENTA_DESCRIPCION = string.Empty    ;
                tIPO_CUENTABindingSource.DataSource = this._tipo_cuenta;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: "
                    + ex.Message, "Personas", MessageBoxButtons.OK);
            }
        }

        private void frmTipoCuentaDetalle_Load(object sender, EventArgs e)
        {
            try
            {
                if (_is_new)
                {
                    this.nuevo();
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

        private bool validar_interfaz()
        {
            bool result = true;

            if (string.IsNullOrEmpty(tCUENTA_DESCRIPCIONTextBox.Text))
            {
                result = false;
                MessageBox.Show("El campo descripción es obligatorio",
                    "Personas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }

        private void actualizar()
        {
            try
            {
                using (Cooperativa_2023Entities context =
                    new Cooperativa_2023Entities())
                {
                    context.TIPO_CUENTA.Attach(this._tipo_cuenta);
                    context.Entry(this._tipo_cuenta).State 
                        = System.Data.Entity.EntityState.Modified;
                    int result = context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: "
                    + ex.Message, "Personas", MessageBoxButtons.OK);
            }
        }

        private void crear()
        {
            try
            {
                using (Cooperativa_2023Entities context =
                    new Cooperativa_2023Entities())
                {
                    context.TIPO_CUENTA.Attach(this._tipo_cuenta);
                    context.Entry(this._tipo_cuenta).State
                        = System.Data.Entity.EntityState.Added;
                    int result = context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: "
                    + ex.Message, "Personas", MessageBoxButtons.OK);
            }
        }

        private void frmTipoCuentaDetalle_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK)
            {
                if (validar_interfaz())
                {
                    //guardar los datos
                    if (!_is_new)
                    {
                        this.actualizar();
                    }
                    else
                    {
                        this.crear();
                    }
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                if (this.DialogResult == DialogResult.Cancel)
                {
                    if (MessageBox.Show("Está seguro de salir sin guardar los cambios?"
                        , "Personas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        e.Cancel = true;
                    }
                }
            }

        }
    }
}
