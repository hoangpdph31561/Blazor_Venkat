using EmployeeManagerment.API.ViewModel;

namespace EmployeeManagerment.Web.Services
{
    public interface IDeparmentService
    {
        Task<List<DeparmentViewModel>> GetDeparments();
        Task<DeparmentViewModel> GetDeparmentById(int id);
    }
}
