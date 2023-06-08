using System;
using System.ComponentModel.DataAnnotations;

namespace ReportSystem.Models
{
    public class ProcedureRelations
    {
        [Key]
        public int PtocedureRelationID { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime ProcedureDate { get; set; }

        public string Description { get; set; }

        public string ExternalParty { get; set; }

        
        [Required]
        public int ReportID { get; set; }
        public Report Report { get; set; }

        [Required]
        public int ProcedureReferencesID { get; set; }
        public ProcedureReferences ProcedureReferences { get; set; }

    }
}
