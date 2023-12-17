using Microsoft.EntityFrameworkCore;

namespace LearnEF.Entities
{
    public class UniversityDbContext : DbContext
    {
        public DbSet<Major> Majors { get; set; }
        public DbSet<ClassRoom> ClassRooms { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-GUEV6L6;Initial Catalog=uni1;User Id=sa;Password=12345;MultipleActiveResultSets=true;");
        }
    }
}
