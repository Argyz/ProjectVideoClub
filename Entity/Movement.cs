using System.ComponentModel.DataAnnotations;

namespace Entity
{
    public class Movement : EntityBase
    {
        [Required(ErrorMessage = "Error el campo es obligatorio")]
        [MaxLength(30, ErrorMessage = "Oops...hubo un error. El campo no puede exceder lo 30 caracteres")]
        public string Name { get; set; }
        public Client Client { get; set; }
    }
}
