using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace webappUno.Models
{
    public class Person
    {
        [Key]
        public int PersonID { get; set; }

        [Required(ErrorMessage ="Your fucking name, please")]
        [Display(Name = "Nombre Completo")]
        [StringLength(100,ErrorMessage ="Acortalo a 100")]

        public string Name { get; set; }
        [Display(Name="Tu carnet")]
        public string Document { get; set; }
    }
}