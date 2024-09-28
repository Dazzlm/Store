using System.ComponentModel.DataAnnotations;

namespace Shop.Models
{
    public class StateViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Departamento")]
        [MaxLength(50, ErrorMessage = "El Campo{0} debe tener maximo {1} caractéres.")]
        [Required(ErrorMessage = "El Campo{0} es obligatorio.")]
        public String Name { get; set; }

        public int CountryId { get; set; }
    }
}
