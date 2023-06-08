using ReportSystem.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ReportSystem.ViewModels.DeliveryViewModel
{
    public class CreationDelivery
    {

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
          public List<Employees>  Employees { get; set; }

      
    }
}
