using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;

namespace CapaModeloHRM.Manuel
{
   public class ClsSentenciasManuel
    {

        ClsConexion Con = new ClsConexion();

        //Muestra datos en combo Puesto
        public DataTable funcCmbHPuesto()
        {
            DataTable Datos = new DataTable();
            try
            {
                string CargaPuestos = "SELECT * FROM PUESTO";
                OdbcCommand Query_Busqueda1 = new OdbcCommand(CargaPuestos, Con.conexion());

                OdbcDataAdapter Lector = new OdbcDataAdapter();
                Lector.SelectCommand = Query_Busqueda1;
                Lector.Fill(Datos);

                Con.desconexion(Con.conexion());
                return Datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Datos;
            }
        }//fin

        //Muestra datos en combo Departamento
        public DataTable funcCmbHDepto()
        {
            DataTable Datos = new DataTable();
            try
            {
                string CargaPuestos = "SELECT * FROM DEPARTAMENTOEMPRESA";
                OdbcCommand Query_Busqueda1 = new OdbcCommand(CargaPuestos, Con.conexion());

                OdbcDataAdapter Lector = new OdbcDataAdapter();
                Lector.SelectCommand = Query_Busqueda1;
                Lector.Fill(Datos);

                Con.desconexion(Con.conexion());
                return Datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Datos;
            }
        }//fin 

        //Muestra datos en combo Licencia
        public DataTable funcCmbLicencia()
        {
            DataTable Datos = new DataTable();
            try
            {
                string CargaPuestos = "SELECT * FROM LICENCIACONDUCIR";
                OdbcCommand Query_Busqueda1 = new OdbcCommand(CargaPuestos, Con.conexion());

                OdbcDataAdapter Lector = new OdbcDataAdapter();
                Lector.SelectCommand = Query_Busqueda1;
                Lector.Fill(Datos);

                Con.desconexion(Con.conexion());
                return Datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Datos;
            }
        }//fin 

        //Muestra datos en combo Horario
        public DataTable funcCmbHorario()
        {
            DataTable Datos = new DataTable();
            try
            {
                string CargaPuestos = "SELECT * FROM TIPOHORARIO";
                OdbcCommand Query_Busqueda1 = new OdbcCommand(CargaPuestos, Con.conexion());

                OdbcDataAdapter Lector = new OdbcDataAdapter();
                Lector.SelectCommand = Query_Busqueda1;
                Lector.Fill(Datos);

                Con.desconexion(Con.conexion());
                return Datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Datos;
            }
        }//fin 


