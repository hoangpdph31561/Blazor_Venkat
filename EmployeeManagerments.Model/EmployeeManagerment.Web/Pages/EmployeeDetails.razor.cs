using EmployeeManagerment.API.ViewModel;
using EmployeeManagerment.Web.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using SelfLearn_Blazor_kudvenkat.Entities;

namespace EmployeeManagerment.Web.Pages
{
    public partial class EmployeeDetails
    {
        protected string ToaDo { get; set; }
        protected string ButtonName { get; set; } = "Hide buttons";
        protected string? CssClass { get; set; } = null;
        public EmployeeViewModel Employee { get; set; } = new EmployeeViewModel();
        [Inject]
        public IEmployeeService employeeService { get; set; }
        [Parameter]
        public string Id { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Employee = await employeeService.GetEmployeeById(Convert.ToInt32(Id));
        }
        protected void GetToaDo(MouseEventArgs args)
        {
            ToaDo = $"X = {args.ClientX} Y = {args.ClientY}";
        }
        protected void HideButtonClick()
        {
            if(ButtonName == "Hide buttons")
            {
                ButtonName = "Show buttons";
                CssClass = "HideFooter";
            }
            else
            {
                ButtonName = "Hide buttons";
                CssClass = null;
            }
        }
    }
}
