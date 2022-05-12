using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Country
    {
        private static Country _pais;

        private string countryName;
        private string[] countryProvinces;

        public string CountryName { get => countryName; set => countryName = value; }
        public string[] CountryProvinces { get => countryProvinces; set => countryProvinces = value; }

        public Country(string countryName, string[] countryProvince)
        {
            this.countryName = countryName;
            this.countryProvinces = countryProvinces;
        }

        public Country() 
        {
            countryName = "Sin asignar";
            countryProvinces = null;
        }

    }
}
