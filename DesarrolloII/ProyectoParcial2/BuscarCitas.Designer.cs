namespace ProyectoParcial2
{
    partial class BuscarCitas
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
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridCitas = new System.Windows.Forms.DataGridView();
            this.lblBuscarPor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtRazonBuscar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCitas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRazonBuscar
            // 
            this.txtRazonBuscar.Location = new System.Drawing.Point(150, 60);
            this.txtRazonBuscar.Name = "txtRazonBuscar";
            this.txtRazonBuscar.Size = new System.Drawing.Size(127, 20);
            this.txtRazonBuscar.TabIndex = 37;
            this.txtRazonBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRazonBuscar_KeyPress);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Image = global::ProyectoParcial2.Properties.Resources.salir;
            this.simpleButton2.Location = new System.Drawing.Point(450, 315);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(105, 45);
            this.simpleButton2.TabIndex = 34;
            this.simpleButton2.Text = "Salir";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // dataGridCitas
            // 
            this.dataGridCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCitas.Location = new System.Drawing.Point(15, 105);
            this.dataGridCitas.Name = "dataGridCitas";
            this.dataGridCitas.Size = new System.Drawing.Size(555, 193);
            this.dataGridCitas.TabIndex = 33;
            this.dataGridCitas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCitas_CellClick);
            // 
            // lblBuscarPor
            // 
            this.lblBuscarPor.AutoSize = true;
            this.lblBuscarPor.Location = new System.Drawing.Point(30, 60);
            this.lblBuscarPor.Name = "lblBuscarPor";
            this.lblBuscarPor.Size = new System.Drawing.Size(106, 13);
            this.lblBuscarPor.TabIndex = 32;
            this.lblBuscarPor.Text = "Nombre del Paciente";
            // 
            // BuscarCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 377);
            this.Controls.Add(this.txtRazonBuscar);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.dataGridCitas);
            this.Controls.Add(this.lblBuscarPor);
            this.Name = "BuscarCitas";
            this.Text = "BuscarCitas";
            this.Load += new System.EventHandler(this.BuscarCitas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtRazonBuscar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCitas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtRazonBuscar;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.DataGridView dataGridCitas;
        private System.Windows.Forms.Label lblBuscarPor;
    }
}