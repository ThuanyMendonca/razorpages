using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesFilme.Models
{
    public class Filme
    {
        public int ID { get; set; }
        [StringLength(100, MinimumLength = 3)]
        public string Titulo { get; set; } = string.Empty;

        [Display(Name = "Data de lançamento")]
        [DataType(DataType.Date)]
        public DateTime DataLancamento { get; set; }

        [Required(ErrorMessage = "Digite o genero do filme")]
        [StringLength(30, MinimumLength = 3)]
        public string Genero { get; set; } = string.Empty;

        [DataType(DataType.Currency)]
        [BindProperty]
        [RegularExpression(@"^\d+(\.\d{1,2})?$", ErrorMessage = "O campo deve ser um número com até duas casas decimais.")]

        [Column(TypeName = "decimal(18,2)")]
        public decimal Preco { get; set; }

        [Range(0,5)]
        public int Pontos { get; set; } = 0;
    }
}
