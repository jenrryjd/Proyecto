namespace ProyectoParcial2
{
    partial class MedicamentoFrm
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
            this.lblTipoNuevo = new System.Windows.Forms.Label();
            this.txtBuscar = new DevExpress.XtraEditors.TextEdit();
            this.btnCancelarEliminar = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridMedicamentoEliminar = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelarActualizacion = new DevExpress.XtraEditors.SimpleButton();
            this.txtTipo = new DevExpress.XtraEditors.TextEdit();
            this.btnActualizar = new DevExpress.XtraEditors.SimpleButton();
            this.cmbTipo = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnInsertar = new DevExpress.XtraEditors.SimpleButton();
            this.btnSalir = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.dataGridMedicamento = new System.Windows.Forms.DataGridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.txtDescripcion = new DevExpress.XtraEditors.MemoEdit();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtBuscar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMedicamentoEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMedicamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTipoNuevo
            // 
            this.lblTipoNuevo.AutoSize = true;
            this.lblTipoNuevo.Location = new System.Drawing.Point(300, 105);
            this.lblTipoNuevo.Name = "lblTipoNuevo";
            this.lblTipoNuevo.Size = new System.Drawing.Size(69, 13);
            this.lblTipoNuevo.TabIndex = 75;
            this.lblTipoNuevo.Text = "Ingresa Tipo:";
            this.lblTipoNuevo.Visible = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(135, 60);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(219, 20);
            this.txtBuscar.TabIndex = 74;
            this.txtBuscar.Visible = false;
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // btnCancelarEliminar
            // 
            this.btnCancelarEliminar.Image = global::ProyectoParcial2.Properties.Resources.cancelar;
            this.btnCancelarEliminar.Location = new System.Drawing.Point(225, 390);
            this.btnCancelarEliminar.Name = "btnCancelarEliminar";
            this.btnCancelarEliminar.Size = new System.Drawing.Size(105, 45);
            this.btnCancelarEliminar.TabIndex = 73;
            this.btnCancelarEliminar.Text = "Cancelar";
            this.btnCancelarEliminar.Visible = false;
            this.btnCancelarEliminar.Click += new System.EventHandler(this.btnCancelarEliminar_Click);
            // 
            // dataGridMedicamentoEliminar
            // 
            this.dataGridMedicamentoEliminar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMedicamentoEliminar.Location = new System.Drawing.Point(15, 225);
            this.dataGridMedicamentoEliminar.Name = "dataGridMedicamentoEliminar";
            this.dataGridMedicamentoEliminar.Size = new System.Drawing.Size(525, 180);
            this.dataGridMedicamentoEliminar.TabIndex = 72;
            this.dataGridMedicamentoEliminar.Visible = false;
            this.dataGridMedicamentoEliminar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMedicamentoEliminar_CellClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::ProyectoParcial2.Properties.Resources.if_Artboard_1_1790656;
            this.btnEliminar.Location = new System.Drawing.Point(0, 435);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(105, 45);
            this.btnEliminar.TabIndex = 71;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Visible = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelarActualizacion
            // 
            this.btnCancelarActualizacion.Image = global::ProyectoParcial2.Properties.Resources.cancelar;
            this.btnCancelarActualizacion.Location = new System.Drawing.Point(330, 405);
            this.btnCancelarActualizacion.Name = "btnCancelarActualizacion";
            this.btnCancelarActualizacion.Size = new System.Drawing.Size(105, 45);
            this.btnCancelarActualizacion.TabIndex = 70;
            this.btnCancelarActualizacion.Text = "Cancelar";
            this.btnCancelarActualizacion.Visible = false;
            this.btnCancelarActualizacion.Click += new System.EventHandler(this.btnCancelarActualizacion_Click);
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(375, 105);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(105, 20);
            this.txtTipo.TabIndex = 59;
            this.txtTipo.Visible = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Image = global::ProyectoParcial2.Properties.Resources.if_82Add_create_new_cross_medical_plus_1886149;
            this.btnActualizar.Location = new System.Drawing.Point(90, 390);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(105, 45);
            this.btnActualizar.TabIndex = 62;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.Visible = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // cmbTipo
            // 
            this.cmbTipo.Location = new System.Drawing.Point(135, 105);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTipo.Properties.Items.AddRange(new object[] {
            "",
            "OTRO"});
            this.cmbTipo.Size = new System.Drawing.Size(152, 20);
            this.cmbTipo.TabIndex = 58;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 69;
            this.label1.Text = "Descripcion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 68;
            this.label4.Text = "Tipo:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::ProyectoParcial2.Properties.Resources.cancelar;
            this.btnCancelar.Location = new System.Drawing.Point(225, 435);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(105, 45);
            this.btnCancelar.TabIndex = 63;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Image = global::ProyectoParcial2.Properties.Resources.if_Compose_1891025;
            this.btnInsertar.Location = new System.Drawing.Point(90, 435);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(105, 45);
            this.btnInsertar.TabIndex = 61;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.Visible = false;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::ProyectoParcial2.Properties.Resources.salir;
            this.btnSalir.Location = new System.Drawing.Point(360, 435);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(105, 45);
            this.btnSalir.TabIndex = 64;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Visible = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(30, 60);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(41, 13);
            this.labelControl2.TabIndex = 67;
            this.labelControl2.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(135, 60);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(219, 20);
            this.txtNombre.TabIndex = 57;
            this.txtNombre.Visible = false;
            // 
            // dataGridMedicamento
            // 
            this.dataGridMedicamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMedicamento.Enabled = false;
            this.dataGridMedicamento.Location = new System.Drawing.Point(15, 240);
            this.dataGridMedicamento.Name = "dataGridMedicamento";
            this.dataGridMedicamento.Size = new System.Drawing.Size(525, 180);
            this.dataGridMedicamento.TabIndex = 66;
            this.dataGridMedicamento.Visible = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(30, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(103, 13);
            this.labelControl1.TabIndex = 65;
            this.labelControl1.Text = "Codigo Medicamento:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(135, 15);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(219, 20);
            this.txtId.TabIndex = 56;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.EditValue = "";
            this.txtDescripcion.Location = new System.Drawing.Point(105, 150);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(375, 75);
            this.txtDescripcion.TabIndex = 60;
            this.txtDescripcion.UseWaitCursor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // MedicamentoFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 508);
            this.Controls.Add(this.lblTipoNuevo);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnCancelarEliminar);
            this.Controls.Add(this.dataGridMedicamentoEliminar);
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
            this.Controls.Add(this.dataGridMedicamento);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtDescripcion);
            this.Name = "MedicamentoFrm";
            this.Text = "MedicamentoFrm";
            this.Load += new System.EventHandler(this.MedicamentoFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtBuscar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMedicamentoEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMedicamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipoNuevo;
        public DevExpress.XtraEditors.TextEdit txtBuscar;
        public DevExpress.XtraEditors.SimpleButton btnCancelarEliminar;
        public System.Windows.Forms.DataGridView dataGridMedicamentoEliminar;
        public DevExpress.XtraEditors.SimpleButton btnEliminar;
        public DevExpress.XtraEditors.SimpleButton btnCancelarActualizacion;
        public DevExpress.XtraEditors.TextEdit txtTipo;
        public DevExpress.XtraEditors.SimpleButton btnActualizar;
        public DevExpress.XtraEditors.ComboBoxEdit cmbTipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        public DevExpress.XtraEditors.SimpleButton btnCancelar;
        public DevExpress.XtraEditors.SimpleButton btnInsertar;
        public DevExpress.XtraEditors.SimpleButton btnSalir;
        public DevExpress.XtraEditors.LabelControl labelControl2;
        public DevExpress.XtraEditors.TextEdit txtNombre;
        public System.Windows.Forms.DataGridView dataGridMedicamento;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraEditors.TextEdit txtId;
        public DevExpress.XtraEditors.MemoEdit txtDescripcion;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}