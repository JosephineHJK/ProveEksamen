using System.ComponentModel.DataAnnotations;

namespace Shared;

public class GradeInCourse
{
    [Required, MaxLength(4)]
    public string? CourseCode { get; set; }
    
    [Required]
    public int Grade { get; set; }
    
    [Key]
    public int GradeId { get; set; }
    
}