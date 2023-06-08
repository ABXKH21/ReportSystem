using ReportSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ReportSystem.ViewModels.ReportViewModel
{
    public class CreationReport
    {
        public int ReportID { get; set; }

        public string ReportNumber { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime CreationReportDate { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:hh:mm tt}")]
        public DateTime CreationReportTime { get; set; }

        public string Entrance { get; set; }

        public string Bulding { get; set; }

        public string Building_Number { get; set; }

        public int? InformantID { get; set; }
        public string InformantName { get; set; }

        [RegularExpression(@"^[0-9]{9,10}$", ErrorMessage = "*الرجاء إدخال رقم الهاتف بشكل صحيح")]
        public string Mobile { get; set; }

        public Gender Gender { get; set; }

        [Required]
        public int Status { get; set; }
        public string Summary { get; set; }

        [Required]
        public string AccidentCause { get; set; }

        public string LocationDescriptin { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime ClosedDate { get; set; }

        public int MainCategoriesID { get; set; }
        public List<MainCategories> MainCategories { get; set; }

        public int SubCategoriesID { get; set; }
        public List<SubCategories> SubCategories { get; set; }

        public int DistrictsID { get; set; }
        public List<Districts> Districts { get; set; }

 
        public int NationalitiesID { get; set; }
        public List<Nationalities> Nationalities { get; set; }
        public int ProceduerTypeID { get; set; }
        public string ProceduerTypeName { get; set; }

        public string CreatorUserame { get; set; }
    }
}
