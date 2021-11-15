using System;
using System.ComponentModel.DataAnnotations;

namespace Entity
{
    public class StockMovie : EntityBase
    {
        [Required(ErrorMessage = "Error el campo es obligatorio")]
        [MaxLength(30, ErrorMessage = "Oops...hubo un error. El campo no puede exceder lo 30 caracteres")]
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Date { get; set; }
        public int Amount { get; set; }
    }
}
