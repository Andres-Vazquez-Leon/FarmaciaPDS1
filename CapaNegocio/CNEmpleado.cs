using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;
//using CapaNegocio;

namespace CapaNegocio
{
    public class CNEmpleado
    {
        public static DataTable BuscarNombre(string nombrecompleto)  // para que funcione la llamada al metodo en la clase FrmListar_empleado se siguio la sugerencia del 
        {                                                  // editor de codigo, se agregaran al resto de metodos que usen la clase metodo excepto listar
            Metodos Datos = new Metodos();
            CDEmpleado Datos_1 = new CDEmpleado();
            Datos_1.Nombrecompleto = nombrecompleto;
            return Datos.Mostrar_informacion("spbuscar_empleado_nombre");
        }

        public static DataTable BuscarClave(int cve_empleado)
        {
            Metodos Datos = new Metodos();
            CDEmpleado Datos_1 = new CDEmpleado();
            Datos_1.Cve_empleado = cve_empleado;
            return Datos.Mostrar_informacion("spbuscar_empleado_clave");
        }


        public static DataTable Listar()
        {
            Metodos Datos = new Metodos();
            return Datos.Mostrar_informacion("splistar_empleado1", null);
        }

        public static DataTable Eliminar(int cve_empleado)
        {
            Metodos Datos = new Metodos();
            CDEmpleado Datos_1 = new CDEmpleado();
            Datos_1.Cve_empleado = cve_empleado;
            return Datos.Mostrar_informacion("speliminar_empleado");
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

        public static string Guardar(string nombrecompleto, string telefono, string direccion) //, int cve_farm)
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
