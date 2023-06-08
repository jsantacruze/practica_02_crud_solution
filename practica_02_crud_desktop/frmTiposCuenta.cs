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
    }
}
