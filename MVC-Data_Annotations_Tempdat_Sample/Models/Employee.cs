using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcApplication1.Models
{
    public class Employee
    {
        public int Id { get; set; }
        //add all other validation
        [Required(ErrorMessage="Plz enter the name")]
        public string Name {get; set; }
        [Required(ErrorMessage = "Plz enter the city")]
        public string City { get; set; }
       
    }
}