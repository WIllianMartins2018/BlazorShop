using System.ComponentModel.DataAnnotations;

namespace BlazorShop.Models;

public class Product {

    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Informe o Título")]
    [Length(3, 120, ErrorMessage = "Produto deve ter pelo menos 3 caractéres e no máximo 120")]
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; }

    [Required(ErrorMessage = "Informe o preço do produto")]
    [DataType(DataType.Currency)]
    public decimal Price { get; set; }
    
    public int CategoryId { get; set; }
    public Category Category {get; set; } = null!;
}