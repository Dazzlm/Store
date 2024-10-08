﻿using System.ComponentModel.DataAnnotations;

namespace Shop.Data.Entities
{
    public class Country


    {


        public int Id { get; set; }

        [Display(Name = "País")]
        [MaxLength(50, ErrorMessage = "El Campo{0} debe tener maximo {1} caractéres.")]
        [Required(ErrorMessage = "El Campo{0} es obligatorio.")]
        public String Name { get; set; }

        public ICollection<State> States { get; set; }
        [Display(Name = "Departamentos")]
        public int StatesNumber  => States == null ? 0 :States.Count;
        
    }
}
