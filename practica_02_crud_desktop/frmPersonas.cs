﻿using System;
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
    }
}