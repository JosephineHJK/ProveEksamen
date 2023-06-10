using System.Text.Json;
using Shared;

namespace BlazorServer.Data;

public class StudentHttpClient : IStudentService
{
    private readonly HttpClient client;

    public StudentHttpClient(HttpClient client)
    {
        this.client = client;
    }
    
    public async Task<Student> CreateAsync(Student dto)
    {
        HttpResponseMessage response = await client.PostAsJsonAsync("/Students", dto);
        string result = await response.Content.ReadAsStringAsync();
        if (!response.IsSuccessStatusCode)
        {
            throw new Exception(result);
        }

        Student student = JsonSerializer.Deserialize<Student>(result, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        })!;
        return student;
    }

    public async Task AddGradeToStudentAsync(AddGradeDto dto)
    {
        HttpResponseMessage response = await client.PostAsJsonAsync("/grades", dto);
        if (!response.IsSuccessStatusCode)
        {
            string content = await response.Content.ReadAsStringAsync();
            throw new Exception(content);
        }
    }


    public async Task<ICollection<Student>> GetAllStudentsAsync(string? nameContains = null)
    {
        string uri = "/students";
        if (!string.IsNullOrEmpty(nameContains))
        {
            uri = $"?name={nameContains}";
        }

        HttpResponseMessage response = await client.GetAsync(uri);
        string result = await response.Content.ReadAsStringAsync();
        if (!response.IsSuccessStatusCode)
        {
            throw new Exception(result);
        }

        ICollection<Student> students =
            JsonSerializer.Deserialize<ICollection<Student>>(result, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        })!;
        return students;
    }
}
    

    


