using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
   public  class Boleta_En
    {
        public int numcomprobante { get; set; }        
        //public int pago { get; set; }
        public DateTime fecha { get; set; }
        public string personal { get; set; }
        public string cliente { get; set; }
        public Boolean estado { get; set; }
        public double montototal { get; set; }

    }
}
