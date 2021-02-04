using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Entities
{
    public class Course
    {
        [Key][Required]
        public int Id { get; set; }
        [Column(TypeName = "varchar(45)")]
        public string Section { get; set; }
        [Column(TypeName = "varchar(45)")]
        public string Turn { get; set; }
        public int Year { get; set; }
    }
}
