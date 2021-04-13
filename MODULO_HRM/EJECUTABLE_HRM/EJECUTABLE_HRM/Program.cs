using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaVistaHRM.MDI;
<<<<<<< HEAD
=======
using CapaVistaHRM.Sergio.Mantenimientos;

>>>>>>> 232ba086b4ed96b54dd92a00f46dfcb4abe8f30a

namespace EJECUTABLE_HRM
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            Application.Run(new frmMDI());
=======
            Application.Run(new CapaVistaHRM.Manuel.Mantenimientos.DatosPersonales());
>>>>>>> 232ba086b4ed96b54dd92a00f46dfcb4abe8f30a
        }
    }
}
