using System.ComponentModel.DataAnnotations;

namespace ReportSystem.Models
{
    public class Nationalities
    {
        [Key]
        public int NationalityID { get; set; }

        public string NationalityEnName { get; set; }

        public string NationalityArName { get; set; }
    }
}
