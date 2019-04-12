using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArtSchoolApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ArtSchoolApp.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }

        //override the default behavior by specifying singular table names in the DbContext
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<Student>().ToTable("Student");
        }
    }
}

// creates a DbSet property for each entity set
// an entity set typically corresponds to a database table, and an entity corresponds to a row in the table.