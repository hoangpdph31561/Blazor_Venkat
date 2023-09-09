using EmployeeManagerment.API.Request;
using EmployeeManagerment.API.ViewModel;
using EmployeeManagerment.Web.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace EmployeeManagerment.Web.Pages
{
    public partial class CreateNewEmployee
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Inject]
        public IEmployeeService EmployeeService { get; set; }
        [Inject]
        public IDeparmentService DeparmentService { get; set; }
        public EmployeeRequest NewEmployee { get; set; } = new EmployeeRequest();
        public List<DeparmentViewModel> Deparments { get; set; } = new List<DeparmentViewModel>();
        public string Result { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Deparments = await DeparmentService.GetDeparments();
            NewEmployee.PhotoPath = "images/z4588458814052_472230aad824892dcc3c25f7e6fddfbc.jpg";
            NewEmployee.DeparmentId = 1;
        }
        private async Task CreateEmployee(EditContext context)
        {
            var result = await EmployeeService.CreateNewEmployee(NewEmployee);
            Result = result;
            System.Threading.Thread.Sleep(3000);
            NavigationManager.NavigateTo("/");
        }
    }
}
