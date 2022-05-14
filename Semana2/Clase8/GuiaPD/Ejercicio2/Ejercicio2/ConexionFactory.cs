using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class ConexionFactory
    {
        IConexion conexiones;
        public void GetConnection(Conexion conexion)
        {
            switch(conexion)
            {
                case Conexion.MySql:
                    conexiones = new ConexionMysql();
                    break;
                case Conexion.SQL:
                    conexiones = new ConexionSQL();
                    break;
                case Conexion.Oracle:
                    conexiones = new ConexionOracle();
                    break;
            }
            conexiones.Conectar();
        }
    }
}
