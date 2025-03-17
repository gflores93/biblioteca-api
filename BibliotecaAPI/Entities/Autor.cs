using System.ComponentModel.DataAnnotations;

namespace BibliotecaAPI.Entities
{
    public class Autor
    {
        public int Id { get; set; }
        [Required]
        public required string Nombre { get; set; }
    }
}
