using EmployeeManagerment.API.ViewModel;
using EmployeeManagerment.Web.Services;
using Microsoft.AspNetCore.Components;
using SelfLearn_Blazor_kudvenkat.Entities;

namespace EmployeeManagerment.Web.Pages
{
    public partial class EmployeeList
    {
        [Inject]
        public IEmployeeService employeeService { get; set; }
        public IEnumerable<EmployeeViewModel> Employees { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Employees = await employeeService.GetEmployee();
        }
        
    }
}
