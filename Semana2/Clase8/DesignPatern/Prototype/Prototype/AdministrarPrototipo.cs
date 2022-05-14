using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class AdministrarPrototipo
    {

        private Dictionary<string, IPrototipo> prototipos = new Dictionary<string, IPrototipo>();

        public AdministrarPrototipo()
        {
            // Adicionamos los objetos prototipo con los valores iniciales que nos interesan
            Persona persona = new Persona("Ciudadano", 18);
            prototipos.Add("Persona", persona);

            Valores valores = new Valores(1);
            prototipos.Add("Valores", valores);
        }

        public void AdicionarPrototipo(string llave, IPrototipo prototipo)
        {
            prototipos.Add(llave, prototipo);
        }

        public object ObtenPrototipo(string llave)
        {
            return prototipos[llave].Clonar();

        }
    }
}
