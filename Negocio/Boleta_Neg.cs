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

    public class Boleta_Neg
    {
        Boleta_Da b = new Boleta_Da();        
       
        public int RegistrarBoleta(Boleta_En bol)
        {
            return b.RegistrarBoleta(bol);
        }
        public DataTable Lista_Personal()
        {
            return b.Lista_Personal();
        }
        public DataTable Lista_Cliente()
        {
            return b.Lista_Cliente();
        }
        public DataTable Lista_boleta()
        {
            return b.Lista_boleta();
        }
        public int colocarcodboleta()
        {
            return b.colocarcodboleta();
        }
        public DataTable listarpedidos(int codpedido)
        {
            return b.listarpedidos(codpedido);
        }
        public DataTable listarservicios(int codservicio)
        {
            return b.listarservicios(codservicio);
        }
        public int RegistrarDetalleBoleta(DetalleBoleta_En DetB)
        {
            
            return b.RegistrarDetalleBoleta(DetB);
        }
        //public int RegistrarDetalleFactura(DetalleFactura_En DetF)
        //{
        //    return detF.RegistrarDetalleFactura(DetF);
        //}
    }
}
