using System;
using System.ComponentModel.DataAnnotations;

namespace Entity
{
    public class StockMovie : EntityBase
    {
       
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Date { get; set; }
        public int Amount { get; set; }
    }
}
