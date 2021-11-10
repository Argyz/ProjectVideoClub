using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Movie : EntityBase
    {
        [Required(ErrorMessage = "Error el campo es obligatorio")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Error el campo es obligatorio")]
        public string Gender { get; set; }

        public DateTime Date { get; set; }
        public Client Client { get; set; }
    }
}
