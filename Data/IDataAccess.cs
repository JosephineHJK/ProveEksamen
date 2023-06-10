using Shared;


namespace Data;

public interface IDataAccess
{
    Task<Student> CreateStudentAsync(Student student);

    public Task<ICollection<Student>> GetAllStudentsAsync();

    public Task AddGradeToStudentAsync(AddGradeDto dto);

    public Task<StatisticsOverviewDto> GetCourseStatisticsAsync();
}