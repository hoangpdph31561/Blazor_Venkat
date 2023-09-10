using EmployeeManagerment.API.ViewModel;
using Microsoft.AspNetCore.Components;
using SelfLearn_Blazor_kudvenkat.Entities;

namespace EmployeeManagerment.Web.Pages
{
    public partial class DisplayEmployee
    {
        [Parameter]
        public EmployeeViewModel Employee { get; set; }
        [Parameter]
        public bool ShowFooter { get; set; }
    }
}
