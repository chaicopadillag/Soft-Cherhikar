using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
     public class Pedido_En
    {
        public int numpedido {  get;set; }
        public string personal { get; set; }
        public string cliente{ get; set; }
        public DateTime fecha { get; set; }
        public double importe { get; set; }
        public  Boolean estado { get; set; }
    }
}
