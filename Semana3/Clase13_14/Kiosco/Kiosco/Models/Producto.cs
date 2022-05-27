using System.ComponentModel.DataAnnotations;

namespace Kiosco.Models
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Categoria { get; set; }
        [DataType(DataType.Date)]
        public DateTime FechaBaja { get; set; }

    }
}
