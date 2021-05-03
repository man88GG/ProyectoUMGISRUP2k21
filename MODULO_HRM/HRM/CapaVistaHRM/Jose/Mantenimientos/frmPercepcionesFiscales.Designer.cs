
namespace CapaVistaHRM.Jose.Mantenimientos
{
    partial class frmPercepcionesFiscales
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtSigno = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblSigno = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdActivo = new System.Windows.Forms.RadioButton();
            this.rdInactivo = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdPositivo = new System.Windows.Forms.RadioButton();
            this.rdNegativo = new System.Windows.Forms.RadioButton();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblCantidadMonto = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnGuardarDatos = new System.Windows.Forms.Button();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cmbPercepcionDeduccion1 = new System.Windows.Forms.ComboBox();
            this.btnAgregarFormula = new System.Windows.Forms.Button();
            this.txtFormula = new System.Windows.Forms.TextBox();
            this.lblPercepcionDeduccion = new System.Windows.Forms.Label();
            this.btnRestaurarValoresFormula = new System.Windows.Forms.Button();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblFormula = new System.Windows.Forms.Label();
            this.lblOperacion = new System.Windows.Forms.Label();
            this.lblValorFormula = new System.Windows.Forms.Label();
            this.txtValorFormula = new System.Windows.Forms.TextBox();
            this.cmbOperacion = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdTipoSi = new System.Windows.Forms.RadioButton();
            this.rdTipoNo = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdOperacionSi = new System.Windows.Forms.RadioButton();
            this.rdOperacionNo = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rdValorFormulaSi = new System.Windows.Forms.RadioButton();
            this.rdValorFormulaNo = new System.Windows.Forms.RadioButton();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.rdNuevo = new System.Windows.Forms.RadioButton();
            this.rdModificar = new System.Windows.Forms.RadioButton();
            this.cmbPercepcionModificar = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblNuevoNombre = new System.Windows.Forms.Label();
            this.txtNuevoNombre = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.rdEliminar = new System.Windows.Forms.RadioButton();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Purple;
            this.tabPage1.Controls.Add(this.txtNuevoNombre);
            this.tabPage1.Controls.Add(this.txtCodigo);
            this.tabPage1.Controls.Add(this.txtNombre);
            this.tabPage1.Controls.Add(this.txtCantidad);
            this.tabPage1.Controls.Add(this.txtDescripcion);
            this.tabPage1.Controls.Add(this.txtEstado);
            this.tabPage1.Controls.Add(this.txtSigno);
            this.tabPage1.Controls.Add(this.lblNuevoNombre);
            this.tabPage1.Controls.Add(this.btnBuscar);
            this.tabPage1.Controls.Add(this.cmbPercepcionModificar);
            this.tabPage1.Controls.Add(this.groupBox13);
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Controls.Add(this.btnAyuda);
            this.tabPage1.Controls.Add(this.btnLimpiarCampos);
            this.tabPage1.Controls.Add(this.btnGuardarDatos);
            this.tabPage1.Controls.Add(this.lblCodigo);
            this.tabPage1.Controls.Add(this.lblNombre);
            this.tabPage1.Controls.Add(this.lblCantidadMonto);
            this.tabPage1.Controls.Add(this.lblEstado);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.lblDescripcion);
            this.tabPage1.Controls.Add(this.lblSigno);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1320, 603);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ingresar / Modificar / Eliminar";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // txtSigno
            // 
            this.txtSigno.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSigno.Location = new System.Drawing.Point(779, 175);
            this.txtSigno.Name = "txtSigno";
            this.txtSigno.Size = new System.Drawing.Size(59, 27);
            this.txtSigno.TabIndex = 49;
            this.txtSigno.Tag = "signo";
            this.txtSigno.Visible = false;
            this.txtSigno.TextChanged += new System.EventHandler(this.txtSigno_TextChanged_1);
            // 
            // txtEstado
            // 
            this.txtEstado.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.Location = new System.Drawing.Point(779, 208);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(61, 27);
            this.txtEstado.TabIndex = 50;
            this.txtEstado.Tag = "estado";
            this.txtEstado.Visible = false;
            this.txtEstado.TextChanged += new System.EventHandler(this.txtEstado_TextChanged);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(141, 162);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcion.Size = new System.Drawing.Size(502, 121);
            this.txtDescripcion.TabIndex = 31;
            this.txtDescripcion.Tag = "descripcion";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(779, 30);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(239, 27);
            this.txtCantidad.TabIndex = 38;
            this.txtCantidad.Tag = "valor";
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged_1);
            // 
            // lblSigno
            // 
            this.lblSigno.AutoSize = true;
            this.lblSigno.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSigno.ForeColor = System.Drawing.Color.White;
            this.lblSigno.Location = new System.Drawing.Point(696, 81);
            this.lblSigno.Name = "lblSigno";
            this.lblSigno.Size = new System.Drawing.Size(53, 20);
            this.lblSigno.TabIndex = 51;
            this.lblSigno.Text = "Signo";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.White;
            this.lblDescripcion.Location = new System.Drawing.Point(15, 162);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(104, 20);
            this.lblDescripcion.TabIndex = 36;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdInactivo);
            this.groupBox1.Controls.Add(this.rdActivo);
            this.groupBox1.Location = new System.Drawing.Point(779, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 49);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            // 
            // rdActivo
            // 
            this.rdActivo.AutoSize = true;
            this.rdActivo.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdActivo.ForeColor = System.Drawing.Color.White;
            this.rdActivo.Location = new System.Drawing.Point(18, 17);
            this.rdActivo.Name = "rdActivo";
            this.rdActivo.Size = new System.Drawing.Size(80, 24);
            this.rdActivo.TabIndex = 21;
            this.rdActivo.TabStop = true;
            this.rdActivo.Text = "Activo";
            this.rdActivo.UseVisualStyleBackColor = true;
            this.rdActivo.CheckedChanged += new System.EventHandler(this.rdActivo_CheckedChanged_1);
            // 
            // rdInactivo
            // 
            this.rdInactivo.AutoSize = true;
            this.rdInactivo.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdInactivo.ForeColor = System.Drawing.Color.White;
            this.rdInactivo.Location = new System.Drawing.Point(133, 17);
            this.rdInactivo.Name = "rdInactivo";
            this.rdInactivo.Size = new System.Drawing.Size(92, 24);
            this.rdInactivo.TabIndex = 22;
            this.rdInactivo.TabStop = true;
            this.rdInactivo.Text = "Inactivo";
            this.rdInactivo.UseVisualStyleBackColor = true;
            this.rdInactivo.CheckedChanged += new System.EventHandler(this.rdInactivo_CheckedChanged_1);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdNegativo);
            this.groupBox4.Controls.Add(this.rdPositivo);
            this.groupBox4.Location = new System.Drawing.Point(779, 64);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(258, 47);
            this.groupBox4.TabIndex = 40;
            this.groupBox4.TabStop = false;
            // 
            // rdPositivo
            // 
            this.rdPositivo.AutoSize = true;
            this.rdPositivo.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdPositivo.ForeColor = System.Drawing.Color.White;
            this.rdPositivo.Location = new System.Drawing.Point(18, 13);
            this.rdPositivo.Name = "rdPositivo";
            this.rdPositivo.Size = new System.Drawing.Size(92, 24);
            this.rdPositivo.TabIndex = 21;
            this.rdPositivo.TabStop = true;
            this.rdPositivo.Text = "Positivo";
            this.rdPositivo.UseVisualStyleBackColor = true;
            this.rdPositivo.CheckedChanged += new System.EventHandler(this.rdPositivo_CheckedChanged_1);
            // 
            // rdNegativo
            // 
            this.rdNegativo.AutoSize = true;
            this.rdNegativo.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNegativo.ForeColor = System.Drawing.Color.White;
            this.rdNegativo.Location = new System.Drawing.Point(133, 17);
            this.rdNegativo.Name = "rdNegativo";
            this.rdNegativo.Size = new System.Drawing.Size(100, 24);
            this.rdNegativo.TabIndex = 22;
            this.rdNegativo.TabStop = true;
            this.rdNegativo.Text = "Negativo";
            this.rdNegativo.UseVisualStyleBackColor = true;
            this.rdNegativo.CheckedChanged += new System.EventHandler(this.rdNegativo_CheckedChanged_1);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.White;
            this.lblEstado.Location = new System.Drawing.Point(696, 138);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(62, 20);
            this.lblEstado.TabIndex = 37;
            this.lblEstado.Text = "Estado";
            // 
            // lblCantidadMonto
            // 
            this.lblCantidadMonto.AutoSize = true;
            this.lblCantidadMonto.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadMonto.ForeColor = System.Drawing.Color.White;
            this.lblCantidadMonto.Location = new System.Drawing.Point(696, 37);
            this.lblCantidadMonto.Name = "lblCantidadMonto";
            this.lblCantidadMonto.Size = new System.Drawing.Size(52, 20);
            this.lblCantidadMonto.TabIndex = 43;
            this.lblCantidadMonto.Text = "Valor";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(15, 64);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(73, 20);
            this.lblNombre.TabIndex = 35;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(141, 64);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(394, 27);
            this.txtNombre.TabIndex = 30;
            this.txtNombre.Tag = "tipoPercepcionDeduccion";
            this.txtNombre.Visible = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(954, 208);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(115, 27);
            this.txtCodigo.TabIndex = 29;
            this.txtCodigo.Tag = "idTipoPercepcionDeduccion";
            this.txtCodigo.Visible = false;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.White;
            this.lblCodigo.Location = new System.Drawing.Point(881, 215);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(67, 20);
            this.lblCodigo.TabIndex = 34;
            this.lblCodigo.Text = "Codigo";
            this.lblCodigo.Visible = false;
            // 
            // btnGuardarDatos
            // 
            this.btnGuardarDatos.Location = new System.Drawing.Point(1137, 96);
            this.btnGuardarDatos.Name = "btnGuardarDatos";
            this.btnGuardarDatos.Size = new System.Drawing.Size(177, 52);
            this.btnGuardarDatos.TabIndex = 58;
            this.btnGuardarDatos.Text = "Guardar";
            this.btnGuardarDatos.UseVisualStyleBackColor = true;
            this.btnGuardarDatos.Click += new System.EventHandler(this.btnGuardarDatos_Click);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Location = new System.Drawing.Point(1137, 162);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(177, 52);
            this.btnLimpiarCampos.TabIndex = 59;
            this.btnLimpiarCampos.Text = "Limpiar";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.Location = new System.Drawing.Point(1229, 17);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(74, 52);
            this.btnAyuda.TabIndex = 60;
            this.btnAyuda.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.groupBox5);
            this.groupBox6.Controls.Add(this.groupBox3);
            this.groupBox6.Controls.Add(this.groupBox2);
            this.groupBox6.Controls.Add(this.cmbOperacion);
            this.groupBox6.Controls.Add(this.txtValorFormula);
            this.groupBox6.Controls.Add(this.lblValorFormula);
            this.groupBox6.Controls.Add(this.lblOperacion);
            this.groupBox6.Controls.Add(this.lblFormula);
            this.groupBox6.Controls.Add(this.lblTipo);
            this.groupBox6.Controls.Add(this.dgvDatos);
            this.groupBox6.Controls.Add(this.btnRestaurarValoresFormula);
            this.groupBox6.Controls.Add(this.lblPercepcionDeduccion);
            this.groupBox6.Controls.Add(this.txtFormula);
            this.groupBox6.Controls.Add(this.btnAgregarFormula);
            this.groupBox6.Controls.Add(this.cmbPercepcionDeduccion1);
            this.groupBox6.Location = new System.Drawing.Point(19, 281);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1284, 316);
            this.groupBox6.TabIndex = 61;
            this.groupBox6.TabStop = false;
            // 
            // cmbPercepcionDeduccion1
            // 
            this.cmbPercepcionDeduccion1.FormattingEnabled = true;
            this.cmbPercepcionDeduccion1.Location = new System.Drawing.Point(122, 58);
            this.cmbPercepcionDeduccion1.Name = "cmbPercepcionDeduccion1";
            this.cmbPercepcionDeduccion1.Size = new System.Drawing.Size(204, 28);
            this.cmbPercepcionDeduccion1.TabIndex = 54;
            // 
            // btnAgregarFormula
            // 
            this.btnAgregarFormula.Location = new System.Drawing.Point(195, 250);
            this.btnAgregarFormula.Name = "btnAgregarFormula";
            this.btnAgregarFormula.Size = new System.Drawing.Size(177, 52);
            this.btnAgregarFormula.TabIndex = 52;
            this.btnAgregarFormula.Text = "Agregar Valores";
            this.btnAgregarFormula.UseVisualStyleBackColor = true;
            this.btnAgregarFormula.Click += new System.EventHandler(this.btnAgregarFormula_Click);
            // 
            // txtFormula
            // 
            this.txtFormula.Enabled = false;
            this.txtFormula.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFormula.Location = new System.Drawing.Point(122, 203);
            this.txtFormula.Name = "txtFormula";
            this.txtFormula.Size = new System.Drawing.Size(433, 27);
            this.txtFormula.TabIndex = 32;
            this.txtFormula.Tag = "formula";
            this.txtFormula.TextChanged += new System.EventHandler(this.txtFormula_TextChanged_1);
            this.txtFormula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFormula_KeyPress);
            // 
            // lblPercepcionDeduccion
            // 
            this.lblPercepcionDeduccion.AutoSize = true;
            this.lblPercepcionDeduccion.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercepcionDeduccion.ForeColor = System.Drawing.Color.White;
            this.lblPercepcionDeduccion.Location = new System.Drawing.Point(195, 23);
            this.lblPercepcionDeduccion.Name = "lblPercepcionDeduccion";
            this.lblPercepcionDeduccion.Size = new System.Drawing.Size(268, 20);
            this.lblPercepcionDeduccion.TabIndex = 53;
            this.lblPercepcionDeduccion.Text = "Formula Percepcion / Deduccion";
            // 
            // btnRestaurarValoresFormula
            // 
            this.btnRestaurarValoresFormula.Location = new System.Drawing.Point(378, 250);
            this.btnRestaurarValoresFormula.Name = "btnRestaurarValoresFormula";
            this.btnRestaurarValoresFormula.Size = new System.Drawing.Size(177, 52);
            this.btnRestaurarValoresFormula.TabIndex = 58;
            this.btnRestaurarValoresFormula.Text = "Borrar Formula";
            this.btnRestaurarValoresFormula.UseVisualStyleBackColor = true;
            this.btnRestaurarValoresFormula.Click += new System.EventHandler(this.btnRestaurarValoresFormula_Click);
            // 
            // dgvDatos
            // 
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(601, 32);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.Size = new System.Drawing.Size(677, 270);
            this.dgvDatos.TabIndex = 59;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.Color.White;
            this.lblTipo.Location = new System.Drawing.Point(18, 66);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(44, 20);
            this.lblTipo.TabIndex = 62;
            this.lblTipo.Text = "Tipo";
            // 
            // lblFormula
            // 
            this.lblFormula.AutoSize = true;
            this.lblFormula.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormula.ForeColor = System.Drawing.Color.White;
            this.lblFormula.Location = new System.Drawing.Point(17, 206);
            this.lblFormula.Name = "lblFormula";
            this.lblFormula.Size = new System.Drawing.Size(74, 20);
            this.lblFormula.TabIndex = 62;
            this.lblFormula.Text = "Formula";
            // 
            // lblOperacion
            // 
            this.lblOperacion.AutoSize = true;
            this.lblOperacion.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperacion.ForeColor = System.Drawing.Color.White;
            this.lblOperacion.Location = new System.Drawing.Point(19, 111);
            this.lblOperacion.Name = "lblOperacion";
            this.lblOperacion.Size = new System.Drawing.Size(93, 20);
            this.lblOperacion.TabIndex = 63;
            this.lblOperacion.Text = "Operacion";
            // 
            // lblValorFormula
            // 
            this.lblValorFormula.AutoSize = true;
            this.lblValorFormula.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorFormula.ForeColor = System.Drawing.Color.White;
            this.lblValorFormula.Location = new System.Drawing.Point(19, 156);
            this.lblValorFormula.Name = "lblValorFormula";
            this.lblValorFormula.Size = new System.Drawing.Size(52, 20);
            this.lblValorFormula.TabIndex = 64;
            this.lblValorFormula.Text = "Valor";
            // 
            // txtValorFormula
            // 
            this.txtValorFormula.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorFormula.Location = new System.Drawing.Point(122, 149);
            this.txtValorFormula.Name = "txtValorFormula";
            this.txtValorFormula.Size = new System.Drawing.Size(204, 27);
            this.txtValorFormula.TabIndex = 65;
            this.txtValorFormula.Tag = "tipoPercepcionDeduccion";
            // 
            // cmbOperacion
            // 
            this.cmbOperacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperacion.FormattingEnabled = true;
            this.cmbOperacion.Location = new System.Drawing.Point(122, 106);
            this.cmbOperacion.Name = "cmbOperacion";
            this.cmbOperacion.Size = new System.Drawing.Size(204, 28);
            this.cmbOperacion.TabIndex = 66;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdTipoNo);
            this.groupBox2.Controls.Add(this.rdTipoSi);
            this.groupBox2.Location = new System.Drawing.Point(339, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(138, 41);
            this.groupBox2.TabIndex = 70;
            this.groupBox2.TabStop = false;
            // 
            // rdTipoSi
            // 
            this.rdTipoSi.AutoSize = true;
            this.rdTipoSi.ForeColor = System.Drawing.Color.White;
            this.rdTipoSi.Location = new System.Drawing.Point(6, 13);
            this.rdTipoSi.Name = "rdTipoSi";
            this.rdTipoSi.Size = new System.Drawing.Size(44, 24);
            this.rdTipoSi.TabIndex = 67;
            this.rdTipoSi.TabStop = true;
            this.rdTipoSi.Text = "Si";
            this.rdTipoSi.UseVisualStyleBackColor = true;
            // 
            // rdTipoNo
            // 
            this.rdTipoNo.AutoSize = true;
            this.rdTipoNo.ForeColor = System.Drawing.Color.White;
            this.rdTipoNo.Location = new System.Drawing.Point(69, 13);
            this.rdTipoNo.Name = "rdTipoNo";
            this.rdTipoNo.Size = new System.Drawing.Size(52, 24);
            this.rdTipoNo.TabIndex = 68;
            this.rdTipoNo.TabStop = true;
            this.rdTipoNo.Text = "No";
            this.rdTipoNo.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdOperacionNo);
            this.groupBox3.Controls.Add(this.rdOperacionSi);
            this.groupBox3.Location = new System.Drawing.Point(339, 99);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(138, 41);
            this.groupBox3.TabIndex = 71;
            this.groupBox3.TabStop = false;
            // 
            // rdOperacionSi
            // 
            this.rdOperacionSi.AutoSize = true;
            this.rdOperacionSi.ForeColor = System.Drawing.Color.White;
            this.rdOperacionSi.Location = new System.Drawing.Point(6, 11);
            this.rdOperacionSi.Name = "rdOperacionSi";
            this.rdOperacionSi.Size = new System.Drawing.Size(44, 24);
            this.rdOperacionSi.TabIndex = 68;
            this.rdOperacionSi.TabStop = true;
            this.rdOperacionSi.Text = "Si";
            this.rdOperacionSi.UseVisualStyleBackColor = true;
            // 
            // rdOperacionNo
            // 
            this.rdOperacionNo.AutoSize = true;
            this.rdOperacionNo.ForeColor = System.Drawing.Color.White;
            this.rdOperacionNo.Location = new System.Drawing.Point(69, 12);
            this.rdOperacionNo.Name = "rdOperacionNo";
            this.rdOperacionNo.Size = new System.Drawing.Size(52, 24);
            this.rdOperacionNo.TabIndex = 69;
            this.rdOperacionNo.TabStop = true;
            this.rdOperacionNo.Text = "No";
            this.rdOperacionNo.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rdValorFormulaNo);
            this.groupBox5.Controls.Add(this.rdValorFormulaSi);
            this.groupBox5.Location = new System.Drawing.Point(339, 146);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(138, 41);
            this.groupBox5.TabIndex = 72;
            this.groupBox5.TabStop = false;
            // 
            // rdValorFormulaSi
            // 
            this.rdValorFormulaSi.AutoSize = true;
            this.rdValorFormulaSi.ForeColor = System.Drawing.Color.White;
            this.rdValorFormulaSi.Location = new System.Drawing.Point(6, 11);
            this.rdValorFormulaSi.Name = "rdValorFormulaSi";
            this.rdValorFormulaSi.Size = new System.Drawing.Size(44, 24);
            this.rdValorFormulaSi.TabIndex = 69;
            this.rdValorFormulaSi.TabStop = true;
            this.rdValorFormulaSi.Text = "Si";
            this.rdValorFormulaSi.UseVisualStyleBackColor = true;
            // 
            // rdValorFormulaNo
            // 
            this.rdValorFormulaNo.AutoSize = true;
            this.rdValorFormulaNo.ForeColor = System.Drawing.Color.White;
            this.rdValorFormulaNo.Location = new System.Drawing.Point(69, 11);
            this.rdValorFormulaNo.Name = "rdValorFormulaNo";
            this.rdValorFormulaNo.Size = new System.Drawing.Size(52, 24);
            this.rdValorFormulaNo.TabIndex = 70;
            this.rdValorFormulaNo.TabStop = true;
            this.rdValorFormulaNo.Text = "No";
            this.rdValorFormulaNo.UseVisualStyleBackColor = true;
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.rdEliminar);
            this.groupBox13.Controls.Add(this.rdModificar);
            this.groupBox13.Controls.Add(this.rdNuevo);
            this.groupBox13.Location = new System.Drawing.Point(19, 6);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(624, 47);
            this.groupBox13.TabIndex = 41;
            this.groupBox13.TabStop = false;
            // 
            // rdNuevo
            // 
            this.rdNuevo.AutoSize = true;
            this.rdNuevo.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNuevo.ForeColor = System.Drawing.Color.White;
            this.rdNuevo.Location = new System.Drawing.Point(18, 13);
            this.rdNuevo.Name = "rdNuevo";
            this.rdNuevo.Size = new System.Drawing.Size(146, 24);
            this.rdNuevo.TabIndex = 21;
            this.rdNuevo.TabStop = true;
            this.rdNuevo.Text = "NuevoRegistro";
            this.rdNuevo.UseVisualStyleBackColor = true;
            this.rdNuevo.CheckedChanged += new System.EventHandler(this.rdNuevo_CheckedChanged);
            // 
            // rdModificar
            // 
            this.rdModificar.AutoSize = true;
            this.rdModificar.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdModificar.ForeColor = System.Drawing.Color.White;
            this.rdModificar.Location = new System.Drawing.Point(195, 13);
            this.rdModificar.Name = "rdModificar";
            this.rdModificar.Size = new System.Drawing.Size(174, 24);
            this.rdModificar.TabIndex = 22;
            this.rdModificar.TabStop = true;
            this.rdModificar.Text = "Modificar Registro";
            this.rdModificar.UseVisualStyleBackColor = true;
            this.rdModificar.CheckedChanged += new System.EventHandler(this.rdModificar_CheckedChanged);
            // 
            // cmbPercepcionModificar
            // 
            this.cmbPercepcionModificar.FormattingEnabled = true;
            this.cmbPercepcionModificar.Location = new System.Drawing.Point(141, 65);
            this.cmbPercepcionModificar.Name = "cmbPercepcionModificar";
            this.cmbPercepcionModificar.Size = new System.Drawing.Size(394, 28);
            this.cmbPercepcionModificar.TabIndex = 73;
            this.cmbPercepcionModificar.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(541, 64);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(102, 29);
            this.btnBuscar.TabIndex = 74;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Visible = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblNuevoNombre
            // 
            this.lblNuevoNombre.AutoSize = true;
            this.lblNuevoNombre.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevoNombre.ForeColor = System.Drawing.Color.White;
            this.lblNuevoNombre.Location = new System.Drawing.Point(17, 117);
            this.lblNuevoNombre.Name = "lblNuevoNombre";
            this.lblNuevoNombre.Size = new System.Drawing.Size(128, 20);
            this.lblNuevoNombre.TabIndex = 75;
            this.lblNuevoNombre.Text = "Nuevo Nombre";
            this.lblNuevoNombre.Visible = false;
            // 
            // txtNuevoNombre
            // 
            this.txtNuevoNombre.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNuevoNombre.Location = new System.Drawing.Point(141, 114);
            this.txtNuevoNombre.Name = "txtNuevoNombre";
            this.txtNuevoNombre.Size = new System.Drawing.Size(394, 27);
            this.txtNuevoNombre.TabIndex = 76;
            this.txtNuevoNombre.Tag = "tipoPercepcionDeduccion";
            this.txtNuevoNombre.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(23, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1328, 636);
            this.tabControl1.TabIndex = 59;
            // 
            // rdEliminar
            // 
            this.rdEliminar.AutoSize = true;
            this.rdEliminar.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdEliminar.ForeColor = System.Drawing.Color.White;
            this.rdEliminar.Location = new System.Drawing.Point(392, 13);
            this.rdEliminar.Name = "rdEliminar";
            this.rdEliminar.Size = new System.Drawing.Size(166, 24);
            this.rdEliminar.TabIndex = 23;
            this.rdEliminar.TabStop = true;
            this.rdEliminar.Text = "Eliminar Registro";
            this.rdEliminar.UseVisualStyleBackColor = true;
            this.rdEliminar.CheckedChanged += new System.EventHandler(this.rdEliminar_CheckedChanged);
            // 
            // frmPercepcionesFiscales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(1374, 660);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.Name = "frmPercepcionesFiscales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento Percepciones";
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtNuevoNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtSigno;
        private System.Windows.Forms.Label lblNuevoNombre;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cmbPercepcionModificar;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.RadioButton rdEliminar;
        private System.Windows.Forms.RadioButton rdModificar;
        private System.Windows.Forms.RadioButton rdNuevo;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rdValorFormulaNo;
        private System.Windows.Forms.RadioButton rdValorFormulaSi;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdOperacionNo;
        private System.Windows.Forms.RadioButton rdOperacionSi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdTipoNo;
        private System.Windows.Forms.RadioButton rdTipoSi;
        private System.Windows.Forms.ComboBox cmbOperacion;
        private System.Windows.Forms.TextBox txtValorFormula;
        private System.Windows.Forms.Label lblValorFormula;
        private System.Windows.Forms.Label lblOperacion;
        private System.Windows.Forms.Label lblFormula;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Button btnRestaurarValoresFormula;
        private System.Windows.Forms.Label lblPercepcionDeduccion;
        private System.Windows.Forms.TextBox txtFormula;
        private System.Windows.Forms.Button btnAgregarFormula;
        private System.Windows.Forms.ComboBox cmbPercepcionDeduccion1;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Button btnGuardarDatos;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCantidadMonto;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdNegativo;
        private System.Windows.Forms.RadioButton rdPositivo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdInactivo;
        private System.Windows.Forms.RadioButton rdActivo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblSigno;
        private System.Windows.Forms.TabControl tabControl1;
    }
}