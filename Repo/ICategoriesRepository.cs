using ReportSystem.Models;
using System.Collections.Generic;

namespace ReportSystem.Repo
{
    public interface ICategoriesRepository
    {
        List<MainCategories> GetAllMainCategories();
        List<SubCategories> GetAllSubCategories(int mainCatId);
        List<ProcedureTypes> GetAllProceduerTypes(int subCatId);

        ProcedureTypes GetProceduerTypeName(int id);
    }
}
