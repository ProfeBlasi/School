using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
namespace AccesData.Context
{
    public class Contexto : DbContext
    { 
        static Contexto instance = null;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-818EPCG;Database=School;Trusted_Connection=True;");
        }
        public static Contexto getInstance()
        {
            if (instance == null)
            {
                instance = new Contexto();
            }
            return instance;
        }

        public DbSet<Student> Stdent { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<Evaluation> Evaluation { get; set; }
        public DbSet<Registry> Registry { get; set; }
        public DbSet<SudentRegistration> SudentRegistration { get; set; }
        public DbSet<Proceedings> Proceedings { get; set; }

    }

}