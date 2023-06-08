using ReportSystem.Models;
using System.Collections.Generic;

namespace ReportSystem.Repo
{
    public interface ILostRepository
    {
        Lost AddLost(Lost lost);
        List<Lost> GetAllLost();
        Lost GetLost(int id);
        List<Lost> GetLostByName(string name);
        Lost FindLost (int id); 
        Lost DeleteLost(int id);
        Lost UpdateLost( Lost lost);

    }
}
