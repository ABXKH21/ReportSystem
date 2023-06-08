using System.ComponentModel.DataAnnotations;

namespace ReportSystem.Models
{
    public class Vehicles
    {
        [Key]
        public int VehicleID { get; set; }

        [Required]
        public string VehicleNumber { get; set; }

        [Required]
        public string VehicleLitter { get; set; }

        [Required]
        public string DriverName { get; set; }

        [Required]
        public int DriverAge { get; set; }

        public string ReffNumber { get; set; }

        public int VehicleDescription { get; set; }

        [Required]
        public int ReportID { get; set; }
        public Report Report { get; set; }
    }
}
