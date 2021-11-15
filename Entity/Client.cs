using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entity
{
    public class Client : Person
    {
        [Required(ErrorMessage = "Error el campo es obligatorio")]
        [MaxLength(50, ErrorMessage = "Oops...hubo un error. El campo no puede exceder lo 30 caracteres")]
        public string Pelicula { get; set; }
        public ICollection<Movement> Movies { get; set; }
        

    }
}
