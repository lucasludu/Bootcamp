using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploGenerico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AlmacenObjetos<DateTime> archivos = new AlmacenObjetos<DateTime>(4);

            /*archivos.Agregar("Juan");
            archivos.Agregar("Carlos");
            archivos.Agregar("Tono");
            archivos.Agregar("Sandra");*/

            archivos.Agregar(new DateTime());
            /*archivos.Agregar(new Empleado(2500));
            archivos.Agregar(new Empleado(3500));
            archivos.Agregar(new Empleado(4500));*/

            DateTime nombrePersona = archivos.getElemento(0);

            Console.WriteLine(nombrePersona);

            Console.ReadKey();
        }

        class AlmacenObjetos<T>
        {
            private T[] datosElemento;
            private int i = 0;

            public AlmacenObjetos(int z)
            {
                datosElemento = new T[z];
            }

            public void Agregar(T obj)
            {
                datosElemento[i] = obj;
                i++;
            }

            public T getElemento(int i)
            {
                return datosElemento[i];
            }

        }

        class Empleado
        {
            private double salario; 

            public Empleado(double salario)
            {
                this.salario = salario;
            }

            public double getSalario()
            {
                return salario;
            }
        }

    }
}
