namespace ProyectoParcial2
{
    partial class EnfermedadesFrm
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
            this.txtBuscar = new DevExpress.XtraEditors.TextEdit();
            this.btnCancelarEliminar = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridEnfermedadesEliminar = new System.Windows.Forms.DataGridView();
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
            this.dataGridEnfermedades = new System.Windows.Forms.DataGridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.txtDescripcion = new DevExpress.XtraEditors.MemoEdit();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblTipoNuevo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuscar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEnfermedadesEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEnfermedades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(135, 75);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(219, 20);
            this.txtBuscar.TabIndex = 73;
            this.txtBuscar.Visible = false;
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // btnCancelarEliminar
            // 
            this.btnCancelarEliminar.Image = global::ProyectoParcial2.Properties.Resources.cancelar;
            this.btnCancelarEliminar.Location = new System.Drawing.Point(225, 450);
            this.btnCancelarEliminar.Name = "btnCancelarEliminar";
            this.btnCancelarEliminar.Size = new System.Drawing.Size(105, 45);
            this.btnCancelarEliminar.TabIndex = 72;
            this.btnCancelarEliminar.Text = "Cancelar";
            this.btnCancelarEliminar.Visible = false;
            this.btnCancelarEliminar.Click += new System.EventHandler(this.btnCancelarEliminar_Click);
            // 
            // dataGridEnfermedadesEliminar
            // 
            this.dataGridEnfermedadesEliminar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEnfermedadesEliminar.Location = new System.Drawing.Point(15, 255);
            this.dataGridEnfermedadesEliminar.Name = "dataGridEnfermedadesEliminar";
            this.dataGridEnfermedadesEliminar.Size = new System.Drawing.Size(525, 180);
            this.dataGridEnfermedadesEliminar.TabIndex = 71;
            this.dataGridEnfermedadesEliminar.Visible = false;
            this.dataGridEnfermedadesEliminar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridEnfermedadesEliminar_CellClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::ProyectoParcial2.Properties.Resources.if_Artboard_1_1790656;
            this.btnEliminar.Location = new System.Drawing.Point(90, 450);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(105, 45);
            this.btnEliminar.TabIndex = 70;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Visible = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelarActualizacion
            // 
            this.btnCancelarActualizacion.Image = global::ProyectoParcial2.Properties.Resources.cancelar;
            this.btnCancelarActualizacion.Location = new System.Drawing.Point(225, 450);
            this.btnCancelarActualizacion.Name = "btnCancelarActualizacion";
            this.btnCancelarActualizacion.Size = new System.Drawing.Size(105, 45);
            this.btnCancelarActualizacion.TabIndex = 69;
            this.btnCancelarActualizacion.Text = "Cancelar";
            this.btnCancelarActualizacion.Visible = false;
            this.btnCancelarActualizacion.Click += new System.EventHandler(this.btnCancelarActualizacion_Click);
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(375, 120);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(105, 20);
            this.txtTipo.TabIndex = 58;
            this.txtTipo.Visible = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Image = global::ProyectoParcial2.Properties.Resources.if_82Add_create_new_cross_medical_plus_1886149;
            this.btnActualizar.Location = new System.Drawing.Point(90, 450);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(105, 45);
            this.btnActualizar.TabIndex = 61;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.Visible = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // cmbTipo
            // 
            this.cmbTipo.Location = new System.Drawing.Point(135, 120);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTipo.Properties.Items.AddRange(new object[] {
            "",
            "OTRO"});
            this.cmbTipo.Size = new System.Drawing.Size(152, 20);
            this.cmbTipo.TabIndex = 57;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 68;
            this.label1.Text = "Descripcion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 67;
            this.label4.Text = "Tipo:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::ProyectoParcial2.Properties.Resources.cancelar;
            this.btnCancelar.Location = new System.Drawing.Point(225, 450);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(105, 45);
            this.btnCancelar.TabIndex = 62;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Image = global::ProyectoParcial2.Properties.Resources.if_Compose_1891025;
            this.btnInsertar.Location = new System.Drawing.Point(90, 450);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(105, 45);
            this.btnInsertar.TabIndex = 60;
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
            this.btnSalir.TabIndex = 63;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Visible = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(30, 75);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(41, 13);
            this.labelControl2.TabIndex = 66;
            this.labelControl2.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(135, 75);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(219, 20);
            this.txtNombre.TabIndex = 56;
            this.txtNombre.Visible = false;
            // 
            // dataGridEnfermedades
            // 
            this.dataGridEnfermedades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEnfermedades.Location = new System.Drawing.Point(15, 255);
            this.dataGridEnfermedades.Name = "dataGridEnfermedades";
            this.dataGridEnfermedades.Size = new System.Drawing.Size(525, 180);
            this.dataGridEnfermedades.TabIndex = 65;
            this.dataGridEnfermedades.Visible = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(30, 30);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(101, 13);
            this.labelControl1.TabIndex = 64;
            this.labelControl1.Text = "Codigo Enfermedad: ";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(135, 30);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(219, 20);
            this.txtId.TabIndex = 55;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.EditValue = "";
            this.txtDescripcion.Location = new System.Drawing.Point(105, 165);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(375, 75);
            this.txtDescripcion.TabIndex = 59;
            this.txtDescripcion.UseWaitCursor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblTipoNuevo
            // 
            this.lblTipoNuevo.AutoSize = true;
            this.lblTipoNuevo.Location = new System.Drawing.Point(300, 120);
            this.lblTipoNuevo.Name = "lblTipoNuevo";
            this.lblTipoNuevo.Size = new System.Drawing.Size(69, 13);
            this.lblTipoNuevo.TabIndex = 74;
            this.lblTipoNuevo.Text = "Ingresa Tipo:";
            this.lblTipoNuevo.Visible = false;
            // 
            // EnfermedadesFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 506);
            this.Controls.Add(this.lblTipoNuevo);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnCancelarEliminar);
            this.Controls.Add(this.dataGridEnfermedadesEliminar);
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
            this.Controls.Add(this.dataGridEnfermedades);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtDescripcion);
            this.Name = "EnfermedadesFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EnfermedadesFrm";
            this.Load += new System.EventHandler(this.EnfermedadesFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtBuscar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEnfermedadesEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEnfermedades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraEditors.TextEdit txtBuscar;
        public DevExpress.XtraEditors.SimpleButton btnCancelarEliminar;
        public System.Windows.Forms.DataGridView dataGridEnfermedadesEliminar;
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
        public DevExpress.XtraEditors.TextEdit txtNombre;
        public System.Windows.Forms.DataGridView dataGridEnfermedades;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraEditors.TextEdit txtId;
        public DevExpress.XtraEditors.MemoEdit txtDescripcion;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblTipoNuevo;
        public DevExpress.XtraEditors.LabelControl labelControl2;
    }
}