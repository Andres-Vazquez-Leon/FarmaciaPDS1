using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CDEmpleado
    {
        public int Cve_empleado { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Nombrecompleto { get; set; }
        public int Cve_farm { get; set; }

        /*
        public string spbuscar = "spbuscar_empleado_nombre";
        public static string splistar = "spbuscar_empleado_lista";
        */

        //public static DataTable Mostrar_informacion(string store_p)
        //{


        //    DataTable resul = new DataTable("empleado");
        //    SqlConnection conexion = new SqlConnection();

        //    try
        //    {
        //        conexion.ConnectionString = Conexion.Conn;
        //        SqlCommand Cmd = new SqlCommand(store_p, conexion); // pendiente de crear procedimiento
        //        Cmd.CommandType = CommandType.StoredProcedure; // Cmd ejecucion del procedimiento

        //        SqlDataAdapter SqlDat = new SqlDataAdapter(Cmd);
        //        SqlDat.Fill(resul);
        //    }
        //    catch (Exception ex)
        //    {
        //        resul = null;
        //        throw ex;
        //    }
        //    finally
        //    {
        //        if (conexion.State == ConnectionState.Open)
        //        {
        //            conexion.Close();
        //        }

        //    }
        //    return resul;
        //}
        
        /*
        Metodos instancia = new Metodos();
        instancia.Mostrar_informacion("spbuscarempleado_");
        */



        public string Guardar(CDEmpleado cli)
        {
            string resul = "";
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion.ConnectionString = Conexion.Conn;
                conexion.Open();
                SqlCommand Cmd = new SqlCommand("spguardar_empleado", conexion); // procedimiento aun no creado
                Cmd.CommandType = CommandType.StoredProcedure;

                Cmd.Parameters.AddWithValue("@cve_empleado", SqlDbType.Int).Direction = ParameterDirection.Output; //en los metodos de guardar los id que se crean solos en la base de datos utilizan .Output
                Cmd.Parameters.AddWithValue("@telefono", cli.Telefono);
                Cmd.Parameters.AddWithValue("@direccion", cli.Direccion);                                          //en caso sea un metodo de editar no llevaria .Output, esto tambien aplica para la base de datos
                Cmd.Parameters.AddWithValue("@nombrecompleto", cli.Nombrecompleto);     
                Cmd.Parameters.AddWithValue("@Cve_farm", cli.Cve_farm);
                
                
                

                resul = Cmd.ExecuteNonQuery() == 1 ? "OK" : "No se pudp insertar el registro";
            }
            catch (Exception ex)
            {
                resul = ex.Message;
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

        public string Editar(CDEmpleado cli)
        {
            string resul = "";
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion.ConnectionString = Conexion.Conn;
                conexion.Open();
                SqlCommand Cmd = new SqlCommand("speditar_empleado", conexion); // procedimiento aun no creado
                Cmd.CommandType = CommandType.StoredProcedure;

                Cmd.Parameters.AddWithValue("@cve_empleado", SqlDbType.Int); //.Direction = ParameterDirection.Output; //en los metodos de guardar los id que se crean solos en la base de datos utilizan .Output
                Cmd.Parameters.AddWithValue("@telefono", cli.Telefono);
                Cmd.Parameters.AddWithValue("@direccion", cli.Direccion);                                          //en caso sea un metodo de editar no llevaria .Output, esto tambien aplica para la base de datos
                Cmd.Parameters.AddWithValue("@nombrecompleto", cli.Nombrecompleto);                                // es probable que en el metodo no sea necesario cve_empleado y Cve_farm en editar, ya que esta fijado por la base de datos
                Cmd.Parameters.AddWithValue("@Cve_farm", cli.Cve_farm);                                            //cambie de opinion con las cve




                resul = Cmd.ExecuteNonQuery() == 1 ? "OK" : "No se pudp insertar el registro";
            }
            catch (Exception ex)
            {
                resul = ex.Message;
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

        
        //public DataTable Buscar_clave() //No se si deberia un incluir esta funcion de busqueda
        //{


        //    DataTable resul = new DataTable("empleado");
        //    SqlConnection conexion = new SqlConnection();

        //    try
        //    {
        //        conexion.ConnectionString = Conexion.Conn;
        //        SqlCommand Cmd = new SqlCommand("spbuscar_empleado_clave", conexion); //Pendiente de crear procedimiento
        //        Cmd.CommandType = CommandType.StoredProcedure; // Cmd ejecucion del procedimiento

        //        SqlDataAdapter SqlDat = new SqlDataAdapter(Cmd);
        //        SqlDat.Fill(resul);
        //    }
        //    catch (Exception ex)
        //    {
        //        resul = null;
        //        throw ex;
        //    }
        //    finally
        //    {
        //        if (conexion.State == ConnectionState.Open)
        //        {
        //            conexion.Close();
        //        }

        //    }
        //    return resul;
        //} 

        //public DataTable Buscar_nombre()
        //{


        //    DataTable resul = new DataTable("empleado");
        //    SqlConnection conexion = new SqlConnection();

        //    try
        //    {
        //        conexion.ConnectionString = Conexion.Conn;
        //        SqlCommand Cmd = new SqlCommand("spbuscar_empleado_nombre", conexion); // pendiente de crear procedimiento
        //        Cmd.CommandType = CommandType.StoredProcedure; // Cmd ejecucion del procedimiento

        //        SqlDataAdapter SqlDat = new SqlDataAdapter(Cmd);
        //        SqlDat.Fill(resul);
        //    }
        //    catch (Exception ex)
        //    {
        //        resul = null;
        //        throw ex;
        //    }
        //    finally
        //    {
        //        if (conexion.State == ConnectionState.Open)
        //        {
        //            conexion.Close();
        //        }

        //    }
        //    return resul;
        //}



    }
}