        //Consulta para buscar un recluta por el Id
        public OdbcDataReader funcBuscarRecluta(string IdRecluta)
        {
            try
            {
                //sentencia para realizar la busqueda obteniendo los nombres de las diferentes entidades e igualando los ID de las diferentes tablas
                string sentencia = "SELECT RE.NOMBRE, RE.APELLIDO, RE.DPI, RE.FECHANACIMIENTO, RE.GENERO, RE.ESTADOCIVIL, RE.CORREO, RE.TELEFONO, RE.NUMEROIGSS, LC.TIPOLICENCIA, P.NOMBREPUESTO, HR.TIPOHORARIO, DE.NOMBREDEPARTAMENTO FROM RECLUTAMIENTO AS RE, LICENCIACONDUCIR AS LC, PUESTO AS P, TIPOHORARIO AS HR,DEPARTAMENTOEMPRESA AS DE, FORMACIONACADEMICA AS FA WHERE RE.IDFORMACIONACADEMICA = FA.IDFORMACIONACADEMICA AND RE.IDLICENCIA = LC.IDLICENCIA AND RE.IDPUESTO = P.IDPUESTO AND RE.IDDEPATAMENTOEMPRESA = DE.IDDEPARTAMENTOEMPRESA AND RE.IDHORARIO = HR.IDTIPOHORARIO AND RE.IDRECLUTA = '" + IdRecluta + "'";
                                    

                OdbcCommand Query_BusquedaReclu = new OdbcCommand(sentencia, Con.conexion());
                OdbcDataReader Lector = Query_BusquedaReclu.ExecuteReader();
                return Lector;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }


        //consulta para buscar en la entidad empleados
        public OdbcDataReader funcBuscarEmpleado(string IdEmpleado, int Estado)
        {
            try
            {
                //sentencia para realizar la busqueda obteniendo los nombres de las diferentes entidades e igualando los ID de las diferentes tablas
               string sentencia = "SELECT RE.NOMBRE, RE.APELLIDO, RE.DPI, RE.FECHANACIMIENTO, RE.GENERO, RE.ESTADOCIVIL, RE.CORREO, RE.TELEFONO, RE.NUMEROIGSS, LC.TIPOLICENCIA, P.NOMBREPUESTO, HR.TIPOHORARIO, DE.NOMBREDEPARTAMENTO, E.CUENTABANCARIA, E.IDRECLUTA FROM RECLUTAMIENTO AS RE, LICENCIACONDUCIR AS LC, PUESTO AS P, TIPOHORARIO AS HR,DEPARTAMENTOEMPRESA AS DE, FORMACIONACADEMICA AS FA, EMPLEADO AS E WHERE RE.IDFORMACIONACADEMICA = FA.IDFORMACIONACADEMICA AND RE.IDLICENCIA = LC.IDLICENCIA AND RE.IDPUESTO = P.IDPUESTO AND RE.IDDEPATAMENTOEMPRESA = DE.IDDEPARTAMENTOEMPRESA AND RE.IDHORARIO = HR.IDTIPOHORARIO AND E.IDRECLUTA = RE.IDRECLUTA AND E.IDEMPLEADO = '" + IdEmpleado + "' AND E.ESTADO = '" + Estado + "'";


                OdbcCommand Query_BusquedaReclu = new OdbcCommand(sentencia, Con.conexion());
                OdbcDataReader Lector = Query_BusquedaReclu.ExecuteReader();
                return Lector;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        //consulta para buscar y obtener el valor Id de los combobox
        public OdbcDataReader funcBusquedaCombosRec(string IdRecluta)
        {
            try
            {
                //sentencia para realizar la busqueda obteniendo los nombres de las diferentes entidades e igualando los ID de las diferentes tablas
                string sentencia = "SELECT RE.IDLICENCIA, RE.IDPUESTO, RE.IDHORARIO, RE.IDDEPATAMENTOEMPRESA FROM RECLUTAMIENTO AS RE WHERE RE.IDRECLUTA = '" + IdRecluta + "'";


                OdbcCommand Query_BusquedaReclu = new OdbcCommand(sentencia, Con.conexion());
                OdbcDataReader Lector = Query_BusquedaReclu.ExecuteReader();
                return Lector;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }

        //consulta para buscar y obtener el valor Id de los combobox
        public OdbcDataReader funcBusquedaCombosEmp(string IdEmpleado)
        {
            try
            {
                //sentencia para realizar la busqueda obteniendo los nombres de las diferentes entidades e igualando los ID de las diferentes tablas
                string sentencia = "SELECT RE.IDLICENCIA, RE.IDPUESTO, RE.IDHORARIO, RE.IDDEPATAMENTOEMPRESA FROM RECLUTAMIENTO AS RE, EMPLEADO AS E WHERE E.IDRECLUTA = RE.IDRECLUTA AND E.IDEMPLEADO = '" + IdEmpleado + "'";


                OdbcCommand Query_BusquedaReclu = new OdbcCommand(sentencia, Con.conexion());
                OdbcDataReader Lector = Query_BusquedaReclu.ExecuteReader();
                return Lector;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }

        //consulta para modificar en la entidad Empleado
        public void funcModificarEmpleado(string Nombres, string Apellidos, int Telefono, string Email,
                int Dpi, int NumIgss, int Puesto, int Departamento, int Horario, string EstadoCivil2, int TipoLicencia,
                 string CuentaBanc, string IdEmpleado, string IdRecluta)
        {
            try
            {
                string sentencia = "UPDATE RECLUTAMIENTO SET NOMBRE='" + Nombres + "', APELLIDO='" + Apellidos +
                    "', TELEFONO='" + Telefono + "', CORREO='" + Email + "', DPI='" + Dpi +
                    "', NUMEROIGSS='" + NumIgss + "', 	IDPUESTO='" + Puesto +
                    "', 	IDDEPATAMENTOEMPRESA='" + Departamento + "', IDHORARIO='" + Horario +
                    "', 	ESTADOCIVIL='" + EstadoCivil2 + "', IDLICENCIA='" + TipoLicencia + "' WHERE IDRECLUTA= '" + IdRecluta + "'";


                string sentencia2 = "UPDATE EMPLEADO SET CUENTABANCARIA ='" + CuentaBanc +  "' WHERE IDEMPLEADO='" + IdEmpleado + "'";
                OdbcCommand Query_Validacion1 = new OdbcCommand(sentencia, Con.conexion());
                OdbcCommand Query_Validacion2 = new OdbcCommand(sentencia2, Con.conexion());
                Query_Validacion1.ExecuteNonQuery();
                Query_Validacion2.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //consulta para modificar en la entidad Empleado
        public void funcModificarRecluta(string Nombres, string Apellidos, int Telefono, string Email,
                int Dpi, int NumIgss, int Puesto, int Departamento, int Horario, string EstadoCivil2, int TipoLicencia,
                 string CuentaBanc, string IdRecluta)
        {
            try
            {
                string sentencia = "UPDATE RECLUTAMIENTO SET NOMBRE='" + Nombres + "', APELLIDO='" + Apellidos +
                    "', TELEFONO='" + Telefono + "', CORREO='" + Email + "', DPI='" + Dpi +
                    "', NUMEROIGSS='" + NumIgss + "', 	IDPUESTO='" + Puesto +
                    "', 	IDDEPATAMENTOEMPRESA='" + Departamento + "', IDHORARIO='" + Horario +
                    "', 	ESTADOCIVIL='" + EstadoCivil2 + "', IDLICENCIA='" + TipoLicencia + "' WHERE IDRECLUTA= '" + IdRecluta + "'";


                OdbcCommand Query_Validacion1 = new OdbcCommand(sentencia, Con.conexion());
                
                Query_Validacion1.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }






    }
}
