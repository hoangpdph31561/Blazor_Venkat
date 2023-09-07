using EmployeeManagerment.Web.Services;
using Microsoft.AspNetCore.Components;
using SelfLearn_Blazor_kudvenkat.Entities;

namespace EmployeeManagerment.Web.Pages
{
    public partial class EmployeeDetails
    {
        public Employee Employee { get; set; } = new Employee();
        [Inject]
        public IEmployeeService employeeService { get; set; }
        [Parameter]
        public string Id { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Employee = await employeeService.GetEmployeeById(Convert.ToInt32(Id));
        }
    }
}
