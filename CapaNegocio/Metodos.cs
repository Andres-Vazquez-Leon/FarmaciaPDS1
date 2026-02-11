using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaNegocio
{
    public class Metodos
    {
        public DataTable Mostrar_informacion(string store_p, List<SqlParameter> parametros = null)
        {
            DataTable resul = new DataTable(); 

            //DataTable resul = new DataTable("empleado");
            SqlConnection conexion = new SqlConnection();

            try
            {
                conexion.ConnectionString = Conexion.Conn;
                SqlCommand Cmd = new SqlCommand(store_p, conexion); // pendiente de crear procedimiento
                Cmd.CommandType = CommandType.StoredProcedure; // Cmd ejecucion del procedimiento

                //linea que sirve para agregar un parametro si List<SqlParameter> es distinto de null
                if (parametros != null)
                {
                    Cmd.Parameters.AddRange(parametros.ToArray());
                }


                SqlDataAdapter SqlDat = new SqlDataAdapter(Cmd);
                SqlDat.Fill(resul);
            }
            catch //(Exception ex)
            {
                //resul = null;
                throw;
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


        public DataTable BuscarNombre(string nombre)
        {
            DataTable resul = new DataTable("cliente");
            SqlConnection conexion = new SqlConnection();

            try
            {
                conexion.ConnectionString = Conexion.Conn;
                SqlCommand Cmd = new SqlCommand("spbuscar_cliente_nombre", conexion);

                Cmd.CommandType = CommandType.StoredProcedure;

                // parámetro
                Cmd.Parameters.AddWithValue("@nombre", nombre);

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
