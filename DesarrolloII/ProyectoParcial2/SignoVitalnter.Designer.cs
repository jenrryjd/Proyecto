namespace ProyectoParcial2
{
    partial class SignoVital
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
            this.txtBuscar = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridCitas = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumCita = new DevExpress.XtraEditors.TextEdit();
            this.txtAltura = new DevExpress.XtraEditors.TextEdit();
            this.txtPeso = new DevExpress.XtraEditors.TextEdit();
            this.txtPresion = new DevExpress.XtraEditors.TextEdit();
            this.txtRitmpCardiaco = new DevExpress.XtraEditors.TextEdit();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSlir = new System.Windows.Forms.Button();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtBuscar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCitas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumCita.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAltura.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPresion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRitmpCardiaco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(139, 55);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(198, 20);
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar Cita:";
            // 
            // dataGridCitas
            // 
            this.dataGridCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCitas.Location = new System.Drawing.Point(12, 105);
            this.dataGridCitas.Name = "dataGridCitas";
            this.dataGridCitas.Size = new System.Drawing.Size(455, 62);
            this.dataGridCitas.TabIndex = 4;
            this.dataGridCitas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCitas_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Registro Signos Vitales";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Numero Cita:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Altura:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Peso:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(255, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Presion:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(255, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Ritmo Cardiaco:";
            // 
            // txtNumCita
            // 
            this.txtNumCita.Location = new System.Drawing.Point(104, 224);
            this.txtNumCita.Name = "txtNumCita";
            this.txtNumCita.Size = new System.Drawing.Size(100, 20);
            this.txtNumCita.TabIndex = 11;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(104, 251);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 20);
            this.txtAltura.TabIndex = 12;
            this.txtAltura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAltura_KeyPress);
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(104, 282);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 20);
            this.txtPeso.TabIndex = 13;
            this.txtPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPeso_KeyPress);
            // 
            // txtPresion
            // 
            this.txtPresion.Location = new System.Drawing.Point(344, 221);
            this.txtPresion.Name = "txtPresion";
            this.txtPresion.Size = new System.Drawing.Size(100, 20);
            this.txtPresion.TabIndex = 14;
            this.txtPresion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPresion_KeyPress);
            // 
            // txtRitmpCardiaco
            // 
            this.txtRitmpCardiaco.Location = new System.Drawing.Point(344, 251);
            this.txtRitmpCardiaco.Name = "txtRitmpCardiaco";
            this.txtRitmpCardiaco.Size = new System.Drawing.Size(100, 20);
            this.txtRitmpCardiaco.TabIndex = 15;
            this.txtRitmpCardiaco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRitmpCardiaco_KeyPress);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(30, 351);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 16;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(225, 351);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSlir
            // 
            this.btnSlir.Location = new System.Drawing.Point(378, 351);
            this.btnSlir.Name = "btnSlir";
            this.btnSlir.Size = new System.Drawing.Size(75, 23);
            this.btnSlir.TabIndex = 18;
            this.btnSlir.Text = "Salir";
            this.btnSlir.UseVisualStyleBackColor = true;
            this.btnSlir.Click += new System.EventHandler(this.btnSlir_Click);
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // SignoVital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 402);
            this.Controls.Add(this.btnSlir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.txtRitmpCardiaco);
            this.Controls.Add(this.txtPresion);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtNumCita);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridCitas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SignoVital";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SignoVital";
            this.Load += new System.EventHandler(this.SignoVital_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtBuscar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCitas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumCita.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAltura.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPresion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRitmpCardiaco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridCitas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.TextEdit txtNumCita;
        private DevExpress.XtraEditors.TextEdit txtAltura;
        private DevExpress.XtraEditors.TextEdit txtPeso;
        private DevExpress.XtraEditors.TextEdit txtPresion;
        private DevExpress.XtraEditors.TextEdit txtRitmpCardiaco;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSlir;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
    }
}