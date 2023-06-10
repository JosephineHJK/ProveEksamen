namespace Shared;

public class AddGradeDto
{
    public string StudentId { get; }

    public string GradeInCourse { get; } 

    public AddGradeDto(string studentId, string gradeInCourse)
    {
        StudentId = studentId;
        GradeInCourse = gradeInCourse;
    }
    
}