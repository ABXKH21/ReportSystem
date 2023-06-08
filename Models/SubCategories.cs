using System.ComponentModel.DataAnnotations;

namespace ReportSystem.Models
{
    public class SubCategories
    {
        [Key]
        public int SubCategoriesID { get; set; }

        public string SubCategoryEnName { get; set; }

        public string SubCategoryArName { get; set; }

        [Required]
        public int MainCategoriesID { get; set; }
        public MainCategories MainCategories { get; set; }
    }
}
