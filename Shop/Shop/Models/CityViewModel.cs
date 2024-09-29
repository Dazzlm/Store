using System.ComponentModel.DataAnnotations;

namespace Shop.Models
{
    public class CityViewModel
    {

        public int Id { get; set; }

        [Display(Name = "Ciudad")]
        [MaxLength(50, ErrorMessage = "El Campo{0} debe tener maximo {1} caractéres.")]
        [Required(ErrorMessage = "El Campo{0} es obligatorio.")]
        public String Name { get; set; }

        public int StateId { get; set; }

    }
}
