using System.ComponentModel.DataAnnotations;

namespace VulnerabilidadesApp.Models
{
    public class Vulnerabilidade
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O título é obrigatório.")]
        public string? Titulo { get; set; }

        [Required(ErrorMessage = "A descrição é obrigatória.")]
        public string? Descricao { get; set; }

        [Required(ErrorMessage = "A severidade é obrigatória.")]
        public string? Severidade { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data de Descoberta")]
        public DateTime DataDescoberta { get; set; }
    }
}
