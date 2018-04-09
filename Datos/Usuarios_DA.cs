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
    public class Usuarios_DA
    {
        public int insertarUsuario(Usuarios_EN usu_ent)
        {
            int resultado = 0;

            try
            {
                using (SqlCommand cmd = new SqlCommand(
                     "Registar_Usuario", Conexion.leerCadena()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@cod", usu_ent.Codigo);
                    cmd.Parameters.AddWithValue("@nomb", usu_ent.Nombre);
                    cmd.Parameters.AddWithValue("@passwor", usu_ent.Contraseña);
                    cmd.Parameters.AddWithValue("@coreo", usu_ent.correo);
                    cmd.Parameters.AddWithValue("@tipo", usu_ent.tipo_usu);
                    cmd.Parameters.AddWithValue("@estado", usu_ent.estado);
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

        public int ActualizarUsuario(Usuarios_EN usu)
        {
            int resultado = 0;
            try
            {
                using (SqlCommand cmd = new SqlCommand(
                "Modificar_Usario", Conexion.leerCadena()))
                {   cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@cod", usu.Codigo);
                    cmd.Parameters.AddWithValue("@nomb", usu.Nombre);
                    cmd.Parameters.AddWithValue("@passwor", usu.Contraseña);
                    cmd.Parameters.AddWithValue("@coreo", usu.correo);
                    cmd.Parameters.AddWithValue("@tipo", usu.tipo_usu);
                    cmd.Parameters.AddWithValue("@estado", usu.estado);
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

        public int eliminarUsuario(Usuarios_EN usuar)
        {
            int resultado = 0;
            try
            {
                using (SqlCommand cmd = new SqlCommand(
                    "Elimnar_usuario", Conexion.leerCadena()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@cod", usuar.Codigo);
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

        public DataTable ListarUsuario()
        {
            using (SqlDataAdapter da = new SqlDataAdapter(
                      "Lista_Usuarios", Conexion.leerCadena()))
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

        public DataTable BuscarUsuario(Usuarios_EN usu)
        {
            using (SqlDataAdapter Da = new SqlDataAdapter(
               "Buscar_Usuario", Conexion.leerCadena()))

            {
                Da.SelectCommand.CommandType =
                CommandType.StoredProcedure;
                Da.SelectCommand.Parameters.
                AddWithValue("@cod", usu.Codigo);
                using (DataTable Dt = new DataTable())
                {
                    Da.Fill(Dt);
                    return Dt;
                }

            }
        }

        public Boolean Buscar_Usuario(Usuarios_EN usu)
        {
            Boolean respuesta = false;
            try
            { string sql = "select * from Usuario where id_usuario ='" + usu.Codigo + "'";
                SqlCommand coman = new SqlCommand(sql, Conexion.leerCadena());
                //coman.CommandType = CommandType.StoredProcedure;
                //coman.Parameters.AddWithValue("@cod", usu.Codigo);
                //Conexion.leerCadena().Open();
                SqlDataReader leer = coman.ExecuteReader();
            if (leer.Read()==true)
            {
                usu.Codigo = leer[0].ToString();
                usu.Nombre = leer[1].ToString();
                usu.Contraseña = leer[2].ToString();
                usu.correo = leer[3].ToString();
                usu.tipo_usu = Convert.ToInt32(leer[4].ToString());
                usu.estado = Convert.ToBoolean(leer[5].ToString());
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
        public DataTable listatipoUsuario()
        {
            using (SqlDataAdapter da = new SqlDataAdapter(
                "filtro_TipoUsuario", Conexion.leerCadena()))
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
        //public int Logueo(Usuarios_EN Usu_Ent)
        //{
        //    int resul = 0;
        //    try
        //    {   SqlCommand coman = new SqlCommand(string.Format(
        //        "select nombre_usuario,contraseña_usuario,id_tipousuario from Usuario"+
        //        " where nombre_usuario='{0}' and PWDCOMPARE('{1}'"+
        //        " contraseña_usuario)=1 and id_tipousuario='{2}'",
        //        Usu_Ent.Nombre,Usu_Ent.Contraseña,Usu_Ent.tipo_usu), Conexion.leerCadena());              

        //        SqlDataReader leer = coman.ExecuteReader();
        //        while (leer.Read())
        //        {                  
        //          resul = 10;
        //        }               

        //    }
        //   catch (Exception e)
        //    {
        //        e.GetBaseException();
        //    }

        //    return resul;
        //    }
        public int Logueo(Usuarios_EN Usu_Ent)
        {
            int resul = 0;
            try
            {
                SqlCommand coman = new SqlCommand("Ingreso_usuario", Conexion.leerCadena());
                coman.CommandType = CommandType.StoredProcedure;
                coman.Parameters.AddWithValue("@Usuario", Usu_Ent.Nombre);
                coman.Parameters.AddWithValue("@Password", Usu_Ent.Contraseña);
                coman.Parameters.AddWithValue("@perfil", Usu_Ent.tipo_usu);          
                SqlDataReader leer = coman.ExecuteReader();
                while (leer.Read())
                {
                    resul = 10;
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
            return resul;
        }

        public object obtener_cargo(string codigo, int cargo)
        {
            object carg = null;
            try
            {
                using(SqlCommand coman=new SqlCommand(
                    "validarcargo_personal", Conexion.leerCadena()))
                {
                    coman.CommandType = CommandType.StoredProcedure;
                    coman.Parameters.AddWithValue("@cod_personal", codigo);
                    coman.Parameters.AddWithValue("@cod_cargo", cargo);
                    carg = coman.ExecuteScalar();
                }
            }
            catch(Exception e){
                Console.WriteLine("Message{0}", e.Message);
            }
            return carg;
        }
        public object ColocarNombrePersonal(string codigo)
        {
            object per = null;
            try
            {
                using (SqlCommand coman = new SqlCommand(
                    "Colocar_Nmobre_personal", Conexion.leerCadena()))
                {
                    coman.CommandType = CommandType.StoredProcedure;
                    coman.Parameters.AddWithValue("@cod", codigo);                  
                    per = coman.ExecuteScalar();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Message{0}", e.Message);
            }
            return per;
        }

        public object ColocarNombreUsuario(string codigo)
        {
            object usu = null;
            try
            {
                using (SqlCommand coman = new SqlCommand(
                    "Colocar_Nombre_Usuario", Conexion.leerCadena()))
                {
                    coman.CommandType = CommandType.StoredProcedure;
                    coman.Parameters.AddWithValue("@cod", codigo);
                    usu = coman.ExecuteScalar();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Message{0}", e.Message);
            }
            return usu;
        }
        public DataTable listarcargo()
        {
            using(SqlDataAdapter adap=new SqlDataAdapter(
                "listarcargo", Conexion.leerCadena()))
            {
                using(DataTable tb= new DataTable())
                {
                    adap.Fill(tb);
                    return tb;
                }
            }
        }


    }

}                 
      

