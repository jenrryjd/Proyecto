namespace ProyectoParcial2
{
    partial class BuscarEnfermedades
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
            this.dataGridEnfermedades = new System.Windows.Forms.DataGridView();
            this.lblBuscarPor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtRazonBuscar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRazonSocial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEnfermedades)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRazonBuscar
            // 
            this.txtRazonBuscar.Enabled = false;
            this.txtRazonBuscar.Location = new System.Drawing.Point(115, 65);
            this.txtRazonBuscar.Name = "txtRazonBuscar";
            this.txtRazonBuscar.Size = new System.Drawing.Size(127, 20);
            this.txtRazonBuscar.TabIndex = 31;
            this.txtRazonBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRazonBuscar_KeyPress);
            // 
            // cmbRazonSocial
            // 
            this.cmbRazonSocial.Location = new System.Drawing.Point(115, 20);
            this.cmbRazonSocial.Name = "cmbRazonSocial";
            this.cmbRazonSocial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbRazonSocial.Properties.Items.AddRange(new object[] {
            "Codigo Enfermedad",
            "Nombre",
            "Tipo"});
            this.cmbRazonSocial.Size = new System.Drawing.Size(127, 20);
            this.cmbRazonSocial.TabIndex = 30;
            this.cmbRazonSocial.SelectedIndexChanged += new System.EventHandler(this.cmbRazonSocial_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Buscar Por:";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Image = global::ProyectoParcial2.Properties.Resources.salir;
            this.simpleButton2.Location = new System.Drawing.Point(460, 320);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(105, 45);
            this.simpleButton2.TabIndex = 28;
            this.simpleButton2.Text = "Salir";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // dataGridEnfermedades
            // 
            this.dataGridEnfermedades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEnfermedades.Location = new System.Drawing.Point(25, 110);
            this.dataGridEnfermedades.Name = "dataGridEnfermedades";
            this.dataGridEnfermedades.Size = new System.Drawing.Size(555, 193);
            this.dataGridEnfermedades.TabIndex = 27;
            this.dataGridEnfermedades.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridEnfermedades_CellClick);
            // 
            // lblBuscarPor
            // 
            this.lblBuscarPor.AutoSize = true;
            this.lblBuscarPor.Location = new System.Drawing.Point(40, 65);
            this.lblBuscarPor.Name = "lblBuscarPor";
            this.lblBuscarPor.Size = new System.Drawing.Size(30, 13);
            this.lblBuscarPor.TabIndex = 26;
            this.lblBuscarPor.Text = "Dato";
            // 
            // BuscarEnfermedades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 384);
            this.Controls.Add(this.txtRazonBuscar);
            this.Controls.Add(this.cmbRazonSocial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.dataGridEnfermedades);
            this.Controls.Add(this.lblBuscarPor);
            this.Name = "BuscarEnfermedades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuscarEnfermedades";
            this.Load += new System.EventHandler(this.BuscarEnfermedades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtRazonBuscar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRazonSocial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEnfermedades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtRazonBuscar;
        private DevExpress.XtraEditors.ComboBoxEdit cmbRazonSocial;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.DataGridView dataGridEnfermedades;
        private System.Windows.Forms.Label lblBuscarPor;
    }
}