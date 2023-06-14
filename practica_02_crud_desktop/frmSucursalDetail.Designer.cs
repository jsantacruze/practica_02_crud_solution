namespace practica_02_crud_desktop
{
    partial class frmSucursalDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label sUCURSAL_IDLabel;
            System.Windows.Forms.Label sUCURSAL_DESCRIPCIONLabel;
            System.Windows.Forms.Label sUCURSAL_DIRECCIONLabel;
            System.Windows.Forms.Label pERSONA_IDLabel;
            System.Windows.Forms.Label sUCURSAL_TELEFONOLabel;
            System.Windows.Forms.Label label1;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.eMPLEADOComboBox = new System.Windows.Forms.ComboBox();
            this.sUCURSALBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMPLEADOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sUCURSAL_MATRIZCheckBox = new System.Windows.Forms.CheckBox();
            this.sUCURSAL_TELEFONOTextBox = new System.Windows.Forms.TextBox();
            this.pERSONA_IDTextBox = new System.Windows.Forms.TextBox();
            this.sUCURSAL_ESTADOCheckBox = new System.Windows.Forms.CheckBox();
            this.sUCURSAL_DIRECCIONTextBox = new System.Windows.Forms.TextBox();
            this.sUCURSAL_DESCRIPCIONTextBox = new System.Windows.Forms.TextBox();
            this.sUCURSAL_IDTextBox = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            sUCURSAL_IDLabel = new System.Windows.Forms.Label();
            sUCURSAL_DESCRIPCIONLabel = new System.Windows.Forms.Label();
            sUCURSAL_DIRECCIONLabel = new System.Windows.Forms.Label();
            pERSONA_IDLabel = new System.Windows.Forms.Label();
            sUCURSAL_TELEFONOLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sUCURSALBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLEADOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sUCURSAL_IDLabel
            // 
            sUCURSAL_IDLabel.AutoSize = true;
            sUCURSAL_IDLabel.Location = new System.Drawing.Point(69, 19);
            sUCURSAL_IDLabel.Name = "sUCURSAL_IDLabel";
            sUCURSAL_IDLabel.Size = new System.Drawing.Size(82, 13);
            sUCURSAL_IDLabel.TabIndex = 0;
            sUCURSAL_IDLabel.Text = "SUCURSAL ID:";
            // 
            // sUCURSAL_DESCRIPCIONLabel
            // 
            sUCURSAL_DESCRIPCIONLabel.AutoSize = true;
            sUCURSAL_DESCRIPCIONLabel.Location = new System.Drawing.Point(7, 48);
            sUCURSAL_DESCRIPCIONLabel.Name = "sUCURSAL_DESCRIPCIONLabel";
            sUCURSAL_DESCRIPCIONLabel.Size = new System.Drawing.Size(144, 13);
            sUCURSAL_DESCRIPCIONLabel.TabIndex = 2;
            sUCURSAL_DESCRIPCIONLabel.Text = "SUCURSAL DESCRIPCION:";
            // 
            // sUCURSAL_DIRECCIONLabel
            // 
            sUCURSAL_DIRECCIONLabel.AutoSize = true;
            sUCURSAL_DIRECCIONLabel.Location = new System.Drawing.Point(21, 74);
            sUCURSAL_DIRECCIONLabel.Name = "sUCURSAL_DIRECCIONLabel";
            sUCURSAL_DIRECCIONLabel.Size = new System.Drawing.Size(130, 13);
            sUCURSAL_DIRECCIONLabel.TabIndex = 4;
            sUCURSAL_DIRECCIONLabel.Text = "SUCURSAL DIRECCION:";
            // 
            // pERSONA_IDLabel
            // 
            pERSONA_IDLabel.AutoSize = true;
            pERSONA_IDLabel.Location = new System.Drawing.Point(266, 22);
            pERSONA_IDLabel.Name = "pERSONA_IDLabel";
            pERSONA_IDLabel.Size = new System.Drawing.Size(76, 13);
            pERSONA_IDLabel.TabIndex = 8;
            pERSONA_IDLabel.Text = "PERSONA ID:";
            // 
            // sUCURSAL_TELEFONOLabel
            // 
            sUCURSAL_TELEFONOLabel.AutoSize = true;
            sUCURSAL_TELEFONOLabel.Location = new System.Drawing.Point(23, 130);
            sUCURSAL_TELEFONOLabel.Name = "sUCURSAL_TELEFONOLabel";
            sUCURSAL_TELEFONOLabel.Size = new System.Drawing.Size(128, 13);
            sUCURSAL_TELEFONOLabel.TabIndex = 10;
            sUCURSAL_TELEFONOLabel.Text = "SUCURSAL TELEFONO:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(62, 167);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(89, 13);
            label1.TabIndex = 14;
            label1.Text = "RESPONSABLE:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(this.eMPLEADOComboBox);
            this.groupBox1.Controls.Add(this.sUCURSAL_MATRIZCheckBox);
            this.groupBox1.Controls.Add(sUCURSAL_TELEFONOLabel);
            this.groupBox1.Controls.Add(this.sUCURSAL_TELEFONOTextBox);
            this.groupBox1.Controls.Add(pERSONA_IDLabel);
            this.groupBox1.Controls.Add(this.pERSONA_IDTextBox);
            this.groupBox1.Controls.Add(this.sUCURSAL_ESTADOCheckBox);
            this.groupBox1.Controls.Add(sUCURSAL_DIRECCIONLabel);
            this.groupBox1.Controls.Add(this.sUCURSAL_DIRECCIONTextBox);
            this.groupBox1.Controls.Add(sUCURSAL_DESCRIPCIONLabel);
            this.groupBox1.Controls.Add(this.sUCURSAL_DESCRIPCIONTextBox);
            this.groupBox1.Controls.Add(sUCURSAL_IDLabel);
            this.groupBox1.Controls.Add(this.sUCURSAL_IDTextBox);
            this.groupBox1.Location = new System.Drawing.Point(10, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 203);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle";
            // 
            // eMPLEADOComboBox
            // 
            this.eMPLEADOComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sUCURSALBindingSource, "PERSONA_ID", true));
            this.eMPLEADOComboBox.DataSource = this.eMPLEADOBindingSource;
            this.eMPLEADOComboBox.DisplayMember = "PERSONA";
            this.eMPLEADOComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.eMPLEADOComboBox.FormattingEnabled = true;
            this.eMPLEADOComboBox.Location = new System.Drawing.Point(157, 164);
            this.eMPLEADOComboBox.Name = "eMPLEADOComboBox";
            this.eMPLEADOComboBox.Size = new System.Drawing.Size(300, 21);
            this.eMPLEADOComboBox.TabIndex = 13;
            this.eMPLEADOComboBox.ValueMember = "PERSONA_ID";
            // 
            // sUCURSALBindingSource
            // 
            this.sUCURSALBindingSource.DataSource = typeof(practica_02_crud_desktop.SUCURSAL);
            // 
            // eMPLEADOBindingSource
            // 
            this.eMPLEADOBindingSource.DataSource = typeof(practica_02_crud_desktop.EMPLEADO);
            // 
            // sUCURSAL_MATRIZCheckBox
            // 
            this.sUCURSAL_MATRIZCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.sUCURSALBindingSource, "SUCURSAL_MATRIZ", true));
            this.sUCURSAL_MATRIZCheckBox.Location = new System.Drawing.Point(256, 97);
            this.sUCURSAL_MATRIZCheckBox.Name = "sUCURSAL_MATRIZCheckBox";
            this.sUCURSAL_MATRIZCheckBox.Size = new System.Drawing.Size(104, 24);
            this.sUCURSAL_MATRIZCheckBox.TabIndex = 13;
            this.sUCURSAL_MATRIZCheckBox.Text = "Matriz";
            this.sUCURSAL_MATRIZCheckBox.UseVisualStyleBackColor = true;
            // 
            // sUCURSAL_TELEFONOTextBox
            // 
            this.sUCURSAL_TELEFONOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sUCURSALBindingSource, "SUCURSAL_TELEFONO", true));
            this.sUCURSAL_TELEFONOTextBox.Location = new System.Drawing.Point(157, 127);
            this.sUCURSAL_TELEFONOTextBox.Name = "sUCURSAL_TELEFONOTextBox";
            this.sUCURSAL_TELEFONOTextBox.Size = new System.Drawing.Size(281, 20);
            this.sUCURSAL_TELEFONOTextBox.TabIndex = 11;
            // 
            // pERSONA_IDTextBox
            // 
            this.pERSONA_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sUCURSALBindingSource, "PERSONA_ID", true));
            this.pERSONA_IDTextBox.Location = new System.Drawing.Point(348, 19);
            this.pERSONA_IDTextBox.Name = "pERSONA_IDTextBox";
            this.pERSONA_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.pERSONA_IDTextBox.TabIndex = 9;
            // 
            // sUCURSAL_ESTADOCheckBox
            // 
            this.sUCURSAL_ESTADOCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.sUCURSALBindingSource, "SUCURSAL_ESTADO", true));
            this.sUCURSAL_ESTADOCheckBox.Location = new System.Drawing.Point(157, 97);
            this.sUCURSAL_ESTADOCheckBox.Name = "sUCURSAL_ESTADOCheckBox";
            this.sUCURSAL_ESTADOCheckBox.Size = new System.Drawing.Size(104, 24);
            this.sUCURSAL_ESTADOCheckBox.TabIndex = 7;
            this.sUCURSAL_ESTADOCheckBox.Text = "Activa";
            this.sUCURSAL_ESTADOCheckBox.UseVisualStyleBackColor = true;
            // 
            // sUCURSAL_DIRECCIONTextBox
            // 
            this.sUCURSAL_DIRECCIONTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sUCURSALBindingSource, "SUCURSAL_DIRECCION", true));
            this.sUCURSAL_DIRECCIONTextBox.Location = new System.Drawing.Point(157, 71);
            this.sUCURSAL_DIRECCIONTextBox.Name = "sUCURSAL_DIRECCIONTextBox";
            this.sUCURSAL_DIRECCIONTextBox.Size = new System.Drawing.Size(281, 20);
            this.sUCURSAL_DIRECCIONTextBox.TabIndex = 5;
            // 
            // sUCURSAL_DESCRIPCIONTextBox
            // 
            this.sUCURSAL_DESCRIPCIONTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sUCURSALBindingSource, "SUCURSAL_DESCRIPCION", true));
            this.sUCURSAL_DESCRIPCIONTextBox.Location = new System.Drawing.Point(157, 45);
            this.sUCURSAL_DESCRIPCIONTextBox.Name = "sUCURSAL_DESCRIPCIONTextBox";
            this.sUCURSAL_DESCRIPCIONTextBox.Size = new System.Drawing.Size(281, 20);
            this.sUCURSAL_DESCRIPCIONTextBox.TabIndex = 3;
            // 
            // sUCURSAL_IDTextBox
            // 
            this.sUCURSAL_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sUCURSALBindingSource, "SUCURSAL_ID", true));
            this.sUCURSAL_IDTextBox.Location = new System.Drawing.Point(157, 19);
            this.sUCURSAL_IDTextBox.Name = "sUCURSAL_IDTextBox";
            this.sUCURSAL_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.sUCURSAL_IDTextBox.TabIndex = 1;
            // 
            // btnAceptar
            // 
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptar.Location = new System.Drawing.Point(277, 224);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(358, 224);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmSucursalDetail
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(482, 251);
            this.ControlBox = false;
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSucursalDetail";
            this.Text = "Detalle de Sucursales";
            this.Load += new System.EventHandler(this.frmSucursalDetail_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sUCURSALBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLEADOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox sUCURSAL_MATRIZCheckBox;
        private System.Windows.Forms.BindingSource sUCURSALBindingSource;
        private System.Windows.Forms.TextBox sUCURSAL_TELEFONOTextBox;
        private System.Windows.Forms.TextBox pERSONA_IDTextBox;
        private System.Windows.Forms.CheckBox sUCURSAL_ESTADOCheckBox;
        private System.Windows.Forms.TextBox sUCURSAL_DIRECCIONTextBox;
        private System.Windows.Forms.TextBox sUCURSAL_DESCRIPCIONTextBox;
        private System.Windows.Forms.TextBox sUCURSAL_IDTextBox;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox eMPLEADOComboBox;
        private System.Windows.Forms.BindingSource eMPLEADOBindingSource;
    }
}