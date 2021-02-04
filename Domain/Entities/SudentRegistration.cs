using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Entities
{
    public class SudentRegistration
    {
        [Key][Required]
        public int Id { get; set; }
        [ForeignKey("Registro")]
        public int RegistrationId { get; set; }
        [ForeignKey("Alumno")]
        public int StudentId { get; set; }
        public Registry Registration { get; set; }
        public Student Student { get; set; }

    }
}
