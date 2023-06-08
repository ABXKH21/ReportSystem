using System.ComponentModel.DataAnnotations;
namespace ReportSystem.Models
{
    public class Employees
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string EmployeeName { get; set; }

        [Required]
        [StringLength(50)]
        public string JobID { get; set; }

        public string Employer { get; set; }

        public string Phone { get; set; }
        
    }

}
