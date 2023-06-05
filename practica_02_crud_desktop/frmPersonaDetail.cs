using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace practica_02_crud_desktop
{
    public partial class frmPersonaDetail : Form
    {
        private long _persona_id;
        private bool _is_new = false;

        /// <summary>
        /// Crea una nueva persona
        /// </summary>
        public frmPersonaDetail()
        {
            InitializeComponent();
            this._is_new = true;
        }

        /// <summary>
        /// Edita una persona
        /// </summary>
        /// <param name="persona_id">Especifica el id de la persona que vamos a editar</param>
        public frmPersonaDetail(long persona_id)
        {
            InitializeComponent();
            this._persona_id = persona_id;
            this._is_new = false;
        }

        public void cargar_datos()
        {
            try
            {
                using (Cooperativa_2023Entities context 
                    = new Cooperativa_2023Entities())
                {
                    var persona = context.PERSONA.Find(this._persona_id);
                    //var persona = context.PERSONA
                    //    .Where(p => p.PERSONA_ID == _persona_id).FirstOrDefault();
                    pERSONABindingSource.DataSource = persona;
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

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: "
                    + ex.Message, "Personas", MessageBoxButtons.OK);
            }
        }

        private void frmPersonaDetail_Load(object sender, EventArgs e)
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

            if (string.IsNullOrEmpty(pERSONA_CEDULA_RUCTextBox.Text))
            {
                result = false;
                MessageBox.Show("El campo cedula es obligatorio",
                    "Personas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }

        private void frmPersonaDetail_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK)
            {
                if (validar_interfaz())
                {
                    //guardar los datos
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
