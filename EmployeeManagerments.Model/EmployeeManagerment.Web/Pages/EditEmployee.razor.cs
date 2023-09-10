using EmployeeManagerment.API.Request;
using EmployeeManagerment.API.ViewModel;
using EmployeeManagerment.Web.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace EmployeeManagerment.Web.Pages
{
    public partial class EditEmployee
    {
        
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Inject]
        public IDeparmentService DeparmentService { get; set; }
        public List<DeparmentViewModel> Deparments { get; set; } = new List<DeparmentViewModel>();
        public EmployeeRequest UpdateEmployeeRequest { get; set; } = new EmployeeRequest();
        public string Result { get; set; }
        [Inject]
        public IEmployeeService EmployeeService { get; set; }
        public EmployeeViewModel  Employee { get; set; } = new EmployeeViewModel();
        public string DeparmentId { get; set; }
        [Parameter]
        public string Id { get; set; }
        protected async override Task OnInitializedAsync()
        {
            Employee = await EmployeeService.GetEmployeeById(Convert.ToInt32(Id));
            Deparments = await DeparmentService.GetDeparments();
            DeparmentId = Employee.DeparmentId.ToString();
            UpdateEmployeeRequest.FirstName = Employee.FirstName;
            UpdateEmployeeRequest.LastName = Employee.LastName;
            UpdateEmployeeRequest.Email = Employee.Email;
            UpdateEmployeeRequest.Gender = Employee.Gender;
            UpdateEmployeeRequest.DeparmentId = Employee.DeparmentId;
            UpdateEmployeeRequest.DateOfBirth = Employee.DateOfBirth;
            UpdateEmployeeRequest.PhotoPath = Employee.PhotoPath;
        }
        protected async Task UpdateEmployee(EditContext context)
        {

            var result = await EmployeeService.UpdateEmployee(Convert.ToInt32(Id), UpdateEmployeeRequest);
            if(result)
            {
                Result = "Update successfully";
            }
            else
            {
                Result = "Update fail";
            }
        }
        protected async Task DeleteEmployee()
        {
            await EmployeeService.DeleteEmployee(Employee.EmployeeId);
            NavigationManager.NavigateTo("/");
        }
    }
}
