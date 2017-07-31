namespace ProyectoParcial2
{
    partial class CitasAsignadas
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
            this.dataGridCitasAsignadas = new System.Windows.Forms.DataGridView();
            this.btnSalir = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCitasAsignadas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridCitasAsignadas
            // 
            this.dataGridCitasAsignadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCitasAsignadas.Location = new System.Drawing.Point(15, 105);
            this.dataGridCitasAsignadas.Name = "dataGridCitasAsignadas";
            this.dataGridCitasAsignadas.Size = new System.Drawing.Size(765, 300);
            this.dataGridCitasAsignadas.TabIndex = 0;
            this.dataGridCitasAsignadas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCitasAsignadas_CellClick);
            this.dataGridCitasAsignadas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCitasAsignadas_CellContentClick);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::ProyectoParcial2.Properties.Resources.salir;
            this.btnSalir.Location = new System.Drawing.Point(675, 420);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(105, 45);
            this.btnSalir.TabIndex = 64;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // CitasAsignadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 480);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dataGridCitasAsignadas);
            this.Name = "CitasAsignadas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CitasAsignadas";
            this.Load += new System.EventHandler(this.CitasAsignadas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCitasAsignadas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridCitasAsignadas;
        public DevExpress.XtraEditors.SimpleButton btnSalir;
    }
}