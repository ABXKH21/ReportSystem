using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReportSystem.Models
{
    public class Logs
    {
        [Key]
        public int LogID { get; set; }

        [Required]
        public LogsAction Action { get; set; }

        public int RefNumber { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime OldDate { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        [Column(TypeName = "varbinary(max)")]
        public byte[] Payload { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime ActoinDate { get; set; }
    }

    public enum LogsAction
    {
        CreateReport = 1,
        UpdateReport = 2,
        AddProcedure = 3,
        CreateCategory = 4,
        CreateProcedure = 5,
        EditCategory = 6,
        EditProcedure = 7,
        CreateUser = 8,
        EditUser = 9,
        CreateVehicle = 10
    }
}
