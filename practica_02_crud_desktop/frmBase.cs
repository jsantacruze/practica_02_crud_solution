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
    public partial class frmBase : Form
    {
        protected string _filtro = string.Empty;

        public frmBase()
        {
            InitializeComponent();
        }
    }
}
