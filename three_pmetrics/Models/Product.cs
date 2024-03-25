using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace three_pmetrics.Models
{
    public class Product
    {
        [Display(Name="Urun Id")]
        public int ProductId { get; set; }
        
        [Required(ErrorMessage = "Gerekli bir alan")]
        [StringLength(100)]
        [Display(Name="Emisyon oluşum noktası")]
        public string PointName { get; set; } = null!;

        [Required(ErrorMessage = "Gerekli bir alan")]
        [StringLength(100)]
        [Display(Name="Emisyon oluşum noktası açıklaması")]
        public string PointDescription { get; set; } = null!;

        [Display(Name="Emisyon oluşum noktası resmi:")]
        public string? PointIcon { get; set; } = string.Empty;

        
        [Range(0, 100000)]
        [Display(Name="Emisyon faktörü")]
        public decimal? EmissionFactor { get; set; }

        [Required(ErrorMessage = "Gerekli bir alan")]
        [DataType(DataType.Date)]
        [Display(Name="Emisyon oluşma tarihi")]
        public DateTime? CreationDate { get; set; }

        [Required(ErrorMessage = "Gerekli bir alan")]
        [DataType(DataType.Time)]
        [Display(Name="Emisyon oluşma saati")]
        public DateTime? CreationTime { get; set; }

        [Required(ErrorMessage = "Gerekli bir alan")]
        [StringLength(100)]
        [Display(Name="Emisyon tüketim birimi")]
        public string EmissionFactorTitle { get; set; } = null!;

        public bool EmissionIsActive { get; set; }

        [Display(Name="Category")]
        
        [Required]
        public int? CategoryId { get; set; }

    }
}
