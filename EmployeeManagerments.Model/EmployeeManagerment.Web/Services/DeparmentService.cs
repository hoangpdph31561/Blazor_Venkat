using EmployeeManagerment.API.ViewModel;

namespace EmployeeManagerment.Web.Services
{
    public class DeparmentService : IDeparmentService
    {
        private readonly HttpClient _httpClient;
        public DeparmentService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<DeparmentViewModel> GetDeparmentById(int id)
        {
            return await _httpClient.GetFromJsonAsync<DeparmentViewModel>($"api/deparments/{id}");
        }

        public async Task<List<DeparmentViewModel>> GetDeparments()
        {
            return await _httpClient.GetFromJsonAsync<List<DeparmentViewModel>>("api/deparments");
        }
    }
}
