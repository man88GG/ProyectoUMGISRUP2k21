using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModeloHRM.Jose
{
    public class ClsSentenciasJose
    {
        ClsConexion Con = new ClsConexion();
        public int funcObtenerCodigo(string NombreTabla, string Campo)
        {
            int Codigo = 0;
            string Sql = "SELECT MAX(" + Campo + ") FROM " + NombreTabla + " ;";
            try
            {
                OdbcCommand Command = new OdbcCommand(Sql, Con.conexion());
                OdbcDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    Codigo = Reader.GetInt32(0);
                }
            }
            catch (Exception Ex) { Console.WriteLine(Ex.Message.ToString() + " \nError al obtener codigo automatico, revise los parametros "+NombreTabla+" y "+Campo+" \n -\n -"); }
            return Codigo + 1;
        }

        public string[] funcLlenarCmb(string Tabla, string Campo)
        {
            string[] Campos = new string[100];
            int I = 0;
            string Sql = "SELECT " + Campo + " FROM " + Tabla + " WHERE estado = 1 ;";
            try
            {
                OdbcCommand Command = new OdbcCommand(Sql, Con.conexion());
                OdbcDataReader Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    Campos[I] = Reader.GetValue(0).ToString();
                    I++;
                }
            }
            catch (Exception Ex) { Console.WriteLine(Ex.Message.ToString() + " \nError en asignarCombo, revise los parametros \n -" + Tabla + "\n -" + Campo); }
            return Campos;
        }

        public OdbcDataAdapter obtener(string consulta)
        {
            try
            {
                string sql = consulta;
                OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, Con.conexion());
                return dataTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Puede que los parametros seas erroneos, verifique los parametro enviados "+consulta+" --- " + ex);
                return null;
            }
        }


        public DataTable obtenerCombo(string tabla, string campo1)
        {
            string sql = "SELECT " + campo1 + " FROM " + tabla + " where estado = 1  ;";
            OdbcCommand command = new OdbcCommand(sql, Con.conexion());
            OdbcDataAdapter adaptador = new OdbcDataAdapter(command);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            return dt;
        }

        public bool procInsertarDatos(string tabla, List<string> lista)
        {
            string sql = " INSERT INTO " + tabla + " VALUES (";
            string consulta = sql;
            int contador = lista.Count();
            int i = 1;
            foreach (var items in lista)
            {
                if (i != contador)
                {
                    try
                    {
                        //int 
                        int.Parse(items);
                        sql += " " + items + ", ";
                        consulta += " " + items + ", ";
                    }
                    catch (Exception )
                    {
                        try
                        {
                            //double
                            double.Parse(items);
                            sql += " " + items + ", ";
                            consulta += " " + items + ", ";
                        }
                        catch (Exception )
                        {
                            try
                            {
                                //DateTimePicker
                                DateTime.Parse(items);
                                sql += " '" + items + "', ";
                                consulta += " " + items + ", ";
                            }
                            catch (Exception )
                            {
                                //string
                                sql += " '" + items + "', ";
                                consulta += " " + items + ", ";
                            }
                        }
                    }
                }
                else
                {
                    break;
                }

                i++;
            }
            var item = lista.Last();
            try
            {
                //int 
                int.Parse(item);
                sql += " " + item + ") ";
                consulta += " " + item + ") ";
            }
            catch (Exception)
            {
                sql += " '" + item + "') ";
                consulta += " " + item + ") ";
            }
            try
            {
                OdbcCommand comm = new OdbcCommand(sql, Con.conexion());
                OdbcDataReader mostrarC = comm.ExecuteReader();
                Console.WriteLine("Los Datos se guardaron correctamente");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo existe la tabla o los campos indicados \n -" + tabla + "\n -" + ex + " " + sql);
                return false;
            }
        }

        public bool procModificarPorMedioDeSql(string sql)
        {
            string Consulta = sql;
            try
            {
                OdbcCommand comm = new OdbcCommand(Consulta, Con.conexion());
                OdbcDataReader mostrarC = comm.ExecuteReader();
                Console.WriteLine("Los Datos se modificaron correctamente");

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se puede modificar revise: \n -" + Consulta + "\n -");
                return false;
            }
        }
        public bool procModificar(string tabla, List<string> campos, List<string> datos)
        {
            int contador = datos.Count();
            string sqlInicio = "UPDATE " + tabla + " SET  ";
            string consulta = sqlInicio;
            int i = 1;
            while (i < contador)
            {
                if (i != (contador - 1))
                {
                    string campo = campos.ElementAt(i);
                    sqlInicio += " " + campo + " = ";
                    consulta += " " + campo + " = ";
                    string dato = datos.ElementAt(i);
                    sqlInicio += " '" + dato + "', ";
                    consulta += " " + dato + ", ";
                }
                else
                {
                    string campo = campos.ElementAt(i);
                    sqlInicio += " " + campo + " = ";
                    consulta += " " + campo + " = ";
                    string dato = datos.ElementAt(i);
                    sqlInicio += " '" + dato + "' ";
                    consulta += " " + dato + " ";
                }
                i++;
            }
            sqlInicio += " WHERE " + campos.ElementAt(0) + " = " + datos.ElementAt(0) + "; ";
            consulta += " WHERE " + campos.ElementAt(0) + " = " + datos.ElementAt(0) + "; ";
         
            try
            {
                OdbcCommand comm = new OdbcCommand(sqlInicio, Con.conexion());
                OdbcDataReader mostrarC = comm.ExecuteReader();
                Console.WriteLine("Los Datos se guardaron correctamente");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo existe la tabla o los campos indicados \n -" + tabla + "\n -");
                return false;
            }
        }

        public bool procEliminar(string tabla, string campo, string idTabla, string id)
        {
            string sql = "UPDATE " + tabla + " SET " + campo + "= 0 WHERE " + idTabla + "= " + id + " ";
       
            try
            {
                OdbcCommand command = new OdbcCommand(sql, Con.conexion());
                OdbcDataReader odbcDataReader = command.ExecuteReader();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nError en Eliminar registro, revise los parametros \n -" + tabla + "\n -" + campo);
                return false;
            }
        }

        public string[] llenarCmbDosParametros(string tabla, string campo1, string campo2)
        {

            string[] Campos = new string[300];
            string[] auto = new string[300];
            int i = 0;
            string sql = "SELECT " + campo1 + "," + campo2 + " FROM " + tabla + " where estado = 1 ;";

            try
            {
                OdbcCommand command = new OdbcCommand(sql, Con.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    Campos[i] = reader.GetValue(0).ToString() + "-" + reader.GetValue(1).ToString();
                    i++;
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nError en asignarCombo, revise los parametros \n -" + tabla + "\n -" + campo1); }
            return Campos;
        }

        /// Modelo 2 //

        public DataTable obtenerDosParametros(string tabla, string campo1, string campo2)
        {
            string sql = "SELECT " + campo1 + "," + campo2 + " FROM " + tabla + " where estado = 1  ;";
            OdbcCommand command = new OdbcCommand(sql, Con.conexion());
            OdbcDataAdapter adaptador = new OdbcDataAdapter(command);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            return dt;
        }

        public string[] modificarPercepcion(string Tabla, int Campo)
        {
            string[] Campos = new string[100];
            int I = 0;
            string Sql = "SELECT *  FROM " + Tabla + " WHERE estado = 1 and idTipoPercepcionDeduccion = "+Campo+" ;";
            try
            {
                OdbcCommand Command = new OdbcCommand(Sql, Con.conexion());
                OdbcDataReader Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    Campos[0] = Reader.GetValue(0).ToString();
                    Campos[1] = Reader.GetValue(1).ToString();
                    Campos[2] = Reader.GetValue(2).ToString();
                    Campos[3] = Reader.GetValue(3).ToString();
                    Campos[4] = Reader.GetValue(4).ToString();
                    Campos[5] = Reader.GetValue(5).ToString();
                    Campos[6] = Reader.GetValue(6).ToString();
                }
            }
            catch (Exception Ex) { Console.WriteLine(Ex.Message.ToString() + " \nError en asignarCombo, revise los parametros \n -" + Tabla + "\n -" + Campo); }
            return Campos;
        }
    }
}
