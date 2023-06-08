using System.ComponentModel.DataAnnotations;

namespace ReportSystem.Models
{
    public class Districts
    {
        [Key]
        public int DistrictsID { get; set; }
        public string DistrictArName { get; set; }
        public string DistrictEnName { get; set; }
    }
}
