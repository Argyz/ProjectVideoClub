using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Client : Person
    {
        [Required(ErrorMessage = "Error el campo es obligatorio")]
        public string User { get; set; }

        public ICollection<Movie> Movies { get; set; }
        

    }
}
