using System;
using System.ComponentModel.DataAnnotations;


namespace ReportSystem.Models
{
    public class Delivery
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string CarType { get; set; }

        [Required]
        [StringLength(50)]
        public string CarModel { get; set; }

        [Required]
        [StringLength(50)]
        public string PlateNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string CarColor { get; set; }

        public int EmployeeId { get; set; }
        public Employees Employee { get; set; }

    }
}
