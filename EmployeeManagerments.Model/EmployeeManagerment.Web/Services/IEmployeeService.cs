using SelfLearn_Blazor_kudvenkat.Entities;

namespace EmployeeManagerment.Web.Services
{
    public interface IEmployeeService
    {
        Task<List<Employee>> GetEmployee();
        Task<Employee> GetEmployeeById(int id);
    }
}
