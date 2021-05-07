using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModeloHRM.Sergio;

namespace CapaControladorHRM.Sergio
{
    public class ClsControladorSergio
    {
        ClsSentenciasSergio Sn = new ClsSentenciasSergio();

        public string[] funcItems(string Tabla, string Campo)
        {
            string[] Items = Sn.funcLlenarCmb(Tabla, Campo);
            return Items;
        }
        public DataTable enviarCombo(string tabla, string campo1)
        {
            var dt1 = Sn.obtenerCombo(tabla, campo1);
            return dt1;
        }

        public DataTable llenarTbl(string tabla)
        {
            OdbcDataAdapter dt = Sn.llenarTbl(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
    }
}
