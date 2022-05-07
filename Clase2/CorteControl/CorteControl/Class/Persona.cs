using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorteControl.Class
{
    public class Persona
    {
        public int legajo { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public double valorHora { get; set; }
        public int horasTrabajadas { get; set; }
        public double sueldoCobrar { get; set; }
        public string ultimoProceso { get; set; }

        public Persona() { }

        public Persona(int legajo, string nombre, string apellido, double valorHora, int horasTrabajadas, double sueldoCobrar, string ultimoProceso)
        {
            this.legajo = legajo;
            this.nombre = nombre;
            this.apellido = apellido;
            this.valorHora = valorHora;
            this.horasTrabajadas = horasTrabajadas;
            this.sueldoCobrar = valorHora * horasTrabajadas;
            this.ultimoProceso = ultimoProceso;
        }

        public override string ToString()
        {
            return legajo + ";" + nombre + ";" + apellido + ";" + valorHora + ";" + horasTrabajadas + ";" + sueldoCobrar + ";" + ultimoProceso;
        }

        /*public override string ToString()
        {
            return "Legajo: " + legajo + 
                   "\nNombre y Apellido: " + nombre + ", " + apellido +
                   "\nValor de la hora: " + valorHora + 
                   "\nHoras Trabajadas: " + horasTrabajadas +
                   "\nSueldo a Cobrar: " + sueldoCobrar +
                   "\nUltimo Proceso: " + ultimoProceso;
        }*/
    }
}
