using EmployeeManagerment.API.DBContext;
using EmployeeManagerment.API.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagerment.API.Catalog.Deparment
{
    public class DeparmentRespository : IDeparmentRespository
    {
        private readonly EmployeeManagermentDBContext _dbContext;
        public DeparmentRespository(EmployeeManagermentDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<DeparmentViewModel> GetDeparmentById(int id)
        {
            var result = await _dbContext.Deparments.FirstOrDefaultAsync(x => x.DeparmentId == id);
            if(result == null)
            {
                return null;
            }
            return new DeparmentViewModel
            {
                DeparmentId = id,
                DeparmentName = result.DeparmentName
            };
        }

        public async Task<List<DeparmentViewModel>> GetDeparments()
        {
            var result = await _dbContext.Deparments.Select(x => new DeparmentViewModel()
            {
                DeparmentId = x.DeparmentId,
                DeparmentName = x.DeparmentName,
            }).ToListAsync();
            return result;
        }
    }
}
