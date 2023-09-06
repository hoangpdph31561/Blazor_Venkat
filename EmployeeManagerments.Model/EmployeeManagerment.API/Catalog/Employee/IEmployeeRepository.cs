using EmployeeManagerment.API.Request;
using EmployeeManagerment.API.ViewModel;
using SelfLearn_Blazor_kudvenkat.Entities;

namespace EmployeeManagerment.API.Catalog.Employee
{
    public interface IEmployeeRepository
    {
        Task<List<EmployeeViewModel>> GetEmployees();
        Task<EmployeeViewModel> GetEmployeeById(int id);
        Task<EmployeeViewModel> AddNewEmployee(EmployeeRequest request);
        Task<EmployeeViewModel> UpdateEmployee(int id, EmployeeRequest request);
        Task DeleteEmployee(int id);
    }
}
