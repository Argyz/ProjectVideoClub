using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entity
{
    public class Client : Person
    {
        
        public ICollection<Movement> Movies { get; set; }
        
    }
}
