namespace ProyectoParcial2
{
    partial class ModificarPacientes
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
            this.txtBuscar = new DevExpress.XtraEditors.TextEdit();
            this.btnEliminar = new DevExpress.XtraEditors.SimpleButton();
            this.comboBuscar = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalir = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridPacientes = new System.Windows.Forms.DataGridView();
            this.lblEtiqueta = new System.Windows.Forms.Label();
            this.dataGridEliminarPaciente = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuscar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBuscar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPacientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEliminarPaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(130, 76);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(162, 20);
            this.txtBuscar.TabIndex = 19;
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(90, 347);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // comboBuscar
            // 
            this.comboBuscar.Location = new System.Drawing.Point(130, 32);
            this.comboBuscar.Name = "comboBuscar";
            this.comboBuscar.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBuscar.Properties.Items.AddRange(new object[] {
            "Cedula",
            "Nombre",
            "Apellido"});
            this.comboBuscar.Size = new System.Drawing.Size(162, 20);
            this.comboBuscar.TabIndex = 17;
            this.comboBuscar.SelectedIndexChanged += new System.EventHandler(this.comboBuscar_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Buscar Por:";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(460, 347);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // dataGridPacientes
            // 
            this.dataGridPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPacientes.Location = new System.Drawing.Point(26, 129);
            this.dataGridPacientes.Name = "dataGridPacientes";
            this.dataGridPacientes.Size = new System.Drawing.Size(520, 193);
            this.dataGridPacientes.TabIndex = 14;
            this.dataGridPacientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPacientes_CellClick);
            // 
            // lblEtiqueta
            // 
            this.lblEtiqueta.AutoSize = true;
            this.lblEtiqueta.Location = new System.Drawing.Point(57, 79);
            this.lblEtiqueta.Name = "lblEtiqueta";
            this.lblEtiqueta.Size = new System.Drawing.Size(33, 13);
            this.lblEtiqueta.TabIndex = 13;
            this.lblEtiqueta.Text = "Dato:";
            // 
            // dataGridEliminarPaciente
            // 
            this.dataGridEliminarPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEliminarPaciente.Location = new System.Drawing.Point(26, 129);
            this.dataGridEliminarPaciente.Name = "dataGridEliminarPaciente";
            this.dataGridEliminarPaciente.Size = new System.Drawing.Size(520, 193);
            this.dataGridEliminarPaciente.TabIndex = 20;
            this.dataGridEliminarPaciente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridEliminarPaciente_CellClick);
            // 
            // ModificarPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 381);
            this.Controls.Add(this.dataGridEliminarPaciente);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.comboBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dataGridPacientes);
            this.Controls.Add(this.lblEtiqueta);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModificarPacientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ModificarPacientes";
            this.Load += new System.EventHandler(this.ModificarPacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtBuscar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBuscar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPacientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEliminarPaciente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtBuscar;
        private DevExpress.XtraEditors.ComboBoxEdit comboBuscar;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btnSalir;
        private System.Windows.Forms.Label lblEtiqueta;
        public DevExpress.XtraEditors.SimpleButton btnEliminar;
        public System.Windows.Forms.DataGridView dataGridPacientes;
        public System.Windows.Forms.DataGridView dataGridEliminarPaciente;
    }
}