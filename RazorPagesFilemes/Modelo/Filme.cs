using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.SqlServer;


namespace RazorPagesFilemes.Modelo
{
    public class Filme
    {
        public int ID { get; set; }
        [Display(Name = "Título")]
        [StringLength(100, MinimumLength =4)]
        [Required(ErrorMessage = "Digite o título do filme")]
        public string Titulo { get; set; } =  string.Empty;

        [Display (Name = "Data de lançamento")] 
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Digite o data de lançamento do filme")]
        public DateTime DataLacamento { get; set; }
        [Display(Name = "Genêro")]

        [Required(ErrorMessage = "Digite o genêro do filme")]
        [StringLength (100, MinimumLength = 4)]
        public string Genero { get; set; } = string.Empty;

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        [Display (Name ="Preço")]
        [Required(ErrorMessage = "Digite o preço do filme")]
        public decimal Preco { get; set; }
        public decimal Precow { get; set; }

        [Range(0, 5)]
        [Required(ErrorMessage = "Digite os pontos do filme")]
        public int Pontos { get; set; } = 0;

    }
}
