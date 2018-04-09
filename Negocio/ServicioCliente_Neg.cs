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
    public class ServicioCliente_Neg
    {
        ServicoCliente_Da s = new ServicoCliente_Da();

        public DataTable Listar_Personal_mecanico()
        {
            return s.Listar_Personal_mecanico();
        }

        public int RegistrarServicioCliente(ServicioCliente_En serv)
        {
            return s.RegistrarServicioCliente(serv);
        }

        public DataTable cargarServicios()
        {
            return s.cargarServicios();
        }

        public decimal colocarPrecio_servicio(int cod)
        {
            return s.colocarPrecio_servicio(cod);
        }

        public DataTable Buscar_placa_vehiculo(string cod_clie)
        {
            return s.Buscar_placa_vehiculo(cod_clie);
        }

        public int RegistrarDetalle_ServicioCliente(DetalleServicioCiente_EN serv)
        {
            return s.RegistrarDetalle_ServicioCliente(serv);
        }

        public int Cargar_Mayor_Codigo()
        {
            return s.Cargar_Mayor_Codigo();
        }

        public DataTable listarServicio_Cliente()
        {
            return s.listarServicio_Cliente();
        }

        public DataTable listarDetalle_ServicioCliente(int num_serv)
        {
            return s.listarDetalle_ServicioCliente(num_serv);
        }

        public DataTable buscar_Servicio_cliente(int num_serv)
        {
            return s.buscar_Servicio_cliente(num_serv);
        }

        public int Eliminar_servicio(ServicioCliente_En serv)
        {
            return s.Eliminar_servicio(serv);

        }
    }
}
