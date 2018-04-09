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
    public class Personal_DA
    {
        public int insertarPersonal(Personal_EN per_ent)
        {
            int resultado = 0;

            try
            {
                using (SqlCommand cmd = new SqlCommand(
                     "Registrar_Personal", Conexion.leerCadena()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@cod", per_ent.Codigo);
                    cmd.Parameters.AddWithValue("@nombre_per", per_ent.Nombre);
                    cmd.Parameters.AddWithValue("@apepaterno", per_ent.Nombrepaterno);
                    cmd.Parameters.AddWithValue("@apematerno ", per_ent.Nombrematerno);
                    cmd.Parameters.AddWithValue("@direccion", per_ent.Direccion);
                    cmd.Parameters.AddWithValue("@telefono", per_ent.Telefono);
                    cmd.Parameters.AddWithValue("@distrito", per_ent.Distrito);
                    cmd.Parameters.AddWithValue("@cargo", per_ent.Cargo);
                    cmd.Parameters.AddWithValue("@estado", per_ent.Estado);
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


        public int ActualizarPersonal(Personal_EN per)
        {
            int resultado = 0;
            try
            {
                using (SqlCommand cmd = new SqlCommand(
                "Modificar_Personal", Conexion.leerCadena()))
                {   
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@cod", per.Codigo);
                    cmd.Parameters.AddWithValue("@nombre_per", per.Nombre);
                    cmd.Parameters.AddWithValue("@apepaterno", per.Nombrepaterno);
                    cmd.Parameters.AddWithValue("@apematerno ", per.Nombrematerno);
                    cmd.Parameters.AddWithValue("@direccion", per.Direccion);
                    cmd.Parameters.AddWithValue("@telefono", per.Telefono);
                    cmd.Parameters.AddWithValue("@distrito", per.Distrito);
                    cmd.Parameters.AddWithValue("@cargo", per.Cargo);
                    cmd.Parameters.AddWithValue("@estado", per.Estado);
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

         public int eliminarPersonal(Personal_EN pers)
        {
            int resultado = 0;
            try
            {
                using (SqlCommand cmd = new SqlCommand(
                    "Elimnar_Personal", Conexion.leerCadena()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@cod", pers.Codigo);
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


        public DataTable ListarPersonal()
        {
            using (SqlDataAdapter da = new SqlDataAdapter(
                      "Lista_Personal", Conexion.leerCadena()))
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
         public DataTable BuscarPersonal(Personal_EN per)
        {
            using (SqlDataAdapter Da = new SqlDataAdapter(
               "Buscar_Personal", Conexion.leerCadena()))

            {
                Da.SelectCommand.CommandType =
                CommandType.StoredProcedure;
                Da.SelectCommand.Parameters.
                AddWithValue("@cod", per.Codigo);
                using (DataTable Dt = new DataTable())
                {
                    Da.Fill(Dt);
                    return Dt;
                }

            }
        }


         public Boolean Buscar_Personal(Personal_EN per)
        {
            Boolean respuesta = false;
            try
            { string sql = "select * from Personal where id_personal ='" + per.Codigo + "'";
                SqlCommand coman = new SqlCommand(sql, Conexion.leerCadena());
                //coman.CommandType = CommandType.StoredProcedure;
                //coman.Parameters.AddWithValue("@cod", usu.Codigo);
                //Conexion.leerCadena().Open();
                SqlDataReader leer = coman.ExecuteReader();
            if (leer.Read()==true)
            {
                per.Codigo = leer[0].ToString();
                per.Nombre = leer[1].ToString();
                per.Nombrepaterno = leer[2].ToString();
                per.Nombrematerno = leer[3].ToString();
                per.Direccion = leer[4].ToString();
                per.Telefono = Convert.ToInt32(leer[5].ToString());
                per.Distrito = Convert.ToInt32(leer[6].ToString());
                per.Cargo = Convert.ToInt32(leer[7].ToString());
                per.Estado = Convert.ToBoolean(leer[8].ToString());
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


        public DataTable listarCargo()
        {
            using (SqlDataAdapter da = new SqlDataAdapter(
                "listarcargo", Conexion.leerCadena()))
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

            public DataTable listaDistrito()
        {
            using (SqlDataAdapter da = new SqlDataAdapter(
                "listardistrito", Conexion.leerCadena()))
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
                
            
       