using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia6.Ejercicio5
{

    public abstract class Animal
    {
        public string nombre { get; set; }

        public Animal(string nombre)
        {
            this.nombre = nombre;
        }

        public override string ToString()
        {
            return "Nombre: " + nombre;
        }

    }

    public class Perro : Animal
    {
        public Perro(string nombre) :base(nombre)
        {

        }
    }

    public class Gato : Animal
    {
        public Gato(string nombre) : base(nombre)
        {

        }
    }

    public class Pila<T>
    {
        private Stack<T> elementos;

        public void initPila()
        {
            elementos = new Stack<T>();
        }

        public void Apilar(T obj)
        {
            elementos.Push(obj);
        }

        public void Desapilar()
        {
            for(int i = 0; i < elementos.Count; i++) 
            { 
                elementos.Pop();
            }
        }

    }
}
