using ReportSystem.Models;
using System.Collections.Generic;

namespace ReportSystem.Repo
{
    public interface INationalitiesRepository
    {
        List<Nationalities> GetAllNationalities();

        IEnumerable<Nationalities> GetGetAllNationalitiesIEnum();
    }
}
