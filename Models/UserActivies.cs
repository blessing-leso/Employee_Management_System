namespace EmployeeSystem.Models
{
    public class UserActivies
    {
        public string? CreateById { get; set; }
        public DateTime CreateDate { get; set; }

        public string? ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set;}
    }
    public class ApprovalActivies: UserActivies
    {
        public string? ApprovedById { get; set; }
        public DateTime ApprovedDate { get; set; }

       
    }
}
