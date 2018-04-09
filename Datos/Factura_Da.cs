using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad; //agregar referencia
using System.Data;
using System.Data.SqlClient;
namespace Datos
{
   public class Factura_Da
    {
        //registrar factura
        public int RegistrarFactura(Factura_En fac)
        {
            int r = 0;
            try
            {
                using (SqlCommand coman = new SqlCommand(
                    "Registrar_Facturacion", Conexion.leerCadena()))
                {
                    coman.CommandType = CommandType.StoredProcedure;
                    coman.Parameters.AddWithValue("@codFacturacion", fac.numcomprobante);
                    coman.Parameters.AddWithValue("@ruc", fac.ruc);
                    coman.Parameters.AddWithValue("@fecha", fac.fecha);
                    coman.Parameters.AddWithValue("@idpersona", fac.personal);
                    //coman.Parameters.AddWithValue("@idpago", fac.pago);
                    coman.Parameters.AddWithValue("@idcliente", fac.cliente);
                    coman.Parameters.AddWithValue("@idestado", fac.estado);
                    coman.Parameters.AddWithValue("@montototal", fac.montototal);
                    coman.Parameters.AddWithValue("@igv", fac.igv);
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
        //registrar detalle boleta
        public int RegistrarDetalleFactura(DetalleFactura_En DetF)
        {
            int r = 0;
            try
            {
                using (SqlCommand coman = new SqlCommand(
                    "INsertar_detalleFactura", Conexion.leerCadena()))
                {
                    coman.CommandType = CommandType.StoredProcedure;
                    coman.Parameters.AddWithValue("@idfactura", DetF.numcomprobante);
                    coman.Parameters.AddWithValue("@codpedido", DetF.pedido);
                    coman.Parameters.AddWithValue("@codservicio", DetF.servicio);
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
        //luistar factura
        public DataTable Lista_Factura()
        {
            using (SqlDataAdapter Adapter = new SqlDataAdapter(
                "usp_listarFactura", Conexion.leerCadena()))
            {
                using (DataTable table = new DataTable())
                {
                    Adapter.Fill(table);
                    return table;
                }
            }
        }
        public int colocarcodFactura()
        {
            int cod = 0;
            try
            {
                using (SqlCommand command = new SqlCommand("ColocarcodFactura", Conexion.leerCadena()))
                {
                    command.CommandType = CommandType.Text;
                    cod = Convert.ToInt32(command.ExecuteScalar());

                }

            }
            catch (Exception e)
            {
                Console.WriteLine("message:{0}", e.Message);
            }
            finally
            {
                Conexion.leerCadena().Close();

            }

            return cod;
        }
    }
    }
   
