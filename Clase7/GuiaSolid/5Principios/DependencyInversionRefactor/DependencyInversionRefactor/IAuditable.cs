using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionRefactor
{
    interface IAuditable
    {
        IEnumerable<Producto> ObtenProductos(int tipo);
    }
}
