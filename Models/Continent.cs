using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Country_Information.Models
{
    [Table("continents")]
    public class Continent
    {
        [Key]
        public int id { get; set; }

        
        public string? name { get; set; }
        
        public string? description { get; set; }
    }
}