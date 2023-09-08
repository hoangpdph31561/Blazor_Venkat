using EmployeeManagerment.API.ViewModel;
using EmployeeManagerment.Web.Services;
using Microsoft.AspNetCore.Components;

namespace EmployeeManagerment.Web.Pages
{
    public partial class EditEmployee
    {
        [Inject]
        public IDeparmentService DeparmentService { get; set; }
        public List<DeparmentViewModel> Deparments { get; set; } = new List<DeparmentViewModel>();
        [Inject]
        public IEmployeeService EmployeeService { get; set; }
        public EmployeeViewModel  Employee { get; set; } = new EmployeeViewModel();
        [Parameter]
        public string Id { get; set; }
        protected async override Task OnInitializedAsync()
        {
            Employee = await EmployeeService.GetEmployeeById(Convert.ToInt32(Id));
            Deparments = await DeparmentService.GetDeparments();
        }
    }
}
