using EmployeeManagerment.API.Request;
using EmployeeManagerment.API.ViewModel;
using Microsoft.AspNetCore.Diagnostics;
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

        public async Task<string> CreateNewEmployee(EmployeeRequest request)
        {
            var result = await _httpClient.PostAsJsonAsync("api/employees", request);
            if(result.IsSuccessStatusCode)
            {
                return "success";
            }
            else
            {
                string errorContent = await result.Content.ReadAsStringAsync();
                return errorContent;
            }
        }

        public async Task<List<EmployeeViewModel>> GetEmployee()
        {
            return await _httpClient.GetFromJsonAsync<List<EmployeeViewModel>>("api/employees");
        }

        public async Task<EmployeeViewModel> GetEmployeeById(int id)
        {
            return await _httpClient.GetFromJsonAsync<EmployeeViewModel>($"api/employees/{id}");
        }

        public async Task<bool> UpdateEmployee(int id, EmployeeRequest request)
        {
            var result = await _httpClient.PutAsJsonAsync($"api/employees/{id}", request);
            return result.IsSuccessStatusCode;
        }

        
    }
}
