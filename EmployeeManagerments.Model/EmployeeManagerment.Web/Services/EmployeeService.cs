using EmployeeManagerment.API.Request;
using EmployeeManagerment.API.ViewModel;
using SelfLearn_Blazor_kudvenkat.Entities;
using System.Net.Http.Json;

namespace EmployeeManagerment.Web.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly HttpClient _httpClient;
        public EmployeeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<EmployeeViewModel>> GetEmployee()
        {
            return await _httpClient.GetFromJsonAsync<List<EmployeeViewModel>>("api/employees");
        }

        public async Task<EmployeeViewModel> GetEmployeeById(int id)
        {
            return await _httpClient.GetFromJsonAsync<EmployeeViewModel>($"api/employees/{id}");
        }

        public async Task<int> UpdateEmployee(int id, EmployeeRequest request)
        {
            var result = await _httpClient.PutAsJsonAsync($"api/employees/{id}", request);
            return (int)result.StatusCode;
        }

        
    }
}
