using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Shared;

namespace Data;

public class DataAccess : IDataAccess
{
    private readonly StudentContext context;

    public DataAccess(StudentContext context)
    {
        this.context = context;
    }

    public async Task<Student> CreateStudentAsync(Student student)
    {
        EntityEntry<Student> newStudent = await context.Students.AddAsync(student);
        await context.SaveChangesAsync();
        return newStudent.Entity;
    }

    public async Task<ICollection<Student>> GetAllStudentsAsync(string name)
    {
        Student? existing = await context.Students.FirstOrDefaultAsync(s =>
            s.Name.ToLower().Equals(name.ToLower())
        );
        return existing;
    }

    public Task AddGradeToStudentAsync(AddGradeDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<StatisticsOverviewDto> GetCourseStatisticsAsync()
    {
        throw new NotImplementedException();
    }
}