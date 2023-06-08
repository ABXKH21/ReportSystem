using System.ComponentModel.DataAnnotations;
namespace ReportSystem.Models
{
    public class Informer
    {
        [Key]
        public int Id { get; set; }
            
        [Required]
        [StringLength(150)]
        public string NameInformer { get; set; }

        [Required]
        [StringLength(50)]
        public string NationalIdentificationId { get; set; }        
        
        [StringLength(10)]
        public string Phone_Number { get; set; }

    }
}
