using ReportSystem.Models;
using System.Collections.Generic;

namespace ReportSystem.Repo
{
    public interface ILostCardRepository 
    {
        LostCardEmployee AddLostCardEmployee (LostCardEmployee lostCardEmployee);
        List<LostCardEmployee> GetAllLostCardEmployee();
        LostCardEmployee GetLostCardEmployee(int id);
        List<LostCardEmployee> GetLostCardEmployeeByName(string name);
        LostCardEmployee DeleteLostCardEmployee(int id);                
        LostCardEmployee UpdateLostCardEmployee(LostCardEmployee lostCard);
    }
}
