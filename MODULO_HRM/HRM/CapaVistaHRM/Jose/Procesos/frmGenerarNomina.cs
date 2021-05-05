using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControladorHRM.Jose;
namespace CapaVistaHRM.Jose.Procesos
{
    public partial class frmGenerarNomina : Form
    {
        ClsControladorJose Cn = new ClsControladorJose();
        public frmGenerarNomina()
        {
            InitializeComponent();
            llenarCombos();
            CodigoMaximo("encabezadonomina","idEncabezadoNomina",txtCodigo);
        }

        public void CodigoMaximo(string tabla, string campo, TextBox txt)
        {
            string tbl = tabla;
            string cmp1 = campo;
            TextBox txt1 = txt;
            int codigo = Cn.funcCodigoMaximo(tbl, cmp1);
            txt1.Text = codigo.ToString();
            txt1.Enabled = false;
        }
        void llenarCombos()
        {
            cmbMoneda.Items.Clear();

            cmbMoneda.Items.Add("Seleccione...");
            llenarComboBox("tipomoneda", "tipoMoneda", cmbMoneda);
            cmbMoneda.SelectedIndex = 0;
        }
        void llenarComboBox(string tabla, string campo1, ComboBox ComboBox)
        {
            string[] items = Cn.funcItems(tabla, campo1);
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] != null)
                {
                    if (items[i] != "")
                    {
                        ComboBox.Items.Add(items[i]);
                    }
                }

            }
            var dt2 = Cn.enviarCombo(tabla, campo1);
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            foreach (DataRow row in dt2.Rows)
            {

                coleccion.Add(Convert.ToString(row[campo1]));
            }
            ComboBox.AutoCompleteCustomSource = coleccion;
            ComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            ComboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void cmbMoneda_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCodigoMoneda.Text = cmbMoneda.SelectedIndex.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text == "" || txtCodigoMoneda.Text == "" || cmbMoneda.SelectedIndex == 0)
            {
                MessageBox.Show("Asegurese de haber llenado todos los campos","Advertencia",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                List<string> DatosNomina = new List<string>();
                string fechaInicio = dtInicio.Value.ToString("yyyy-MM-dd HH:MM");
                string fechaFinal = dtFinal.Value.ToString("yyyy-MM-dd HH:MM");
                DatosNomina.Add(txtCodigo.Text);
                DatosNomina.Add(txtNombre.Text);
                DatosNomina.Add(fechaInicio);
                DatosNomina.Add(fechaFinal);
                DatosNomina.Add("0.0");
                DatosNomina.Add(txtCodigoMoneda.Text);
                try
                {
                    if(Cn.procDatosInsertar("encabezadonomina",DatosNomina))
                    {
                        MessageBox.Show("los Datos han sido Guardados Exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                        CodigoMaximo("encabezadonomina", "idEncabezadoNomina", txtCodigo);
                    }
                    else
                    {
                        MessageBox.Show("Upss, ha ocurrido un error, consulta con un experto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                catch(Exception)
                {

                }

            }
        }
        void LimpiarCampos()
        {
            txtNombre.Text = "";
            cmbMoneda.SelectedIndex = 0;
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
