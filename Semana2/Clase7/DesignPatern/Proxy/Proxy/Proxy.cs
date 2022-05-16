using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    /*
     * Se hace uso de anidamientoadentro de la clase.
     * Esto hace que cualquier clase colocada como privada y anidada
     * solo sea conocida por Proxy
     */

    public class Proxy
    {
        public interface ISujeto
        {
            void Peticion(int op);
        }

        public class ProxySencillo : ISujeto
        {
            private Cocina cocina;

            public void Peticion(int op)
            {
                if(cocina == null)
                {
                    Console.WriteLine("Activado el sujeto");
                    cocina = new Cocina();
                }
                if(op == 1)
                {
                    cocina.RecetaSecreta();
                }
                if(op == 2)
                {
                    cocina.Cocinar(5);
                }
            }
        }

        public class ProxySeguro : ISujeto
        {
            private Cocina cocina;

            public void Peticion(int op)
            {
                string password;

                Console.WriteLine("Dame Password: ");
                password = Console.ReadLine();

                if(password == "abc123")
                {
                    if(cocina == null)
                    {
                        Console.WriteLine("Activando el sujeto.");
                        cocina = new Cocina();
                    }
                    if(op == 1)
                    {
                        cocina.RecetaSecreta();
                    }
                    if(op == 2)
                    {
                        cocina.Cocinar(5);
                    }
                } 
                else
                {
                    Console.WriteLine("Acceso Denegado");
                }
            }
        }

        // Esta es la clase que estamos protegiendo con el proxy
        private class Cocina
        {
            public void RecetaSecreta()
            {
                Console.WriteLine("Pan");
                Console.WriteLine("Aceite de Oliva");
                Console.WriteLine("Especias");
                Console.WriteLine("Jamon");
                Console.WriteLine("Queso");
            }

            public void Cocinar(int n)
            {
                Console.WriteLine("Cocinando {0} recentas", n);
            }
        }

    }
}
