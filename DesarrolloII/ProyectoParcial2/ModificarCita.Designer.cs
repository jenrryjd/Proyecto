namespace ProyectoParcial2
{
    partial class ModificarCita
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
            this.txtRazonBuscar = new DevExpress.XtraEditors.TextEdit();
            this.cmbRazonSocial = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridCitas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtRazonBuscar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRazonSocial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCitas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRazonBuscar
            // 
            this.txtRazonBuscar.Location = new System.Drawing.Point(105, 75);
            this.txtRazonBuscar.Name = "txtRazonBuscar";
            this.txtRazonBuscar.Size = new System.Drawing.Size(127, 20);
            this.txtRazonBuscar.TabIndex = 19;
            // 
            // cmbRazonSocial
            // 
            this.cmbRazonSocial.Location = new System.Drawing.Point(105, 30);
            this.cmbRazonSocial.Name = "cmbRazonSocial";
            this.cmbRazonSocial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbRazonSocial.Properties.Items.AddRange(new object[] {
            "Numero de Cita",
            "Cedula del Paciente",
            "Fecha"});
            this.cmbRazonSocial.Size = new System.Drawing.Size(127, 20);
            this.cmbRazonSocial.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Buscar Por:";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(457, 309);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 15;
            this.simpleButton2.Text = "Salir";
            // 
            // dataGridCitas
            // 
            this.dataGridCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCitas.Location = new System.Drawing.Point(12, 110);
            this.dataGridCitas.Name = "dataGridCitas";
            this.dataGridCitas.Size = new System.Drawing.Size(528, 193);
            this.dataGridCitas.TabIndex = 14;
            this.dataGridCitas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCitas_CellClick);
            this.dataGridCitas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCitas_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Cedula:";
            // 
            // ModificarCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 345);
            this.Controls.Add(this.txtRazonBuscar);
            this.Controls.Add(this.cmbRazonSocial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.dataGridCitas);
            this.Controls.Add(this.label1);
            this.Name = "ModificarCita";
            this.Text = "ModificarCita";
            ((System.ComponentModel.ISupportInitialize)(this.txtRazonBuscar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRazonSocial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCitas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtRazonBuscar;
        private DevExpress.XtraEditors.ComboBoxEdit cmbRazonSocial;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.DataGridView dataGridCitas;
        private System.Windows.Forms.Label label1;
    }
}