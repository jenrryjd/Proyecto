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
            this.components = new System.ComponentModel.Container();
            this.txtRazonBuscar = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridCitas = new System.Windows.Forms.DataGridView();
            this.lblBuscarPor = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridCitasEliminar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.txtRazonBuscar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCitas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCitasEliminar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRazonBuscar
            // 
            this.txtRazonBuscar.Location = new System.Drawing.Point(150, 60);
            this.txtRazonBuscar.Name = "txtRazonBuscar";
            this.txtRazonBuscar.Size = new System.Drawing.Size(127, 20);
            this.txtRazonBuscar.TabIndex = 37;
            this.txtRazonBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRazonBuscar_KeyPress_1);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Image = global::ProyectoParcial2.Properties.Resources.salir;
            this.simpleButton2.Location = new System.Drawing.Point(720, 315);
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
            this.dataGridCitas.Size = new System.Drawing.Size(810, 193);
            this.dataGridCitas.TabIndex = 33;
            this.dataGridCitas.Visible = false;
            this.dataGridCitas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCitas_CellClick);
            this.dataGridCitas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCitas_CellContentClick);
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
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(285, 60);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 38;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dataGridCitasEliminar
            // 
            this.dataGridCitasEliminar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCitasEliminar.Location = new System.Drawing.Point(15, 105);
            this.dataGridCitasEliminar.Name = "dataGridCitasEliminar";
            this.dataGridCitasEliminar.Size = new System.Drawing.Size(810, 195);
            this.dataGridCitasEliminar.TabIndex = 39;
            this.dataGridCitasEliminar.Visible = false;
            this.dataGridCitasEliminar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCitasEliminar_CellClick);
            this.dataGridCitasEliminar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCitasEliminar_CellContentClick);
            // 
            // BuscarCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 377);
            this.Controls.Add(this.dataGridCitasEliminar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtRazonBuscar);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.dataGridCitas);
            this.Controls.Add(this.lblBuscarPor);
            this.Name = "BuscarCitas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuscarCitas";
            this.Load += new System.EventHandler(this.BuscarCitas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtRazonBuscar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCitas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCitasEliminar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtRazonBuscar;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.Label lblBuscarPor;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.DataGridView dataGridCitas;
        public System.Windows.Forms.DataGridView dataGridCitasEliminar;
    }
}