using Shared;

namespace BlazorServer.Data;

public interface IStudentService
{
     Task<Student> CreateAsync(Student student);

     Task<ICollection<Student>> GetAllStudentsAsync(string? nameContains = null);

     Task AddGradeToStudentAsync(AddGradeDto dto);
}
