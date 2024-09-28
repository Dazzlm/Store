using System.ComponentModel.DataAnnotations;

namespace Shop.Data.Entities
{
    public class Category
    {


        public int Id { get; set; }

        [Display(Name = "Categoria")]
        [MaxLength(50, ErrorMessage = "El Campo{0} debe tener maximo {1} caractéres.")]
        [Required(ErrorMessage = "El Campo{0} es obligatorio.")]
        public String Name { get; set; }

    }
}
