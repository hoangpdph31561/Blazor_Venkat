using EmployeeManagerment.API.ViewModel;

namespace EmployeeManagerment.API.Catalog.Deparment
{
    public interface IDeparmentRespository
    {
        Task<List<DeparmentViewModel>> GetDeparments();
        Task<DeparmentViewModel> GetDeparmentById(int id);
    }
}
