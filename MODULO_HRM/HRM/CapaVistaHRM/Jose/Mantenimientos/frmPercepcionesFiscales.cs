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

namespace CapaVistaHRM.Jose.Mantenimientos
{
    public partial class frmPercepcionesFiscales : Form
    {
        ClsValidaciones validar = new ClsValidaciones();
        ClsControladorJose Cn = new ClsControladorJose();
        public frmPercepcionesFiscales(string usuario, Form formularioPadre)
        {
            InitializeComponent();
            actualizarData();
            llenarCombos();
            rdTipoNo.Checked = true; rdOperacionNo.Checked = true; rdValorFormulaNo.Checked = true;
        }
       
        void llenarCombos()
        {
            cmbPercepcionDeduccion1.Items.Clear();
            cmbPercepcionModificar.Items.Clear();
            cmbOperacion.Items.Clear();
            cmbPercepcionDeduccion1.Items.Add("Seleccione...");
            cmbPercepcionModificar.Items.Add("Seleccione...");
            llenarse("tipopercepciondeduccion", "tipoPercepcionDeduccion", cmbPercepcionDeduccion1);
            llenarseDosParametros("tipopercepciondeduccion","idTipoPercepcionDeduccion" ,"tipoPercepcionDeduccion", cmbPercepcionModificar);
            cmbPercepcionDeduccion1.SelectedIndex = 0;
            cmbPercepcionModificar.SelectedIndex = 0;
            ComboOperaciones();
            cmbOperacion.SelectedIndex = 0;
        }
        void ComboOperaciones()
        {
            cmbOperacion.Items.Add("Seleccione...");
            cmbOperacion.Items.Add("+");
            cmbOperacion.Items.Add("-");
            cmbOperacion.Items.Add("*");
            cmbOperacion.Items.Add("/");
            cmbOperacion.Items.Add("(");
            cmbOperacion.Items.Add(")");
        }

