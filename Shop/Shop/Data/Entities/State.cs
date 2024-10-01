using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Shop.Data.Entities
{
    public class State
    {

        public int Id { get; set; }

        [Display(Name = "Departamento")]
        [MaxLength(50, ErrorMessage = "El Campo{0} debe tener maximo {1} caractéres.")]
        [Required(ErrorMessage = "El Campo{0} es obligatorio.")]
        public String Name { get; set; }

        [JsonIgnore]
        public Country Country { get; set; }
        public ICollection<City> Cities { get; set; }
        [Display(Name = "Ciudades")]
        public int CitiesNumber => Cities == null ? 0: Cities.Count;    
    }
}
