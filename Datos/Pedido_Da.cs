using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
        public class Pedido_Da
    {
        //-------------------------------------------------------------------------------
        //Metodos para Pedido
        public int cargarUltimoCodigoPedido()
        {
            int respuesta = 0;
            try
            {
                using (SqlCommand com = new SqlCommand(
                    "select max(id_pedido) from  Pedido_Cliente_Repuesto",
                    Conexion.leerCadena()))
                {
                    com.CommandType = CommandType.Text;     
                   respuesta =Convert.ToInt32( com.ExecuteScalar());
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

            return respuesta;

        }
        public int Registar_Pedido(Pedido_En pedido)
        {
            int resultado = 0;
            try
            {
                using (SqlCommand com = new SqlCommand(
                    "Registrar_Pedido", Conexion.leerCadena()))
                {
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@num_ped", pedido.numpedido);
                    com.Parameters.AddWithValue("@idpersonal", pedido.personal);
                    com.Parameters.AddWithValue("@idcliente", pedido.cliente);
                    com.Parameters.AddWithValue("@fecha", pedido.fecha);
                    com.Parameters.AddWithValue("@Monto", pedido.importe);
                    com.Parameters.AddWithValue("@estado", pedido.estado);
                    resultado=com.ExecuteNonQuery();
                }

            }

            catch(Exception e) {
                
              Console.WriteLine("Message:{0}",e.Message) ;
            }
            finally
            {
                Conexion.leerCadena().Close();
            }
            return resultado;
        }

        public int Disminuir_Existencia_Repuesto(int id_repuesto,int cantidadVendida)
        {
            int respuesta = 0;
            try
            {
                using(SqlCommand comand=new SqlCommand(
                    "DisminuirExistenciaRepuesto", Conexion.leerCadena()))
                {
                    comand.CommandType = CommandType.StoredProcedure;
                    comand.Parameters.AddWithValue("@id_repto", id_repuesto);
                    comand.Parameters.AddWithValue("@cantidadVen", cantidadVendida);
                    respuesta = comand.ExecuteNonQuery();
                }

            }
            catch(Exception e)
            {
                Console.WriteLine( "Message:{0}", e.Message);
            }

            return respuesta;
        }

        public int Cargar_Cantidad_Existencia_Repuesto(int cod)
        {
            int respuesta = 0;
            try
            {
                using (SqlCommand com = new SqlCommand(
                    "CargarCantidadExistencia",   Conexion.leerCadena()))
                {
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@id_repto", cod);
                    respuesta = Convert.ToInt32(com.ExecuteScalar());
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

            return respuesta;

        }

        public int Eliminar_Pedido(Pedido_En pedido)
        {
            int resultado = 0;
            try
            {
                using (SqlCommand com = new SqlCommand(
                    "Dar_baja_pedido", Conexion.leerCadena()))
                {
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@cod_pedio", pedido.numpedido);                   
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

        public DataTable Lista_Persoanl()
        {
            using (SqlDataAdapter Adapter = new SqlDataAdapter(
                "Listar_Personal_pedido", Conexion.leerCadena()))
            {                
                using (DataTable table = new DataTable())
                {
                    Adapter.Fill(table);
                    return table;
                }
            }
        }

        public DataTable lista_repuesto(int cod_catag)
        {
            using (SqlDataAdapter Adapt = new SqlDataAdapter(
                "listar_repuesto_pedido", Conexion.leerCadena()))                
            {Adapt.SelectCommand.CommandType = CommandType.StoredProcedure;
                Adapt.SelectCommand.Parameters.AddWithValue("@cod_cat", cod_catag);
                
                using (DataTable tab = new DataTable())
                {
                    Adapt.Fill(tab);
                    return tab;
                }
            }
        }
        public DataTable lista_categoria_rpto()
        {
            using (SqlDataAdapter Adapt = new SqlDataAdapter(
                "listar_categoria_repuesto", Conexion.leerCadena()))
            {
                Adapt.SelectCommand.CommandType = CommandType.StoredProcedure;

                using (DataTable tab = new DataTable())
                {
                    Adapt.Fill(tab);
                    return tab;
                }
            }
        }
        public DataTable Buscar_Pedido(Pedido_En pedido)
        {
            
                using(SqlDataAdapter Adap=new SqlDataAdapter("Buscar_Pedido", Conexion.leerCadena()))
                {
                    Adap.SelectCommand.CommandType = CommandType.StoredProcedure;
                    Adap.SelectCommand.Parameters.AddWithValue("@num_ped", pedido.numpedido);
                    using (DataTable table = new DataTable())
                    {
                        Adap.Fill(table);
                        return table;
                    }
                }           
        }

        public DataTable Listar_Pedido()
        {
            using (SqlDataAdapter adap = new SqlDataAdapter(
                "Listar_Pedido", Conexion.leerCadena()))
            {  using(DataTable tb = new DataTable())
                {
                    adap.Fill(tb);
                    return tb;
                }
            }


            
        }

        public decimal colocar_precio(int cod)
        {
            decimal respuesta = 0;
            try
            {
                using (SqlCommand com = new SqlCommand(
                    "buscar_repuesto_precio",
                    Conexion.leerCadena()))
                {
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@cod", cod);
                    respuesta = Convert.ToDecimal(com.ExecuteScalar());
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

            return respuesta;

        }
        

    
        //-------------------------------------------------------------------------------
        //Metodos para Detalle_Pedido
        public int Registar_Detalle_Pedido(Detallepedido_En Deta_pedido)
        {
            int resultado = 0;
            try
            {
                using (SqlCommand com = new SqlCommand(
                    "Registrar_Detalle_Pedido", Conexion.leerCadena()))
                {
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@num_ped", Deta_pedido.numpedido);
                    com.Parameters.AddWithValue("@id_respt", Deta_pedido.repuesto);
                    com.Parameters.AddWithValue("@cantidad", Deta_pedido.cantidad);
                    com.Parameters.AddWithValue("@precio", Deta_pedido.precio);
                    com.Parameters.AddWithValue("@importe", Deta_pedido.sub_total);                   
                    resultado = com.ExecuteNonQuery();
                    if (resultado > 0)
                    {
                       resultado=Disminuir_Existencia_Repuesto(Deta_pedido.repuesto, Deta_pedido.cantidad);

                    }
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
            

        public int Eliminar_Detalle_Pedido(Detallepedido_En Deta_pedido)
        {
            int resultado = 0;
            try
            {
                using (SqlCommand com = new SqlCommand(
                    "Elminar_Detalle_pedido", Conexion.leerCadena()))
                {
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@num_ped", Deta_pedido.numpedido);
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

        public DataTable BuscarDetallePedido(int num_pedido)
        {
            using(SqlDataAdapter adap=new SqlDataAdapter("buscarDetalle_pedido", Conexion.leerCadena()))
            {
                adap.SelectCommand.CommandType = CommandType.StoredProcedure;
                adap.SelectCommand.Parameters.AddWithValue("@num_ped", num_pedido);
                using (DataTable tb = new DataTable())
                {
                    adap.Fill(tb);
                    return tb;
                }
            }
        }
    }
}
