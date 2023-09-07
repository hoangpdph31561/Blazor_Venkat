using SelfLearn_Blazor_kudvenkat.Entities;

namespace EmployeeManagerment.Web.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly HttpClient _httpClient;
        public EmployeeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<Employee>> GetEmployee()
        {
            return await _httpClient.GetFromJsonAsync<List<Employee>>("api/employees");
        }
    }
}
