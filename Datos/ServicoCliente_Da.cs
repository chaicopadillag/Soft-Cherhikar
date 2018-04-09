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
   public class ServicoCliente_Da
    {
        public int RegistrarServicioCliente(ServicioCliente_En serv)
        {
            int r =0;
            try
            {
                using (SqlCommand coman = new SqlCommand(
                    "Registrar_ServicioCliente", Conexion.leerCadena())){
                    coman.CommandType = CommandType.StoredProcedure;
                    coman.Parameters.AddWithValue("@num_serv", serv.numserv);                   
                    coman.Parameters.AddWithValue("@cliente", serv.cliente);
                    coman.Parameters.AddWithValue("@placa", serv.placa);
                    coman.Parameters.AddWithValue("@personal", serv.personal);
                    coman.Parameters.AddWithValue("@fecha", serv.fecha);
                    coman.Parameters.AddWithValue("@importe", serv.importe);
                    coman.Parameters.AddWithValue("@estado", serv.estado);
                    r = coman.ExecuteNonQuery();

                }

            }
            catch(Exception e)
            {
                Console.WriteLine("Message:{0}", e.Message);
            }
            finally
            {
                Conexion.leerCadena().Close();
            }

            return r;

        }

        public DataTable cargarServicios()
        {
            using(SqlDataAdapter data=new SqlDataAdapter("cargar_servicio", Conexion.leerCadena()))
            {
                using (DataTable tb=new DataTable())
                {
                    data.Fill(tb);
                    return tb;
                }
            }
       }

     
        public decimal colocarPrecio_servicio(int cod)
        {
            decimal precio = 0;
            try
            {
                using(SqlCommand coman=new SqlCommand("colocar_precio", Conexion.leerCadena()))
                {
                    coman.CommandType = CommandType.StoredProcedure;
                    coman.Parameters.AddWithValue("@cod", cod);
                    precio = Convert.ToDecimal(coman.ExecuteScalar());
                }

            }
            catch(Exception e)
            {
                Console.WriteLine("Message:{0}", e.Message);               
            }
            finally
            {
                Conexion.leerCadena().Close();
            }
            return precio;
        }

      public DataTable Buscar_placa_vehiculo(string cod_clie)
        {
            using(SqlDataAdapter adap = new SqlDataAdapter(
                "buscarVehiculo_servicioCliente", Conexion.leerCadena()))
            {
                adap.SelectCommand.CommandType = CommandType.StoredProcedure;
                adap.SelectCommand.Parameters.AddWithValue("@cod", cod_clie);
                using(DataTable tb= new DataTable())
                {
                    adap.Fill(tb);
                    return tb;
                }
            }
        }

        public int RegistrarDetalle_ServicioCliente(DetalleServicioCiente_EN serv)
        {
            int r = 0;
            try
            {
                using (SqlCommand coman = new SqlCommand(
                    "RegistrarDetalle_ServicioCliente", Conexion.leerCadena()))
                {
                    coman.CommandType = CommandType.StoredProcedure;
                    coman.Parameters.AddWithValue("@numser", serv.numserv);
                    coman.Parameters.AddWithValue("@servicio", serv.servicico);
                    coman.Parameters.AddWithValue("@precio", serv.importe);                                      
                    r = coman.ExecuteNonQuery();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Message:{0}", e.Message);
            }
            finally
            {
                Conexion.leerCadena().Close();
            }

            return r;

        }

        public int Cargar_Mayor_Codigo()
        {
            int ultimo_codigo = 0;
            try
            {
                using (SqlCommand coman = new SqlCommand(
                    "select max( id_serv )from ServicioMant_Cliente", Conexion.leerCadena()))
                {
                    coman.CommandType = CommandType.Text;
                    ultimo_codigo =Convert.ToInt32( coman.ExecuteScalar());
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Message:{0}", e.Message);
            }
            return ultimo_codigo;
        }

        public DataTable listarServicio_Cliente()
        {
            using(SqlDataAdapter Adap = new SqlDataAdapter(
                "listar_Servicio_cliente", Conexion.leerCadena()))
            {
                using (DataTable tb = new DataTable())
                {
                    Adap.Fill(tb);
                    return tb;
                }
            }
        }

        public DataTable listarDetalle_ServicioCliente(int num_serv)
        {
            using (SqlDataAdapter Adap = new SqlDataAdapter(
                "listarDetalle_ServicioCliente", Conexion.leerCadena()))
            {
                Adap.SelectCommand.CommandType = CommandType.StoredProcedure;
                Adap.SelectCommand.Parameters.AddWithValue("@num_serv", num_serv);
                using (DataTable tb = new DataTable())
                {
                    Adap.Fill(tb);
                    return tb;
                }
            }
        }

        public DataTable buscar_Servicio_cliente(int num_serv)
        {
            using (SqlDataAdapter Adap = new SqlDataAdapter(
                "buscar_Servicio_cliente", Conexion.leerCadena()))
            {
                Adap.SelectCommand.CommandType = CommandType.StoredProcedure;
                Adap.SelectCommand.Parameters.AddWithValue("@num_serv", num_serv);
                using (DataTable tb = new DataTable())
                {
                    Adap.Fill(tb);
                    return tb;
                }
            }
        }


        public DataTable Listar_Personal_mecanico()
        {
            using(SqlDataAdapter adap=new SqlDataAdapter(
                "Listar_Personal_mecanico", Conexion.leerCadena()))
            {
                using(DataTable tb=new DataTable())
                {
                    adap.Fill(tb);
                    return tb;
                }

            }
        }

        public int Eliminar_servicio(ServicioCliente_En serv)
        {
            int resultado = 0;
            try
            {
                using (SqlCommand com = new SqlCommand(
                    "Dar_baja_ServicioVehiculo", Conexion.leerCadena()))
                {
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@cod_serv", serv.numserv);
                    resultado = com.ExecuteNonQuery();
                }

            }

            catch (Exception e)
            {

                Console.WriteLine("Message:{0}", e.Message);
            }
            finally
            {
                Conexion.leerCadena().Close();
            }
            return resultado;
        }
    }
}
