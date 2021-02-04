using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Entities
{
    public class Proceedings
    {
        [Key][Required]
        public int Id { get; set; }
        [ForeignKey("Alumno")]
        public int StudentId { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Intensity { get; set; }
        public Student Student { get; set; }
    }
}
