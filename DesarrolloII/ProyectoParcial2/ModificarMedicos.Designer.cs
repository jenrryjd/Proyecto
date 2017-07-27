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
            this.lblTituloBusqueda = new System.Windows.Forms.Label();
            this.dataGridMedicos = new System.Windows.Forms.DataGridView();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBuscar = new DevExpress.XtraEditors.ComboBoxEdit();
            this.textBuscare = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMedicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBuscar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBuscare.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloBusqueda
            // 
            this.lblTituloBusqueda.AutoSize = true;
            this.lblTituloBusqueda.Location = new System.Drawing.Point(43, 75);
            this.lblTituloBusqueda.Name = "lblTituloBusqueda";
            this.lblTituloBusqueda.Size = new System.Drawing.Size(43, 13);
            this.lblTituloBusqueda.TabIndex = 2;
            this.lblTituloBusqueda.Text = "Cedula:";
            // 
            // dataGridMedicos
            // 
            this.dataGridMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMedicos.Location = new System.Drawing.Point(12, 125);
            this.dataGridMedicos.Name = "dataGridMedicos";
            this.dataGridMedicos.Size = new System.Drawing.Size(520, 193);
            this.dataGridMedicos.TabIndex = 6;
            this.dataGridMedicos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMedicos_CellClick);
            this.dataGridMedicos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMedicos_CellContentClick);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(446, 343);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 8;
            this.simpleButton2.Text = "Salir";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
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
            this.comboBuscar.SelectedIndexChanged += new System.EventHandler(this.comboBoxEdit1_SelectedIndexChanged);
            // 
            // textBuscare
            // 
            this.textBuscare.Location = new System.Drawing.Point(116, 72);
            this.textBuscare.Name = "textBuscare";
            this.textBuscare.Size = new System.Drawing.Size(127, 20);
            this.textBuscare.TabIndex = 12;
            this.textBuscare.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEdit1_KeyPress);
            // 
            // ModificarMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 379);
            this.Controls.Add(this.textBuscare);
            this.Controls.Add(this.comboBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.dataGridMedicos);
            this.Controls.Add(this.lblTituloBusqueda);
            this.Name = "ModificarMedicos";
            this.Text = "ModificarMedicos";
            this.Load += new System.EventHandler(this.ModificarMedicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMedicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBuscar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBuscare.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTituloBusqueda;
        private System.Windows.Forms.DataGridView dataGridMedicos;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.ComboBoxEdit comboBuscar;
        private DevExpress.XtraEditors.TextEdit textBuscare;
    }
}