using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModeloHRM.Jose;

namespace CapaControladorHRM.Jose
{
    
    public class ClsControladorJose
    {
        ClsSentenciasJose Sn = new ClsSentenciasJose();

        public int funcCodigoMaximo(string Tabla, string Campo)
        {
            int CodigoNuevo = Sn.funcObtenerCodigo(Tabla, Campo);
            return CodigoNuevo;
        }
        public DataTable enviarCombo(string tabla, string campo1)
        {
            var dt1 = Sn.obtenerCombo(tabla, campo1);
            return dt1;
        }
        public DataTable enviar(string consulta)
        {
            try
            {
                OdbcDataAdapter dt = Sn.obtener(consulta);
                DataTable table = new DataTable();
                dt.Fill(table);
                return table;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Puede que los parametros seas erroneos, verifique los parametro enviados" + ex);
                return null;
            }

        }

        public string[] funcItems(string Tabla, string Campo)
        {
            string[] Items = Sn.funcLlenarCmb(Tabla, Campo);
            return Items;
        }

        public string[] funModicicarPercepcion(string Tabla, int Campo)
        {
            string[] Items = Sn.modificarPercepcion(Tabla, Campo);
            return Items;
        }
        public string[] items(string tabla, string campo1)
        {
            string[] Items = Sn.funcLlenarCmb(tabla, campo1);
            return Items;
        }

        public bool procDatosInsertar(string tabla, List<string> lista)
        {
            if (Sn.procInsertarDatos(tabla, lista))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool procDatosModificar(string tabla, List<string> campos, List<string> datos)
        {
            if (Sn.procModificar(tabla, campos, datos))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool funcEliminar(string tabla, string campo, string idTabla, string id)
        {

            if (Sn.procEliminar(tabla, campo, idTabla, id))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string[] itemsDosParametros(string tabla, string campo1, string campo2)
        {
            string[] Items = Sn.llenarCmbDosParametros(tabla, campo1, campo2);
            return Items;
        }
        ///Controlador 2///
        public DataTable enviarDosParametros(string tabla, string campo1, string campo2)
        {
            var dt1 = Sn.obtenerDosParametros(tabla, campo1, campo2);
            return dt1;
        }
    }
}
