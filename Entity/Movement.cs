using System.ComponentModel.DataAnnotations;

namespace Entity
{
    public class Movement : EntityBase
    {
       
        public string Name { get; set; }
        public Client Client { get; set; }
    }
}
