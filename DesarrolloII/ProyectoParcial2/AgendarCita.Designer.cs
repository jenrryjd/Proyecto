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
            this.btnAgendar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtCedPac = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtNomPac = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.dateTimeHoraCita = new System.Windows.Forms.DateTimePicker();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cmbNomDoc = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnBuscarPac = new DevExpress.XtraEditors.SimpleButton();
            this.btnModificar = new DevExpress.XtraEditors.SimpleButton();
            this.btnSalir = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtNCita.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEspecialidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCedPac.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomPac.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbNomDoc.Properties)).BeginInit();
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
            this.txtNCita.Location = new System.Drawing.Point(135, 45);
            this.txtNCita.Name = "txtNCita";
            this.txtNCita.Size = new System.Drawing.Size(100, 20);
            this.txtNCita.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(30, 180);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(62, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Especialidad:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(30, 270);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(33, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Fecha:";
            // 
            // dateTimeFechaCita
            // 
            this.dateTimeFechaCita.Location = new System.Drawing.Point(135, 270);
            this.dateTimeFechaCita.Name = "dateTimeFechaCita";
            this.dateTimeFechaCita.Size = new System.Drawing.Size(202, 20);
            this.dateTimeFechaCita.TabIndex = 6;
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.Location = new System.Drawing.Point(135, 180);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbEspecialidad.Size = new System.Drawing.Size(202, 20);
            this.cmbEspecialidad.TabIndex = 7;
            // 
            // btnAgendar
            // 
            this.btnAgendar.Location = new System.Drawing.Point(45, 360);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(75, 23);
            this.btnAgendar.TabIndex = 9;
            this.btnAgendar.Text = "Agendar";
            this.btnAgendar.Visible = false;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(30, 315);
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
            // txtCedPac
            // 
            this.txtCedPac.Location = new System.Drawing.Point(135, 90);
            this.txtCedPac.Name = "txtCedPac";
            this.txtCedPac.Size = new System.Drawing.Size(202, 20);
            this.txtCedPac.TabIndex = 19;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(30, 135);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(102, 13);
            this.labelControl8.TabIndex = 20;
            this.labelControl8.Text = "Nombre del Paciente:";
            // 
            // txtNomPac
            // 
            this.txtNomPac.Location = new System.Drawing.Point(135, 135);
            this.txtNomPac.Name = "txtNomPac";
            this.txtNomPac.Size = new System.Drawing.Size(202, 20);
            this.txtNomPac.TabIndex = 21;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(30, 225);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(93, 13);
            this.labelControl9.TabIndex = 22;
            this.labelControl9.Text = "Nombre del Doctor:";
            this.labelControl9.Click += new System.EventHandler(this.labelControl9_Click);
            // 
            // dateTimeHoraCita
            // 
            this.dateTimeHoraCita.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimeHoraCita.Location = new System.Drawing.Point(135, 315);
            this.dateTimeHoraCita.Name = "dateTimeHoraCita";
            this.dateTimeHoraCita.Size = new System.Drawing.Size(100, 20);
            this.dateTimeHoraCita.TabIndex = 24;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(33, 198);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(0, 13);
            this.labelControl5.TabIndex = 25;
            // 
            // cmbNomDoc
            // 
            this.cmbNomDoc.Location = new System.Drawing.Point(135, 225);
            this.cmbNomDoc.Name = "cmbNomDoc";
            this.cmbNomDoc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbNomDoc.Size = new System.Drawing.Size(202, 20);
            this.cmbNomDoc.TabIndex = 27;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(180, 360);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 28;
            this.btnCancelar.Text = "Cancelar";
            // 
            // btnBuscarPac
            // 
            this.btnBuscarPac.Location = new System.Drawing.Point(345, 90);
            this.btnBuscarPac.Name = "btnBuscarPac";
            this.btnBuscarPac.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarPac.TabIndex = 29;
            this.btnBuscarPac.Text = "Buscar";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(45, 360);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 30;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Visible = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(315, 360);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 31;
            this.btnSalir.Text = "Salir";
            // 
            // AgendarCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 409);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnBuscarPac);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.cmbNomDoc);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.dateTimeHoraCita);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.txtNomPac);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.txtCedPac);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.btnAgendar);
            this.Controls.Add(this.cmbEspecialidad);
            this.Controls.Add(this.dateTimeFechaCita);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtNCita);
            this.Controls.Add(this.labelControl1);
            this.Name = "AgendarCita";
            this.Text = "AgendarCita";
            this.Load += new System.EventHandler(this.AgendarCita_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNCita.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEspecialidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCedPac.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomPac.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbNomDoc.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtNCita;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.DateTimePicker dateTimeFechaCita;
        private DevExpress.XtraEditors.ComboBoxEdit cmbEspecialidad;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtCedPac;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtNomPac;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private System.Windows.Forms.DateTimePicker dateTimeHoraCita;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.ComboBoxEdit cmbNomDoc;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnBuscarPac;
        public DevExpress.XtraEditors.SimpleButton btnModificar;
        public DevExpress.XtraEditors.SimpleButton btnAgendar;
        private DevExpress.XtraEditors.SimpleButton btnSalir;
    }
}