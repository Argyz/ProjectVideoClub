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
        [MaxLength(30,ErrorMessage = "Oops...hubo un error. El campo no puede exceder lo 30 caracteres")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Error el campo es obligatario")]
        [MaxLength(30, ErrorMessage = "Oops...hubo un error. El campo no puede exceder lo 30 caracteres")]
        public string LastName { get; set; }
    }
}

