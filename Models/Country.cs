using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Country_Information.Models
{
    [Table("countries")]
    public class Country
    {
        [Key]
        public int id { get; set; }

        public string? name { get; set; }

        public int continent_id { get; set; }

        public string? lenguage { get; set; }

        public string? population { get; set; }
    }
}