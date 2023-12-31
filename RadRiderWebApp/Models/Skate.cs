using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RadRiderWebApp.Models;

public class Skate
{
    public int Id { get; set; }
    
    [Display(Name = "Nome")]
    [StringLength(200, ErrorMessage = "Campo 'Nome' deve ter no maximo 200 caracteres.")]
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
    
    [Display(Name = "Categoria")]
    public int? CategoryId { get; set; }
    
    [Display(Name = "Marca")]
    [ForeignKey("BrandId")]
    public int? BrandId { get; set; }
    
    public double ProductReview { get; set; }
    
    [Display(Name = "Quantidade")]
    [Required(ErrorMessage = "Campo 'Quantidade' deve ser informado.")]
    [Range(0, int.MaxValue, ErrorMessage="A quantidade deve ser maior ou igual a zero.")]
    public int Amount { get; set; }
    
    [Required(ErrorMessage = "Campo 'Preço' deve ser informado.")]
    [Display(Name = "Preço")]
    [DataType(DataType.Currency)]
    public double Price { get; set; }
    
    [Required(ErrorMessage = "Campo 'Data de fabricação' deve ser informado.")]
    [DataType("month")]
    [Display(Name = "Data de fabricação")]
    [DisplayFormat(DataFormatString = "{0:MM/yyyy}")]
    public DateTime ManufacturingDate { get; set; }

    public ICollection<Tag>? Tags { get; set; }
}