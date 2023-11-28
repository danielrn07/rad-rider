using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RadRiderWebApp.Models;

public class Skate
{
    public int Id { get; set; }
    
    [Display(Name = "Nome")]
    [StringLength(50, ErrorMessage = "Campo 'Nome' deve ter no maximo 50 caracteres.")]
    [Required(ErrorMessage = "Campo 'Nome' deve ser informado.")]
    public string Name { get; set; }
    public string NameSlug => Name.ToLower().Replace(" ", "-");
    
    [Required(ErrorMessage = "Campo 'Descrição' deve ser informado.")]
    [Display(Name = "Descrição")]
    public string Description { get; set; }
    
    [Required(ErrorMessage = "Uma imagem deve ser enviada.")]
    public string ImagePath { get; set; }
    
    [Required(ErrorMessage = "Campo 'Tamanho' deve ser informado.")]
    [Display(Name = "Tamanho")]
    public double Size { get; set; }
    
    [Display(Name = "Modelo")]
    [ForeignKey("SkateModelId")]
    public int? SkateModelId { get; set; }
    
    // [Required(ErrorMessage = "Campo 'Categoria' deve ser informado.")]
    // [Display(Name = "Categoria")]
    // public string Category { get; set; }
    
    [Display(Name = "Categoria")]
    public int? CategoryId { get; set; }
    
    [Display(Name = "Marca")]
    [ForeignKey("BrandId")]
    public int? BrandId { get; set; }
    
    public double ProductReview { get; set; }
    
    [Required(ErrorMessage = "Campo 'Quantidade' deve ser informado.")]
    public int Amount { get; set; }
    
    [Required(ErrorMessage = "Campo 'Preço' deve ser informado.")]
    [Display(Name = "Preço")]
    [DataType(DataType.Currency)]
    public double Price { get; set; }
    
    public bool LimitedEdition { get; set; }

    public string LimitedEditionFormatted =>
        LimitedEdition ? "Este produto é edição limitada" : "Este produto não é edição limitada";
    
    [Required(ErrorMessage = "Campo 'Data de fabricação' deve ser informado.")]
    [DataType("month")]
    [Display(Name = "Data de fabricação")]
    [DisplayFormat(DataFormatString = "{0:MM/yyyy}")]
    public DateTime ManufacturingDate { get; set; }
}