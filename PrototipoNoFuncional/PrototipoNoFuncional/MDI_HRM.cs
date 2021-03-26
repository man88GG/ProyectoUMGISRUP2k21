using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoNoFuncional
{
    public partial class MDI_HRM : Form
    {
        private frmPuesto FormularioPuesto;
        private frmDepartamentos FormularioDepartamento;
        private frmCurso FormularioCurso;
        private frmCapacitaciones FormularioCapacitaciones;
        private frmFaltas FormularioFaltas;
        private frmContratos FormularioContratos;
        private frmPercepcionesFiscales FormularioPercepciones;
        private Contratacion FormularioContratacion;
        private frmDespidos FormularioDespidos;
        private frmAscensos FormularioAscenso;
        private frmReclutamiento FormularioReclutas;


        public MDI_HRM()
        {
            InitializeComponent();
        }
        private void puestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
           if (FormularioPuesto == null)
            {
                FormularioPuesto = new  frmPuesto();
                FormularioPuesto.MdiParent = this;
                FormularioPuesto.FormClosed += (o, args) => FormularioPuesto = null;
            }
            FormularioPuesto.Show();
            FormularioPuesto.BringToFront();
            
        }
        private void cursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FormularioCurso == null)
            {
                FormularioCurso = new frmCurso();
                FormularioCurso.MdiParent = this;
                FormularioCurso.FormClosed += (o, args) => FormularioCurso = null;
            }
            FormularioCurso.Show();
            FormularioCurso.BringToFront();
        }
   
        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FormularioDepartamento == null)
            {
                FormularioDepartamento = new frmDepartamentos();
                FormularioDepartamento.MdiParent = this;
                FormularioDepartamento.FormClosed += (o, args) => FormularioDepartamento = null;
            }
            FormularioDepartamento.Show();
            FormularioDepartamento.BringToFront();
        }
        private void faltasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FormularioFaltas == null)
            {
                FormularioFaltas = new frmFaltas();
                FormularioFaltas.MdiParent = this;
                FormularioFaltas.FormClosed += (o, args) => FormularioFaltas = null;
            }
            FormularioFaltas.Show();
            FormularioFaltas.BringToFront();
        }

        private void contratosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FormularioContratos == null)
            {
                FormularioContratos = new frmContratos();
                FormularioContratos.MdiParent = this;
                FormularioContratos.FormClosed += (o, args) => FormularioContratos = null;
            }
            FormularioContratos.Show();
            FormularioContratos.BringToFront();
        }

        private void percepcionesFiscalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (FormularioPercepciones == null)
            {
                FormularioPercepciones = new frmPercepcionesFiscales();
                FormularioPercepciones.MdiParent = this;
                FormularioPercepciones.FormClosed += (o, args) => FormularioPercepciones = null;
            }
            FormularioPercepciones.Show();
            FormularioPercepciones.BringToFront();
        }

        private void salariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void capacitacionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (FormularioCapacitaciones == null)
            {
                FormularioCapacitaciones = new frmCapacitaciones();
                FormularioCapacitaciones.MdiParent = this;
                FormularioCapacitaciones.FormClosed += (o, args) => FormularioCapacitaciones = null;
            }
            FormularioCapacitaciones.Show();
            FormularioCapacitaciones.BringToFront();
        }

        private void contratacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FormularioContratacion == null)
            {
                FormularioContratacion = new Contratacion();
                FormularioContratacion.MdiParent = this;
                FormularioContratacion.FormClosed += (o, args) => FormularioContratacion = null;
            }
            FormularioContratacion.Show();
            FormularioContratacion.BringToFront();
        }

        private void despidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FormularioDespidos == null)
            {
                FormularioDespidos = new frmDespidos();
                FormularioDespidos.MdiParent = this;
                FormularioDespidos.FormClosed += (o, args) => FormularioDespidos = null;
            }
            FormularioDespidos.Show();
            FormularioDespidos.BringToFront();
        }

        private void ascensosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FormularioAscenso == null)
            {
                FormularioAscenso = new frmAscensos();
                FormularioAscenso.MdiParent = this;
                FormularioAscenso.FormClosed += (o, args) => FormularioAscenso = null;
            }
            FormularioAscenso.Show();
            FormularioAscenso.BringToFront();
        }

        private void reclutamientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FormularioReclutas == null)
            {
                FormularioReclutas = new frmReclutamiento();
                FormularioReclutas.MdiParent = this;
                FormularioReclutas.FormClosed += (o, args) => FormularioReclutas = null;
            }
            FormularioReclutas.Show();
            FormularioReclutas.BringToFront();
        }
    }
}
