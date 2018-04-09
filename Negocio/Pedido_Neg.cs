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
    public class Pedido_Neg
    {
        Pedido_Da p = new Pedido_Da();
        //-------------------------------------------------------------------------------
        //Metodos para Pedido
        public int cargarUltimoCodigoPedido()
        {
            return p.cargarUltimoCodigoPedido();
        }
        public int Registar_Pedido(Pedido_En pedido)
        {
            return p.Registar_Pedido(pedido);
        }

        public int Disminuir_Existencia_Repuesto(int id_repuesto, int cantidadVendida)
        {
            return p.Disminuir_Existencia_Repuesto(id_repuesto, cantidadVendida);
        }

        public int Cargar_Cantidad_Existencia_Repuesto(int cod)
        {
            return p.Cargar_Cantidad_Existencia_Repuesto(cod);
        }
        public int Eliminar_Pedido(Pedido_En pedido)
        {
            return p.Eliminar_Pedido(pedido);
        }

        public DataTable Lista_Persoanl()
        {
            return p.Lista_Persoanl();
        }

        public DataTable lista_repuesto(int cod_catag)
        {
            return p.lista_repuesto(cod_catag);
        }
        public DataTable lista_categoria_rpto()
        {
            return p.lista_categoria_rpto();
        }
        public DataTable Buscar_Pedido(Pedido_En pedido)
        {
            return p.Buscar_Pedido(pedido);
        }

        public DataTable Listar_Pedido() {
         return   p.Listar_Pedido();
        }

        public decimal colocar_precio(int cod)
        {
            return p.colocar_precio(cod);
        }

        //-------------------------------------------------------------------------------
        //Metodos para Detalle_Pedido
        public int Registar_Detalle_Pedido(Detallepedido_En Deta_pedido) {
            return p.Registar_Detalle_Pedido(Deta_pedido);
        }     

        public int Eliminar_Detalle_Pedido(Detallepedido_En Deta_pedido)
        {
            return p.Eliminar_Detalle_Pedido(Deta_pedido);
        }

        public DataTable BuscarDetallePedido(int num_pedido)
        {
            return p.BuscarDetallePedido(num_pedido);
        }


    }
}
