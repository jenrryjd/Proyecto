namespace ProyectoParcial2
{
    partial class AtencionTratamientoFrm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNcita = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxNoAsiste = new System.Windows.Forms.CheckBox();
            this.checkBoxAsiste = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.lblRitmoCardiaco = new System.Windows.Forms.Label();
            this.lblPresion = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.memoEnfermedades = new DevExpress.XtraEditors.MemoEdit();
            this.memoAlergias = new DevExpress.XtraEditors.MemoEdit();
            this.lblTipoSangre = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtBuscarMedicamento = new System.Windows.Forms.TextBox();
            this.dataGridMedicamentos = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblCedulaPac = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblNombrePac = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dataGridReceta = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel7 = new System.Windows.Forms.Panel();
            this.ResumenCitaMedica = new DevExpress.XtraEditors.MemoEdit();
            this.label15 = new System.Windows.Forms.Label();
            this.btnSalir = new DevExpress.XtraEditors.SimpleButton();
            this.btnInsertar = new DevExpress.XtraEditors.SimpleButton();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblNumerodeAtencion = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEnfermedades.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoAlergias.Properties)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMedicamentos)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReceta)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResumenCitaMedica.Properties)).BeginInit();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblNcita);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.checkBoxNoAsiste);
            this.panel1.Controls.Add(this.checkBoxAsiste);
            this.panel1.Location = new System.Drawing.Point(15, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 45);
            this.panel1.TabIndex = 0;
            // 
            // lblNcita
            // 
            this.lblNcita.AutoSize = true;
            this.lblNcita.Location = new System.Drawing.Point(90, 15);
            this.lblNcita.Name = "lblNcita";
            this.lblNcita.Size = new System.Drawing.Size(35, 13);
            this.lblNcita.TabIndex = 2;
            this.lblNcita.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cita Numero:";
            // 
            // checkBoxNoAsiste
            // 
            this.checkBoxNoAsiste.AutoSize = true;
            this.checkBoxNoAsiste.Location = new System.Drawing.Point(255, 15);
            this.checkBoxNoAsiste.Name = "checkBoxNoAsiste";
            this.checkBoxNoAsiste.Size = new System.Drawing.Size(71, 17);
            this.checkBoxNoAsiste.TabIndex = 1;
            this.checkBoxNoAsiste.Text = "No Asiste";
            this.checkBoxNoAsiste.UseVisualStyleBackColor = true;
            this.checkBoxNoAsiste.CheckedChanged += new System.EventHandler(this.checkBoxNoAsiste_CheckedChanged);
            // 
            // checkBoxAsiste
            // 
            this.checkBoxAsiste.AutoSize = true;
            this.checkBoxAsiste.Location = new System.Drawing.Point(180, 15);
            this.checkBoxAsiste.Name = "checkBoxAsiste";
            this.checkBoxAsiste.Size = new System.Drawing.Size(54, 17);
            this.checkBoxAsiste.TabIndex = 0;
            this.checkBoxAsiste.Text = "Asiste";
            this.checkBoxAsiste.UseVisualStyleBackColor = true;
            this.checkBoxAsiste.CheckedChanged += new System.EventHandler(this.checkBoxAsiste_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.lblRitmoCardiaco);
            this.panel2.Controls.Add(this.lblPresion);
            this.panel2.Controls.Add(this.lblPeso);
            this.panel2.Controls.Add(this.lblAltura);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(330, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 240);
            this.panel2.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(60, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(163, 25);
            this.label11.TabIndex = 9;
            this.label11.Text = "Signos Vitales";
            // 
            // lblRitmoCardiaco
            // 
            this.lblRitmoCardiaco.AutoSize = true;
            this.lblRitmoCardiaco.Location = new System.Drawing.Point(120, 195);
            this.lblRitmoCardiaco.Name = "lblRitmoCardiaco";
            this.lblRitmoCardiaco.Size = new System.Drawing.Size(35, 13);
            this.lblRitmoCardiaco.TabIndex = 9;
            this.lblRitmoCardiaco.Text = "label5";
            // 
            // lblPresion
            // 
            this.lblPresion.AutoSize = true;
            this.lblPresion.Location = new System.Drawing.Point(120, 150);
            this.lblPresion.Name = "lblPresion";
            this.lblPresion.Size = new System.Drawing.Size(35, 13);
            this.lblPresion.TabIndex = 8;
            this.lblPresion.Text = "label5";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(120, 105);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(35, 13);
            this.lblPeso.TabIndex = 7;
            this.lblPeso.Text = "label5";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(120, 60);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(35, 13);
            this.lblAltura.TabIndex = 6;
            this.lblAltura.Text = "label5";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Ritmo Cardiaco:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Presion:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Peso: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Altura:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.memoEnfermedades);
            this.panel3.Controls.Add(this.memoAlergias);
            this.panel3.Controls.Add(this.lblTipoSangre);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(15, 75);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 240);
            this.panel3.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(75, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 25);
            this.label10.TabIndex = 8;
            this.label10.Text = "Antecedentes";
            // 
            // memoEnfermedades
            // 
            this.memoEnfermedades.Enabled = false;
            this.memoEnfermedades.Location = new System.Drawing.Point(120, 165);
            this.memoEnfermedades.Name = "memoEnfermedades";
            this.memoEnfermedades.Size = new System.Drawing.Size(165, 60);
            this.memoEnfermedades.TabIndex = 7;
            // 
            // memoAlergias
            // 
            this.memoAlergias.Enabled = false;
            this.memoAlergias.Location = new System.Drawing.Point(120, 90);
            this.memoAlergias.Name = "memoAlergias";
            this.memoAlergias.Size = new System.Drawing.Size(165, 60);
            this.memoAlergias.TabIndex = 6;
            // 
            // lblTipoSangre
            // 
            this.lblTipoSangre.AutoSize = true;
            this.lblTipoSangre.Location = new System.Drawing.Point(120, 60);
            this.lblTipoSangre.Name = "lblTipoSangre";
            this.lblTipoSangre.Size = new System.Drawing.Size(35, 13);
            this.lblTipoSangre.TabIndex = 3;
            this.lblTipoSangre.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Enfermendades:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Alergias:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tipo de Sangre:";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.txtBuscarMedicamento);
            this.panel4.Controls.Add(this.dataGridMedicamentos);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Enabled = false;
            this.panel4.Location = new System.Drawing.Point(615, 75);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(480, 240);
            this.panel4.TabIndex = 2;
            // 
            // txtBuscarMedicamento
            // 
            this.txtBuscarMedicamento.Location = new System.Drawing.Point(60, 60);
            this.txtBuscarMedicamento.Name = "txtBuscarMedicamento";
            this.txtBuscarMedicamento.Size = new System.Drawing.Size(240, 20);
            this.txtBuscarMedicamento.TabIndex = 12;
            this.txtBuscarMedicamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarMedicamento_KeyPress);
            // 
            // dataGridMedicamentos
            // 
            this.dataGridMedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMedicamentos.Enabled = false;
            this.dataGridMedicamentos.Location = new System.Drawing.Point(15, 90);
            this.dataGridMedicamentos.Name = "dataGridMedicamentos";
            this.dataGridMedicamentos.Size = new System.Drawing.Size(450, 120);
            this.dataGridMedicamentos.TabIndex = 11;
            this.dataGridMedicamentos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMedicamentos_CellClick);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(60, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 25);
            this.label14.TabIndex = 10;
            this.label14.Text = "Receta";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 60);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "label5";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.lblEspecialidad);
            this.panel5.Controls.Add(this.lblCedulaPac);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.lblNombrePac);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Location = new System.Drawing.Point(390, 15);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(555, 45);
            this.panel5.TabIndex = 3;
            // 
            // lblCedulaPac
            // 
            this.lblCedulaPac.AutoSize = true;
            this.lblCedulaPac.Location = new System.Drawing.Point(390, 15);
            this.lblCedulaPac.Name = "lblCedulaPac";
            this.lblCedulaPac.Size = new System.Drawing.Size(19, 13);
            this.lblCedulaPac.TabIndex = 9;
            this.lblCedulaPac.Text = "----";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(330, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Cedula:";
            // 
            // lblNombrePac
            // 
            this.lblNombrePac.AutoSize = true;
            this.lblNombrePac.Location = new System.Drawing.Point(75, 15);
            this.lblNombrePac.Name = "lblNombrePac";
            this.lblNombrePac.Size = new System.Drawing.Size(133, 13);
            this.lblNombrePac.TabIndex = 7;
            this.lblNombrePac.Text = "jenrry patricio nuñez nuñez";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Paciente:";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.dataGridReceta);
            this.panel6.Location = new System.Drawing.Point(16, 331);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(584, 149);
            this.panel6.TabIndex = 12;
            // 
            // dataGridReceta
            // 
            this.dataGridReceta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridReceta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridReceta.Location = new System.Drawing.Point(15, 15);
            this.dataGridReceta.Name = "dataGridReceta";
            this.dataGridReceta.Size = new System.Drawing.Size(555, 120);
            this.dataGridReceta.TabIndex = 11;
            this.dataGridReceta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridReceta_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nº Cita";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Id Medicamento";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nombre Medicamento";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cantidad";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Indicaciones";
            this.Column5.Name = "Column5";
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.ResumenCitaMedica);
            this.panel7.Controls.Add(this.label15);
            this.panel7.Controls.Add(this.btnSalir);
            this.panel7.Controls.Add(this.btnInsertar);
            this.panel7.Location = new System.Drawing.Point(616, 331);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(480, 149);
            this.panel7.TabIndex = 12;
            // 
            // ResumenCitaMedica
            // 
            this.ResumenCitaMedica.Enabled = false;
            this.ResumenCitaMedica.Location = new System.Drawing.Point(14, 44);
            this.ResumenCitaMedica.Name = "ResumenCitaMedica";
            this.ResumenCitaMedica.Size = new System.Drawing.Size(331, 91);
            this.ResumenCitaMedica.TabIndex = 9;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(15, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(242, 25);
            this.label15.TabIndex = 10;
            this.label15.Text = "Resumen Cita Medica";
            // 
            // btnSalir
            // 
            this.btnSalir.Enabled = false;
            this.btnSalir.Image = global::ProyectoParcial2.Properties.Resources.salir;
            this.btnSalir.Location = new System.Drawing.Point(359, 89);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(105, 45);
            this.btnSalir.TabIndex = 63;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Enabled = false;
            this.btnInsertar.Image = global::ProyectoParcial2.Properties.Resources.if_Compose_1891025;
            this.btnInsertar.Location = new System.Drawing.Point(359, 14);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(105, 45);
            this.btnInsertar.TabIndex = 60;
            this.btnInsertar.Text = "Guardar";
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.lblNumerodeAtencion);
            this.panel8.Controls.Add(this.label17);
            this.panel8.Location = new System.Drawing.Point(961, 16);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(134, 45);
            this.panel8.TabIndex = 3;
            // 
            // lblNumerodeAtencion
            // 
            this.lblNumerodeAtencion.AutoSize = true;
            this.lblNumerodeAtencion.Location = new System.Drawing.Point(90, 15);
            this.lblNumerodeAtencion.Name = "lblNumerodeAtencion";
            this.lblNumerodeAtencion.Size = new System.Drawing.Size(35, 13);
            this.lblNumerodeAtencion.TabIndex = 2;
            this.lblNumerodeAtencion.Text = "label2";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(15, 15);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = "Nº Atencion:";
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new System.Drawing.Point(495, 15);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(19, 13);
            this.lblEspecialidad.TabIndex = 10;
            this.lblEspecialidad.Text = "----";
            this.lblEspecialidad.Visible = false;
            // 
            // AtencionTratamientoFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 483);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AtencionTratamientoFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AtencionTratamientoFrm";
            this.Load += new System.EventHandler(this.AtencionTratamientoFrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEnfermedades.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoAlergias.Properties)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMedicamentos)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReceta)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResumenCitaMedica.Properties)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBoxNoAsiste;
        private System.Windows.Forms.CheckBox checkBoxAsiste;
        private System.Windows.Forms.Label lblNcita;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTipoSangre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.MemoEdit memoAlergias;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.MemoEdit memoEnfermedades;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblRitmoCardiaco;
        private System.Windows.Forms.Label lblPresion;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblCedulaPac;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblNombrePac;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridMedicamentos;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dataGridReceta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Panel panel7;
        private DevExpress.XtraEditors.MemoEdit ResumenCitaMedica;
        private System.Windows.Forms.Label label15;
        public DevExpress.XtraEditors.SimpleButton btnSalir;
        public DevExpress.XtraEditors.SimpleButton btnInsertar;
        private System.Windows.Forms.TextBox txtBuscarMedicamento;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblNumerodeAtencion;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblEspecialidad;
    }
}