using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using Datos;
using System.Data;
namespace Negocio
{
   public class Servicio_Neg
    {
       Servicio_Da  s = new Servicio_Da();
        public int Registar_servicios(Servicio_En serv)
        {
            return s.Registar_servicios(serv);
        }
        public int ModificarServicio(Servicio_En serv)
        {
            return s.ModificarServicio(serv);
        }
        public DataTable buscar_servicio(int cod)
        {
           return s.buscar_servicio(cod);
        }
        public int buscar_servicio(Servicio_En serv)
        {
            return s.buscar_servicio(serv);
        }
        public DataTable ListarServicio()
        {
            return s.ListarServicio();
        }
        public decimal colocarPrecio(int cod)
        {
            return s.colocarPrecio(cod);
        }
        public int Cargar_Codigo()
        {
            return s.Cargar_Codigo();
        }
        public int Eliminar_servicio(Servicio_En serv)
        {
            return s.Eliminar_servicio(serv);
        }

    }
}
