﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;

namespace CapaModeloHRM.Sergio
{
    public class ClsSentenciasSergio
    {
        ClsConexion Con = new ClsConexion();


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

        public string[] funcLlenarCmbCourse(string Tabla, string Campo, string CourseId)
        {
            string[] Campos = new string[100];
            int I = 0;
            string Sql = "SELECT * FROM " + Tabla + " WHERE idCompetencia="+ CourseId+" and estado = 1 ;";
            try
            {
                OdbcCommand Command = new OdbcCommand(Sql, Con.conexion());
                OdbcDataReader Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    Campos[I] = Reader.GetValue(0).ToString() + " - " + Reader.GetValue(1).ToString();
                    I++;
                }
            }
            catch (Exception Ex) { Console.WriteLine(Ex.Message.ToString() + " \nError en asignarCombo, revise los parametros \n -" + Tabla + "\n -" + Campo); }
            return Campos;
        }

        //PRUEBA DE ESTO
        public string[] funcLlenarCmbComplejo(string Tabla1, string Tabla2, string Campo1, string Campo2, string Campo3)
        {
            string[] Campos = new string[100];
            int I = 0;
            string Sql = "SELECT R.idRecluta, R.nombre, R.apellido FROM RECLUTAMIENTO R, EMPLEADO E WHERE E.idRecluta = R.idRecluta and E.estado=1;";
            try
            {
                OdbcCommand Command = new OdbcCommand(Sql, Con.conexion());
                OdbcDataReader Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    Campos[I] = Reader.GetValue(0).ToString() + " - "+ Reader.GetValue(1).ToString() + " " + Reader.GetValue(2).ToString();
                    I++;
                }
            }
            catch (Exception Ex) { Console.WriteLine(Ex.Message.ToString() + " \nError en asignarCombo, revise los parametros \n -" + Tabla1 + "\n -" + Campo1); }
            return Campos;
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

        public DataTable obtenerComboCourse(string tabla, string campo1, string campo2)
        {
            string sql = "SELECT " + campo1 + ", "+campo2+" FROM " + tabla + " where estado = 1  ;";
            OdbcCommand command = new OdbcCommand(sql, Con.conexion());
            OdbcDataAdapter adaptador = new OdbcDataAdapter(command);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            return dt;
        }
        public DataTable obtenerCombo2(string tabla1, string tabla2, string campo1, string campo2, string campo3)
        {
            string sql = "SELECT R."+campo1+", R."+campo2+", R."+campo3+" FROM "+tabla1+ " R, "+tabla2+ " E WHERE E."+campo1+" = R."+campo1+" and E.estado=1;";
            OdbcCommand command = new OdbcCommand(sql, Con.conexion());
            OdbcDataAdapter adaptador = new OdbcDataAdapter(command);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            return dt;
        }

        public OdbcDataAdapter llenarTbl(string tabla)// metodo  que obtinene el contenio de una tabla
        {
            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT * FROM " + tabla + " WHERE estado = 1 ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, Con.conexion());
            return dataTable;
        }

        public OdbcDataAdapter llenarTblDepartametos(string tabla, string department)// metodo  que obtinene el contenio de una tabla
        {
            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT E.idEmpleado FROM EMPLEADO E, RECLUTAMIENTO R, DEPARTAMENTOEMPRESA D WHERE E.idRecluta = R.idRecluta AND R.idDepatamentoEmpresa = D.idDepartamentoEmpresa and R.idDepatamentoEmpresa = "+department+" and E.estado = 1 ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, Con.conexion());
            return dataTable;
        }

        public OdbcDataAdapter llenarTblRango(string tabla, string inicio, string fin)// metodo  que obtinene el contenio de una tabla
        {
            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT E.idEmpleado FROM EMPLEADO E, RECLUTAMIENTO R, DEPARTAMENTOEMPRESA D WHERE  E.idRecluta = R.idRecluta AND R.idDepatamentoEmpresa = D.idDepartamentoEmpresa and E.estado=1 and E.idEmpleado between "+inicio+" and "+fin+";";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, Con.conexion());
            return dataTable;
        }
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
            catch (Exception Ex) { Console.WriteLine(Ex.Message.ToString() + " \nError al obtener codigo automatico, revise los parametros " + NombreTabla + " y " + Campo + " " + Ex + " " + " \n -\n -"); }
            return Codigo + 1;
        }






        ////////////////////
        ///
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
                    catch (Exception)
                    {
                        try
                        {
                            //double
                            double.Parse(items);
                            sql += " " + items + ", ";
                            consulta += " " + items + ", ";
                        }
                        catch (Exception)
                        {
                            try
                            {
                                //DateTimePicker
                                DateTime.Parse(items);
                                sql += " '" + items + "', ";
                                consulta += " " + items + ", ";
                            }
                            catch (Exception)
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
    }
}
