using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Reserva_Cliente_En
    {
        public int codigo { get; set; }
        public DateTime fecha { get; set; }
        public DateTime hora { get; set; }
        public string cod_client { get; set; }
        public string nombre { get; set; }
        public int cod_servicio { get; set; }
        public string placa { get; set; }
        public Boolean estado { get; set; }
    }
}
