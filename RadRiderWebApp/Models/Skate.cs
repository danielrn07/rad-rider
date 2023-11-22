using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RadRiderWebApp.Models;

public class Skate
{
    public int Id { get; set; }
    public string Name { get; set; }
    
    [Display(Name = "Descrição")]
    public string Description { get; set; }
    public string ImagePath { get; set; }
    
    [Display(Name = "Tamanho")]
    public double Size { get; set; }
    
    [Display(Name = "Modelo")]
    public string Model { get; set; }
    
    [Display(Name = "Categoria")]
    public string Category { get; set; }
    
    [Display(Name = "Marca")]
    public string Brand { get; set; }
    public double ProductReview { get; set; }
    public int Amount { get; set; }
    
    [Display(Name = "Preço")]
    [DataType(DataType.Currency)]
    public double Price { get; set; }
    
    public bool LimitedEdition { get; set; }

    public string LimitedEditionFormatted =>
        LimitedEdition ? "Este produto é edição limitada" : "Este produto não é edição limitada";
    
    [Display(Name = "Data de fabricação")]
    [DisplayFormat(DataFormatString = "{0:MM/yyyy}")]
    public DateTime ManufacturingDate { get; set; }
}