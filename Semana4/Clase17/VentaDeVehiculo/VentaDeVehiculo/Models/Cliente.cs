using System.ComponentModel.DataAnnotations;

namespace VentaDeVehiculo.Models
{
    /// <summary>
    /// Permite registrar los clientes de la concesionaria
    /// </summary>
    public class Cliente
    {
        /// <summary>
        /// Id del cliente
        /// </summary>
        /// <value>El Id se incrementa automaticamente</value>
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Nombre { get; set; }

        [Required]
        public string? Apellido { get; set; }

        [Required]
        public string? DNI { get; set; }

        [Required]
        public string? Direccion { get; set; }
    }
}
