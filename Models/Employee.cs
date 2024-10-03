namespace EmployeeSystem.Models
{
    public class Employee : UserActivies
    {
        public int Id { get; set; }
        public string EmployeeId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FullName => $"{Name} {Surname}";
        public string Email { get; set; }
        public int Phone { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string Department { get; set; }
        public string Designation { get; set; }
    }
}
