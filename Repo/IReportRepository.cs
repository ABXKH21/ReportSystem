using ReportSystem.Models;
using System.Collections.Generic;

namespace ReportSystem.Repo
{
    public interface IReportRepository
    {

        Report AddReport(Report report);
        List<Report> GetAllReports();
        Report GetReport(int reportId);
        Report DeleteReport(int reportId);

        Report FindInReport(int id);
        Report UpdateReport(Report report);

    }
}
