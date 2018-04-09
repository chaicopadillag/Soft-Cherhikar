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
    public class Materiales_Neg
    {
        Materiales_DA m = new Materiales_DA();
        public DataTable listar_Categoria_Repuestos()
        {
            return m.listar_Categoria_Repuestos();
        }
        public int insertarMateriales(Materiales_EN mat_per)
        {
            return m.insertarMateriales(mat_per);
        }

        public int ActualizarMateriales(Materiales_EN mat)
        {
            return m.ActualizarMateriales(mat);
        }

        public int eliminarRepuestos(Materiales_EN mate)
        {
            return m.eliminarRepuestos(mate);
        }

        public DataTable ListarRepuestos()
        {
            return m.ListarRepuestos();
        }
        public DataTable BuscarRepuestos(Materiales_EN mat)
        {
            return m.BuscarRepuestos(mat);
        }
        public Boolean Buscar_Repuestos(Materiales_EN mat)
        {
            return m.Buscar_Repuestos(mat);
        }
        public int colocarcodmaterial()
        {
            return m.colocarcodmaterial();
        }

    }
}
