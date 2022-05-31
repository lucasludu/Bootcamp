using System.ComponentModel.DataAnnotations;

namespace VentaDeVehiculo.Models
{
    /// <summary>
    /// Permite registrar los vehiculos de la concesionaria
    /// </summary>
    public class Vehiculo
    {
        /// <summary>
        /// Id del vehiculo
        /// </summary>
        /// <value>El Id se incrementa automaticamente</value>
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Marca { get; set; }

        [Required]
        public string? Modelo { get; set; }

        [Required]
        public double Importe { get; set; }

        [DataType(DataType.Date)]
        public DateTime FechaBaja { get; set; }

    }
}
