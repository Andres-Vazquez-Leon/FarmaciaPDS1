using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class CNEmpleado
    {
        public static DataTable Listar()
        {
            Metodos Datos = new Metodos();
            return Datos.Mostrar_informacion("splistar_empleado");
        }

        public static DataTable Elimninar()
        {
            Metodos Datos = new Metodos();
            return Datos.Mostrar_informacion("speliminar_empleado");
        }


        public static string Editar(int cve_empleado,string telefono, string nombrecompleto, string cve_farm)
        {
            CDEmpleado Datos = new CDEmpleado();
            Datos.Cve_empleado = cve_empleado;
            Datos.Telefono = telefono;
            Datos.Nombrecompleto = nombrecompleto;
            Datos.Cve_farm = cve_farm;
            
            return Datos.Editar(Datos);

        }

        public static string Guardar(int cve_empleado, string telefono, string nombrecompleto, string cve_farm)
        {
            CDEmpleado Datos = new CDEmpleado();
            Datos.Telefono = telefono;
            Datos.Nombrecompleto = nombrecompleto;
            Datos.Cve_farm = cve_farm;

            return Datos.Guardar(Datos);


        }
}
