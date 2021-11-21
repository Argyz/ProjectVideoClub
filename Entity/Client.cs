using System.Collections.Generic;

namespace Entity
{
    public class Client : Person
    {
        public ICollection<Movement> Movies { get; set; }
        
    }
}
