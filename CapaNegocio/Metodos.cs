using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CapaDatos
{
    public class Metodos
    {
        public DataTable Mostrar_informacion(string store_p)
        {


            DataTable resul = new DataTable("empleado");
            SqlConnection conexion = new SqlConnection();

            try
            {
                conexion.ConnectionString = Conexion.Conn;
                SqlCommand Cmd = new SqlCommand(store_p, conexion); // pendiente de crear procedimiento
                Cmd.CommandType = CommandType.StoredProcedure; // Cmd ejecucion del procedimiento

                SqlDataAdapter SqlDat = new SqlDataAdapter(Cmd);
                SqlDat.Fill(resul);
            }
            catch (Exception ex)
            {
                resul = null;
                throw ex;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }

            }
            return resul;
        }
    }
}
