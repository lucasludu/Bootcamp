using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovRefactor
{
    class Noticiero : Principal
    {
        protected string mensaje;

        public Noticiero(string mensaje) : base(mensaje)
        {

        }

        public override void Muestra()
        {
            Console.WriteLine("Desde el noticiero: {0}", mensaje);
        }
    }
