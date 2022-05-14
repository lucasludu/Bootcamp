using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class ConexionOracle : IConexion
    {
        public void Conectar()
        {
            Console.WriteLine("Conectado a: " + Conexion.Oracle.ToString());
        }

    }
}
