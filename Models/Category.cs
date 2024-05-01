using System.ComponentModel.DataAnnotations;

namespace BlazorShop.Models;

public class Category {

    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Informe o Título")]
    [Length(3, 60, ErrorMessage = "Categoria deve ter pelo menos 3 caractéres e no máximo 60")]
    public string Title { get; set; } = string.Empty;
    
}