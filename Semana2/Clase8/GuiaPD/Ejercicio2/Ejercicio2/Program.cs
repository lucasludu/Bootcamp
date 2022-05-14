using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConexionFactory conexionFactory = new ConexionFactory();

            conexionFactory.GetConnection(Conexion.MySql);
            Console.WriteLine("\n-----------------\n");
            conexionFactory.GetConnection(Conexion.SQL);
            Console.WriteLine("\n-----------------\n");
            conexionFactory.GetConnection(Conexion.Oracle);
            Console.WriteLine("\n-----------------\n");

            Console.ReadKey();
        }
    }
}
