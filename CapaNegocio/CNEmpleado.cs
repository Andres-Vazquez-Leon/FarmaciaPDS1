using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using CapaNegocio;

namespace CapaNegocio
{
    public class CNEmpleado
    {
        static string buscarnombre ="spbuscar_empleado_por_nombre1";
        static string buscarclave ="spbuscar_empleado_por_clave1";
        static string eliminar ="speliminar_empleado_por_cve1";


        public static DataTable BuscarNombre(string nombrecompleto)  // para que funcione la llamada al metodo en la clase FrmListar_empleado se siguio la sugerencia del 
        {                                                  // editor de codigo, se agregaran al resto de metodos que usen la clase metodo excepto listar
            Metodos Datos = new Metodos();
            CDEmpleado DatosE = new CDEmpleado();
            DatosE.Nombrecompleto = nombrecompleto;
            List<SqlParameter> parametros = new List<SqlParameter> {
            new SqlParameter("@nombrecompleto", nombrecompleto)};
            return Datos.Mostrar_informacion(buscarnombre, parametros);
        }

        public static DataTable BuscarClave(int cve_empleado)
        {
            Metodos Datos = new Metodos();
            CDEmpleado DatosE = new CDEmpleado(); //
            //DatosE.Cve_empleado = cve_empleado;
            List<SqlParameter> parametros = new List<SqlParameter> {
            new SqlParameter("@cve_empleado", cve_empleado)};
            return Datos.Mostrar_informacion(buscarclave, parametros); //
        }


        public static DataTable Listar()
        {
            Metodos Datos = new Metodos();
            return Datos.Mostrar_informacion("splistar_empleado1", null);
        }

        public static DataTable Eliminar(int cve_empleado)
        {
            Metodos Datos = new Metodos();
            CDEmpleado DatosE = new CDEmpleado(); //
            //DatosE.Cve_empleado = cve_empleado;
            List<SqlParameter> parametros = new List<SqlParameter> {
            new SqlParameter("@cve_empleado", cve_empleado)};
            return Datos.Mostrar_informacion(eliminar, parametros); //
        }


        public static string Editar(int cve_empleado, string nombrecompleto, string direccion, string telefono)//, int cve_farm)
        {
            CDEmpleado Datos = new CDEmpleado();
            Datos.Cve_empleado = cve_empleado;
            Datos.Nombrecompleto = nombrecompleto;
            Datos.Direccion = direccion;
            Datos.Telefono = telefono;
            //Datos.Cve_farm = cve_farm;

            return Datos.Editar(Datos);

        }

        public static string Guardar(string nombrecompleto, string direccion, string telefono) //, int cve_farm)
        {
            CDEmpleado Datos = new CDEmpleado();
            Datos.Nombrecompleto = nombrecompleto;
            Datos.Telefono = telefono;
            Datos.Direccion = direccion;
            
            //Datos.Cve_farm = cve_farm;

            return Datos.Guardar(Datos);


        }

        public static bool ProbarConexion()
        {
            CDEmpleado datos = new CDEmpleado();
            return datos.ProbarConexion();
        }
    }
}
