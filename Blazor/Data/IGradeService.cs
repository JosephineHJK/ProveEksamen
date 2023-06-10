using Shared;

namespace BlazorServer.Data;

public interface IGradeService
{
    public Task<StatisticsOverviewDto> GetCourseStatisticsAsync();
}