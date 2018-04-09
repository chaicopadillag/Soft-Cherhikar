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
    public class Materiales_DA
    {
        public int colocarcodmaterial()
        {
            int cod = 0;
            try
            {
                using (SqlCommand command = new SqlCommand("generarcodigo", Conexion.leerCadena()))
                {
                    command.CommandType = CommandType.Text;
                    cod = Convert.ToInt32(command.ExecuteScalar());

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

            return cod;
        }
        public int insertarMateriales(Materiales_EN mat_ent)
        {
            int resultado = 0;

            try
            {
                using (SqlCommand cmd = new SqlCommand(
                     "Registrar_Repuestos", Conexion.leerCadena()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@cod", mat_ent.Codigo);
                    cmd.Parameters.AddWithValue("@nombre_repuesto", mat_ent.Nombre);
                    cmd.Parameters.AddWithValue("@precio_repuesto", mat_ent.Precio);
                    cmd.Parameters.AddWithValue("@cantidad_repuesto", mat_ent.Cantidad);
                    cmd.Parameters.AddWithValue("@marca_repuesto", mat_ent.Marca);
                    cmd.Parameters.AddWithValue("@id_categoriarepuesto", mat_ent.Categoria);
                    cmd.Parameters.AddWithValue("@estado", mat_ent.Estado);
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
        public int ActualizarMateriales(Materiales_EN mat)
        {
            int resultado = 0;
            try
            {
                using (SqlCommand cmd = new SqlCommand(
                "Modificar_Repuestos", Conexion.leerCadena()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@cod", mat.Codigo);
                    cmd.Parameters.AddWithValue("@nombre_repuesto", mat.Nombre);
                    cmd.Parameters.AddWithValue("@precio_repuesto", mat.Precio);
                    cmd.Parameters.AddWithValue("@cantidad_repuesto", mat.Cantidad);
                    cmd.Parameters.AddWithValue("@marca_repuesto", mat.Marca);
                    cmd.Parameters.AddWithValue("@id_categoriarepuesto", mat.Categoria);
                    cmd.Parameters.AddWithValue("@estado", mat.Estado);
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



        public int eliminarRepuestos(Materiales_EN mate)
        {
            int resultado = 0;
            try
            {
                using (SqlCommand cmd = new SqlCommand(
                    "Elimnar_Repuestos", Conexion.leerCadena()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@cod", mate.Codigo);
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
   

         public DataTable ListarRepuestos()
        {
            using (SqlDataAdapter da = new SqlDataAdapter(
                      "Lista_Repuestos", Conexion.leerCadena()))
            {
                da.SelectCommand.CommandType =
                    CommandType.StoredProcedure;
                using (DataTable DT = new DataTable())
                {
                    da.Fill(DT);
                    return DT;
                 }
            }
        }
            
        

         public DataTable BuscarRepuestos(Materiales_EN mat)
        {
            using (SqlDataAdapter Da = new SqlDataAdapter(
               "Buscar_Repuestos", Conexion.leerCadena()))

            {
                Da.SelectCommand.CommandType =
                CommandType.StoredProcedure;
                Da.SelectCommand.Parameters.
                AddWithValue("@cod", mat.Codigo);
                using (DataTable Dt = new DataTable())
                {
                    Da.Fill(Dt);
                    return Dt;
                }

            }
        }

           public Boolean Buscar_Repuestos(Materiales_EN mat)
        {
            Boolean respuesta = false;
            try
            { string sql = "select * from Repuestos where id_repuesto ='" + mat.Codigo + "'";
                SqlCommand coman = new SqlCommand(sql, Conexion.leerCadena());
                //coman.CommandType = CommandType.StoredProcedure;
                //coman.Parameters.AddWithValue("@cod", usu.Codigo);
                //Conexion.leerCadena().Open();
                SqlDataReader leer = coman.ExecuteReader();
            if (leer.Read()==true)
            {
                mat.Codigo = leer[0].ToString();
                mat.Nombre = leer[1].ToString();
                mat.Precio = Convert.ToDouble(leer[2].ToString());
                mat.Cantidad = Convert.ToInt32(leer[3].ToString());
                mat.Marca = leer[4].ToString();
                mat.Categoria = Convert.ToInt32(leer[5].ToString());
                mat.Estado = Convert.ToBoolean(leer[6].ToString());
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
           public DataTable listar_Categoria_Repuestos()
           {
               using (SqlDataAdapter da = new SqlDataAdapter(
                   "listarCategoriaRepuestos", Conexion.leerCadena()))
               {
                   da.SelectCommand.CommandType =
                       CommandType.StoredProcedure;
                   using (DataTable DT = new DataTable())
                   {
                       da.Fill(DT);
                       return DT;
                   }
               }
           }
    }
}
       

        
    
