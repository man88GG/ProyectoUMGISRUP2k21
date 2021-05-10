namespace CapaVistaHRM.Sergio.Procesos
{
    partial class frmPeticionCapacitacion
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
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rdCursosGenerales = new System.Windows.Forms.RadioButton();
            this.rdCompetencia = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbOpciones = new System.Windows.Forms.ComboBox();
            this.cmbEmpleado = new System.Windows.Forms.ComboBox();
            this.dgvPeticiones = new System.Windows.Forms.DataGridView();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbCompetencias = new System.Windows.Forms.ComboBox();
            this.txtCompetencia = new System.Windows.Forms.TextBox();
            this.rdInactivo = new System.Windows.Forms.RadioButton();
            this.rdActivo = new System.Windows.Forms.RadioButton();
            this.cmbCourse = new System.Windows.Forms.ComboBox();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtRangoInicio = new System.Windows.Forms.TextBox();
            this.txtRangoFinal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeticiones)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(101, 37);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 0;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(101, 79);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(269, 20);
            this.txtTitulo.TabIndex = 1;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(114, 126);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(256, 132);
            this.txtDescripcion.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(29, 582);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Estado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Título";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Codigo";
            // 
            // rdCursosGenerales
            // 
            this.rdCursosGenerales.AutoSize = true;
            this.rdCursosGenerales.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdCursosGenerales.ForeColor = System.Drawing.Color.White;
            this.rdCursosGenerales.Location = new System.Drawing.Point(176, 434);
            this.rdCursosGenerales.Name = "rdCursosGenerales";
            this.rdCursosGenerales.Size = new System.Drawing.Size(139, 21);
            this.rdCursosGenerales.TabIndex = 20;
            this.rdCursosGenerales.TabStop = true;
            this.rdCursosGenerales.Text = "Cursos generales";
            this.rdCursosGenerales.UseVisualStyleBackColor = true;
            this.rdCursosGenerales.CheckedChanged += new System.EventHandler(this.rdCursosGenerales_CheckedChanged);
            // 
            // rdCompetencia
            // 
            this.rdCompetencia.AutoSize = true;
            this.rdCompetencia.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdCompetencia.ForeColor = System.Drawing.Color.White;
            this.rdCompetencia.Location = new System.Drawing.Point(26, 434);
            this.rdCompetencia.Name = "rdCompetencia";
            this.rdCompetencia.Size = new System.Drawing.Size(112, 21);
            this.rdCompetencia.TabIndex = 19;
            this.rdCompetencia.TabStop = true;
            this.rdCompetencia.Text = "Competencia";
            this.rdCompetencia.UseVisualStyleBackColor = true;
            this.rdCompetencia.CheckedChanged += new System.EventHandler(this.rdCompetencia_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(23, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Capacitación dirigida a";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(410, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(655, 217);
            this.dataGridView1.TabIndex = 26;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Titulo";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Descripcion";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Empleado";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Curso";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Estado";
            this.Column6.Name = "Column6";
            // 
            // cmbOpciones
            // 
            this.cmbOpciones.FormattingEnabled = true;
            this.cmbOpciones.Items.AddRange(new object[] {
            "Seleccione",
            "Empleado",
            "Rango de Empleado",
            "Departamento"});
            this.cmbOpciones.Location = new System.Drawing.Point(187, 282);
            this.cmbOpciones.Name = "cmbOpciones";
            this.cmbOpciones.Size = new System.Drawing.Size(183, 21);
            this.cmbOpciones.TabIndex = 27;
            this.cmbOpciones.SelectedIndexChanged += new System.EventHandler(this.cmbOpciones_SelectedIndexChanged);
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.Items.AddRange(new object[] {
            "Seleccione..."});
            this.cmbEmpleado.Location = new System.Drawing.Point(26, 325);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(260, 21);
            this.cmbEmpleado.TabIndex = 28;
            this.cmbEmpleado.Visible = false;
            this.cmbEmpleado.SelectedIndexChanged += new System.EventHandler(this.cmbEmpleado_SelectedIndexChanged);
            this.cmbEmpleado.TextChanged += new System.EventHandler(this.cmbEmpleado_TextChanged);
            // 
            // dgvPeticiones
            // 
            this.dgvPeticiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeticiones.Location = new System.Drawing.Point(410, 325);
            this.dgvPeticiones.Name = "dgvPeticiones";
            this.dgvPeticiones.Size = new System.Drawing.Size(655, 226);
            this.dgvPeticiones.TabIndex = 29;
            this.dgvPeticiones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPeticiones_CellContentClick);
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Location = new System.Drawing.Point(305, 326);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(65, 20);
            this.txtEmpleado.TabIndex = 30;
            this.txtEmpleado.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(140, 386);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 31;
            this.label6.Text = "CURSOS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(23, 414);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 17);
            this.label7.TabIndex = 32;
            this.label7.Text = "Buscar curso por:";
            // 
            // cmbCompetencias
            // 
            this.cmbCompetencias.FormattingEnabled = true;
            this.cmbCompetencias.Location = new System.Drawing.Point(26, 461);
            this.cmbCompetencias.Name = "cmbCompetencias";
            this.cmbCompetencias.Size = new System.Drawing.Size(247, 21);
            this.cmbCompetencias.TabIndex = 33;
            this.cmbCompetencias.SelectedIndexChanged += new System.EventHandler(this.cmbCompetencias_SelectedIndexChanged);
            // 
            // txtCompetencia
            // 
            this.txtCompetencia.Location = new System.Drawing.Point(280, 461);
            this.txtCompetencia.Name = "txtCompetencia";
            this.txtCompetencia.Size = new System.Drawing.Size(48, 20);
            this.txtCompetencia.TabIndex = 34;
            this.txtCompetencia.TextChanged += new System.EventHandler(this.txtCompetencia_TextChanged);
            // 
            // rdInactivo
            // 
            this.rdInactivo.AutoSize = true;
            this.rdInactivo.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdInactivo.ForeColor = System.Drawing.Color.White;
            this.rdInactivo.Location = new System.Drawing.Point(187, 582);
            this.rdInactivo.Name = "rdInactivo";
            this.rdInactivo.Size = new System.Drawing.Size(76, 21);
            this.rdInactivo.TabIndex = 36;
            this.rdInactivo.TabStop = true;
            this.rdInactivo.Text = "Inactivo";
            this.rdInactivo.UseVisualStyleBackColor = true;
            this.rdInactivo.CheckedChanged += new System.EventHandler(this.rdInactivo_CheckedChanged);
            // 
            // rdActivo
            // 
            this.rdActivo.AutoSize = true;
            this.rdActivo.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdActivo.ForeColor = System.Drawing.Color.White;
            this.rdActivo.Location = new System.Drawing.Point(114, 582);
            this.rdActivo.Name = "rdActivo";
            this.rdActivo.Size = new System.Drawing.Size(67, 21);
            this.rdActivo.TabIndex = 35;
            this.rdActivo.TabStop = true;
            this.rdActivo.Text = "Activo";
            this.rdActivo.UseVisualStyleBackColor = true;
            this.rdActivo.CheckedChanged += new System.EventHandler(this.rdActivo_CheckedChanged);
            // 
            // cmbCourse
            // 
            this.cmbCourse.FormattingEnabled = true;
            this.cmbCourse.Location = new System.Drawing.Point(26, 488);
            this.cmbCourse.Name = "cmbCourse";
            this.cmbCourse.Size = new System.Drawing.Size(247, 21);
            this.cmbCourse.TabIndex = 37;
            this.cmbCourse.SelectedIndexChanged += new System.EventHandler(this.cmbCourse_SelectedIndexChanged);
            // 
            // txtCourse
            // 
            this.txtCourse.Location = new System.Drawing.Point(280, 484);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(48, 20);
            this.txtCourse.TabIndex = 38;
            this.txtCourse.TextChanged += new System.EventHandler(this.txtCourse_TextChanged);
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(270, 582);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(45, 20);
            this.txtEstado.TabIndex = 39;
            this.txtEstado.TextChanged += new System.EventHandler(this.txtEstado_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(794, 590);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(191, 61);
            this.btnSave.TabIndex = 40;
            this.btnSave.Text = "Guardar petición";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(538, 591);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(211, 60);
            this.btnAdd.TabIndex = 41;
            this.btnAdd.Text = "Agregar peticion";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtRangoInicio
            // 
            this.txtRangoInicio.Location = new System.Drawing.Point(70, 361);
            this.txtRangoInicio.Name = "txtRangoInicio";
            this.txtRangoInicio.Size = new System.Drawing.Size(100, 20);
            this.txtRangoInicio.TabIndex = 42;
            this.txtRangoInicio.Visible = false;
            // 
            // txtRangoFinal
            // 
            this.txtRangoFinal.Location = new System.Drawing.Point(176, 361);
            this.txtRangoFinal.Name = "txtRangoFinal";
            this.txtRangoFinal.Size = new System.Drawing.Size(100, 20);
            this.txtRangoFinal.TabIndex = 43;
            this.txtRangoFinal.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(635, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(193, 17);
            this.label8.TabIndex = 44;
            this.label8.Text = "Peticiones para capacitación.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(635, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(180, 17);
            this.label9.TabIndex = 45;
            this.label9.Text = "asignación de capacitación";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1122, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 46;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmPeticionCapacitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(1214, 683);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtRangoFinal);
            this.Controls.Add(this.txtRangoInicio);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtCourse);
            this.Controls.Add(this.cmbCourse);
            this.Controls.Add(this.rdInactivo);
            this.Controls.Add(this.rdActivo);
            this.Controls.Add(this.txtCompetencia);
            this.Controls.Add(this.cmbCompetencias);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEmpleado);
            this.Controls.Add(this.dgvPeticiones);
            this.Controls.Add(this.cmbEmpleado);
            this.Controls.Add(this.cmbOpciones);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdCursosGenerales);
            this.Controls.Add(this.rdCompetencia);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtCodigo);
            this.Name = "frmPeticionCapacitacion";
            this.Text = "frmPeticionCapacitacion";
            this.Load += new System.EventHandler(this.frmPeticionCapacitacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeticiones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdCursosGenerales;
        private System.Windows.Forms.RadioButton rdCompetencia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbOpciones;
        private System.Windows.Forms.ComboBox cmbEmpleado;
        private System.Windows.Forms.DataGridView dgvPeticiones;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbCompetencias;
        private System.Windows.Forms.TextBox txtCompetencia;
        private System.Windows.Forms.RadioButton rdInactivo;
        private System.Windows.Forms.RadioButton rdActivo;
        private System.Windows.Forms.ComboBox cmbCourse;
        private System.Windows.Forms.TextBox txtCourse;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.TextBox txtRangoInicio;
        private System.Windows.Forms.TextBox txtRangoFinal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
    }
}