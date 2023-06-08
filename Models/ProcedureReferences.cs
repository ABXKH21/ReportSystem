using System.ComponentModel.DataAnnotations;

namespace ReportSystem.Models
{
    public class ProcedureReferences
    {
        [Key]
        public int ProcedureReferenceID { get; set; }

        [Required]
        public string Damages { get; set; }

        public string CreationUserName { get; set; }

        public string ExternalParty { get; set; }
    }
}
