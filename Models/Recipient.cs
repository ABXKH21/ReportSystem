using System.ComponentModel.DataAnnotations;
namespace ReportSystem.Models
{
    public class Recipient
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int Superviosor { get; set; }

    }
}
