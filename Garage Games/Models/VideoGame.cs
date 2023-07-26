using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Garage_Games.Models
{
    [Table("VideoGame")]
    public class VideoGame
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage ="Nome não informado")]
        [StringLength(70, MinimumLength = 10, ErrorMessage = "O {0} deve ter no mínimo {1} e no máximo {2} caracteres")]
        public string Nome { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "Descrição não informada")]
        [MinLength(20, ErrorMessage = "A descrição deve ter no mínimo {1} caracteres")]
        [MaxLength(100, ErrorMessage = "A descrição deve ter no máximo {1} caracteres")]
        public string DescricaoCurta { get; set; }

        [Display(Name = "Descrição detalhada")]
        [Required(ErrorMessage = "Descrição detalhada não informada")]
        [MinLength(20, ErrorMessage = "A descrição deve ter no mínimo {1} caracteres")]
        [MaxLength(100, ErrorMessage = "A descrição deve ter no máximo {1} caracteres")]
        public string DescricaoDetalhada { get; set; }

        [Display(Name = "Preço")]
        [Required(ErrorMessage = "Preço não informado")]
        [Column(TypeName = "decimal(7,2)")]
        [Range(1,99999.99, ErrorMessage = "O preço deve estar entre R$ {1} e R$ {2}")]
        public decimal Preco { get; set; }

        [Display(Name = "Caminho da imagem")]
        [StringLength(200, ErrorMessage = "O caminho da imagem deve ter no máximo {1} caracteres")]
        public string ImagemUrl { get; set; }

        [Display(Name = "Caminho da imagem de thumbnail")]
        [StringLength(200, ErrorMessage = "A url da imagem deve ter no máximo {1} caracteres")]
        public string ImagemThumbnailUrl { get; set; }

        [Display(Name = "Favorito ?")]
        public bool favorito { get; set; }

        [Display(Name = "Disponível em estoque ? ")]
        public bool disponivel { get; set; }


        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
