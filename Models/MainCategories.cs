using System.ComponentModel.DataAnnotations;

namespace ReportSystem.Models
{
    public class MainCategories
    {
        [Key]
        public int MainCategoryID { get; set; }

        public string CategoryEnName { get; set; }

        public string CategoryArName { get; set; }
    }
}
