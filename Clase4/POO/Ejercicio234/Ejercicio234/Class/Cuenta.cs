using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio234.Class
{
    public class Cuenta
    {
        private Persona titular;
        private double cantidad;

        public Cuenta(Persona titular)
        {
            this.titular = titular;
        }

        public Cuenta(Persona titular, double cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public Persona Titular { get => titular; }
        public double Cantidad { get => cantidad; set => cantidad = value; }

        public override string ToString()
        {
            return "Titular de la cuenta: " + titular.ToString() + " $ " + cantidad;
        }

        public double ingresarDinero(double monto)
        {
            try 
            { 
                if(monto > 0)
                {
                    this.cantidad += monto;
                } 
                else
                {
                    Console.WriteLine("No ingresó dinero a la cuenta.");
                }
            }
            catch(Exception)
            {
                Console.WriteLine("Ingrese un dato númerico.");
            }
            return this.cantidad;
        }

        public double retirarDinero(double monto)
        {
            try
            {
                if(this.cantidad <= -2000)
                {
                    this.cantidad -= monto;
                } 
                else
                {
                    Console.WriteLine("No tiene dinero suficiente para retirar.");
                }
            }
            catch(Exception)
            {
                Console.WriteLine("Ingresar un dato númerico.");
            }
            return this.cantidad;
        }


    }
}
