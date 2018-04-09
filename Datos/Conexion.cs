using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace Datos
{
    class Conexion
    {
        public static SqlConnection leerCadena()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(
                    ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                else
                {
                    con.Open();

                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Message:{0}", e.Message);
            }
            return con;
        }
    }
}
