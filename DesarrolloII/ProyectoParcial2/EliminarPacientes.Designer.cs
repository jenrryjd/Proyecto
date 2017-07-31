namespace ProyectoParcial2
{
    partial class EliminarPacientes
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
            this.textBuscar = new DevExpress.XtraEditors.TextEdit();
            this.btnEliminarMed = new DevExpress.XtraEditors.SimpleButton();
            this.cmbEliminarPac = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridPacientes = new System.Windows.Forms.DataGridView();
            this.lblTituloBusqueda = new System.Windows.Forms.Label();
            this.labelEliminarPaci = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.textBuscar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEliminarPac.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // textBuscar
            // 
            this.textBuscar.Location = new System.Drawing.Point(157, 98);
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.Size = new System.Drawing.Size(162, 20);
            this.textBuscar.TabIndex = 26;
            this.textBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBuscar_KeyPress);
            // 
            // btnEliminarMed
            // 
            this.btnEliminarMed.Location = new System.Drawing.Point(123, 368);
            this.btnEliminarMed.Name = "btnEliminarMed";
            this.btnEliminarMed.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarMed.TabIndex = 25;
            this.btnEliminarMed.Text = "Eliminar";
            this.btnEliminarMed.Click += new System.EventHandler(this.btnEliminarMed_Click);
            // 
            // cmbEliminarPac
            // 
            this.cmbEliminarPac.Location = new System.Drawing.Point(157, 54);
            this.cmbEliminarPac.Name = "cmbEliminarPac";
            this.cmbEliminarPac.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbEliminarPac.Properties.Items.AddRange(new object[] {
            "Cedula",
            "Nombre\t",
            "Apellido"});
            this.cmbEliminarPac.Size = new System.Drawing.Size(162, 20);
            this.cmbEliminarPac.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Buscar Por:";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(487, 369);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 22;
            this.simpleButton2.Text = "Salir";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // dataGridPacientes
            // 
            this.dataGridPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPacientes.Location = new System.Drawing.Point(53, 151);
            this.dataGridPacientes.Name = "dataGridPacientes";
            this.dataGridPacientes.Size = new System.Drawing.Size(520, 193);
            this.dataGridPacientes.TabIndex = 21;
            this.dataGridPacientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPacientes_CellClick);
            this.dataGridPacientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPacientes_CellContentClick);
            // 
            // lblTituloBusqueda
            // 
            this.lblTituloBusqueda.AutoSize = true;
            this.lblTituloBusqueda.Location = new System.Drawing.Point(84, 101);
            this.lblTituloBusqueda.Name = "lblTituloBusqueda";
            this.lblTituloBusqueda.Size = new System.Drawing.Size(43, 13);
            this.lblTituloBusqueda.TabIndex = 20;
            this.lblTituloBusqueda.Text = "Cedula:";
            // 
            // labelEliminarPaci
            // 
            this.labelEliminarPaci.AutoSize = true;
            this.labelEliminarPaci.Location = new System.Drawing.Point(437, 101);
            this.labelEliminarPaci.Name = "labelEliminarPaci";
            this.labelEliminarPaci.Size = new System.Drawing.Size(35, 13);
            this.labelEliminarPaci.TabIndex = 27;
            this.labelEliminarPaci.Text = "label1";
            // 
            // EliminarPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 446);
            this.Controls.Add(this.labelEliminarPaci);
            this.Controls.Add(this.textBuscar);
            this.Controls.Add(this.btnEliminarMed);
            this.Controls.Add(this.cmbEliminarPac);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.dataGridPacientes);
            this.Controls.Add(this.lblTituloBusqueda);
            this.Name = "EliminarPacientes";
            this.Text = "EliminarPacientes";
            this.Load += new System.EventHandler(this.EliminarPacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textBuscar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEliminarPac.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit textBuscar;
        public DevExpress.XtraEditors.SimpleButton btnEliminarMed;
        private DevExpress.XtraEditors.ComboBoxEdit cmbEliminarPac;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.DataGridView dataGridPacientes;
        private System.Windows.Forms.Label lblTituloBusqueda;
        private System.Windows.Forms.Label labelEliminarPaci;
    }
}