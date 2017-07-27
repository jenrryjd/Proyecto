namespace ProyectoParcial2
{
    partial class EliminarMedico
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
            this.btnEliminarModMed = new DevExpress.XtraEditors.SimpleButton();
            this.comboBuscar = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridPacientes = new System.Windows.Forms.DataGridView();
            this.lblTituloBusqueda = new System.Windows.Forms.Label();
            this.lblPce = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.textBuscar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBuscar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // textBuscar
            // 
            this.textBuscar.Location = new System.Drawing.Point(109, 82);
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.Size = new System.Drawing.Size(127, 20);
            this.textBuscar.TabIndex = 19;
            this.textBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEdit1_KeyPress);
            // 
            // btnEliminarModMed
            // 
            this.btnEliminarModMed.Location = new System.Drawing.Point(69, 353);
            this.btnEliminarModMed.Name = "btnEliminarModMed";
            this.btnEliminarModMed.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarModMed.TabIndex = 18;
            this.btnEliminarModMed.Text = "Eliminar";
            this.btnEliminarModMed.Click += new System.EventHandler(this.btnEliminarModMed_Click);
            // 
            // comboBuscar
            // 
            this.comboBuscar.Location = new System.Drawing.Point(109, 38);
            this.comboBuscar.Name = "comboBuscar";
            this.comboBuscar.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBuscar.Properties.Items.AddRange(new object[] {
            "Cedula",
            "Nombre",
            "Apellido"});
            this.comboBuscar.Size = new System.Drawing.Size(127, 20);
            this.comboBuscar.TabIndex = 17;
            this.comboBuscar.SelectedIndexChanged += new System.EventHandler(this.comboBuscar_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Buscar Por:";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(413, 353);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 15;
            this.simpleButton2.Text = "Salir";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // dataGridPacientes
            // 
            this.dataGridPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPacientes.Location = new System.Drawing.Point(5, 135);
            this.dataGridPacientes.Name = "dataGridPacientes";
            this.dataGridPacientes.Size = new System.Drawing.Size(520, 193);
            this.dataGridPacientes.TabIndex = 14;
            this.dataGridPacientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPacientes_CellClick);
            // 
            // lblTituloBusqueda
            // 
            this.lblTituloBusqueda.AutoSize = true;
            this.lblTituloBusqueda.Location = new System.Drawing.Point(36, 85);
            this.lblTituloBusqueda.Name = "lblTituloBusqueda";
            this.lblTituloBusqueda.Size = new System.Drawing.Size(43, 13);
            this.lblTituloBusqueda.TabIndex = 13;
            this.lblTituloBusqueda.Text = "Cedula:";
            // 
            // lblPce
            // 
            this.lblPce.AutoSize = true;
            this.lblPce.Location = new System.Drawing.Point(303, 76);
            this.lblPce.Name = "lblPce";
            this.lblPce.Size = new System.Drawing.Size(0, 13);
            this.lblPce.TabIndex = 20;
            // 
            // EliminarMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 415);
            this.Controls.Add(this.lblPce);
            this.Controls.Add(this.textBuscar);
            this.Controls.Add(this.btnEliminarModMed);
            this.Controls.Add(this.comboBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.dataGridPacientes);
            this.Controls.Add(this.lblTituloBusqueda);
            this.Name = "EliminarMedico";
            this.Text = "EliminarMedico";
            this.Load += new System.EventHandler(this.EliminarMedico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textBuscar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBuscar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit textBuscar;
        public DevExpress.XtraEditors.SimpleButton btnEliminarModMed;
        private DevExpress.XtraEditors.ComboBoxEdit comboBuscar;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.DataGridView dataGridPacientes;
        private System.Windows.Forms.Label lblTituloBusqueda;
        private System.Windows.Forms.Label lblPce;
    }
}