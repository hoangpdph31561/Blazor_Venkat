using SelfLearn_Blazor_kudvenkat.Entities;

namespace EmployeeManagerment.Web.Pages
{
    public partial class EmployeeList
    {
        public IEnumerable<Employee> Employees { get; set; }
        protected override async Task OnInitializedAsync()
        {
            await Task.Run(LoadEmployees);
        }
        private void LoadEmployees()
        {
            System.Threading.Thread.Sleep(3000);
            Employee e1 = new Employee()
            {
                EmployeeId = 1,
                FirstName = "Hoang",
                LastName = "Pham",
                DateOfBirth = new DateTime(1998, 06, 23),
                Email = "hoang23577@gmai.com",
                Gender = SelfLearn_Blazor_kudvenkat.Enum.Gender.Male,
                PhotoPath = "images/z4588458814052_472230aad824892dcc3c25f7e6fddfbc.jpg",
                Deparment = new Deparment()
                {
                    DeparmentId = 1,
                    DeparmentName = "C#"
                }

            };
            Employee e2 = new Employee()
            {
                EmployeeId = 2,
                FirstName = "Giang",
                LastName = "Nguyen",
                DateOfBirth = new DateTime(2002, 06, 23),
                Email = "hoang23577@gmai.com",
                Gender = SelfLearn_Blazor_kudvenkat.Enum.Gender.Female,
                PhotoPath = "images/z4588461449146_87d4cb5c0761f68b6be7686c0ed5ae85.jpg",
                Deparment = new Deparment()
                {
                    DeparmentId = 2,
                    DeparmentName = "Java"
                }

            };
            Employee e3 = new Employee()
            {
                EmployeeId = 3,
                FirstName = "Mai Anh",
                LastName = "Nguyen",
                DateOfBirth = new DateTime(2004, 06, 23),
                Email = "hoang23577@gmai.com",
                Gender = SelfLearn_Blazor_kudvenkat.Enum.Gender.Female,
                PhotoPath = "images/Picture1.png",
                Deparment = new Deparment()
                {
                    DeparmentId = 1,
                    DeparmentName = "C#"
                }

            };
            Employees = new List<Employee>() { e1, e2 ,e3};
        }
    }
}
