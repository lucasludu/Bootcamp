using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio234.Class
{
    #region classes
    public class CuentaJoven : Cuenta 
    {
        private double bonificacion;

        public CuentaJoven(Persona titular, double cantidad, double bonificacion) : base(titular, cantidad)
        {
            this.Bonificacion = bonificacion;
        }

        public double Bonificacion { get => bonificacion; set => bonificacion = value; }

        public override string ToString()
        {
            return "\n\tCuenta Joven: \n" + base.ToString() + "\n\tLa bonificación es de: " + bonificacion + "%";
        }

        public bool esTitularValido()
        {
            if(this.Titular.Edad >= 18 && this.Titular.Edad <= 25)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void retirarDinero(double monto)
        {
            if(esTitularValido())
            {
                try 
                { 
                    if(Cantidad > 0)
                    {
                        this.Cantidad -= monto;
                    } 
                    else
                    {
                        Console.WriteLine("No posee dínero en la cuenta");
                    }
                }
                catch(Exception)
                {
                    Console.WriteLine("Ingrese un valor númerico.");
                }
            }
            else
            {
                Console.WriteLine("No es un titular valido.");
            }
        }

    }
    #endregion
}
