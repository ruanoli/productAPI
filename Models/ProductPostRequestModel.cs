using System.ComponentModel.DataAnnotations;

namespace ProductAPI.Services.Models
{
    public class ProductPostRequestModel
    {
        [Required(ErrorMessage = "Informe o nome do produto.")]
        public string? Name { get; set; }
        [StringLength(200, ErrorMessage = "Tamanho máximo de caracteres {1}")]
        public string? Description { get; set; }
        [Required(ErrorMessage = "Informe a quantidade de produtos.")]
        public int Quantity { get; set; }
        [Required(ErrorMessage = "Informe o preço do produtos.")]
        public decimal Price { get; set; }
    }
}
