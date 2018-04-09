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
    public class Factura_Neg
    {
        Factura_Da f = new Factura_Da();
        Boleta_Da b = new Boleta_Da();
        public int RegistrarFactura(Factura_En fac)
        {
            return f.RegistrarFactura(fac);
        }
        public int RegistrarDetalleFactura(DetalleFactura_En DetF)
        {
            return f.RegistrarDetalleFactura(DetF);
        }
        public int colocarcodFactura()
        {
           return f.colocarcodFactura();
        }
        public DataTable Lista_Personal()
        {
            return b.Lista_Personal();
        }
        public DataTable Lista_Cliente()
        {
            return b.Lista_Cliente();
        }
        public DataTable Lista_TipoPago()
        {
            return b.Lista_Cliente();
        }       
        public DataTable Lista_Factura()
        {
            return f.Lista_Factura();
        }
    }
}
