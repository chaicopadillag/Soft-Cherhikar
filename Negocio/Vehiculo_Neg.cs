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

    public class Vehiculo_Neg
    {
        Vehiculo_Da c = new  Vehiculo_Da ();

        public int RegistarVehiculo(Vehiculo_En car)
        {
            return c.RegistarVehiculo(car);
        }

        public int ModificarVehiculo(Vehiculo_En car)
        {
            return c.ModificarVehiculo(car);
        }
        public int EliminarVehiculo(Vehiculo_En car)
        {
            return c.EliminarVehiculo(car);
        }
        public DataTable Listar_Vehiculo()
        {
            return c.Listar_Vehiculo();
        }
        public DataTable BuscarVehiculoTabla(Vehiculo_En car)
        {
            return c.BuscarVehiculoTabla(car);
        }

        public Boolean Buscar_VehiculoFrom(Vehiculo_En car)
        {
            return c.Buscar_VehiculoFrom(car);
         }

        public DataTable listar_Marca()
        {
            return c.listar_Marca();
        }
        public DataTable listar_tipoVehiculo()
        {
            return c.listar_tipoVehiculo();
        }
        public DataTable listar_Modelo(int car)
        {
            return c.listar_Modelo(car);
        }

        public DataTable Buscar_Cliente_Vehiculo(string cod)
        {
            return c.Buscar_Cliente_Vehiculo(cod);
        }
        public DataTable Listar_Cliente_Vehiculo()
        {
           return c.Listar_Cliente_Vehiculo();
        }
        }
}
