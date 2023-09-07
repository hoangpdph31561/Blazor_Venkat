using SelfLearn_Blazor_kudvenkat.Enum;

namespace EmployeeManagerment.API.ViewModel
{
    public class EmployeeViewModel
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public int DeparmentId { get; set; }
        public string PhotoPath { get; set; }
        public string DeparmentName { get; set; }
    }
}
