namespace SelfLearn_Blazor_kudvenkat.Entities
{
    public class Deparment
    {
        public int DeparmentId { get; set; }
        public string DeparmentName { get; set; }
        public List<Employee> Employees { get; set; }
    }
}