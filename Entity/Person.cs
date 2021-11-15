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
        
        public string Name { get; set; }

       
        public string LastName { get; set; }
    }
}

