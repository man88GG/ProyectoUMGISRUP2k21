
namespace PrototipoNoFuncional
{
    partial class frmAscensos
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
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.pnlAscensos = new System.Windows.Forms.Panel();
            this.txtIdEmpleado = new System.Windows.Forms.TextBox();
            this.pnlDatosGenerales = new System.Windows.Forms.Panel();
            this.txtPrimerApellido = new System.Windows.Forms.TextBox();
            this.txtPrimerNombre = new System.Windows.Forms.TextBox();
            this.lblPrimerNombre = new System.Windows.Forms.Label();
            this.lblPrimerApellido = new System.Windows.Forms.Label();
            this.gbxAntiguoCargo = new System.Windows.Forms.GroupBox();
            this.cmbDepartamentoAnterior = new System.Windows.Forms.ComboBox();
            this.lblPuestoAnterior = new System.Windows.Forms.Label();
            this.lblDepartamentoTrabajoAnterior = new System.Windows.Forms.Label();
            this.cmbPuestoAnterior = new System.Windows.Forms.ComboBox();
            this.gbxNuevoCargo = new System.Windows.Forms.GroupBox();
            this.cmbDepartamentoNuevo = new System.Windows.Forms.ComboBox();
            this.lblPuestoNuevo = new System.Windows.Forms.Label();
            this.cmbPuestoNuevo = new System.Windows.Forms.ComboBox();
            this.lblDepartamentoNuevo = new System.Windows.Forms.Label();
            this.lblIngreseIdEmpleado = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAscender = new System.Windows.Forms.Button();
            this.pnlAscensos.SuspendLayout();
            this.pnlDatosGenerales.SuspendLayout();
            this.gbxAntiguoCargo.SuspendLayout();
            this.gbxNuevoCargo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.Location = new System.Drawing.Point(24, 375);
            this.btnEmpleados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(173, 68);
            this.btnEmpleados.TabIndex = 35;
            this.btnEmpleados.Text = "Ver Lista Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = true;
            // 
            // pnlAscensos
            // 
            this.pnlAscensos.Controls.Add(this.txtIdEmpleado);
            this.pnlAscensos.Controls.Add(this.pnlDatosGenerales);
            this.pnlAscensos.Controls.Add(this.gbxAntiguoCargo);
            this.pnlAscensos.Controls.Add(this.gbxNuevoCargo);
            this.pnlAscensos.Controls.Add(this.lblIngreseIdEmpleado);
            this.pnlAscensos.Controls.Add(this.btnBuscar);
            this.pnlAscensos.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlAscensos.Location = new System.Drawing.Point(24, 21);
            this.pnlAscensos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlAscensos.Name = "pnlAscensos";
            this.pnlAscensos.Size = new System.Drawing.Size(893, 343);
            this.pnlAscensos.TabIndex = 34;
            // 
            // txtIdEmpleado
            // 
            this.txtIdEmpleado.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtIdEmpleado.Location = new System.Drawing.Point(423, 34);
            this.txtIdEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdEmpleado.Name = "txtIdEmpleado";
            this.txtIdEmpleado.Size = new System.Drawing.Size(148, 27);
            this.txtIdEmpleado.TabIndex = 26;
            // 
            // pnlDatosGenerales
            // 
            this.pnlDatosGenerales.Controls.Add(this.txtPrimerApellido);
            this.pnlDatosGenerales.Controls.Add(this.txtPrimerNombre);
            this.pnlDatosGenerales.Controls.Add(this.lblPrimerNombre);
            this.pnlDatosGenerales.Controls.Add(this.lblPrimerApellido);
            this.pnlDatosGenerales.Enabled = false;
            this.pnlDatosGenerales.Location = new System.Drawing.Point(11, 94);
            this.pnlDatosGenerales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlDatosGenerales.Name = "pnlDatosGenerales";
            this.pnlDatosGenerales.Size = new System.Drawing.Size(417, 120);
            this.pnlDatosGenerales.TabIndex = 22;
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPrimerApellido.Location = new System.Drawing.Point(117, 60);
            this.txtPrimerApellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.Size = new System.Drawing.Size(297, 27);
            this.txtPrimerApellido.TabIndex = 7;
            // 
            // txtPrimerNombre
            // 
            this.txtPrimerNombre.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPrimerNombre.Location = new System.Drawing.Point(117, 15);
            this.txtPrimerNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrimerNombre.Name = "txtPrimerNombre";
            this.txtPrimerNombre.Size = new System.Drawing.Size(297, 27);
            this.txtPrimerNombre.TabIndex = 5;
            // 
            // lblPrimerNombre
            // 
            this.lblPrimerNombre.AutoSize = true;
            this.lblPrimerNombre.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimerNombre.Location = new System.Drawing.Point(13, 18);
            this.lblPrimerNombre.Name = "lblPrimerNombre";
            this.lblPrimerNombre.Size = new System.Drawing.Size(73, 20);
            this.lblPrimerNombre.TabIndex = 1;
            this.lblPrimerNombre.Text = "Nombre";
            // 
            // lblPrimerApellido
            // 
            this.lblPrimerApellido.AutoSize = true;
            this.lblPrimerApellido.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimerApellido.Location = new System.Drawing.Point(13, 64);
            this.lblPrimerApellido.Name = "lblPrimerApellido";
            this.lblPrimerApellido.Size = new System.Drawing.Size(80, 20);
            this.lblPrimerApellido.TabIndex = 3;
            this.lblPrimerApellido.Text = "Apellido ";
            // 
            // gbxAntiguoCargo
            // 
            this.gbxAntiguoCargo.Controls.Add(this.cmbDepartamentoAnterior);
            this.gbxAntiguoCargo.Controls.Add(this.lblPuestoAnterior);
            this.gbxAntiguoCargo.Controls.Add(this.lblDepartamentoTrabajoAnterior);
            this.gbxAntiguoCargo.Controls.Add(this.cmbPuestoAnterior);
            this.gbxAntiguoCargo.Enabled = false;
            this.gbxAntiguoCargo.Location = new System.Drawing.Point(459, 89);
            this.gbxAntiguoCargo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxAntiguoCargo.Name = "gbxAntiguoCargo";
            this.gbxAntiguoCargo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxAntiguoCargo.Size = new System.Drawing.Size(193, 198);
            this.gbxAntiguoCargo.TabIndex = 29;
            this.gbxAntiguoCargo.TabStop = false;
            this.gbxAntiguoCargo.Text = "Antiguo Cargo";
            // 
            // cmbDepartamentoAnterior
            // 
            this.cmbDepartamentoAnterior.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbDepartamentoAnterior.FormattingEnabled = true;
            this.cmbDepartamentoAnterior.Location = new System.Drawing.Point(5, 150);
            this.cmbDepartamentoAnterior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDepartamentoAnterior.Name = "cmbDepartamentoAnterior";
            this.cmbDepartamentoAnterior.Size = new System.Drawing.Size(175, 28);
            this.cmbDepartamentoAnterior.TabIndex = 30;
            // 
            // lblPuestoAnterior
            // 
            this.lblPuestoAnterior.AutoSize = true;
            this.lblPuestoAnterior.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuestoAnterior.Location = new System.Drawing.Point(5, 34);
            this.lblPuestoAnterior.Name = "lblPuestoAnterior";
            this.lblPuestoAnterior.Size = new System.Drawing.Size(62, 20);
            this.lblPuestoAnterior.TabIndex = 19;
            this.lblPuestoAnterior.Text = "Puesto";
            // 
            // lblDepartamentoTrabajoAnterior
            // 
            this.lblDepartamentoTrabajoAnterior.AutoSize = true;
            this.lblDepartamentoTrabajoAnterior.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamentoTrabajoAnterior.Location = new System.Drawing.Point(5, 105);
            this.lblDepartamentoTrabajoAnterior.Name = "lblDepartamentoTrabajoAnterior";
            this.lblDepartamentoTrabajoAnterior.Size = new System.Drawing.Size(121, 20);
            this.lblDepartamentoTrabajoAnterior.TabIndex = 18;
            this.lblDepartamentoTrabajoAnterior.Text = "Departamento";
            // 
            // cmbPuestoAnterior
            // 
            this.cmbPuestoAnterior.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbPuestoAnterior.FormattingEnabled = true;
            this.cmbPuestoAnterior.Location = new System.Drawing.Point(5, 65);
            this.cmbPuestoAnterior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbPuestoAnterior.Name = "cmbPuestoAnterior";
            this.cmbPuestoAnterior.Size = new System.Drawing.Size(175, 28);
            this.cmbPuestoAnterior.TabIndex = 29;
            // 
            // gbxNuevoCargo
            // 
            this.gbxNuevoCargo.Controls.Add(this.cmbDepartamentoNuevo);
            this.gbxNuevoCargo.Controls.Add(this.lblPuestoNuevo);
            this.gbxNuevoCargo.Controls.Add(this.cmbPuestoNuevo);
            this.gbxNuevoCargo.Controls.Add(this.lblDepartamentoNuevo);
            this.gbxNuevoCargo.Enabled = false;
            this.gbxNuevoCargo.Location = new System.Drawing.Point(677, 94);
            this.gbxNuevoCargo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxNuevoCargo.Name = "gbxNuevoCargo";
            this.gbxNuevoCargo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxNuevoCargo.Size = new System.Drawing.Size(200, 196);
            this.gbxNuevoCargo.TabIndex = 30;
            this.gbxNuevoCargo.TabStop = false;
            this.gbxNuevoCargo.Text = "Nuevo Cargo";
            // 
            // cmbDepartamentoNuevo
            // 
            this.cmbDepartamentoNuevo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbDepartamentoNuevo.FormattingEnabled = true;
            this.cmbDepartamentoNuevo.Location = new System.Drawing.Point(5, 142);
            this.cmbDepartamentoNuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDepartamentoNuevo.Name = "cmbDepartamentoNuevo";
            this.cmbDepartamentoNuevo.Size = new System.Drawing.Size(175, 28);
            this.cmbDepartamentoNuevo.TabIndex = 34;
            // 
            // lblPuestoNuevo
            // 
            this.lblPuestoNuevo.AutoSize = true;
            this.lblPuestoNuevo.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuestoNuevo.Location = new System.Drawing.Point(5, 26);
            this.lblPuestoNuevo.Name = "lblPuestoNuevo";
            this.lblPuestoNuevo.Size = new System.Drawing.Size(62, 20);
            this.lblPuestoNuevo.TabIndex = 32;
            this.lblPuestoNuevo.Text = "Puesto";
            // 
            // cmbPuestoNuevo
            // 
            this.cmbPuestoNuevo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbPuestoNuevo.FormattingEnabled = true;
            this.cmbPuestoNuevo.Location = new System.Drawing.Point(5, 57);
            this.cmbPuestoNuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbPuestoNuevo.Name = "cmbPuestoNuevo";
            this.cmbPuestoNuevo.Size = new System.Drawing.Size(175, 28);
            this.cmbPuestoNuevo.TabIndex = 33;
            // 
            // lblDepartamentoNuevo
            // 
            this.lblDepartamentoNuevo.AutoSize = true;
            this.lblDepartamentoNuevo.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamentoNuevo.Location = new System.Drawing.Point(5, 103);
            this.lblDepartamentoNuevo.Name = "lblDepartamentoNuevo";
            this.lblDepartamentoNuevo.Size = new System.Drawing.Size(121, 20);
            this.lblDepartamentoNuevo.TabIndex = 31;
            this.lblDepartamentoNuevo.Text = "Departamento";
            // 
            // lblIngreseIdEmpleado
            // 
            this.lblIngreseIdEmpleado.AutoSize = true;
            this.lblIngreseIdEmpleado.Location = new System.Drawing.Point(161, 38);
            this.lblIngreseIdEmpleado.Name = "lblIngreseIdEmpleado";
            this.lblIngreseIdEmpleado.Size = new System.Drawing.Size(222, 20);
            this.lblIngreseIdEmpleado.TabIndex = 27;
            this.lblIngreseIdEmpleado.Text = "Ingrese el ID del Empleado";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(603, 34);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(95, 30);
            this.btnBuscar.TabIndex = 20;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnAscender
            // 
            this.btnAscender.Enabled = false;
            this.btnAscender.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAscender.Location = new System.Drawing.Point(756, 384);
            this.btnAscender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAscender.Name = "btnAscender";
            this.btnAscender.Size = new System.Drawing.Size(161, 50);
            this.btnAscender.TabIndex = 33;
            this.btnAscender.Text = "Ascender";
            this.btnAscender.UseVisualStyleBackColor = true;
            // 
            // frmAscensos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 470);
            this.Controls.Add(this.btnEmpleados);
            this.Controls.Add(this.pnlAscensos);
            this.Controls.Add(this.btnAscender);
            this.Name = "frmAscensos";
            this.Text = "frmAscensos";
            this.pnlAscensos.ResumeLayout(false);
            this.pnlAscensos.PerformLayout();
            this.pnlDatosGenerales.ResumeLayout(false);
            this.pnlDatosGenerales.PerformLayout();
            this.gbxAntiguoCargo.ResumeLayout(false);
            this.gbxAntiguoCargo.PerformLayout();
            this.gbxNuevoCargo.ResumeLayout(false);
            this.gbxNuevoCargo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Panel pnlAscensos;
        private System.Windows.Forms.TextBox txtIdEmpleado;
        private System.Windows.Forms.Panel pnlDatosGenerales;
        private System.Windows.Forms.TextBox txtPrimerApellido;
        private System.Windows.Forms.TextBox txtPrimerNombre;
        private System.Windows.Forms.Label lblPrimerNombre;
        private System.Windows.Forms.Label lblPrimerApellido;
        private System.Windows.Forms.GroupBox gbxAntiguoCargo;
        private System.Windows.Forms.ComboBox cmbDepartamentoAnterior;
        private System.Windows.Forms.Label lblPuestoAnterior;
        private System.Windows.Forms.Label lblDepartamentoTrabajoAnterior;
        private System.Windows.Forms.ComboBox cmbPuestoAnterior;
        private System.Windows.Forms.GroupBox gbxNuevoCargo;
        private System.Windows.Forms.ComboBox cmbDepartamentoNuevo;
        private System.Windows.Forms.Label lblPuestoNuevo;
        private System.Windows.Forms.ComboBox cmbPuestoNuevo;
        private System.Windows.Forms.Label lblDepartamentoNuevo;
        private System.Windows.Forms.Label lblIngreseIdEmpleado;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAscender;
    }
}