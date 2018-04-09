using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;
using System.Data;


namespace Negocio
{
    
    public  class Usuarios_Neg
    { Usuarios_DA u = new Usuarios_DA();
        public object obtener_cargo(string codigo, int cargo)
        {
            return u.obtener_cargo(codigo, cargo);
        }

        public DataTable listarcargo()
        {
            return u.listarcargo();
        }

        public object ColocarNombrePersonal(string codigo)
        {
            return u.ColocarNombrePersonal(codigo);
        }

        public object ColocarNombreUsuario(string codigo)
        {
            return u.ColocarNombreUsuario(codigo);
        }
        public int Logueo(Usuarios_EN Usu_Ent)
        {
            return u.Logueo(Usu_Ent);
        }

        public int insertarUsuario(Usuarios_EN usu_ent)
        {
            return u.insertarUsuario(usu_ent);
        }

        public int ActualizarUsuario(Usuarios_EN usu)
        {
            return u.ActualizarUsuario(usu);
        }

        public int eliminarUsuario(Usuarios_EN usuar)
        {
            return u.eliminarUsuario(usuar);
        }

        public DataTable ListarUsuario()
        {
            return u.ListarUsuario();
        }


        public DataTable BuscarUsuario(Usuarios_EN usu)
        {
            return u.BuscarUsuario(usu);
        }
        public DataTable listatipoUsuario()
        {
            return u.listatipoUsuario();
        }

        public Boolean Buscar_Usuario(Usuarios_EN usu)
        {
            return u.Buscar_Usuario(usu);
        }
        }
}
