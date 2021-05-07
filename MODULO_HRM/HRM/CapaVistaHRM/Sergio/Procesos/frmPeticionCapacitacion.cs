using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControladorHRM.Sergio;

namespace CapaVistaHRM.Sergio.Procesos
{
    public partial class frmPeticionCapacitacion : Form
    {
        ClsControladorSergio cn = new ClsControladorSergio();
        public frmPeticionCapacitacion()
        {
            InitializeComponent();
            actualizardatagriew();
        } 

        private void frmPeticionCapacitacion_Load(object sender, EventArgs e)
        {

        }
        string tabla = "PETICIONCAPACITACION";
        public void actualizardatagriew()
        {
            DataTable dt = cn.llenarTbl(tabla);
            dgvPeticiones.DataSource = dt;
        }

        private void cmbEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void llenarCombos()
        {
            cmbEmpleado.Items.Clear();

            cmbEmpleado.Items.Add("Seleccione...");
            llenarComboBox("empleado", "idRecluta", cmbEmpleado); //tabla, campo, combo
            cmbEmpleado.SelectedIndex = 0;
        }
        void llenarComboBox(string tabla, string campo1, ComboBox ComboBox)
        {
            string[] items = cn.funcItems(tabla, campo1);
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
            var dt2 = cn.enviarCombo(tabla, campo1);
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            foreach (DataRow row in dt2.Rows)
            {

                coleccion.Add(Convert.ToString(row[campo1]));
            }
            ComboBox.AutoCompleteCustomSource = coleccion;
            ComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            ComboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
    }
}
