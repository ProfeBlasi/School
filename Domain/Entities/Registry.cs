using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Entities
{
    public class Registry
    {
        [Key][Required]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Assistance { get; set; }
    }
}
