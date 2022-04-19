using Microsoft.EntityFrameworkCore;

namespace EFAndLinqPractice_SchoolAPI.Models
{
    public class SchoolContext : DbContext
    {
        //Se debe agregar el dbContext

        public SchoolContext(DbContextOptions op): base(op) { }

        //referencia a los models
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }

    }
}