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
            this.txtRazonBuscar = new DevExpress.XtraEditors.TextEdit();
            this.comboBuscar = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridPacientes = new System.Windows.Forms.DataGridView();
            this.lblTituloBusqueda = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtRazonBuscar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBuscar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRazonBuscar
            // 
            this.txtRazonBuscar.Location = new System.Drawing.Point(130, 76);
            this.txtRazonBuscar.Name = "txtRazonBuscar";
            this.txtRazonBuscar.Size = new System.Drawing.Size(162, 20);
            this.txtRazonBuscar.TabIndex = 19;
            this.txtRazonBuscar.EditValueChanged += new System.EventHandler(this.txtRazonBuscar_EditValueChanged);
            this.txtRazonBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEdit1_KeyPress);
            // 
            // comboBuscar
            // 
            this.comboBuscar.Location = new System.Drawing.Point(130, 32);
            this.comboBuscar.Name = "comboBuscar";
            this.comboBuscar.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBuscar.Properties.Items.AddRange(new object[] {
            "Cedula",
            "Nombre\t",
            "Apellido"});
            this.comboBuscar.Size = new System.Drawing.Size(162, 20);
            this.comboBuscar.TabIndex = 17;
            this.comboBuscar.SelectedIndexChanged += new System.EventHandler(this.comboBoxEdit1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Buscar Por:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(460, 347);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 15;
            this.simpleButton2.Text = "Salir";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // dataGridPacientes
            // 
            this.dataGridPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPacientes.Location = new System.Drawing.Point(26, 129);
            this.dataGridPacientes.Name = "dataGridPacientes";
            this.dataGridPacientes.Size = new System.Drawing.Size(520, 193);
            this.dataGridPacientes.TabIndex = 14;
            this.dataGridPacientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPacientes_CellClick);
            this.dataGridPacientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPacientes_CellContentClick);
            // 
            // lblTituloBusqueda
            // 
            this.lblTituloBusqueda.AutoSize = true;
            this.lblTituloBusqueda.Location = new System.Drawing.Point(57, 79);
            this.lblTituloBusqueda.Name = "lblTituloBusqueda";
            this.lblTituloBusqueda.Size = new System.Drawing.Size(43, 13);
            this.lblTituloBusqueda.TabIndex = 13;
            this.lblTituloBusqueda.Text = "Cedula:";
            this.lblTituloBusqueda.Click += new System.EventHandler(this.lblTituloBusqueda_Click);
            // 
            // ModificarPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 381);
            this.Controls.Add(this.txtRazonBuscar);
            this.Controls.Add(this.comboBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.dataGridPacientes);
            this.Controls.Add(this.lblTituloBusqueda);
            this.Name = "ModificarPacientes";
            this.Text = "ModificarPacientes";
            this.Load += new System.EventHandler(this.ModificarPacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtRazonBuscar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBuscar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtRazonBuscar;
        private DevExpress.XtraEditors.ComboBoxEdit comboBuscar;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.DataGridView dataGridPacientes;
        private System.Windows.Forms.Label lblTituloBusqueda;
    }
}