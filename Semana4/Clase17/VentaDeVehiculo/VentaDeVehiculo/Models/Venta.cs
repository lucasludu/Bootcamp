using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VentaDeVehiculo.Models
{
    /// <summary>
    /// Permite registrar las ventas de los vehiculos de los clientes
    /// </summary>
    public class Venta
    {
        /// <summary>
        /// Id de la venta
        /// </summary>
        /// <value>El Id se incrementa automaticamente</value>
        [Key]
        public int Id { get; set; }

        [Required]
        public double Importe { get; set; }

        public double Descuento { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }

        /// <summary>
        /// Se vincula el vehiculo con la venta por id
        /// </summary>
        [ForeignKey("Vehiculo")] 
        public int VehiculoId { get; set; }
        public Vehiculo? Vehiculo { get; set; }

        /// <summary>
        /// Se vincula el cliente con la venta por id
        /// </summary>
        [ForeignKey("Cliente")]
        public int ClienteId { get; set; }
        public Cliente? Cliente { get; set; }
    }
}
