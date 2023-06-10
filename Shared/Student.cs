using System.ComponentModel.DataAnnotations;

namespace Shared;

public class Student
{
    [MaxLength(25)]
    public string Name { get; set; }

    [Required]
    public string Programme { get; set; }
    
    [Key]
    public int Id { get; set; }
    
    public Student(string name, string programme)
    {
        Name = name;
        Programme = programme;
    }
    
    public ICollection<GradeInCourse> GradeInCourses { get; set;}
}