using ReportSystem.Models;
using System.Collections.Generic;

namespace ReportSystem.Repo
{
    public interface IAddressesRepository
    {
        List<Districts> GetAllDistricts();   
    }
}
