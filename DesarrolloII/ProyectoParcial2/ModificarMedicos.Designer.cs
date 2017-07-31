namespace ProyectoParcial2
{
    partial class ModificarMedicos
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
            this.lblEtiqueta = new System.Windows.Forms.Label();
            this.dataGridMedico = new System.Windows.Forms.DataGridView();
            this.btnSalir = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBuscar = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnEliminarModMed = new DevExpress.XtraEditors.SimpleButton();
            this.txtBuscar = new DevExpress.XtraEditors.TextEdit();
            this.dataGridElimanrMedico = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMedico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBuscar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuscar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridElimanrMedico)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEtiqueta
            // 
            this.lblEtiqueta.AutoSize = true;
            this.lblEtiqueta.Location = new System.Drawing.Point(43, 75);
            this.lblEtiqueta.Name = "lblEtiqueta";
            this.lblEtiqueta.Size = new System.Drawing.Size(33, 13);
            this.lblEtiqueta.TabIndex = 2;
            this.lblEtiqueta.Text = "Dato:";
            // 
            // dataGridMedico
            // 
            this.dataGridMedico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMedico.Location = new System.Drawing.Point(12, 125);
            this.dataGridMedico.Name = "dataGridMedico";
            this.dataGridMedico.Size = new System.Drawing.Size(520, 193);
            this.dataGridMedico.TabIndex = 6;
            this.dataGridMedico.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(446, 343);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Buscar Por:";
            // 
            // comboBuscar
            // 
            this.comboBuscar.Location = new System.Drawing.Point(116, 28);
            this.comboBuscar.Name = "comboBuscar";
            this.comboBuscar.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBuscar.Properties.Items.AddRange(new object[] {
            "Cedula",
            "Nombre",
            "Apellido"});
            this.comboBuscar.Size = new System.Drawing.Size(127, 20);
            this.comboBuscar.TabIndex = 10;
            this.comboBuscar.SelectedIndexChanged += new System.EventHandler(this.comboBuscar_SelectedIndexChanged);
            // 
            // btnEliminarModMed
            // 
            this.btnEliminarModMed.Location = new System.Drawing.Point(76, 343);
            this.btnEliminarModMed.Name = "btnEliminarModMed";
            this.btnEliminarModMed.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarModMed.TabIndex = 11;
            this.btnEliminarModMed.Text = "Eliminar";
            this.btnEliminarModMed.Click += new System.EventHandler(this.btnEliminarModMed_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(116, 72);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(127, 20);
            this.txtBuscar.TabIndex = 12;
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // dataGridElimanrMedico
            // 
            this.dataGridElimanrMedico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridElimanrMedico.Location = new System.Drawing.Point(12, 125);
            this.dataGridElimanrMedico.Name = "dataGridElimanrMedico";
            this.dataGridElimanrMedico.Size = new System.Drawing.Size(520, 193);
            this.dataGridElimanrMedico.TabIndex = 13;
            this.dataGridElimanrMedico.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridElimanrMedico_CellClick);
            // 
            // ModificarMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 379);
            this.Controls.Add(this.dataGridElimanrMedico);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnEliminarModMed);
            this.Controls.Add(this.comboBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dataGridMedico);
            this.Controls.Add(this.lblEtiqueta);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModificarMedicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ModificarMedicos";
            this.Load += new System.EventHandler(this.ModificarMedicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMedico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBuscar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuscar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridElimanrMedico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblEtiqueta;
        private DevExpress.XtraEditors.SimpleButton btnSalir;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.ComboBoxEdit comboBuscar;
        private DevExpress.XtraEditors.TextEdit txtBuscar;
        public DevExpress.XtraEditors.SimpleButton btnEliminarModMed;
        public System.Windows.Forms.DataGridView dataGridElimanrMedico;
        public System.Windows.Forms.DataGridView dataGridMedico;
    }
}