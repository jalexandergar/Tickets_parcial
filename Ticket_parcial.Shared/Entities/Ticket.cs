using System.ComponentModel.DataAnnotations;

namespace Ticket_parcial.Shared.Entities
{
    public class Ticket
    {
        public string? Id { get; set; }

        [Display(Name = "Categoría")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(80, ErrorMessage = "El campo {0} no puede tener más de {1} caractéres")]
        public DateTime? Date { get; set; }

        public bool Marked { get; set; }

        public string? Gate { get; set; }
    }
}
