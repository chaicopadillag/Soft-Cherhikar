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
   public class Cliente_Neg
    {
        //INSTANCIAR LA CLASE PRODUCTOS DE DATOS
        Clientes_Da D = new Clientes_Da();
        public bool InsertarClienteR(Cliente_EN Pro)
        {
            return D.InsertarCliente(Pro);
        }
        public int ActualizarClienteR(Cliente_EN Pro)
        {
            return D.ActualizarCliente(Pro);
        }
        public int EliminarClienteR(Cliente_EN cli)
        {
            return D.EliminarCliente(cli);
        }
        public DataTable ListaDistritoR()
        {
            return D.ListaDistrito();
        }
        public DataTable ListaTipoClienteR()
        {
            return D.ListaTipoCliente();
        }

        public DataTable ListaPersonalR()
        {
            return D.ListaPersonal();
        }
        public DataTable ListaClienteR()
        {
            return D.ListaCliente();
        }

        public int BuscarCliente(Cliente_EN Pro)
        {
            return D.BuscarCliente(Pro);
        }


    }
}

