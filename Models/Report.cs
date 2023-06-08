using System;
using System.ComponentModel.DataAnnotations;

namespace ReportSystem.Models
{
    public class Report
    {
        [Key]
        public int ReportID { get; set; }

   

        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime CreationReportDate { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:hh:mm tt}")]
        public DateTime CreationReportTime { get; set; }

        public string Entrance { get; set; }

        public string Bulding { get; set; }

        public int? InformantID { get; set; }

        public string InformantName { get; set; }

        [Required]
        public string Mobile { get; set; }

        public Gender Gender { get; set; }

        [Required]
        public int Status { get; set; }

        public string Summary { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime ClosedDate { get; set; }

        public string CreatorUserame { get; set; }

        [Required]
        public string AccidentCause { get; set; }

        public string LocationDescriptin { get; set; }

        

        public int ProcedureTypesId { get; set; }
        public ProcedureTypes ProcedureTypes { get; set; }

        [Required]
        public int DistrictsID { get; set; }
        public Districts Districts { get; set; }

        [Required]
        public int NationalitiesID { get; set; }
        public Nationalities Nationalities { get; set; }
    }

    public enum Gender
    {
        Male = 1,
        Female = 2
    }
}
