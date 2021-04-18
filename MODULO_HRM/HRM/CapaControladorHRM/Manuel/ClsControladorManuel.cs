using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using CapaModeloHRM.Manuel;
using System.Data.Odbc;

namespace CapaControladorHRM.Manuel
{
    public class ClsControladorManuel
    {
        ClsSentenciasManuel sn = new ClsSentenciasManuel();

        //Paso de datos comboPuesto
        public DataTable funcItemsPuesto()
        {
            DataTable Items = sn.funcCmbHPuesto();
            return Items;
        }

        //Paso de datos Horario
        public DataTable funcItemsDepto()
        {
            DataTable Items = sn.funcCmbHDepto();
            return Items;
        }
        //Paso de datos Licencia de Conducir

        public DataTable funcItemsLicencia()
        {
            DataTable Items = sn.funcCmbLicencia();
            return Items;
        }
        //Paso de datos Estado Civil
        public DataTable funcItemsHorario()
        {
            DataTable Items = sn.funcCmbHorario();
            return Items;
        }


        //consulta de busqueda por Id 
        public OdbcDataReader funcBuscarRecluta(string IdRecluta)
        {
            OdbcDataReader Lector = sn.funcBuscarRecluta(IdRecluta);
            return Lector;
        }

        //Paso de datos para consulta buscar en la entidad empleados
        public OdbcDataReader funcBuscarEmpleado(string IdEmpleado, int Estado)
        {
            OdbcDataReader Lector = sn.funcBuscarEmpleado(IdEmpleado, Estado);
            return Lector;
        }

        //Paso de datos para consulta buscar en la entidad empleados
        public OdbcDataReader funcBusquedaCombosRec(string IdRecluta)
        {
            OdbcDataReader Lector2 = sn.funcBusquedaCombosRec(IdRecluta);
            return Lector2;
        }

        //Paso de datos para consulta buscar en la entidad empleados
        public OdbcDataReader funcBusquedaCombosEmp(string IdEmpleado)
        {
            OdbcDataReader Lector2 = sn.funcBusquedaCombosEmp(IdEmpleado);
            return Lector2;
        }


        //Paso de datos para consulta modificar en la entidad Empleado
        public void funcModificarEmpleado(string Nombres, string Apellidos, int Telefono, string Email,
                int Dpi, int NumIgss, int Puesto, int Departamento, int Horario, string EstadoCivil2, int TipoLicencia,
                 string CuentaBanc, string IdEmpleado,string IdRecluta)
        {

            
            sn.funcModificarEmpleado(Nombres, Apellidos, Telefono, Email, Dpi, NumIgss,
                            Puesto, Departamento, Horario, EstadoCivil2, TipoLicencia, CuentaBanc, IdEmpleado, IdRecluta);


        }


        //Paso de datos para consulta modificar en la entidad Empleado
        public void funcModificarRecluta(string Nombres, string Apellidos, int Telefono, string Email,
                int Dpi, int NumIgss, int Puesto, int Departamento, int Horario, string EstadoCivil2, int TipoLicencia,
                 string CuentaBanc, string IdRecluta)
        {


            sn.funcModificarRecluta(Nombres, Apellidos, Telefono, Email, Dpi, NumIgss,
                            Puesto, Departamento, Horario, EstadoCivil2, TipoLicencia, CuentaBanc, IdRecluta);


        }



    }
}
