namespace ProyectoParcial2
{
    partial class AlergiasFrm
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
            this.cmbTipo = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnInsertar = new DevExpress.XtraEditors.SimpleButton();
            this.btnSalir = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.dataGridAlergias = new System.Windows.Forms.DataGridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.btnActualizar = new DevExpress.XtraEditors.SimpleButton();
            this.txtTipo = new DevExpress.XtraEditors.TextEdit();
            this.txtDescripcion = new DevExpress.XtraEditors.MemoEdit();
            this.btnCancelarActualizacion = new DevExpress.XtraEditors.SimpleButton();
            this.btnEliminar = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridAlergiasEliminar = new System.Windows.Forms.DataGridView();
            this.btnCancelarEliminar = new DevExpress.XtraEditors.SimpleButton();
            this.txtBuscar = new DevExpress.XtraEditors.TextEdit();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblTipoNuevo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAlergias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAlergiasEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuscar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTipo
            // 
            this.cmbTipo.Location = new System.Drawing.Point(105, 120);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTipo.Properties.Items.AddRange(new object[] {
            "",
            "OTRO"});
            this.cmbTipo.Size = new System.Drawing.Size(152, 20);
            this.cmbTipo.TabIndex = 2;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Descripcion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Tipo:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::ProyectoParcial2.Properties.Resources.cancelar;
            this.btnCancelar.Location = new System.Drawing.Point(225, 450);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(105, 45);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Image = global::ProyectoParcial2.Properties.Resources.if_Compose_1891025;
            this.btnInsertar.Location = new System.Drawing.Point(90, 450);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(105, 45);
            this.btnInsertar.TabIndex = 5;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.Visible = false;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::ProyectoParcial2.Properties.Resources.salir;
            this.btnSalir.Location = new System.Drawing.Point(360, 450);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(105, 45);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Visible = false;
            this.btnSalir.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(30, 75);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(41, 13);
            this.labelControl2.TabIndex = 40;
            this.labelControl2.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(105, 75);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(219, 20);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.Visible = false;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // dataGridAlergias
            // 
            this.dataGridAlergias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAlergias.Enabled = false;
            this.dataGridAlergias.Location = new System.Drawing.Point(15, 255);
            this.dataGridAlergias.Name = "dataGridAlergias";
            this.dataGridAlergias.Size = new System.Drawing.Size(525, 180);
            this.dataGridAlergias.TabIndex = 38;
            this.dataGridAlergias.Visible = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(30, 30);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(73, 13);
            this.labelControl1.TabIndex = 37;
            this.labelControl1.Text = "Codigo Alergia:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(105, 30);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(219, 20);
            this.txtId.TabIndex = 0;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Image = global::ProyectoParcial2.Properties.Resources.if_82Add_create_new_cross_medical_plus_1886149;
            this.btnActualizar.Location = new System.Drawing.Point(119, 399);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(105, 59);
            this.btnActualizar.TabIndex = 6;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.Visible = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(345, 120);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(105, 20);
            this.txtTipo.TabIndex = 3;
            this.txtTipo.Visible = false;
            this.txtTipo.EditValueChanged += new System.EventHandler(this.txtTipo_EditValueChanged);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.EditValue = "";
            this.txtDescripcion.Location = new System.Drawing.Point(105, 165);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(345, 75);
            this.txtDescripcion.TabIndex = 4;
            this.txtDescripcion.UseWaitCursor = true;
            // 
            // btnCancelarActualizacion
            // 
            this.btnCancelarActualizacion.Image = global::ProyectoParcial2.Properties.Resources.cancelar;
            this.btnCancelarActualizacion.Location = new System.Drawing.Point(225, 450);
            this.btnCancelarActualizacion.Name = "btnCancelarActualizacion";
            this.btnCancelarActualizacion.Size = new System.Drawing.Size(105, 45);
            this.btnCancelarActualizacion.TabIndex = 49;
            this.btnCancelarActualizacion.Text = "Cancelar";
            this.btnCancelarActualizacion.Visible = false;
            this.btnCancelarActualizacion.Click += new System.EventHandler(this.btnCancelarActualizacion_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::ProyectoParcial2.Properties.Resources.if_Artboard_1_1790656;
            this.btnEliminar.Location = new System.Drawing.Point(30, 444);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(105, 45);
            this.btnEliminar.TabIndex = 50;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Visible = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dataGridAlergiasEliminar
            // 
            this.dataGridAlergiasEliminar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAlergiasEliminar.Location = new System.Drawing.Point(15, 255);
            this.dataGridAlergiasEliminar.Name = "dataGridAlergiasEliminar";
            this.dataGridAlergiasEliminar.Size = new System.Drawing.Size(525, 180);
            this.dataGridAlergiasEliminar.TabIndex = 51;
            this.dataGridAlergiasEliminar.Visible = false;
            this.dataGridAlergiasEliminar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridAlergiasEliminar_CellClick);
            // 
            // btnCancelarEliminar
            // 
            this.btnCancelarEliminar.Image = global::ProyectoParcial2.Properties.Resources.cancelar;
            this.btnCancelarEliminar.Location = new System.Drawing.Point(225, 450);
            this.btnCancelarEliminar.Name = "btnCancelarEliminar";
            this.btnCancelarEliminar.Size = new System.Drawing.Size(105, 45);
            this.btnCancelarEliminar.TabIndex = 52;
            this.btnCancelarEliminar.Text = "Cancelar";
            this.btnCancelarEliminar.Visible = false;
            this.btnCancelarEliminar.Click += new System.EventHandler(this.btnCancelarEliminar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(105, 75);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(219, 20);
            this.txtBuscar.TabIndex = 54;
            this.txtBuscar.Visible = false;
            this.txtBuscar.EditValueChanged += new System.EventHandler(this.txtBuscar_EditValueChanged);
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblTipoNuevo
            // 
            this.lblTipoNuevo.AutoSize = true;
            this.lblTipoNuevo.Location = new System.Drawing.Point(270, 120);
            this.lblTipoNuevo.Name = "lblTipoNuevo";
            this.lblTipoNuevo.Size = new System.Drawing.Size(69, 13);
            this.lblTipoNuevo.TabIndex = 55;
            this.lblTipoNuevo.Text = "Ingresa Tipo:";
            this.lblTipoNuevo.Visible = false;
            // 
            // AlergiasFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 501);
            this.Controls.Add(this.lblTipoNuevo);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnCancelarEliminar);
            this.Controls.Add(this.dataGridAlergiasEliminar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCancelarActualizacion);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.dataGridAlergias);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtDescripcion);
            this.Name = "AlergiasFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AlergiasFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAlergias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAlergiasEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuscar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        public DevExpress.XtraEditors.SimpleButton btnInsertar;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraEditors.SimpleButton btnActualizar;
        public DevExpress.XtraEditors.SimpleButton btnCancelarActualizacion;
        public DevExpress.XtraEditors.SimpleButton btnCancelar;
        public DevExpress.XtraEditors.SimpleButton btnSalir;
        public DevExpress.XtraEditors.ComboBoxEdit cmbTipo;
        public DevExpress.XtraEditors.TextEdit txtNombre;
        public System.Windows.Forms.DataGridView dataGridAlergias;
        public DevExpress.XtraEditors.TextEdit txtId;
        public DevExpress.XtraEditors.TextEdit txtTipo;
        public DevExpress.XtraEditors.MemoEdit txtDescripcion;
        public DevExpress.XtraEditors.SimpleButton btnEliminar;
        public System.Windows.Forms.DataGridView dataGridAlergiasEliminar;
        public DevExpress.XtraEditors.SimpleButton btnCancelarEliminar;
        public DevExpress.XtraEditors.TextEdit txtBuscar;
        public System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblTipoNuevo;
        public DevExpress.XtraEditors.LabelControl labelControl2;
    }
}