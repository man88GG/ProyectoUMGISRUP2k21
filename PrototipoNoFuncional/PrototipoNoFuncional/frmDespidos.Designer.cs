
namespace PrototipoNoFuncional
{
    partial class frmDespidos
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
            this.rbtnRenuncia = new System.Windows.Forms.RadioButton();
            this.rbtnDespido = new System.Windows.Forms.RadioButton();
            this.lblTipoBaja = new System.Windows.Forms.Label();
            this.gbxPrestacionesDespido = new System.Windows.Forms.GroupBox();
            this.BtnBaja = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFechaBaja = new System.Windows.Forms.Label();
            this.rtxtCausaDespido = new System.Windows.Forms.RichTextBox();
            this.lblCausaDespido = new System.Windows.Forms.Label();
            this.txtTiempoLaborado = new System.Windows.Forms.TextBox();
            this.txtMontoPrestaciones = new System.Windows.Forms.TextBox();
            this.lblPrestaciones = new System.Windows.Forms.Label();
            this.lblTiempoLaborado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.gbxPrestacionesDespido.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbtnRenuncia
            // 
            this.rbtnRenuncia.AutoSize = true;
            this.rbtnRenuncia.Enabled = false;
            this.rbtnRenuncia.Location = new System.Drawing.Point(191, 96);
            this.rbtnRenuncia.Name = "rbtnRenuncia";
            this.rbtnRenuncia.Size = new System.Drawing.Size(89, 21);
            this.rbtnRenuncia.TabIndex = 14;
            this.rbtnRenuncia.TabStop = true;
            this.rbtnRenuncia.Text = "Renuncia";
            this.rbtnRenuncia.UseVisualStyleBackColor = true;
            // 
            // rbtnDespido
            // 
            this.rbtnDespido.AutoSize = true;
            this.rbtnDespido.Enabled = false;
            this.rbtnDespido.Location = new System.Drawing.Point(37, 96);
            this.rbtnDespido.Name = "rbtnDespido";
            this.rbtnDespido.Size = new System.Drawing.Size(81, 21);
            this.rbtnDespido.TabIndex = 13;
            this.rbtnDespido.TabStop = true;
            this.rbtnDespido.Text = "Despido";
            this.rbtnDespido.UseVisualStyleBackColor = true;
            // 
            // lblTipoBaja
            // 
            this.lblTipoBaja.AutoSize = true;
            this.lblTipoBaja.Location = new System.Drawing.Point(34, 61);
            this.lblTipoBaja.Name = "lblTipoBaja";
            this.lblTipoBaja.Size = new System.Drawing.Size(267, 17);
            this.lblTipoBaja.TabIndex = 12;
            this.lblTipoBaja.Text = "Indique el tipo de Baja que va a Realizar:";
            // 
            // gbxPrestacionesDespido
            // 
            this.gbxPrestacionesDespido.Controls.Add(this.BtnBaja);
            this.gbxPrestacionesDespido.Controls.Add(this.dtpFecha);
            this.gbxPrestacionesDespido.Controls.Add(this.lblFechaBaja);
            this.gbxPrestacionesDespido.Controls.Add(this.rtxtCausaDespido);
            this.gbxPrestacionesDespido.Controls.Add(this.lblCausaDespido);
            this.gbxPrestacionesDespido.Controls.Add(this.txtTiempoLaborado);
            this.gbxPrestacionesDespido.Controls.Add(this.txtMontoPrestaciones);
            this.gbxPrestacionesDespido.Controls.Add(this.lblPrestaciones);
            this.gbxPrestacionesDespido.Controls.Add(this.lblTiempoLaborado);
            this.gbxPrestacionesDespido.Enabled = false;
            this.gbxPrestacionesDespido.Location = new System.Drawing.Point(24, 160);
            this.gbxPrestacionesDespido.Margin = new System.Windows.Forms.Padding(4);
            this.gbxPrestacionesDespido.Name = "gbxPrestacionesDespido";
            this.gbxPrestacionesDespido.Padding = new System.Windows.Forms.Padding(4);
            this.gbxPrestacionesDespido.Size = new System.Drawing.Size(914, 415);
            this.gbxPrestacionesDespido.TabIndex = 11;
            this.gbxPrestacionesDespido.TabStop = false;
            this.gbxPrestacionesDespido.Text = "Prestaciones";
            // 
            // BtnBaja
            // 
            this.BtnBaja.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBaja.Location = new System.Drawing.Point(698, 26);
            this.BtnBaja.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.BtnBaja.Name = "BtnBaja";
            this.BtnBaja.Size = new System.Drawing.Size(194, 50);
            this.BtnBaja.TabIndex = 22;
            this.BtnBaja.Text = "Realizar Baja";
            this.BtnBaja.UseVisualStyleBackColor = true;
            // 
            // dtpFecha
            // 
            this.dtpFecha.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.dtpFecha.Location = new System.Drawing.Point(294, 122);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(429, 22);
            this.dtpFecha.TabIndex = 24;
            // 
            // lblFechaBaja
            // 
            this.lblFechaBaja.AutoSize = true;
            this.lblFechaBaja.Location = new System.Drawing.Point(10, 122);
            this.lblFechaBaja.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaBaja.Name = "lblFechaBaja";
            this.lblFechaBaja.Size = new System.Drawing.Size(99, 17);
            this.lblFechaBaja.TabIndex = 23;
            this.lblFechaBaja.Text = "Fecha de Baja";
            // 
            // rtxtCausaDespido
            // 
            this.rtxtCausaDespido.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.rtxtCausaDespido.Location = new System.Drawing.Point(12, 190);
            this.rtxtCausaDespido.Margin = new System.Windows.Forms.Padding(4);
            this.rtxtCausaDespido.Name = "rtxtCausaDespido";
            this.rtxtCausaDespido.Size = new System.Drawing.Size(884, 203);
            this.rtxtCausaDespido.TabIndex = 12;
            this.rtxtCausaDespido.Text = "";
            // 
            // lblCausaDespido
            // 
            this.lblCausaDespido.AutoSize = true;
            this.lblCausaDespido.Location = new System.Drawing.Point(9, 158);
            this.lblCausaDespido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCausaDespido.Name = "lblCausaDespido";
            this.lblCausaDespido.Size = new System.Drawing.Size(104, 17);
            this.lblCausaDespido.TabIndex = 11;
            this.lblCausaDespido.Text = "Causa Despido";
            // 
            // txtTiempoLaborado
            // 
            this.txtTiempoLaborado.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtTiempoLaborado.Location = new System.Drawing.Point(294, 71);
            this.txtTiempoLaborado.Margin = new System.Windows.Forms.Padding(4);
            this.txtTiempoLaborado.Name = "txtTiempoLaborado";
            this.txtTiempoLaborado.Size = new System.Drawing.Size(300, 22);
            this.txtTiempoLaborado.TabIndex = 9;
            // 
            // txtMontoPrestaciones
            // 
            this.txtMontoPrestaciones.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtMontoPrestaciones.Location = new System.Drawing.Point(294, 27);
            this.txtMontoPrestaciones.Margin = new System.Windows.Forms.Padding(4);
            this.txtMontoPrestaciones.Name = "txtMontoPrestaciones";
            this.txtMontoPrestaciones.Size = new System.Drawing.Size(200, 22);
            this.txtMontoPrestaciones.TabIndex = 7;
            // 
            // lblPrestaciones
            // 
            this.lblPrestaciones.AutoSize = true;
            this.lblPrestaciones.Location = new System.Drawing.Point(9, 34);
            this.lblPrestaciones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrestaciones.Name = "lblPrestaciones";
            this.lblPrestaciones.Size = new System.Drawing.Size(191, 17);
            this.lblPrestaciones.TabIndex = 0;
            this.lblPrestaciones.Text = "Monto Prestaciones  a Pagar";
            // 
            // lblTiempoLaborado
            // 
            this.lblTiempoLaborado.AutoSize = true;
            this.lblTiempoLaborado.Location = new System.Drawing.Point(9, 78);
            this.lblTiempoLaborado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTiempoLaborado.Name = "lblTiempoLaborado";
            this.lblTiempoLaborado.Size = new System.Drawing.Size(215, 17);
            this.lblTiempoLaborado.TabIndex = 2;
            this.lblTiempoLaborado.Text = "Tiempo Laborado en la Empresa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Empleado";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(160, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(288, 24);
            this.comboBox1.TabIndex = 16;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(460, 12);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 17;
            // 
            // frmDespidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 592);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbtnRenuncia);
            this.Controls.Add(this.rbtnDespido);
            this.Controls.Add(this.lblTipoBaja);
            this.Controls.Add(this.gbxPrestacionesDespido);
            this.Name = "frmDespidos";
            this.Text = "frmDespidos";
            this.gbxPrestacionesDespido.ResumeLayout(false);
            this.gbxPrestacionesDespido.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnRenuncia;
        private System.Windows.Forms.RadioButton rbtnDespido;
        private System.Windows.Forms.Label lblTipoBaja;
        private System.Windows.Forms.GroupBox gbxPrestacionesDespido;
        private System.Windows.Forms.Button BtnBaja;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFechaBaja;
        private System.Windows.Forms.RichTextBox rtxtCausaDespido;
        private System.Windows.Forms.Label lblCausaDespido;
        private System.Windows.Forms.TextBox txtTiempoLaborado;
        private System.Windows.Forms.TextBox txtMontoPrestaciones;
        private System.Windows.Forms.Label lblPrestaciones;
        private System.Windows.Forms.Label lblTiempoLaborado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}