using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Singleton
    {
        // Aqui guardamos la unica instancia que va a existir
        private static Singleton instancia;

        // Datos propios de la clase
        private string nombre;
        private int edad;

        // Se crea constructor privado
        private Singleton()
        {
            nombre = "Sin asignar";
            edad = 99;
        }

        public static Singleton ObtenInstancia()
        {
            // Se verifica si no existe la instancia
            if(instancia == null)
            {
                // Si no existe, instanciamos
                instancia = new Singleton();
                Console.WriteLine("---- Instancia creada por primera vez----");
            }
            // Regresamos la instancia
            return instancia;
        }

        // Aqui metodos propios de la clase
        public override string ToString()
        {
            return String.Format("La persona {0}, tiene edad de {1}", nombre, edad);
        }

        public void PonerDatos(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        // Esto representa cualquier otro objeto
        public void AlgunProceso()
        {
            Console.WriteLine("{0} esta trabajando en algo", nombre);
        }
    }
}
