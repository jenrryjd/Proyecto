﻿namespace ProyectoParcial2
{
    partial class Especialidad
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtEspe = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnInsertarEspecia = new DevExpress.XtraEditors.SimpleButton();
            this.btnModificarEspe = new DevExpress.XtraEditors.SimpleButton();
            this.btnElimnarEspe = new DevExpress.XtraEditors.SimpleButton();
            this.txtBuscar = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCambiante = new System.Windows.Forms.Label();
            this.comboBuscar = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigo = new DevExpress.XtraEditors.TextEdit();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEspe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuscar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBuscar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 207);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(389, 165);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellBorderStyleChanged += new System.EventHandler(this.dataGridView1_CellBorderStyleChanged);
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(23, 95);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(62, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Especialidad:";
            // 
            // txtEspe
            // 
            this.txtEspe.Location = new System.Drawing.Point(104, 92);
            this.txtEspe.Name = "txtEspe";
            this.txtEspe.Size = new System.Drawing.Size(219, 20);
            this.txtEspe.TabIndex = 3;
            this.txtEspe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEspe_KeyPress);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(342, 388);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "Salir";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnInsertarEspecia
            // 
            this.btnInsertarEspecia.Location = new System.Drawing.Point(86, 388);
            this.btnInsertarEspecia.Name = "btnInsertarEspecia";
            this.btnInsertarEspecia.Size = new System.Drawing.Size(75, 23);
            this.btnInsertarEspecia.TabIndex = 8;
            this.btnInsertarEspecia.Text = "Insertar";
            this.btnInsertarEspecia.Click += new System.EventHandler(this.btnInsertarEspecia_Click);
            // 
            // btnModificarEspe
            // 
            this.btnModificarEspe.Location = new System.Drawing.Point(86, 388);
            this.btnModificarEspe.Name = "btnModificarEspe";
            this.btnModificarEspe.Size = new System.Drawing.Size(75, 23);
            this.btnModificarEspe.TabIndex = 9;
            this.btnModificarEspe.Text = "Modificar";
            this.btnModificarEspe.Click += new System.EventHandler(this.btnModificarEspe_Click);
            // 
            // btnElimnarEspe
            // 
            this.btnElimnarEspe.Location = new System.Drawing.Point(86, 388);
            this.btnElimnarEspe.Name = "btnElimnarEspe";
            this.btnElimnarEspe.Size = new System.Drawing.Size(75, 23);
            this.btnElimnarEspe.TabIndex = 10;
            this.btnElimnarEspe.Text = "Eliminar";
            this.btnElimnarEspe.Click += new System.EventHandler(this.btnElimnarEspe_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(109, 169);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(152, 20);
            this.txtBuscar.TabIndex = 11;
            this.txtBuscar.EditValueChanged += new System.EventHandler(this.txtBuscar_EditValueChanged);
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(248, 388);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 13;
            this.simpleButton2.Text = "Cancelar";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Buscar Por:";
            // 
            // lblCambiante
            // 
            this.lblCambiante.AutoSize = true;
            this.lblCambiante.Location = new System.Drawing.Point(20, 172);
            this.lblCambiante.Name = "lblCambiante";
            this.lblCambiante.Size = new System.Drawing.Size(33, 13);
            this.lblCambiante.TabIndex = 34;
            this.lblCambiante.Text = "Dato:";
            // 
            // comboBuscar
            // 
            this.comboBuscar.Location = new System.Drawing.Point(109, 127);
            this.comboBuscar.Name = "comboBuscar";
            this.comboBuscar.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBuscar.Properties.Items.AddRange(new object[] {
            "Codigo",
            "Especialidad"});
            this.comboBuscar.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBuscar.Size = new System.Drawing.Size(152, 20);
            this.comboBuscar.TabIndex = 35;
            this.comboBuscar.SelectedIndexChanged += new System.EventHandler(this.comboBuscar_SelectedIndexChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(23, 54);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 13);
            this.labelControl1.TabIndex = 37;
            this.labelControl1.Text = "Codigo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.EditValue = "";
            this.txtCodigo.Location = new System.Drawing.Point(104, 51);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(219, 20);
            this.txtCodigo.TabIndex = 36;
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // Especialidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 428);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.comboBuscar);
            this.Controls.Add(this.lblCambiante);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnElimnarEspe);
            this.Controls.Add(this.btnModificarEspe);
            this.Controls.Add(this.btnInsertarEspecia);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtEspe);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Especialidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Especialidad";
            this.Load += new System.EventHandler(this.Especialidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEspe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuscar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBuscar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        public DevExpress.XtraEditors.SimpleButton btnInsertarEspecia;
        public DevExpress.XtraEditors.SimpleButton btnModificarEspe;
        public DevExpress.XtraEditors.SimpleButton btnElimnarEspe;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCambiante;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
        public DevExpress.XtraEditors.TextEdit txtEspe;
        public DevExpress.XtraEditors.TextEdit txtBuscar;
        public DevExpress.XtraEditors.ComboBoxEdit comboBuscar;
        public DevExpress.XtraEditors.TextEdit txtCodigo;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}