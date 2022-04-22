using System.ComponentModel.DataAnnotations;

namespace ApiPostCrearHumano.Model
{
    public class Humano
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Sexo { get; set; }
        [Required]
        public int Edad { get; set; }
        [Required]
        public decimal Altura { get; set; }
        [Required]
        public decimal Peso { get; set; }
    }
}
