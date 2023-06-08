using System.ComponentModel.DataAnnotations;

namespace ReportSystem.Models
{
    public class ProcedureTypes
    {
        [Key]
        public int ProcedureTypeID { get; set; }

        [Required]
        public string ProcedureTypeName { get; set; }

        [Required]
        public int SubCategoriesID { get; set; }
        public SubCategories SubCategories { get; set; }
    }
}
