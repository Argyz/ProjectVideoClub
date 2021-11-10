using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Person : EntityBase
    {
        [Required(ErrorMessage = "Error el campo es obligatorio")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Error el campo es obligatario")]
        public string LastName { get; set; }
    }
}
