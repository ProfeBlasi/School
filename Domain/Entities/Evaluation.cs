using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Entities
{
    public class Evaluation
    {
        public int Id { get; set; }
        [Column(TypeName = "varchar(45)")]
        public string Name { get; set; }
        [Column(TypeName = "varchar(45)")]
        public string Trimester { get; set; }
        [ForeignKey("Alumno")]
        public int StudentId { get; set; }
        public int Qualification { get; set; }
        public int Recuperative { get; set; }
        public Student Staudent { get; set; }
    }
}
