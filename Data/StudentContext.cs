using Microsoft.EntityFrameworkCore;
using Shared;

namespace Data;

public class StudentContext : DbContext
{
    public DbSet<Student> Students { get; set; }
    
    public DbSet<GradeInCourse> Grade { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source = ...Migrations.db");
    }

    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
      //  modelBuilder.Entity<Student>().HasKey(student => student.Id);
        //modelBuilder.Entity<GradeInCourse>().HasKey(gradeInCourse => gradeInCourse.Id);
    //}
}