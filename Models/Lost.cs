using System;
using System.ComponentModel.DataAnnotations;

namespace ReportSystem.Models
{
    public class Lost
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime OpenDate { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:hh:mm tt}")]
        public DateTime OpenTime { get; set; }


        public string Subject { get; set; }
        public string Job_UniversityID { get; set; }
        public string CollageName { get; set; }
        public string Department { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public bool Stealing { get; set; }
        public string StealingInfo { get; set; }


        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime LostDate { get; set; }
        public string PlaceLost { get; set; }


        [Required]
        public int NationalitiesID { get; set; }
        public Nationalities Nationalities { get; set; }

        [Required]
        public int InformerId { get; set; }
        public Informer Informer { get; set; }
    }
}
