using ReportSystem.Models;
using System.Collections.Generic;

namespace ReportSystem.Repo
{
    public interface IEmployeeRepository
    {
        Employees AddEmployee(Employees employees);
        List<Employees> GetAllEmployee();
        Employees GetEmployee(int id);
        Employees DeleteEmployee(int id);
        Employees UpdateEmployee(Employees employees);
    }
}
