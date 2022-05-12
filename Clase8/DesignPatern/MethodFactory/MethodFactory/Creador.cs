using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodFactory
{
    // Aca se implementa el metodo fabrica
    class Creador
    {
        public static IVehiculo MetodoFabrica(int dinero)
        {
            IVehiculo temp = null;

            // Se selecciona el tipo de instancia segun las reglas
            if(dinero > 10000000)
            {
                temp = new Avion();
            }
            else if(dinero > 200000)
            {
                temp = new Auto();
            }
            else
            {
                temp = new Bici();
            }
            return temp;
        }
    }
}
