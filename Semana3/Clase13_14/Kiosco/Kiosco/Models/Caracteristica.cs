using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kiosco.Models
{
    public class Caracteristica
    {
        [Key]
        public int Id { get; set; }
        public double Precio { get; set; }
        public double Ancho { get; set; }
        public double Largo { get; set; }
        public double Peso { get; set; }

        [ForeignKey("Producto")]
        public int Producto_Id { get; set; }
        public Producto Producto { get; set; }
    }
}
