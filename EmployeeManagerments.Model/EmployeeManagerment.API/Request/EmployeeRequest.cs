using SelfLearn_Blazor_kudvenkat.Enum;

namespace EmployeeManagerment.API.Request
{
    public class EmployeeRequest
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public int DeparmentId { get; set; }
        public string PhotoPath { get; set; }
    }
}
