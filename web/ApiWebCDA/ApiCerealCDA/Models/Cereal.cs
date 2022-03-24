using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCerealCDA.Models
{
    [Table("tata")]
    public class Cereal
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Le champs est requis")]
        // [MinLength(2)]
        // [MaxLength(32)]
        [StringLength(64, MinimumLength = 2)]
        [RegularExpression("^[^_]{2,50}$")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Le champs est requis")]
        [Range(-1, 500)]
        public int Calories { get; set; }

        [Required(ErrorMessage = "Le champs est requis")]
        [Range(-1, 500)]
        public int Protein { get; set; }

        [Required(ErrorMessage = "Le champs est requis")]
        [Range(-1, 500)]
        public ushort Sodium { get; set; }

        [Required(ErrorMessage = "Le champs est requis")]
        [Range(-1, 500)]
        public int Fiber { get; set; }

        [Required(ErrorMessage = "Le champs est requis")]
        [Range(-1, 500)]
        public int Carbo { get; set; }

        [Required(ErrorMessage = "Le champs est requis")]
        [Range(-1, 500)]
        public int Sugars { get; set; }

        [Required(ErrorMessage = "Le champs est requis")]
        [Range(-1, 500)]
        public int Potass { get; set; }

        [Required(ErrorMessage = "Le champs est requis")]
        [Range(-1, 500)]
        public int Vitamins { get; set; }

        [Required(ErrorMessage = "Le champs est requis")]
        [Range(0.0, 100.0)]
        [Column(TypeName = "decimal(5,2)")]
        //[Precision(2)]
        public decimal Rating { get; set; }
    }
}
