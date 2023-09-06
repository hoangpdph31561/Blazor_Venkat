using EmployeeManagerment.API.DBContext;
using EmployeeManagerment.API.Request;
using EmployeeManagerment.API.ViewModel;
using Microsoft.EntityFrameworkCore;
using SelfLearn_Blazor_kudvenkat.Entities;

namespace EmployeeManagerment.API.Catalog.Employee
{
    public class EmployeeRespository : IEmployeeRepository
    {
        private readonly EmployeeManagermentDBContext _dbContext;
        public EmployeeRespository(EmployeeManagermentDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<EmployeeViewModel> AddNewEmployee(EmployeeRequest request)
        {
            var resultDeparment = await _dbContext.Deparments.FirstOrDefaultAsync(x => x.DeparmentId == request.DeparmentId);
            if (resultDeparment == null)
            {
                return null;
            }
            
            var newEmployee = new SelfLearn_Blazor_kudvenkat.Entities.Employee
            {
                
                FirstName = request.FirstName,
                LastName = request.LastName,
                DateOfBirth = request.DateOfBirth,
                Email = request.Email,
                Gender = request.Gender,
                DeparmentId = request.DeparmentId,
                PhotoPath = request.PhotoPath,
            };
            _dbContext.Employees.Add(newEmployee);
            await _dbContext.SaveChangesAsync();
            var finalResult = new EmployeeViewModel
            {
                EmployeeId = newEmployee.EmployeeId,
                FirstName = request.FirstName,
                LastName = request.LastName,
                DateOfBirth = request.DateOfBirth,
                Email = request.Email,
                Gender = request.Gender,
                DeparmentId = request.DeparmentId,
                PhotoPath = request.PhotoPath,
            };
            return finalResult;
        }

        public async Task DeleteEmployee(int id)
        {
            var result = await _dbContext.Employees.FirstOrDefaultAsync(x => x.EmployeeId == id);
            if (result == null)
            {
                throw new Exception("Unable to find");
            }
            _dbContext.Employees.Remove(result);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<EmployeeViewModel> GetEmployeeById(int id)
        {
            var result = await _dbContext.Employees.FirstOrDefaultAsync(x => x.EmployeeId == id);
            if (result == null)
            {
                return null;
            }
            var finalResult = new EmployeeViewModel
            {
                EmployeeId = result.EmployeeId,
                FirstName = result.FirstName,
                LastName = result.LastName,
                DateOfBirth = result.DateOfBirth,
                Email = result.Email,
                Gender = result.Gender,
                DeparmentId = result.DeparmentId,
                PhotoPath = result.PhotoPath,
            };
            return finalResult;
        }

        public async Task<List<EmployeeViewModel>> GetEmployees()
        {
            return await _dbContext.Employees.Select(x => new EmployeeViewModel
            {
                EmployeeId = x.EmployeeId,
                FirstName = x.FirstName,
                LastName = x.LastName,
                DateOfBirth = x.DateOfBirth,
                Email = x.Email,
                Gender = x.Gender,
                DeparmentId = x.DeparmentId,
                PhotoPath = x.PhotoPath,
            }).ToListAsync();
        }

        public async Task<EmployeeViewModel> UpdateEmployee(int id, EmployeeRequest request)
        {
            var result = await _dbContext.Employees.FirstOrDefaultAsync(x => x.EmployeeId == id);
            if(result == null)
            {
                return null;
            }
            result.FirstName = request.FirstName;
            result.LastName = request.LastName;
            result.Email = request.Email;
            result.DateOfBirth = request.DateOfBirth;
            result.Gender = request.Gender;
            result.DeparmentId = request.DeparmentId;
            result.PhotoPath = request.PhotoPath;
            _dbContext.Employees.Update(result);
            await _dbContext.SaveChangesAsync();
            var finalResult = new EmployeeViewModel
            {
                EmployeeId = result.EmployeeId,
                FirstName = result.FirstName,
                LastName = result.LastName,
                DateOfBirth = result.DateOfBirth,
                Email = result.Email,
                Gender = result.Gender,
                DeparmentId = result.DeparmentId,
                PhotoPath = result.PhotoPath,
            };
            return finalResult;
        }
    }
}
