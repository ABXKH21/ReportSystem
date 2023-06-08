using ReportSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ReportSystem.ViewModels.LostViewModel
{
    public class CreationLost
    {
        public Lost Lost { get; set; }
      
        public IEnumerable<Nationalities> NationalitiesList { get; set; }

    }
}
