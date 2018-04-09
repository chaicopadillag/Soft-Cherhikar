using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad; //agregar referencia
using System.Data.SqlClient;
using System.Data;
namespace Datos
{
    public class Boleta_Da
    {
        //registrar boleta
        public int RegistrarBoleta(Boleta_En bol)
        {
            int r = 0;
            try
            {
                using (SqlCommand coman = new SqlCommand(
                    "Registrar_Boleta", Conexion.leerCadena()))
                {
                    coman.CommandType = CommandType.StoredProcedure;
                    coman.Parameters.AddWithValue("@codBoleta", bol.numcomprobante);
                    coman.Parameters.AddWithValue("@fecha", bol.fecha);
                    coman.Parameters.AddWithValue("@idpersona", bol.personal);
                    coman.Parameters.AddWithValue("@idcliente", bol.cliente);
                    coman.Parameters.AddWithValue("@idestado", bol.estado);
                    coman.Parameters.AddWithValue("@montoTotal", bol.montototal);
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
                //listar personal
        public DataTable Lista_Personal()
        {
            using (SqlDataAdapter Adapter = new SqlDataAdapter(
                "usp_listarpersonal", Conexion.leerCadena()))
            {
                using (DataTable table = new DataTable())
                {
                    Adapter.Fill(table);
                    return table;
                }
            }
        }
        //lista clientes
        public DataTable Lista_Cliente()
        {
            using (SqlDataAdapter Adapter = new SqlDataAdapter(
                "usp_listarcliente", Conexion.leerCadena()))
            {
                using (DataTable table = new DataTable())
                {
                    Adapter.Fill(table);
                    return table;
                }
            }
        }
        //listar boleta
        public DataTable Lista_boleta()
        {
            using (SqlDataAdapter Adapter = new SqlDataAdapter(
                "usp_listarboleta", Conexion.leerCadena()))
            {
                using (DataTable table = new DataTable())
                {
                    Adapter.Fill(table);
                    return table;
                }
            }
        }
       
        public int colocarcodboleta()
        {
            int cod = 0;
            try
            {
                using (SqlCommand command =new SqlCommand("Colocarcodboleta", Conexion.leerCadena()))
                {
                    command.CommandType = CommandType.Text;
                    cod =Convert.ToInt32( command.ExecuteScalar());

                }

            }
            catch(Exception e)
            {
                Console.WriteLine("message:{0}", e.Message);
            }
            finally
            {
                Conexion.leerCadena().Close();
            
            }

            return cod;        
    }
        public DataTable listarpedidos(int codpedido)
        {

            using (SqlDataAdapter adap = new SqlDataAdapter("filtro_Detalle_Pedido_X_Cliente", Conexion.leerCadena()))
            {
                adap.SelectCommand.CommandType = CommandType.StoredProcedure;
                adap.SelectCommand.Parameters.AddWithValue("@codpedido", codpedido);                
                 using (DataTable tb=new DataTable())
                {
                    adap.Fill(tb);
                    return tb;
                }
            }
        }
        public DataTable listarservicios(int codservicio)
        {

            using (SqlDataAdapter adap = new SqlDataAdapter("filtro_Detalle_Servicio_X_Cliente", Conexion.leerCadena()))
            {
                adap.SelectCommand.CommandType = CommandType.StoredProcedure;
                adap.SelectCommand.Parameters.AddWithValue("@codservicio",codservicio);               
                using (DataTable tb = new DataTable())
                {
                    adap.Fill(tb);
                    return tb;
                }
            }
        }

        public int RegistrarDetalleBoleta(DetalleBoleta_En DetB)
        {
            int r = 0;
            try
            {
                using (SqlCommand coman = new SqlCommand(
                    "INsertar_detalleBoleta", Conexion.leerCadena()))
                {
                    coman.CommandType = CommandType.StoredProcedure;
                    coman.Parameters.AddWithValue("@idboleta", DetB.numcomprobante);
                    coman.Parameters.AddWithValue("@codpedido", DetB.pedido);
                    coman.Parameters.AddWithValue("@codservicio", DetB.servicio);
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

    }

}
