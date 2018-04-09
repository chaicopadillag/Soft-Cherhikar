using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidad;

namespace Datos
{
    public class Reserva_Cliente_Da
    {
        public int coloccar_ultimoCodigo()
        { int cod = 0;
            try
            {using(SqlCommand coman=new SqlCommand(
                "generar_cod_reserva", Conexion.leerCadena()))
            {
                coman.CommandType = CommandType.Text;
                cod =Convert.ToInt32( coman.ExecuteScalar());
            }

            }
            catch
            {

            }
            return cod;
        }
        public int RegistrarReserva(Reserva_Cliente_En reserva)

        {
            int resultado = 0;

            try
            {
                using (SqlCommand cmd = new SqlCommand(
                     "Registrar_Reserva", Conexion.leerCadena()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Num_Reser", reserva.codigo);
                    cmd.Parameters.AddWithValue("@FechaReser", reserva.fecha);
                    cmd.Parameters.AddWithValue("@HoraReser", reserva.hora);
                    cmd.Parameters.AddWithValue("@idCliente", reserva.cod_client);
                    cmd.Parameters.AddWithValue("@idPersonal", reserva.nombre);
                    cmd.Parameters.AddWithValue("@idServicio", reserva.cod_servicio);
                    cmd.Parameters.AddWithValue("@Placa_Vehicu", reserva.placa);
                    cmd.Parameters.AddWithValue("@estado", reserva.estado);
                    resultado = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                e.GetBaseException();
            }
            finally
            {
                Conexion.leerCadena().Close();
            }

            return resultado;
        }
        public int EliminarReserva(Reserva_Cliente_En reserva)
        {
            int resultado = 0;
            try
            {
                using (SqlCommand cmd = new SqlCommand(
                    "Eliminar_Reserva", Conexion.leerCadena()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Num_Reser", reserva.codigo );
                    resultado = cmd.ExecuteNonQuery();

                }
            }
            catch (Exception e)
            {
                e.GetBaseException();
            }
            finally
            {
                Conexion.leerCadena().Close();
            }

            return resultado;
        }
        public DataTable Listar_Reserva()
        {
            using (SqlDataAdapter da = new SqlDataAdapter(
                      "lista_reserva", Conexion.leerCadena()))
            {
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                using (DataTable DT = new DataTable())
                {
                    da.Fill(DT);
                    return DT;
                }
            }
        }
        public DataTable Listar_personal()
        {
            using (SqlDataAdapter da = new SqlDataAdapter(
                      "listar_personal", Conexion.leerCadena()))
            {
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                using (DataTable DT = new DataTable())
                {
                    da.Fill(DT);
                    return DT;
                }
            }
        }
        public DataTable listar_servicio()
        {
            using (SqlDataAdapter da = new SqlDataAdapter(
                      "listar_servicio", Conexion.leerCadena()))
            {
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                using (DataTable DT = new DataTable())
                {
                    da.Fill(DT);
                    return DT;
                }
            }
        }
      
        public DataTable buscar_reserva_cliente(int num_reser)
        {
            using (SqlDataAdapter Adap = new SqlDataAdapter(
                "Buscar_Reserva", Conexion.leerCadena()))
            {
                Adap.SelectCommand.CommandType = CommandType.StoredProcedure;
                Adap.SelectCommand.Parameters.AddWithValue("@Num_Reser", num_reser);
                using (DataTable tb = new DataTable())
                {
                    Adap.Fill(tb);
                    return tb;
                }
            }
        }
      
        public DataTable Buscar_Cliente( string cod_cli)
        {
            using (SqlDataAdapter Da = new SqlDataAdapter(
              "Buscar_Cliente", Conexion.leerCadena()))

            {
                Da.SelectCommand.CommandType = CommandType.StoredProcedure;
                Da.SelectCommand.Parameters.AddWithValue("@cod_cli", cod_cli);
                using (DataTable Dt = new DataTable())
                {
                    Da.Fill(Dt);
                    return Dt;
                }
            }
        }

        
    }
 }
    
  
    
