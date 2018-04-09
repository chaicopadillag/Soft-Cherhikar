using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class Clientes_Da
    {
        public bool InsertarCliente(Cliente_EN Pro)
        {
            bool resultado = false;
            try
            {
                using (SqlCommand cmd = new SqlCommand("PA_REGISTRARCLIENTE", Conexion.leerCadena()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CODIGOCLIENTE", Pro.Codigo);
                    cmd.Parameters.AddWithValue("@NOMBRECLIENTE", Pro.Nombre);
                    cmd.Parameters.AddWithValue("@APELLIDOPATERNO", Pro.ApellidoPaterno);
                    cmd.Parameters.AddWithValue("@APELLIDOMATERNO", Pro.ApellidoMaterno);
                    cmd.Parameters.AddWithValue("@DIRECCION", Pro.Direccion);
                    cmd.Parameters.AddWithValue("@TELEFONO", Pro.Telefono);
                    cmd.Parameters.AddWithValue("@IDDISTRITO", Pro.Distrito);
                    cmd.Parameters.AddWithValue("@IDTIPOCLIENTE", Pro.TipoCliente);
                    cmd.Parameters.AddWithValue("@IDPERSONAL ", Pro.Personal);
                    cmd.Parameters.AddWithValue("@ESTADO", Pro.ESTADO);

                    int resul = cmd.ExecuteNonQuery();
                    if (resul > 0)
                        resultado = true;
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("Message:{0}", e.Message);

            }
            return resultado;
        }

        public int ActualizarCliente(Cliente_EN Pro)
        {
            int n = 0;
            try
            {
                using (SqlCommand cmd = new SqlCommand("PA_ACTUALIZARCLIENTE", Conexion.leerCadena()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CODIGOCLIENTE", Pro.Codigo);
                    cmd.Parameters.AddWithValue("@NOMBRECLIENTE", Pro.Nombre);
                    cmd.Parameters.AddWithValue("@APELLIDOPATERNO", Pro.ApellidoPaterno);
                    cmd.Parameters.AddWithValue("@APELLIDOMATERNO", Pro.ApellidoMaterno);
                    cmd.Parameters.AddWithValue("@DIRECCION", Pro.Direccion);
                    cmd.Parameters.AddWithValue("@TELEFONO", Pro.Telefono);
                    cmd.Parameters.AddWithValue("@IDDISTRITO", Pro.Distrito);
                    cmd.Parameters.AddWithValue("@IDTIPOCLIENTE", Pro.TipoCliente);
                    cmd.Parameters.AddWithValue("@IDPERSONAL ", Pro.Personal);
                    cmd.Parameters.AddWithValue("@ESTADO", Pro.ESTADO);
                    n = cmd.ExecuteNonQuery();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Message:{0}", e.Message);
            }
            return n;
        }


        public int EliminarCliente(Cliente_EN Pro)
        {
            int r = 0;
            try
            {
                using (SqlCommand cmd = new SqlCommand(
                "USPEliminarCliente", Conexion.leerCadena()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idCliente", Pro.Codigo);

                    r = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Message:{0}", e.Message);
            }
            return r;
        }


        public DataTable ListaDistrito()
        {
            using (SqlDataAdapter da = new SqlDataAdapter("pa_listaDistrito", Conexion.leerCadena()))
            {
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                using (DataTable dt = new DataTable())
                {
                    da.Fill(dt);
                    return dt;
                }
            }
        }


        public DataTable ListaTipoCliente()
        {
            using (SqlDataAdapter da = new SqlDataAdapter("PA_LISTATIPOCLIENTE", Conexion.leerCadena()))
            {
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                using (DataTable dt = new DataTable())
                {
                    da.Fill(dt);
                    return dt;
                }
            }
        }
        public DataTable ListaUsuario()
        {
            using (SqlDataAdapter da = new SqlDataAdapter("usp_listaUsuario", Conexion.leerCadena()))
            {
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                using (DataTable dt = new DataTable())
                {
                    da.Fill(dt);
                    return dt;
                }
            }
        }
        public DataTable ListaPersonal()
        {
            using (SqlDataAdapter da = new SqlDataAdapter("usp_listapersonal", Conexion.leerCadena()))
            {
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                using (DataTable dt = new DataTable())
                {
                    da.Fill(dt);
                    return dt;
                }
            }
        }
        public DataTable ListaCliente()
        {
            using (SqlDataAdapter da = new SqlDataAdapter("PA_LISTACLIENTE", Conexion.leerCadena()))
            {
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                using (DataTable dt = new DataTable())
                {
                    da.Fill(dt);
                    return dt;
                }
            }
        }




        public int BuscarCliente(Cliente_EN Pro)
        {
            int n = 0;
            try
            {
                using (SqlCommand comd = new SqlCommand("PA_BUSCARCLIENTES", Conexion.leerCadena()))
                {
                    comd.CommandType = CommandType.StoredProcedure;
                    comd.Parameters.AddWithValue("@CODIGO", Pro.Codigo);
                    using (SqlDataReader leer = comd.ExecuteReader())
                    {
                        if (leer.Read() == true)
                        {

                            Pro.Codigo = leer[0].ToString();
                            Pro.Nombre = leer[1].ToString();
                            Pro.ApellidoPaterno = leer[2].ToString();
                            Pro.ApellidoMaterno = leer[3].ToString();
                            Pro.Direccion = leer[4].ToString();
                            Pro.Telefono = leer[5].ToString();
                            Pro.Distrito = Convert.ToInt32(leer[6].ToString());
                            Pro.TipoCliente = Convert.ToInt32(leer[7].ToString());
                            Pro.Personal = leer[8].ToString();
                            Pro.ESTADO = Convert.ToBoolean(leer[9].ToString());

                            n = 10;
                        }

                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Message:{0}", e.Message);
            }
            return n;


        }

    
    }
}
