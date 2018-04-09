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
   public class Reserva_Cliente_Neg
    {
        Reserva_Cliente_Da R = new Reserva_Cliente_Da();

        public int coloccar_ultimoCodigo()
        {
            return R.coloccar_ultimoCodigo();
        }
        public int RegistrarReserva(Reserva_Cliente_En  reserva)
        {
            return R.RegistrarReserva(reserva);

        }
        public int EliminarReserva(Reserva_Cliente_En reserva)
        {
            return R.EliminarReserva(reserva);
        }
        public DataTable buscar_reserva_cliente(int num_reser)
        {
            return R.buscar_reserva_cliente(num_reser);
        }
        public DataTable Buscar_Cliente(string cod_cli)
        {
            return R.Buscar_Cliente(cod_cli);
        }       
        public DataTable listar_Reserva()
        {
            return R.Listar_Reserva();
        }
        public DataTable Listar_personal()
        {
            return R.Listar_personal();
        }
        public DataTable listar_servicio()
        {
            return R.listar_servicio();
        }
    }
}
