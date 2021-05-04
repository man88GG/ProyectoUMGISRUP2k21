
    namespace CapaVistaHRM.Manuel.Procesos
{
    partial class frmEntrevista
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
            this.tbcEntrevista = new System.Windows.Forms.TabControl();
            this.tbpDatosRecluta = new System.Windows.Forms.TabPage();
            this.btnReclutas = new System.Windows.Forms.Button();
            this.lblIngreseIdRecluta = new System.Windows.Forms.Label();
            this.txtIdBancoTalento = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.pnlPuesto = new System.Windows.Forms.Panel();
            this.lblHorario = new System.Windows.Forms.Label();
            this.cmbHorario = new System.Windows.Forms.ComboBox();
            this.cmbDepartamentoTrabajo = new System.Windows.Forms.ComboBox();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.cmbPuestoTrabajo = new System.Windows.Forms.ComboBox();
            this.lblDepartamentoTrabajo = new System.Windows.Forms.Label();
            this.pnlDatosGenerales = new System.Windows.Forms.Panel();
            this.txtPrimerApellido = new System.Windows.Forms.TextBox();
            this.txtPrimerNombre = new System.Windows.Forms.TextBox();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.tbpDatosEntrevista = new System.Windows.Forms.TabPage();
            this.gbxDatosEntrevista = new System.Windows.Forms.GroupBox();
            this.pnlOpciones = new System.Windows.Forms.Panel();
            this.rbtnSegOpcion = new System.Windows.Forms.RadioButton();
            this.rbtnPrimeraOp = new System.Windows.Forms.RadioButton();
            this.btnIngresoEntrevista = new System.Windows.Forms.Button();
            this.rtxtComentarios = new System.Windows.Forms.RichTextBox();
            this.lblComentarios = new System.Windows.Forms.Label();
            this.cmbTipoEntrevista = new System.Windows.Forms.ComboBox();
            this.lblResultadoEntrevista = new System.Windows.Forms.Label();
            this.lblTipoEntrevista = new System.Windows.Forms.Label();
            this.rbtnAprobado = new System.Windows.Forms.RadioButton();
            this.rbtnReprobado = new System.Windows.Forms.RadioButton();
            this.lblPunteoEntrevista = new System.Windows.Forms.Label();
            this.txtPunteo = new System.Windows.Forms.TextBox();
            this.tbcEntrevista.SuspendLayout();
            this.tbpDatosRecluta.SuspendLayout();
            this.pnlPuesto.SuspendLayout();
            this.pnlDatosGenerales.SuspendLayout();
            this.tbpDatosEntrevista.SuspendLayout();
            this.gbxDatosEntrevista.SuspendLayout();
            this.pnlOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcEntrevista
            // 
            this.tbcEntrevista.Controls.Add(this.tbpDatosRecluta);
            this.tbcEntrevista.Controls.Add(this.tbpDatosEntrevista);
            this.tbcEntrevista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcEntrevista.Location = new System.Drawing.Point(0, 0);
            this.tbcEntrevista.Name = "tbcEntrevista";
            this.tbcEntrevista.SelectedIndex = 0;
            this.tbcEntrevista.Size = new System.Drawing.Size(829, 459);
            this.tbcEntrevista.TabIndex = 0;
            // 
            // tbpDatosRecluta
            // 
            this.tbpDatosRecluta.BackColor = System.Drawing.Color.Purple;
            this.tbpDatosRecluta.Controls.Add(this.btnReclutas);
            this.tbpDatosRecluta.Controls.Add(this.lblIngreseIdRecluta);
            this.tbpDatosRecluta.Controls.Add(this.txtIdBancoTalento);
            this.tbpDatosRecluta.Controls.Add(this.btnBuscar);
            this.tbpDatosRecluta.Controls.Add(this.pnlPuesto);
            this.tbpDatosRecluta.Controls.Add(this.pnlDatosGenerales);
            this.tbpDatosRecluta.Location = new System.Drawing.Point(4, 29);
            this.tbpDatosRecluta.Name = "tbpDatosRecluta";
            this.tbpDatosRecluta.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDatosRecluta.Size = new System.Drawing.Size(821, 426);
            this.tbpDatosRecluta.TabIndex = 0;
            this.tbpDatosRecluta.Text = "Datos Recluta";
            // 
            // btnReclutas
            // 
            this.btnReclutas.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReclutas.Location = new System.Drawing.Point(28, 334);
            this.btnReclutas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReclutas.Name = "btnReclutas";
            this.btnReclutas.Size = new System.Drawing.Size(184, 76);
            this.btnReclutas.TabIndex = 35;
            this.btnReclutas.Text = "Ver Lista Reclutas No Entrevistados";
            this.btnReclutas.UseVisualStyleBackColor = true;
            this.btnReclutas.Click += new System.EventHandler(this.btnReclutas_Click);
            // 
            // lblIngreseIdRecluta
            // 
            this.lblIngreseIdRecluta.AutoSize = true;
            this.lblIngreseIdRecluta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblIngreseIdRecluta.Location = new System.Drawing.Point(75, 62);
            this.lblIngreseIdRecluta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIngreseIdRecluta.Name = "lblIngreseIdRecluta";
            this.lblIngreseIdRecluta.Size = new System.Drawing.Size(200, 20);
            this.lblIngreseIdRecluta.TabIndex = 34;
            this.lblIngreseIdRecluta.Text = "Ingrese el ID del Recluta";
            // 
            // txtIdBancoTalento
            // 
            this.txtIdBancoTalento.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtIdBancoTalento.Location = new System.Drawing.Point(319, 59);
            this.txtIdBancoTalento.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdBancoTalento.Name = "txtIdBancoTalento";
            this.txtIdBancoTalento.Size = new System.Drawing.Size(184, 27);
            this.txtIdBancoTalento.TabIndex = 33;
            this.txtIdBancoTalento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcNumero);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(536, 53);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(119, 38);
            this.btnBuscar.TabIndex = 30;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // pnlPuesto
            // 
            this.pnlPuesto.Controls.Add(this.lblHorario);
            this.pnlPuesto.Controls.Add(this.cmbHorario);
            this.pnlPuesto.Controls.Add(this.cmbDepartamentoTrabajo);
            this.pnlPuesto.Controls.Add(this.lblPuesto);
            this.pnlPuesto.Controls.Add(this.cmbPuestoTrabajo);
            this.pnlPuesto.Controls.Add(this.lblDepartamentoTrabajo);
            this.pnlPuesto.Enabled = false;
            this.pnlPuesto.Location = new System.Drawing.Point(519, 150);
            this.pnlPuesto.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pnlPuesto.Name = "pnlPuesto";
            this.pnlPuesto.Size = new System.Drawing.Size(264, 219);
            this.pnlPuesto.TabIndex = 32;
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHorario.Location = new System.Drawing.Point(5, 159);
            this.lblHorario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(157, 20);
            this.lblHorario.TabIndex = 36;
            this.lblHorario.Text = "Horario que Aplica";
            // 
            // cmbHorario
            // 
            this.cmbHorario.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbHorario.Enabled = false;
            this.cmbHorario.FormattingEnabled = true;
            this.cmbHorario.Location = new System.Drawing.Point(9, 183);
            this.cmbHorario.Margin = new System.Windows.Forms.Padding(4);
            this.cmbHorario.Name = "cmbHorario";
            this.cmbHorario.Size = new System.Drawing.Size(242, 28);
            this.cmbHorario.TabIndex = 36;
            // 
            // cmbDepartamentoTrabajo
            // 
            this.cmbDepartamentoTrabajo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbDepartamentoTrabajo.Enabled = false;
            this.cmbDepartamentoTrabajo.FormattingEnabled = true;
            this.cmbDepartamentoTrabajo.Location = new System.Drawing.Point(9, 112);
            this.cmbDepartamentoTrabajo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDepartamentoTrabajo.Name = "cmbDepartamentoTrabajo";
            this.cmbDepartamentoTrabajo.Size = new System.Drawing.Size(242, 28);
            this.cmbDepartamentoTrabajo.TabIndex = 35;
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuesto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPuesto.Location = new System.Drawing.Point(4, 15);
            this.lblPuesto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(150, 20);
            this.lblPuesto.TabIndex = 19;
            this.lblPuesto.Text = "Puesto que Aplica";
            // 
            // cmbPuestoTrabajo
            // 
            this.cmbPuestoTrabajo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbPuestoTrabajo.Enabled = false;
            this.cmbPuestoTrabajo.FormattingEnabled = true;
            this.cmbPuestoTrabajo.Location = new System.Drawing.Point(9, 41);
            this.cmbPuestoTrabajo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPuestoTrabajo.Name = "cmbPuestoTrabajo";
            this.cmbPuestoTrabajo.Size = new System.Drawing.Size(242, 28);
            this.cmbPuestoTrabajo.TabIndex = 29;
            // 
            // lblDepartamentoTrabajo
            // 
            this.lblDepartamentoTrabajo.AutoSize = true;
            this.lblDepartamentoTrabajo.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamentoTrabajo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDepartamentoTrabajo.Location = new System.Drawing.Point(4, 84);
            this.lblDepartamentoTrabajo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepartamentoTrabajo.Name = "lblDepartamentoTrabajo";
            this.lblDepartamentoTrabajo.Size = new System.Drawing.Size(209, 20);
            this.lblDepartamentoTrabajo.TabIndex = 18;
            this.lblDepartamentoTrabajo.Text = "Departamento que Aplica";
            // 
            // pnlDatosGenerales
            // 
            this.pnlDatosGenerales.Controls.Add(this.txtPrimerApellido);
            this.pnlDatosGenerales.Controls.Add(this.txtPrimerNombre);
            this.pnlDatosGenerales.Controls.Add(this.lblNombres);
            this.pnlDatosGenerales.Controls.Add(this.lblApellidos);
            this.pnlDatosGenerales.Enabled = false;
            this.pnlDatosGenerales.Location = new System.Drawing.Point(28, 150);
            this.pnlDatosGenerales.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pnlDatosGenerales.Name = "pnlDatosGenerales";
            this.pnlDatosGenerales.Size = new System.Drawing.Size(441, 123);
            this.pnlDatosGenerales.TabIndex = 31;
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPrimerApellido.Enabled = false;
            this.txtPrimerApellido.Location = new System.Drawing.Point(197, 75);
            this.txtPrimerApellido.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.Size = new System.Drawing.Size(229, 27);
            this.txtPrimerApellido.TabIndex = 7;
            // 
            // txtPrimerNombre
            // 
            this.txtPrimerNombre.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPrimerNombre.Enabled = false;
            this.txtPrimerNombre.Location = new System.Drawing.Point(197, 22);
            this.txtPrimerNombre.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtPrimerNombre.Name = "txtPrimerNombre";
            this.txtPrimerNombre.Size = new System.Drawing.Size(229, 27);
            this.txtPrimerNombre.TabIndex = 5;
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombres.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNombres.Location = new System.Drawing.Point(16, 22);
            this.lblNombres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(81, 20);
            this.lblNombres.TabIndex = 1;
            this.lblNombres.Text = "Nombres";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblApellidos.Location = new System.Drawing.Point(16, 78);
            this.lblApellidos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(84, 20);
            this.lblApellidos.TabIndex = 3;
            this.lblApellidos.Text = "Apellidos";
            // 
            // tbpDatosEntrevista
            // 
            this.tbpDatosEntrevista.BackColor = System.Drawing.Color.Purple;
            this.tbpDatosEntrevista.Controls.Add(this.gbxDatosEntrevista);
            this.tbpDatosEntrevista.Location = new System.Drawing.Point(4, 29);
            this.tbpDatosEntrevista.Name = "tbpDatosEntrevista";
            this.tbpDatosEntrevista.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDatosEntrevista.Size = new System.Drawing.Size(821, 426);
            this.tbpDatosEntrevista.TabIndex = 1;
            this.tbpDatosEntrevista.Text = "Datos Entrevista";
            // 
            // gbxDatosEntrevista
            // 
            this.gbxDatosEntrevista.BackColor = System.Drawing.Color.Purple;
            this.gbxDatosEntrevista.Controls.Add(this.txtPunteo);
            this.gbxDatosEntrevista.Controls.Add(this.lblPunteoEntrevista);
            this.gbxDatosEntrevista.Controls.Add(this.pnlOpciones);
            this.gbxDatosEntrevista.Controls.Add(this.rbtnReprobado);
            this.gbxDatosEntrevista.Controls.Add(this.rbtnAprobado);
            this.gbxDatosEntrevista.Controls.Add(this.btnIngresoEntrevista);
            this.gbxDatosEntrevista.Controls.Add(this.rtxtComentarios);
            this.gbxDatosEntrevista.Controls.Add(this.lblComentarios);
            this.gbxDatosEntrevista.Controls.Add(this.cmbTipoEntrevista);
            this.gbxDatosEntrevista.Controls.Add(this.lblResultadoEntrevista);
            this.gbxDatosEntrevista.Controls.Add(this.lblTipoEntrevista);
            this.gbxDatosEntrevista.Enabled = false;
            this.gbxDatosEntrevista.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbxDatosEntrevista.Location = new System.Drawing.Point(8, 23);
            this.gbxDatosEntrevista.Name = "gbxDatosEntrevista";
            this.gbxDatosEntrevista.Size = new System.Drawing.Size(809, 398);
            this.gbxDatosEntrevista.TabIndex = 10;
            this.gbxDatosEntrevista.TabStop = false;
            this.gbxDatosEntrevista.Text = "Datos de Entrevista";
            // 
            // pnlOpciones
            // 
            this.pnlOpciones.Controls.Add(this.rbtnSegOpcion);
            this.pnlOpciones.Controls.Add(this.rbtnPrimeraOp);
            this.pnlOpciones.Enabled = false;
            this.pnlOpciones.Location = new System.Drawing.Point(546, 125);
            this.pnlOpciones.Name = "pnlOpciones";
            this.pnlOpciones.Size = new System.Drawing.Size(259, 80);
            this.pnlOpciones.TabIndex = 13;
            // 
            // rbtnSegOpcion
            // 
            this.rbtnSegOpcion.AutoSize = true;
            this.rbtnSegOpcion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbtnSegOpcion.Location = new System.Drawing.Point(3, 47);
            this.rbtnSegOpcion.Name = "rbtnSegOpcion";
            this.rbtnSegOpcion.Size = new System.Drawing.Size(252, 24);
            this.rbtnSegOpcion.TabIndex = 1;
            this.rbtnSegOpcion.TabStop = true;
            this.rbtnSegOpcion.Text = "Segunda Opción a Contratar";
            this.rbtnSegOpcion.UseVisualStyleBackColor = true;
            this.rbtnSegOpcion.CheckedChanged += new System.EventHandler(this.rbtnSegOpcion_CheckedChanged);
            // 
            // rbtnPrimeraOp
            // 
            this.rbtnPrimeraOp.AutoSize = true;
            this.rbtnPrimeraOp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbtnPrimeraOp.Location = new System.Drawing.Point(4, 12);
            this.rbtnPrimeraOp.Name = "rbtnPrimeraOp";
            this.rbtnPrimeraOp.Size = new System.Drawing.Size(247, 24);
            this.rbtnPrimeraOp.TabIndex = 0;
            this.rbtnPrimeraOp.TabStop = true;
            this.rbtnPrimeraOp.Text = "Primera Opción a Contratar";
            this.rbtnPrimeraOp.UseVisualStyleBackColor = true;
            this.rbtnPrimeraOp.CheckedChanged += new System.EventHandler(this.rbtnPrimeraOp_CheckedChanged);
            // 
            // btnIngresoEntrevista
            // 
            this.btnIngresoEntrevista.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnIngresoEntrevista.Location = new System.Drawing.Point(634, 16);
            this.btnIngresoEntrevista.Name = "btnIngresoEntrevista";
            this.btnIngresoEntrevista.Size = new System.Drawing.Size(171, 57);
            this.btnIngresoEntrevista.TabIndex = 8;
            this.btnIngresoEntrevista.Text = "Ingresar Entrevista";
            this.btnIngresoEntrevista.UseVisualStyleBackColor = true;
            this.btnIngresoEntrevista.Click += new System.EventHandler(this.btnIngresoEntrevista_Click);
            // 
            // rtxtComentarios
            // 
            this.rtxtComentarios.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.rtxtComentarios.Location = new System.Drawing.Point(12, 210);
            this.rtxtComentarios.Name = "rtxtComentarios";
            this.rtxtComentarios.Size = new System.Drawing.Size(793, 183);
            this.rtxtComentarios.TabIndex = 2;
            this.rtxtComentarios.Text = "";
            // 
            // lblComentarios
            // 
            this.lblComentarios.AutoSize = true;
            this.lblComentarios.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblComentarios.Location = new System.Drawing.Point(8, 176);
            this.lblComentarios.Name = "lblComentarios";
            this.lblComentarios.Size = new System.Drawing.Size(250, 20);
            this.lblComentarios.TabIndex = 3;
            this.lblComentarios.Text = "Comentarios del Entrevistador";
            // 
            // cmbTipoEntrevista
            // 
            this.cmbTipoEntrevista.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbTipoEntrevista.FormattingEnabled = true;
            this.cmbTipoEntrevista.Location = new System.Drawing.Point(207, 26);
            this.cmbTipoEntrevista.Name = "cmbTipoEntrevista";
            this.cmbTipoEntrevista.Size = new System.Drawing.Size(149, 28);
            this.cmbTipoEntrevista.TabIndex = 7;
            // 
            // lblResultadoEntrevista
            // 
            this.lblResultadoEntrevista.AutoSize = true;
            this.lblResultadoEntrevista.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblResultadoEntrevista.Location = new System.Drawing.Point(8, 123);
            this.lblResultadoEntrevista.Name = "lblResultadoEntrevista";
            this.lblResultadoEntrevista.Size = new System.Drawing.Size(211, 20);
            this.lblResultadoEntrevista.TabIndex = 4;
            this.lblResultadoEntrevista.Text = "Resultado de la Entrevista";
            // 
            // lblTipoEntrevista
            // 
            this.lblTipoEntrevista.AutoSize = true;
            this.lblTipoEntrevista.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTipoEntrevista.Location = new System.Drawing.Point(6, 34);
            this.lblTipoEntrevista.Name = "lblTipoEntrevista";
            this.lblTipoEntrevista.Size = new System.Drawing.Size(127, 20);
            this.lblTipoEntrevista.TabIndex = 6;
            this.lblTipoEntrevista.Text = "Tipo Entrevista";
            // 
            // rbtnAprobado
            // 
            this.rbtnAprobado.AutoSize = true;
            this.rbtnAprobado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbtnAprobado.Location = new System.Drawing.Point(250, 121);
            this.rbtnAprobado.Name = "rbtnAprobado";
            this.rbtnAprobado.Size = new System.Drawing.Size(108, 24);
            this.rbtnAprobado.TabIndex = 9;
            this.rbtnAprobado.TabStop = true;
            this.rbtnAprobado.Text = "Aprobado";
            this.rbtnAprobado.UseVisualStyleBackColor = true;
            this.rbtnAprobado.CheckedChanged += new System.EventHandler(this.rbtnAprobado_CheckedChanged);
            // 
            // rbtnReprobado
            // 
            this.rbtnReprobado.AutoSize = true;
            this.rbtnReprobado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbtnReprobado.Location = new System.Drawing.Point(394, 119);
            this.rbtnReprobado.Name = "rbtnReprobado";
            this.rbtnReprobado.Size = new System.Drawing.Size(116, 24);
            this.rbtnReprobado.TabIndex = 10;
            this.rbtnReprobado.TabStop = true;
            this.rbtnReprobado.Text = "Reprobado";
            this.rbtnReprobado.UseVisualStyleBackColor = true;
            this.rbtnReprobado.CheckedChanged += new System.EventHandler(this.rbtnReprobado_CheckedChanged);
            // 
            // lblPunteoEntrevista
            // 
            this.lblPunteoEntrevista.AutoSize = true;
            this.lblPunteoEntrevista.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPunteoEntrevista.Location = new System.Drawing.Point(6, 79);
            this.lblPunteoEntrevista.Name = "lblPunteoEntrevista";
            this.lblPunteoEntrevista.Size = new System.Drawing.Size(189, 20);
            this.lblPunteoEntrevista.TabIndex = 14;
            this.lblPunteoEntrevista.Text = "Punteo de la Entrevista";
            // 
            // txtPunteo
            // 
            this.txtPunteo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPunteo.Location = new System.Drawing.Point(207, 72);
            this.txtPunteo.Name = "txtPunteo";
            this.txtPunteo.Size = new System.Drawing.Size(128, 27);
            this.txtPunteo.TabIndex = 15;
            // 
            // frmEntrevista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(829, 459);
            this.Controls.Add(this.tbcEntrevista);
            this.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEntrevista";
            this.Text = "Entrevista";
            this.Load += new System.EventHandler(this.frmEntrevista_Load);
            this.tbcEntrevista.ResumeLayout(false);
            this.tbpDatosRecluta.ResumeLayout(false);
            this.tbpDatosRecluta.PerformLayout();
            this.pnlPuesto.ResumeLayout(false);
            this.pnlPuesto.PerformLayout();
            this.pnlDatosGenerales.ResumeLayout(false);
            this.pnlDatosGenerales.PerformLayout();
            this.tbpDatosEntrevista.ResumeLayout(false);
            this.gbxDatosEntrevista.ResumeLayout(false);
            this.gbxDatosEntrevista.PerformLayout();
            this.pnlOpciones.ResumeLayout(false);
            this.pnlOpciones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcEntrevista;
        private System.Windows.Forms.TabPage tbpDatosRecluta;
        private System.Windows.Forms.TabPage tbpDatosEntrevista;
        private System.Windows.Forms.GroupBox gbxDatosEntrevista;
        private System.Windows.Forms.RichTextBox rtxtComentarios;
        private System.Windows.Forms.Label lblComentarios;
        private System.Windows.Forms.ComboBox cmbTipoEntrevista;
        private System.Windows.Forms.Label lblResultadoEntrevista;
        private System.Windows.Forms.Label lblTipoEntrevista;
        private System.Windows.Forms.Label lblIngreseIdRecluta;
        private System.Windows.Forms.TextBox txtIdBancoTalento;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.ComboBox cmbPuestoTrabajo;
        private System.Windows.Forms.Label lblDepartamentoTrabajo;
        private System.Windows.Forms.Panel pnlPuesto;
        private System.Windows.Forms.Panel pnlDatosGenerales;
        private System.Windows.Forms.TextBox txtPrimerApellido;
        private System.Windows.Forms.TextBox txtPrimerNombre;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Button btnIngresoEntrevista;
        private System.Windows.Forms.ComboBox cmbDepartamentoTrabajo;
        private System.Windows.Forms.Button btnReclutas;
        private System.Windows.Forms.Panel pnlOpciones;
        private System.Windows.Forms.RadioButton rbtnSegOpcion;
        private System.Windows.Forms.RadioButton rbtnPrimeraOp;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.ComboBox cmbHorario;
        private System.Windows.Forms.TextBox txtPunteo;
        private System.Windows.Forms.Label lblPunteoEntrevista;
        private System.Windows.Forms.RadioButton rbtnReprobado;
        private System.Windows.Forms.RadioButton rbtnAprobado;
    }
}