namespace practica_02_crud_desktop
{
    partial class frmTipoCuentaDetalle
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
            System.Windows.Forms.Label tCUENTA_IDLabel;
            System.Windows.Forms.Label tCUENTA_DESCRIPCIONLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tIPO_CUENTABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tCUENTA_IDTextBox = new System.Windows.Forms.TextBox();
            this.tCUENTA_DESCRIPCIONTextBox = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            tCUENTA_IDLabel = new System.Windows.Forms.Label();
            tCUENTA_DESCRIPCIONLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tIPO_CUENTABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(tCUENTA_DESCRIPCIONLabel);
            this.groupBox1.Controls.Add(this.tCUENTA_DESCRIPCIONTextBox);
            this.groupBox1.Controls.Add(tCUENTA_IDLabel);
            this.groupBox1.Controls.Add(this.tCUENTA_IDTextBox);
            this.groupBox1.Location = new System.Drawing.Point(8, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 115);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle";
            // 
            // tIPO_CUENTABindingSource
            // 
            this.tIPO_CUENTABindingSource.DataSource = typeof(practica_02_crud_desktop.TIPO_CUENTA);
            // 
            // tCUENTA_IDLabel
            // 
            tCUENTA_IDLabel.AutoSize = true;
            tCUENTA_IDLabel.Location = new System.Drawing.Point(92, 32);
            tCUENTA_IDLabel.Name = "tCUENTA_IDLabel";
            tCUENTA_IDLabel.Size = new System.Drawing.Size(21, 13);
            tCUENTA_IDLabel.TabIndex = 0;
            tCUENTA_IDLabel.Text = "ID:";
            // 
            // tCUENTA_IDTextBox
            // 
            this.tCUENTA_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tIPO_CUENTABindingSource, "TCUENTA_ID", true));
            this.tCUENTA_IDTextBox.Location = new System.Drawing.Point(131, 29);
            this.tCUENTA_IDTextBox.Name = "tCUENTA_IDTextBox";
            this.tCUENTA_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.tCUENTA_IDTextBox.TabIndex = 1;
            // 
            // tCUENTA_DESCRIPCIONLabel
            // 
            tCUENTA_DESCRIPCIONLabel.AutoSize = true;
            tCUENTA_DESCRIPCIONLabel.Location = new System.Drawing.Point(30, 62);
            tCUENTA_DESCRIPCIONLabel.Name = "tCUENTA_DESCRIPCIONLabel";
            tCUENTA_DESCRIPCIONLabel.Size = new System.Drawing.Size(83, 13);
            tCUENTA_DESCRIPCIONLabel.TabIndex = 2;
            tCUENTA_DESCRIPCIONLabel.Text = "DESCRIPCION:";
            // 
            // tCUENTA_DESCRIPCIONTextBox
            // 
            this.tCUENTA_DESCRIPCIONTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tIPO_CUENTABindingSource, "TCUENTA_DESCRIPCION", true));
            this.tCUENTA_DESCRIPCIONTextBox.Location = new System.Drawing.Point(131, 59);
            this.tCUENTA_DESCRIPCIONTextBox.Name = "tCUENTA_DESCRIPCIONTextBox";
            this.tCUENTA_DESCRIPCIONTextBox.Size = new System.Drawing.Size(360, 20);
            this.tCUENTA_DESCRIPCIONTextBox.TabIndex = 3;
            // 
            // btnAceptar
            // 
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptar.Location = new System.Drawing.Point(379, 128);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(460, 128);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmTipoCuentaDetalle
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(551, 156);
            this.ControlBox = false;
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmTipoCuentaDetalle";
            this.Text = "Tipo de Cuenta";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTipoCuentaDetalle_FormClosing);
            this.Load += new System.EventHandler(this.frmTipoCuentaDetalle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tIPO_CUENTABindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tCUENTA_DESCRIPCIONTextBox;
        private System.Windows.Forms.BindingSource tIPO_CUENTABindingSource;
        private System.Windows.Forms.TextBox tCUENTA_IDTextBox;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}