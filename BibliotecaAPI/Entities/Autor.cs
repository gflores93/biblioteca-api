using System.ComponentModel.DataAnnotations;

namespace BibliotecaAPI.Entities
{
    public class Autor
    {
        public int Id { get; set; }
        [Required]
        public required string Nombre { get; set; }

        // Propiedad usada para crear relación 1 a muchos, no modifica estructuras de tablas, pero si crea el mapeo de navigación en DBContext
        public List<Libro> Libros { get; set; } = new List<Libro>(); 
    }
}
