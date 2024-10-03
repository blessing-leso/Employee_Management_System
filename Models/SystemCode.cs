using System.ComponentModel.DataAnnotations;

namespace EmployeeSystem.Models
{
    public class SystemCode:UserActivies
    {
        [Key]
        public int Id { get; set; }
        public string? Code { get; set; }
        public string? Description { get; set; }
    }
}