        public void llenarseDosParametros(string tabla, string campo1, string campo2,ComboBox Combo)
        {
            Combo.ValueMember = "numero";
            Combo.DisplayMember = "nombre";
            string[] items = Cn.itemsDosParametros(tabla, campo2, campo1);
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] != null)
                {
                    if (items[i] != "")
                    {
                        Combo.Items.Add(items[i]);
                    }
                }

            }
            var dt2 = Cn.enviarDosParametros(tabla, campo2, campo1);
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            foreach (DataRow row in dt2.Rows)
            {
                coleccion.Add(Convert.ToString(row[campo2]) + "-" + Convert.ToString(row[campo1]));
            }
            Combo.AutoCompleteCustomSource = coleccion;
            Combo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Combo.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        void llenarse(string tabla, string campo1, ComboBox ComboBox)
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

        public void actualizarData()
        {
            string consulta = "Select idTipoPercepcionDeduccion as Codigo, tipoPercepcionDeduccion as Nombre,formula as Formula,signo as Signo from tipopercepciondeduccion where estado = 1;";
            DataTable dt = Cn.enviar(consulta);
            dgvDatos.DataSource = dt;
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

        private void rdInactivo_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdInactivo.Checked == true)
            {
                txtEstado.Text = "0";
            }

        }

        private void rdActivo_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdActivo.Checked == true)
            {
                txtEstado.Text = "1";
            }
        }

        private void txtEstado_TextChanged(object sender, EventArgs e)
        {
            if (txtEstado.Text == "")
            {
                rdActivo.Checked = false;
                rdInactivo.Checked = false;
            }
            if (txtEstado.Text == "1")
            {
                rdActivo.Checked = true;
            }
        }

        private void txtSigno_TextChanged_1(object sender, EventArgs e)
        {
            if (txtSigno.Text == "")
            {
                rdPositivo.Checked = false;
                rdNegativo.Checked = false;
            }
            if (txtSigno.Text == "+")
            {
                rdPositivo.Checked = true;
            }
            if (txtSigno.Text == "-")
            {
                rdNegativo.Checked = true;
            }
        }

        private void rdNegativo_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdNegativo.Checked == true)
            {
                txtSigno.Text = "-";
            }
        }

        private void rdPositivo_CheckedChanged_1(object sender, EventArgs e)
        {

            if (rdPositivo.Checked == true)
            {
                txtSigno.Text = "+";
            }
        }



        private void txtCantidad_TextChanged_1(object sender, EventArgs e)
        {


        }

        private void txtFormula_TextChanged_1(object sender, EventArgs e)
        {

        }


        int validaciones()
        {
            if (rdTipoSi.Checked == true && rdOperacionSi.Checked == true && rdValorFormulaSi.Checked == true)
            {
                if (cmbPercepcionDeduccion1.SelectedIndex == 0 || cmbPercepcionDeduccion1.SelectedItem == null || cmbOperacion.SelectedIndex == 0 || txtValorFormula.Text == "")
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
            else if (rdTipoSi.Checked == true && rdOperacionSi.Checked == true && rdValorFormulaSi.Checked == false)
            {
                if (cmbPercepcionDeduccion1.SelectedIndex == 0 || cmbPercepcionDeduccion1.SelectedItem == null || cmbOperacion.SelectedIndex == 0)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
            else if (rdTipoSi.Checked == true && rdOperacionSi.Checked == false && rdValorFormulaSi.Checked == false)
            {
                if (cmbPercepcionDeduccion1.SelectedIndex == 0 || cmbPercepcionDeduccion1.SelectedItem == null)
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
            else if (rdTipoSi.Checked == false && rdOperacionSi.Checked == true && rdValorFormulaSi.Checked == true)
            {
                if (cmbOperacion.SelectedIndex == 0 || cmbOperacion.SelectedItem == null || txtValorFormula.Text == "")
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
            else if (rdTipoSi.Checked == false && rdOperacionSi.Checked == false && rdValorFormulaSi.Checked == true)
            {
                if (txtValorFormula.Text == "")
                {
                    return 8;
                }
                else
                {
                    return 9;
                }
            }
            else if (rdTipoSi.Checked == false && rdOperacionSi.Checked == true && rdValorFormulaSi.Checked == false)
            {
                if (cmbOperacion.SelectedIndex == 0 || cmbOperacion.SelectedItem == null)
                {
                    return 10;
                }
                else
                {
                    return 11;
                }
            }
            else
            {
                return 13;
            } 
        }
        
       void LimpiarParametrosFormula()
        {
            cmbPercepcionDeduccion1.SelectedIndex = 0;
            cmbOperacion.SelectedIndex = 0;
            txtValorFormula.Text = "";
        }
        private void btnAgregarFormula_Click(object sender, EventArgs e)
        {
            if (rdTipoSi.Checked == false && rdOperacionSi.Checked == false && rdValorFormulaSi.Checked == false)
            {
                
                    MessageBox.Show("Debe seleccionar una de las opciones, que desea agregar a la formula.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                switch(validaciones())
                {
                    case 0:
                        MessageBox.Show("Falta almenos uno de los parametros seleccionado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    case 1:
                            txtFormula.Text += " ( " + cmbPercepcionDeduccion1.SelectedItem.ToString() + " " + cmbOperacion.SelectedItem.ToString() + " " + txtValorFormula.Text + " ) ";
                            rdTipoNo.Checked = true; rdOperacionNo.Checked = true; rdValorFormulaNo.Checked = true;

                        LimpiarParametrosFormula();
                        break;
                    case 2:
                        MessageBox.Show("Falta almenos uno de los parametros seleccionado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    case 3:
                        txtFormula.Text += " ( " + cmbPercepcionDeduccion1.SelectedItem.ToString() + " " + cmbOperacion.SelectedItem.ToString() + " ";
                        rdTipoNo.Checked = true; rdOperacionNo.Checked = true; rdValorFormulaNo.Checked = true;
                        LimpiarParametrosFormula();
                        break;
                    case 4:
                        MessageBox.Show("Falta almenos uno de los parametros seleccionado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    case 5:
                        txtFormula.Text += " ( " + cmbPercepcionDeduccion1.SelectedItem.ToString() + " ";
                        rdTipoNo.Checked = true; rdOperacionNo.Checked = true; rdValorFormulaNo.Checked = true;
                        LimpiarParametrosFormula();
                        break;
                    case 6:
                        MessageBox.Show("Falta almenos uno de los parametros seleccionado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    case 7:
                        if (txtFormula.Text == "")
                        {
                            MessageBox.Show("No se puede agregar un operador como primer parametro de la formula.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            txtFormula.Text += " " + cmbOperacion.SelectedItem.ToString() + " " + txtValorFormula.Text + " ";
                            rdTipoNo.Checked = true; rdOperacionNo.Checked = true; rdValorFormulaNo.Checked = true;
                            LimpiarParametrosFormula();
                        }
                        
                        break;
                    case 8:
                        MessageBox.Show("Falta almenos uno de los parametros seleccionado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    case 9:
                        if(txtFormula.Text == "")
                        {
                        txtFormula.Text += " ( "+ txtValorFormula.Text + " ";
                        rdTipoNo.Checked = true; rdOperacionNo.Checked = true; rdValorFormulaNo.Checked = true;
                            LimpiarParametrosFormula();
                        }
                        else
                        {
                        txtFormula.Text += " "+ txtValorFormula.Text + " ";
                        rdTipoNo.Checked = true; rdOperacionNo.Checked = true; rdValorFormulaNo.Checked = true;
                            LimpiarParametrosFormula();
                        }
                        break;
                    case 10:
                        MessageBox.Show("Falta almenos uno de los parametros seleccionado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    case 11:
                        if (txtFormula.Text == "")
                        {
                            MessageBox.Show("No puede agregar un signo como primer parametro en la formula.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            txtFormula.Text += " " + cmbOperacion.SelectedItem.ToString() + " ";
                            rdTipoNo.Checked = true; rdOperacionNo.Checked = true; rdValorFormulaNo.Checked = true;
                            LimpiarParametrosFormula();
                        }
                        break;
                    default:
                        MessageBox.Show("Debe seleccionar, lo que desea agregar a la formula.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                } 
            }
        }

        private void btnRestaurarValoresFormula_Click(object sender, EventArgs e)
        {
            txtFormula.Text = "";
            cmbPercepcionDeduccion1.SelectedIndex = 0;
         
        }

        private void btnGuardarDatos_Click(object sender, EventArgs e)
        {
            if (rdNuevo.Checked == true)
            {
                if (txtCodigo.Text == "" || txtNombre.Text == "" || txtDescripcion.Text == "" || txtSigno.Text == "" || txtEstado.Text == "")
                {
                    MessageBox.Show("No debe dejar campos vacios!!!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (txtFormula.Text == "" || txtCantidad.Text == "")
                    {
                        DialogResult dialogResult = MessageBox.Show("El campo Formula o el campo valor aun siguen vacios, desea continuar?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                        if (dialogResult == DialogResult.OK)
                        {
                            List<string> Percepciones = new List<string>();
                            Percepciones.Add(txtCodigo.Text);
                            Percepciones.Add(txtNombre.Text);
                            Percepciones.Add(txtDescripcion.Text);
                            Percepciones.Add(txtFormula.Text);
                            Percepciones.Add(txtCantidad.Text);
                            Percepciones.Add(txtSigno.Text);
                            Percepciones.Add(txtEstado.Text);
                            if (Cn.procDatosInsertar("tipopercepciondeduccion", Percepciones))
                            {
                                MessageBox.Show("Los Datos fueron ingresaods Correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                limpiarCampos();
                                CodigoMaximo("tipopercepciondeduccion", "idTipoPercepcionDeduccion", txtCodigo);
                                actualizarData();
                                llenarCombos();
                            }
                            else
                            {
                                MessageBox.Show("Ha ocurrido un error al ingresar los datos, consulte con un experto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }else
                    {
                        List<string> Percepciones = new List<string>();
                        Percepciones.Add(txtCodigo.Text);
                        Percepciones.Add(txtNombre.Text);
                        Percepciones.Add(txtDescripcion.Text);
                        Percepciones.Add(txtFormula.Text);
                        Percepciones.Add(txtCantidad.Text);
                        Percepciones.Add(txtSigno.Text);
                        Percepciones.Add(txtEstado.Text);
                        if (Cn.procDatosInsertar("tipopercepciondeduccion", Percepciones))
                        {
                            MessageBox.Show("Los Datos fueron ingresaods Correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limpiarCampos();
                            CodigoMaximo("tipopercepciondeduccion", "idTipoPercepcionDeduccion", txtCodigo);
                            actualizarData();
                            llenarCombos();
                        }
                        else
                        {
                            MessageBox.Show("Ha ocurrido un error al ingresar los datos, consulte con un experto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else if (rdModificar.Checked == true)
            {
                if (txtCodigo.Text == "" || txtNuevoNombre.Text == "" || txtDescripcion.Text == "" || txtSigno.Text == "" || txtEstado.Text == "" || cmbPercepcionModificar.SelectedIndex == 0)
                {
                    MessageBox.Show("No debe dejar campos vacios!!!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (txtFormula.Text == "" || txtCantidad.Text == "")
                    {
                        DialogResult dialogResult = MessageBox.Show("El campo Formula o el campo valor aun siguen vacios, desea continuar?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                        if (dialogResult == DialogResult.OK)
                        {
                            List<string> Percepciones = new List<string>();
                            List<string> PercepcionesTag = new List<string>();

                            Percepciones.Add(txtCodigo.Text);
                            Percepciones.Add(txtNuevoNombre.Text);
                            Percepciones.Add(txtDescripcion.Text);
                            Percepciones.Add(txtFormula.Text);
                            Percepciones.Add(txtCantidad.Text);
                            Percepciones.Add(txtSigno.Text);
                            Percepciones.Add(txtEstado.Text);

                            PercepcionesTag.Add("idTipoPercepcionDeduccion");
                            PercepcionesTag.Add("tipoPercepcionDeduccion");
                            PercepcionesTag.Add("descripcion");
                            PercepcionesTag.Add("formula");
                            PercepcionesTag.Add("valor");
                            PercepcionesTag.Add("signo");
                            PercepcionesTag.Add("estado");

                            if (Cn.procDatosModificar("tipopercepciondeduccion", PercepcionesTag, Percepciones))
                            {
                                MessageBox.Show("Los Datos fueron modificados Correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                limpiarCampos();
                                actualizarData();
                                llenarCombos();
                            }
                            else
                            {
                                MessageBox.Show("Ha ocurrido un error al ingresar los datos, consulte con un experto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        List<string> Percepciones = new List<string>();
                        List<string> PercepcionesTag = new List<string>();

                        Percepciones.Add(txtCodigo.Text);
                        Percepciones.Add(txtNuevoNombre.Text);
                        Percepciones.Add(txtDescripcion.Text);
                        Percepciones.Add(txtFormula.Text);
                        Percepciones.Add(txtCantidad.Text);
                        Percepciones.Add(txtSigno.Text);
                        Percepciones.Add(txtEstado.Text);

                        PercepcionesTag.Add("idTipoPercepcionDeduccion");
                        PercepcionesTag.Add("tipoPercepcionDeduccion");
                        PercepcionesTag.Add("descripcion");
                        PercepcionesTag.Add("formula");
                        PercepcionesTag.Add("valor");
                        PercepcionesTag.Add("signo");
                        PercepcionesTag.Add("estado");

                        if (Cn.procDatosModificar("tipopercepciondeduccion", PercepcionesTag, Percepciones))
                        {
                            MessageBox.Show("Los Datos fueron modificados Correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limpiarCampos();
                            actualizarData();
                            llenarCombos();
                        }
                        else
                        {
                            MessageBox.Show("Ha ocurrido un error al ingresar los datos, consulte con un experto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else if (rdEliminar.Checked == true)
            {
                if (cmbPercepcionModificar.SelectedIndex == 0 || cmbPercepcionModificar.SelectedItem == null)
                {
                    MessageBox.Show("Para eliminar el registro debe seleccionarlo en la lista.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("¿Esta seguro de eliminar el registro?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    if (dialogResult == DialogResult.OK)
                    {
                       if( Cn.funcEliminar("tipopercepciondeduccion","estado","idTipoPercepcionDeduccion",txtCodigo.Text))
                        {
                            MessageBox.Show("El registro fue eliminado correctamente", "Informaion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limpiarCampos();
                            actualizarData();
                            llenarCombos();
                        }
                        else
                        {
                            MessageBox.Show("Ha occurido un error al eliminar el dato, verifique el error con un experto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                    }
                }

            }
            else if (rdModificar.Checked == false && rdNuevo.Checked == false && rdEliminar.Checked == false)
            {
                MessageBox.Show("Debe seleccionar una de las 3 opciones, ingresar un nuevo registro o modificar un registro.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }
        void limpiarCamposCambio()
        {
            cmbPercepcionModificar.SelectedIndex = 0;
            txtNuevoNombre.Text = "";
            txtNuevoNombre.Visible = false;
            txtCodigo.Text = ""; txtNombre.Text = ""; txtDescripcion.Text = ""; txtSigno.Text = ""; txtEstado.Text = ""; txtFormula.Text = ""; txtCantidad.Text = "";
            txtValorFormula.Text = "";
            cmbPercepcionDeduccion1.SelectedIndex = 0;
            cmbOperacion.SelectedIndex = 0;
            rdOperacionSi.Checked = false;
            rdTipoSi.Checked = false;
            rdValorFormulaSi.Checked = false;
            btnBuscar.Visible = false;
        }
        void limpiarCampos()
        {
            rdEliminar.Checked = false;
            rdModificar.Checked = false;
            txtNombre.Visible = false;
            cmbPercepcionModificar.Visible = false;
            txtNuevoNombre.Visible = false;
            rdNuevo.Checked = false;
            cmbPercepcionModificar.SelectedIndex = 0;
            txtNuevoNombre.Text = "";
            txtNuevoNombre.Visible = false;
            txtCodigo.Text = ""; txtNombre.Text = ""; txtDescripcion.Text = ""; txtSigno.Text = ""; txtEstado.Text = ""; txtFormula.Text = ""; txtCantidad.Text = "";
            txtValorFormula.Text = "";
            cmbPercepcionDeduccion1.SelectedIndex = 0;
            cmbOperacion.SelectedIndex = 0;
            rdOperacionSi.Checked = false;
            rdTipoSi.Checked = false;
            rdValorFormulaSi.Checked = false;
            btnBuscar.Visible = false;
            lblNuevoNombre.Visible = false;
        }

        private void txtFormula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 32 || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || e.KeyChar == 164 || e.KeyChar == 165)
            {
                e.Handled = true;
            }
        }

        private void rdNuevo_CheckedChanged(object sender, EventArgs e)
        {
            cmbPercepcionModificar.SelectedIndex = 0;
            txtNombre.Visible= true;
            cmbPercepcionModificar.Visible = false;
            btnBuscar.Visible = false;
            lblNuevoNombre.Visible = false;
            txtNuevoNombre.Text = "";
            txtNuevoNombre.Visible = false;
            limpiarCamposCambio();
            CodigoMaximo("tipopercepciondeduccion", "idTipoPercepcionDeduccion", txtCodigo);
        }

        private void rdModificar_CheckedChanged(object sender, EventArgs e)
        {
            txtNombre.Visible = false;
            txtNombre.Text = "";
            cmbPercepcionModificar.Visible = true;
            btnBuscar.Visible = true;
            lblNuevoNombre.Visible = true;
            txtNuevoNombre.Visible = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(cmbPercepcionModificar.SelectedIndex == 0 || cmbPercepcionModificar.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar al menos un elemento de la lista.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string[] nombreCodigo = cmbPercepcionModificar.SelectedItem.ToString().Split('-');
                int codigo = 0;
                try
                {
                    codigo = Int32.Parse(nombreCodigo[0]);
                }
                catch (Exception)
                {
                    codigo = Int32.Parse(nombreCodigo[1]);
                }

                string[] items = Cn.funModicicarPercepcion("tipopercepciondeduccion",codigo);
                txtCodigo.Text = items[0];
                txtNuevoNombre.Text = items[1];
                txtDescripcion.Text = items[2];
                txtFormula.Text = items[3];
                txtCantidad.Text = items[4];
                txtSigno.Text = items[5];
                txtEstado.Text = items[6];
            }         
        }

        private void rdEliminar_CheckedChanged(object sender, EventArgs e)
        {
            txtNombre.Visible = false;
            txtNombre.Text = "";
            cmbPercepcionModificar.Visible = true;
            btnBuscar.Visible = true;
            lblNuevoNombre.Visible = false;
            txtNuevoNombre.Visible = false;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
    
}
