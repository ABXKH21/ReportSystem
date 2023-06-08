using System.ComponentModel.DataAnnotations;
namespace ReportSystem.Models
{
    public class LostCardEmployee
    {
        [Key]
        public int Id { get; set; }

        [Required]      

        public string Reason { get; set; }

        public int EmployeeId { get; set; }
        public Employees Employee { get; set; }


    }
}


