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
   public class Vehiculo_Da
    {        
        public int RegistarVehiculo(Vehiculo_En car)
        {
            int resultado = 0;

            try
            {
                using (SqlCommand cmd = new SqlCommand(
                     "Registar_Vehiculo", Conexion.leerCadena()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@placa", car.placa);
                    cmd.Parameters.AddWithValue("@color", car.color);
                    cmd.Parameters.AddWithValue("@descripcion", car.descrip);
                    cmd.Parameters.AddWithValue("@cliente", car.cod_client);
                    cmd.Parameters.AddWithValue("@marca", car.cod_marca);
                    cmd.Parameters.AddWithValue("@tipo", car.cod_tipo);
                    cmd.Parameters.AddWithValue("@modelo", car.cod_madel);
                    cmd.Parameters.AddWithValue("@estado", car.estado);
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

        public int ModificarVehiculo(Vehiculo_En car)
        {
            int resultado = 0;
            try
            {
                using (SqlCommand cmd = new SqlCommand(
                "Modificar_Vehiculo", Conexion.leerCadena()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@placa", car.placa);
                    cmd.Parameters.AddWithValue("@color", car.color);
                    cmd.Parameters.AddWithValue("@descripcion", car.descrip);
                    cmd.Parameters.AddWithValue("@cliente", car.cod_client);
                    cmd.Parameters.AddWithValue("@marca", car.cod_marca);
                    cmd.Parameters.AddWithValue("@tipo", car.cod_tipo);
                    cmd.Parameters.AddWithValue("@modelo", car.cod_madel);
                    cmd.Parameters.AddWithValue("@estado", car.estado);
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

        public int EliminarVehiculo(Vehiculo_En car)
        {
            int resultado = 0;
            try
            {
                using (SqlCommand cmd = new SqlCommand(
                    "Eliminar_Vehiculo", Conexion.leerCadena()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Placa", car.placa);
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

        public DataTable Listar_Vehiculo()
        {
            using (SqlDataAdapter da = new SqlDataAdapter(
                      "ListaVehiculo", Conexion.leerCadena()))
            {
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                using (DataTable DT = new DataTable())
                {
                    da.Fill(DT);
                    return DT;
                }
            }
        }

        public DataTable BuscarVehiculoTabla(Vehiculo_En car)
        {
            using (SqlDataAdapter Da = new SqlDataAdapter(
               "BuscarVehiculo", Conexion.leerCadena()))

            {
               Da.SelectCommand.CommandType = CommandType.StoredProcedure;
                Da.SelectCommand.Parameters. AddWithValue("@placa", car.placa);
                using (DataTable Dt = new DataTable())
                {
                    Da.Fill(Dt);
                    return Dt;
                }

            }
        }

        public Boolean Buscar_VehiculoFrom(Vehiculo_En car)
        {
            Boolean respuesta = false;
            try
            {
                string sql = "select * from Vehiculo where placa_vehiculo ='" + car.placa + "'";
                SqlCommand coman = new SqlCommand(sql, Conexion.leerCadena());
                //coman.CommandType = CommandType.StoredProcedure;
                //coman.Parameters.AddWithValue("@cod", usu.Codigo);
                //Conexion.leerCadena().Open();
                SqlDataReader leer = coman.ExecuteReader();
                if (leer.Read() == true)
                {
                    car.placa = leer[0].ToString();
                    car.color = leer[1].ToString();
                    car.descrip = leer[2].ToString();
                    car.cod_client = leer[3].ToString();
                    car.cod_marca = Convert.ToInt32( leer[4].ToString());
                    car.cod_tipo = Convert.ToInt32(leer[5].ToString());
                    car.cod_madel = Convert.ToInt32(leer[6].ToString());
                    car.estado = Convert.ToBoolean(leer[7].ToString());

                    respuesta = true;
                }
                //Conexion.leerCadena().Close();

            }
            catch (Exception e)
            {
                e.GetBaseException();
            }
            finally
            {
                Conexion.leerCadena().Close();
            }

            return respuesta;
        }

        public DataTable listar_Marca()
        {
            using (SqlDataAdapter da = new SqlDataAdapter(
                "listaMarcaVehiculo", Conexion.leerCadena()))
            {  da.SelectCommand.CommandType = CommandType.StoredProcedure;
                using (DataTable DT = new DataTable())
                {
                    da.Fill(DT);
                    return DT;
                }
            }
        }

        public DataTable listar_tipoVehiculo()
        {
            using (SqlDataAdapter da = new SqlDataAdapter(
                "listar_tipoVehiculo", Conexion.leerCadena()))
            {
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                using (DataTable DT = new DataTable())
                {
                    da.Fill(DT);
                    return DT;
                }
            }
        }

        public DataTable listar_Modelo(int cod)
        {
            using (SqlDataAdapter Da = new SqlDataAdapter(
              "lista_ModeloV_x_MarcaV", Conexion.leerCadena()))

            {   Da.SelectCommand.CommandType = CommandType.StoredProcedure;
                Da.SelectCommand.Parameters. AddWithValue("@codigo",cod);
                using (DataTable Dt = new DataTable())
                {
                    Da.Fill(Dt);
                    return Dt;
                }

            }
        }

        public DataTable Listar_Cliente_Vehiculo()
        {
            using (SqlDataAdapter Da = new SqlDataAdapter(
              "Listar_Cliente_Vehiculo", Conexion.leerCadena()))

            {
                Da.SelectCommand.CommandType = CommandType.StoredProcedure;             
                using (DataTable Dt = new DataTable())
                {
                    Da.Fill(Dt);
                    return Dt;
                }

            }
        }

        public DataTable Buscar_Cliente_Vehiculo(string cod)
        {
            using (SqlDataAdapter Da = new SqlDataAdapter(
              "busca_Cliente_Vehiculo", Conexion.leerCadena()))
               {
                Da.SelectCommand.CommandType = CommandType.StoredProcedure;
                Da.SelectCommand.Parameters.AddWithValue("@codigo", cod);
                using (DataTable Dt = new DataTable())
                {
                    Da.Fill(Dt);
                    return Dt;
                }

            }
        }


    }
}
