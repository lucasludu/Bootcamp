﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia6.Ejercicio6
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
        public Perro(string nombre) : base(nombre)
        {

        }
    }
    public class Gato : Animal
    {
        public Gato(string nombre) : base(nombre)
        {

        }
    }

    public class Cola<T> 
    {
        private List<T> elementos;

        public Cola()
        {
            elementos = new List<T>();
        }

        public void Agregar(T obj)
        {
            elementos.Insert(0, obj);
        }

        public T Desencolar()
        {
            T obj = elementos.Last();
            elementos.Remove(obj);
            return obj;
        }

        public void Mostrar()
        {
            foreach(T obj in elementos)
            {
                Console.WriteLine(obj);
            }
        }

    }
}
