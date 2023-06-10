using Microsoft.AspNetCore.Mvc;
using Shared;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class GradesController : ControllerBase
{
    [HttpGet]
    public Task<ActionResult<StatisticsOverviewDto>> GetCourseStatisticsAsync()
    {
        throw new NotImplementedException();
    }
}