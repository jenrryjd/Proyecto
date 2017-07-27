namespace ProyectoParcial2
{
    partial class AgendarCita
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtNCita = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dateTimeFechaCita = new System.Windows.Forms.DateTimePicker();
            this.cmbEspecialidad = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtCedula = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btnBuscarPac = new DevExpress.XtraEditors.SimpleButton();
            this.txtNomDoc = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtCedDoc = new DevExpress.XtraEditors.TextEdit();
            this.btnCancelarEliminar = new DevExpress.XtraEditors.SimpleButton();
            this.btnEliminar = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelarActualizacion = new DevExpress.XtraEditors.SimpleButton();
            this.btnActualizar = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnInsertar = new DevExpress.XtraEditors.SimpleButton();
            this.btnSalir = new DevExpress.XtraEditors.SimpleButton();
            this.comboBoxHorario = new System.Windows.Forms.ComboBox();
            this.txtBuscar = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNCita.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEspecialidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCedula.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomDoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCedDoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuscar.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(30, 45);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(63, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Numero Cita:";
            // 
            // txtNCita
            // 
            this.txtNCita.Enabled = false;
            this.txtNCita.Location = new System.Drawing.Point(135, 45);
            this.txtNCita.Name = "txtNCita";
            this.txtNCita.Size = new System.Drawing.Size(100, 20);
            this.txtNCita.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(30, 225);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(62, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Especialidad:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(30, 180);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(33, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Fecha:";
            // 
            // dateTimeFechaCita
            // 
            this.dateTimeFechaCita.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFechaCita.Location = new System.Drawing.Point(135, 180);
            this.dateTimeFechaCita.Name = "dateTimeFechaCita";
            this.dateTimeFechaCita.Size = new System.Drawing.Size(202, 20);
            this.dateTimeFechaCita.TabIndex = 6;
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.Location = new System.Drawing.Point(135, 225);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbEspecialidad.Size = new System.Drawing.Size(202, 20);
            this.cmbEspecialidad.TabIndex = 7;
            this.cmbEspecialidad.SelectedIndexChanged += new System.EventHandler(this.cmbEspecialidad_SelectedIndexChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(30, 360);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(30, 13);
            this.labelControl4.TabIndex = 12;
            this.labelControl4.Text = "Hora: ";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(30, 90);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(98, 13);
            this.labelControl7.TabIndex = 18;
            this.labelControl7.Text = "Cedula del Paciente:";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(135, 90);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(202, 20);
            this.txtCedula.TabIndex = 19;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(30, 135);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(102, 13);
            this.labelControl8.TabIndex = 20;
            this.labelControl8.Text = "Nombre del Paciente:";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(135, 135);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(202, 20);
            this.txtNombre.TabIndex = 21;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(30, 315);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(93, 13);
            this.labelControl9.TabIndex = 22;
            this.labelControl9.Text = "Nombre del Doctor:";
            this.labelControl9.Click += new System.EventHandler(this.labelControl9_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(33, 198);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(0, 13);
            this.labelControl5.TabIndex = 25;
            // 
            // btnBuscarPac
            // 
            this.btnBuscarPac.Location = new System.Drawing.Point(345, 90);
            this.btnBuscarPac.Name = "btnBuscarPac";
            this.btnBuscarPac.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarPac.TabIndex = 29;
            this.btnBuscarPac.Text = "Buscar";
            this.btnBuscarPac.Click += new System.EventHandler(this.btnBuscarPac_Click);
            // 
            // txtNomDoc
            // 
            this.txtNomDoc.Enabled = false;
            this.txtNomDoc.Location = new System.Drawing.Point(135, 315);
            this.txtNomDoc.Name = "txtNomDoc";
            this.txtNomDoc.Size = new System.Drawing.Size(202, 20);
            this.txtNomDoc.TabIndex = 32;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(30, 270);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(87, 13);
            this.labelControl6.TabIndex = 33;
            this.labelControl6.Text = "Cedula de Doctor:";
            // 
            // txtCedDoc
            // 
            this.txtCedDoc.Enabled = false;
            this.txtCedDoc.Location = new System.Drawing.Point(135, 270);
            this.txtCedDoc.Name = "txtCedDoc";
            this.txtCedDoc.Size = new System.Drawing.Size(202, 20);
            this.txtCedDoc.TabIndex = 34;
            // 
            // btnCancelarEliminar
            // 
            this.btnCancelarEliminar.Image = global::ProyectoParcial2.Properties.Resources.cancelar;
            this.btnCancelarEliminar.Location = new System.Drawing.Point(165, 375);
            this.btnCancelarEliminar.Name = "btnCancelarEliminar";
            this.btnCancelarEliminar.Size = new System.Drawing.Size(105, 45);
            this.btnCancelarEliminar.TabIndex = 59;
            this.btnCancelarEliminar.Text = "Cancelar";
            this.btnCancelarEliminar.Visible = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::ProyectoParcial2.Properties.Resources.if_Artboard_1_1790656;
            this.btnEliminar.Location = new System.Drawing.Point(30, 375);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(105, 45);
            this.btnEliminar.TabIndex = 58;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Visible = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelarActualizacion
            // 
            this.btnCancelarActualizacion.Image = global::ProyectoParcial2.Properties.Resources.cancelar;
            this.btnCancelarActualizacion.Location = new System.Drawing.Point(150, 435);
            this.btnCancelarActualizacion.Name = "btnCancelarActualizacion";
            this.btnCancelarActualizacion.Size = new System.Drawing.Size(105, 45);
            this.btnCancelarActualizacion.TabIndex = 57;
            this.btnCancelarActualizacion.Text = "Cancelar";
            this.btnCancelarActualizacion.Visible = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Image = global::ProyectoParcial2.Properties.Resources.if_82Add_create_new_cross_medical_plus_1886149;
            this.btnActualizar.Location = new System.Drawing.Point(30, 435);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(105, 45);
            this.btnActualizar.TabIndex = 54;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::ProyectoParcial2.Properties.Resources.cancelar;
            this.btnCancelar.Location = new System.Drawing.Point(165, 405);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(105, 45);
            this.btnCancelar.TabIndex = 55;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Visible = false;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Image = global::ProyectoParcial2.Properties.Resources.if_Compose_1891025;
            this.btnInsertar.Location = new System.Drawing.Point(30, 405);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(105, 45);
            this.btnInsertar.TabIndex = 53;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.Visible = false;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::ProyectoParcial2.Properties.Resources.salir;
            this.btnSalir.Location = new System.Drawing.Point(300, 405);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(105, 45);
            this.btnSalir.TabIndex = 56;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Visible = false;
            // 
            // comboBoxHorario
            // 
            this.comboBoxHorario.FormattingEnabled = true;
            this.comboBoxHorario.Items.AddRange(new object[] {
            "08:30:00",
            "09:30:00",
            "10:30:00",
            "11:30:00",
            "12:30:00",
            "14:30:00",
            "15:30:00",
            "16:30:00",
            "17:30:00"});
            this.comboBoxHorario.Location = new System.Drawing.Point(135, 360);
            this.comboBoxHorario.Name = "comboBoxHorario";
            this.comboBoxHorario.Size = new System.Drawing.Size(121, 21);
            this.comboBoxHorario.TabIndex = 60;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(135, 75);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(202, 20);
            this.txtBuscar.TabIndex = 61;
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // AgendarCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 470);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.comboBoxHorario);
            this.Controls.Add(this.btnCancelarEliminar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCancelarActualizacion);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtCedDoc);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtNomDoc);
            this.Controls.Add(this.btnBuscarPac);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.cmbEspecialidad);
            this.Controls.Add(this.dateTimeFechaCita);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtNCita);
            this.Controls.Add(this.labelControl1);
            this.Name = "AgendarCita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgendarCita";
            this.Load += new System.EventHandler(this.AgendarCita_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNCita.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEspecialidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCedula.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomDoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCedDoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuscar.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btnBuscarPac;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        public DevExpress.XtraEditors.SimpleButton btnCancelarEliminar;
        public DevExpress.XtraEditors.SimpleButton btnEliminar;
        public DevExpress.XtraEditors.SimpleButton btnCancelarActualizacion;
        public DevExpress.XtraEditors.SimpleButton btnActualizar;
        public DevExpress.XtraEditors.SimpleButton btnCancelar;
        public DevExpress.XtraEditors.SimpleButton btnInsertar;
        public DevExpress.XtraEditors.SimpleButton btnSalir;
        public DevExpress.XtraEditors.TextEdit txtNCita;
        public System.Windows.Forms.DateTimePicker dateTimeFechaCita;
        public DevExpress.XtraEditors.ComboBoxEdit cmbEspecialidad;
        public DevExpress.XtraEditors.TextEdit txtCedula;
        public DevExpress.XtraEditors.TextEdit txtNombre;
        public DevExpress.XtraEditors.TextEdit txtNomDoc;
        public DevExpress.XtraEditors.TextEdit txtCedDoc;
        public System.Windows.Forms.ComboBox comboBoxHorario;
        public DevExpress.XtraEditors.TextEdit txtBuscar;
    }
}