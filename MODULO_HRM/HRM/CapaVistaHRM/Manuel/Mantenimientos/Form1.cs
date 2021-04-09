using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaHRM.Manuel.Mantenimientos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string TipoEntidad;
        private void Rbtn_Empleado_CheckedChanged(object sender, EventArgs e)
        {
            if (Rbtn_Empleado.Checked == true)
            {

                lblIngreseIdEmpleado.Visible = true;
                lblIngreseIdEmpleado.Text = "Ingrese el ID del Empleado ";
                txtId.Enabled = true;
                btnBuscar.Enabled = true;
                TipoEntidad = "Empleado";
                lblCuentaBanc.Visible = true;
                txtCuentaBanc.Visible = true;
            }
        }

        private void Rbtn_Recluta_CheckedChanged(object sender, EventArgs e)
        {
            lblIngreseIdEmpleado.Visible = true;
            lblIngreseIdEmpleado.Text = "Ingrese el ID del Recluta ";
            txtId.Enabled = true;
            btnBuscar.Enabled = true;
            TipoEntidad = "Recluta";
            lblCuentaBanc.Visible = false;
            txtCuentaBanc.Visible = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Mensaje de Validación
            if (txtId.Text == "") { MessageBox.Show("ADVERTENCIA: El campo de busqueda no puede estar vacío.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else
            {
               



            }//fin ifelse
        }


        //Funcion de Limpieza
        private void funcLimpieza()
        {
            txtId.Text = "";
            txtPrimerNombre.Text = "";
            txtSegundoNombre.Text = "";
            txtPrimerApellido.Text = "";
            txtSegundoApellido.Text = "";
            txtDpi.Text = "";
            txtNumeroIgss.Text = "";
            dtpFechaNacimiento.Value = DateTime.Now;
            txtGenero.Text = "";
            cmbPuesto.Text = "";
            cmbDepartamento.Text = "";
            txtResidencia.Text = "";
            txtZona.Text = "";
            txtMunicipio.Text = "";
            txtDepartamento.Text = "";
            txtCorreoElectronico.Text = "";
            txtTelefono.Text = "";
            txtCuentaBanc.Text = "";
            cmbEstadoCivil.Text = "";
            cmbTipoLicencia.Text = "";




        }

        //Funcion de Bloqueo
        private void funcBloqueo()
        {
            btnModificar.Enabled = true;
            pnlDatosGenerales.Enabled = true;
            gbxDomicilio.Enabled = true;
            pnlPuesto.Enabled = true;
            cmbEstadoCivil.Enabled = true;
            cmbTipoLicencia.Enabled = true;
            txtCuentaBanc.Enabled = true;
        }

        //Funcion de Desbloqueo
        private void funcDesbloqueo()
        {
            btnModificar.Enabled = false;
            pnlDatosGenerales.Enabled = false;
            gbxDomicilio.Enabled = false;
            pnlPuesto.Enabled = false;
            cmbEstadoCivil.Enabled = false;
            cmbTipoLicencia.Enabled = false;
            txtCuentaBanc.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtDpi.MaxLength = 13;
            txtTelefono.MaxLength = 8;
            txtNumeroIgss.MaxLength = 8;
            txtResidencia.MaxLength = 8;
            txtZona.MaxLength = 8;
            txtCuentaBanc.MaxLength = 8;
            txtId.MaxLength = 8;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            //Mensaje de Validación
            //Revisar la variable de cuenta bancaria
            if (txtId.Text == "" || txtPrimerNombre.Text == "" || txtSegundoNombre.Text == "" || txtPrimerApellido.Text == "" || txtSegundoApellido.Text == "" || txtZona.Text == "" || txtResidencia.Text == "" || txtDepartamento.Text == "" || txtMunicipio.Text == "" || txtCorreoElectronico.Text == "" || txtTelefono.Text == "" || txtCuentaBanc.Text == "") { MessageBox.Show("ADVERTENCIA: Uno o más campos están vacíos.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else
            {

                //Mensaje de Pregunta
                if (MessageBox.Show("¿Desea modificar este Empleado?", "Empleado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.Yes) { }
                else
                {

                    

                }//fin elseif Pregunta

            }//fin elseif txt

        }
    }
}
