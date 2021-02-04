using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Entities
{
    public class Student
    {
        [Key] [Required]
        public int Id { get; set; }
        [Column(TypeName = "varchar(45)")]
        public string LastNameName { get; set; }
        [ForeignKey("Curso")]
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
