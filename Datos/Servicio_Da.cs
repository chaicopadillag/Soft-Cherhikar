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
   public class Servicio_Da
    {
        public int Registar_servicios(Servicio_En serv)
        {
            int r = 0;
            try
            {
                using (SqlCommand coman = new SqlCommand(
                    "Registar_servicios", Conexion.leerCadena()))
                {
                    coman.CommandType = CommandType.StoredProcedure;
                    coman.Parameters.AddWithValue("@cod_ser", serv.codigo);
                    coman.Parameters.AddWithValue("@nom_ser", serv.Nom_servicio);
                    coman.Parameters.AddWithValue("@precio", serv.precio);
                    coman.Parameters.AddWithValue("@descripcion", serv.discripcion);
                    coman.Parameters.AddWithValue("@estado", serv.estado);
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
        public int ModificarServicio(Servicio_En serv)
        {
            int resultado = 0;
            try
            {
                using (SqlCommand cmd = new SqlCommand(
                "usp_ActualizarServicio", Conexion.leerCadena()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@cod_ser", serv.codigo);
                    cmd.Parameters.AddWithValue("@nom_ser", serv.Nom_servicio);
                    cmd.Parameters.AddWithValue("@descripcion", serv.discripcion);
                    cmd.Parameters.AddWithValue("@precio", serv.precio);
                    cmd.Parameters.AddWithValue("@estado", serv.estado);
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
        public int Eliminar_servicio(Servicio_En serv)
        {
            int resultado = 0;
            try
            {
                using (SqlCommand cmd = new SqlCommand(
                "usp_Eliminarservicio", Conexion.leerCadena()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigo", serv.codigo);                   
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
        public DataTable buscar_servicio(int cod)
        {
            using (SqlDataAdapter Adap = new SqlDataAdapter(
                "usp_BuscarServicio", Conexion.leerCadena()))
            {
                Adap.SelectCommand.CommandType = CommandType.StoredProcedure;
                Adap.SelectCommand.Parameters.AddWithValue("@codigo", cod);
                using (DataTable tb = new DataTable())
                {
                    Adap.Fill(tb);
                    return tb;
                }
            }
        }
        
        public DataTable ListarServicio()
        {
            using (SqlDataAdapter da = new SqlDataAdapter(
                      "usp_ListarServicio", Conexion.leerCadena()))
            {
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                using (DataTable DT = new DataTable())
                {
                    da.Fill(DT);
                    return DT;
                }
            }
        }
        public decimal colocarPrecio(int cod)
        {
            decimal precio = 0;
            try
            {
                using (SqlCommand coman = new SqlCommand("colocar_precio", Conexion.leerCadena()))
                {
                    coman.CommandType = CommandType.StoredProcedure;
                    coman.Parameters.AddWithValue("@Cod", cod);
                    precio = Convert.ToDecimal(coman.ExecuteScalar());

                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Message{0}", e.Message);
            }
            finally
            {
                Conexion.leerCadena().Close();
            }
            return precio;
        }
        public int Cargar_Codigo()
        {
            int ultimo_codigo = 0;
            try
            {
                using (SqlCommand coman = new SqlCommand(
                    "select  max(id_servicio)  from Servicios", Conexion.leerCadena()))
                {
                    coman.CommandType = CommandType.Text;
                    ultimo_codigo = Convert.ToInt32(coman.ExecuteScalar());


                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Message:{0}", e.Message);
            }
            return ultimo_codigo;
        }

        public int buscar_servicio(Servicio_En serv)
        {
            int n = 0;                       
            try
            {
                string sql= "select * from Servicios where id_servicio=" + serv.codigo ;
                SqlCommand coman = new SqlCommand(sql, Conexion.leerCadena());               
                SqlDataReader leer = coman.ExecuteReader();                    
                       if (leer.Read() == true)
                        {
                            serv.codigo = Convert.ToInt32(leer[0].ToString());
                            serv.Nom_servicio = leer[1].ToString();
                           serv.precio = Convert.ToDouble(leer[2].ToString());                            
                            serv.discripcion = leer[3].ToString();
                            serv.estado = Convert.ToBoolean(leer[4].ToString());
                            n = 10;
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
 
