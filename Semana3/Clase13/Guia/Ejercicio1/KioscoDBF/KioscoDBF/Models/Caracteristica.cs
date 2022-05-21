namespace KioscoDBF.Models
{
    public class Caracteristica
    {
        public int Id { get; set; }
        public int ProductoId { get; set; }
        public double Precio { get; set; }
        public double Ancho { get; set; }
        public double Largo { get; set; }
        public double Peso { get; set; }
    }
}
