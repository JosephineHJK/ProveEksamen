using Data;
using Microsoft.AspNetCore.Mvc;
using Shared;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class StudentController : ControllerBase
{
    private readonly IDataAccess dataAccess;

    public StudentController(IDataAccess dataAccess)
    {
        this.dataAccess = dataAccess;
    }
    [HttpPost]
    public async Task<ActionResult<Student>> CreateAsync(Student dto)
    {
        try
        {
            Student student = await dataAccess.CreateStudentAsync(dto);
            return Created($"/students/{student.Id}", student);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return StatusCode(500, e.Message);
        }
    }

    [HttpGet]
    public async Task<ICollection<Student>> GetAllStudentsAsync()
    {
        ICollection<Student> students = await DataAccess.GetAllStudentsAsync;
            return students;
    }

    [HttpPost("student/{studentId}")]
    public async Task<ActionResult> AddGradeToStudentAsync([FromBody] GradeInCourse grade, [FromRoute] int studentId)
    {
        try
        {
            GradeInCourse added = await DataAccess.AddGradeToStudentAsync(grade, studentId);
            return Created($"{added.Id}", added);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return StatusCode(500, e.Message);
        }
    }
}