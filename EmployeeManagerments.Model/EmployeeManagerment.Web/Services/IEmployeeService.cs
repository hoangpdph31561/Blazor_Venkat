using EmployeeManagerment.API.Request;
using EmployeeManagerment.API.ViewModel;
using SelfLearn_Blazor_kudvenkat.Entities;

namespace EmployeeManagerment.Web.Services
{
    public interface IEmployeeService
    {
        Task<List<EmployeeViewModel>> GetEmployee();
        Task<EmployeeViewModel> GetEmployeeById(int id);
        Task<int> UpdateEmployee(int id, EmployeeRequest request);
    }
}
