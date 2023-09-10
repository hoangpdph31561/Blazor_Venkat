using EmployeeManagerment.API.ViewModel;
using EmployeeManagerment.Web.Services;
using Microsoft.AspNetCore.Components;
using Re_Useable_web_razor;
using SelfLearn_Blazor_kudvenkat.Entities;

namespace EmployeeManagerment.Web.Pages
{
    public partial class DisplayEmployee
    {
        [Parameter]
        public EventCallback<int> OnEmployeeDeleted { get; set; }
        [Inject]
        public IEmployeeService EmployeeService { get; set; }
        [Parameter]
        public EmployeeViewModel Employee { get; set; }
        [Parameter]
        public bool ShowFooter { get; set; }
        protected DeleteConfirm DeleteConfirm { get; set; }
        protected void Delete_Click()
        {
            DeleteConfirm.Show();
        }
        protected async Task Confirm_DeleteClick(bool deleteConfirm)
        {
            if(deleteConfirm)
            {
                await EmployeeService.DeleteEmployee(Employee.EmployeeId);
                await OnEmployeeDeleted.InvokeAsync(Employee.EmployeeId);
            }
        }
    }
}
