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
    public class Personal_Neg
    {
        Personal_DA p = new Personal_DA();
        public DataTable listarCargo()
        {
            return p.listarCargo();
        }
        public int insertarPersonal(Personal_EN per_ent)
        {
            return p.insertarPersonal(per_ent);
        }

        public int ActualizarPersonal(Personal_EN per)
        {
            return p.ActualizarPersonal(per);
        }

        public int eliminarPersonal(Personal_EN pers)
        {
            return p.eliminarPersonal(pers);
        }
           public DataTable ListarPersonal()
        {
            return p.ListarPersonal();
        }
        public DataTable listaDistrito()
        {
            return p.listaDistrito();
        }
        public DataTable BuscarPersonal_tabla(Personal_EN per)
        {
            return p.BuscarPersonal(per);
        }
        public Boolean Buscar_Personal(Personal_EN per)
        {
            return p.Buscar_Personal(per);
        }

    
        }
    }

