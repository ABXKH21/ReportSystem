using Microsoft.EntityFrameworkCore;
using ReportSystem.Context;
using ReportSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ReportSystem.Repo
{
    public class ReportRepository : IReportRepository
    {
        private readonly ReportSysContext reportSysContext;

        public ReportRepository(ReportSysContext reportSysContext)
        {
            this.reportSysContext = reportSysContext;
        }

        public Report AddReport(Report report)
        {
            if (report == null)
            {
                throw new Exception();
            }

            reportSysContext.Report.Add(report);
            reportSysContext.SaveChanges();
            return report;
        }

        public Report DeleteReport(int reportId)
        {
            Report report = reportSysContext.Report.Find(reportId);
            if (report != null)
            {
                reportSysContext.Report.Where(x => x.ReportID == reportId);
                reportSysContext.Report.Remove(report);
                reportSysContext.SaveChanges();
            }
            return report;
        }

        public Report FindInReport(int id)
        {
            return reportSysContext.Report.Find(id);
        }

        public List<Report> GetAllReports()
        {

            var temp = reportSysContext.Report.Include(c => c.Nationalities).
                                               Include(c => c.ProcedureTypes).
                                               ThenInclude(c => c.SubCategories).
                                               ThenInclude(c => c.MainCategories).ToList();
            
            return temp;
        }

        public Report GetReport(int reportId)
        {
            var report = reportSysContext.Report.Include(c => c.Nationalities).Include(c => c.Districts).Include(c => c.ProcedureTypes).ThenInclude(c => c.SubCategories).ThenInclude(c => c.MainCategories).FirstOrDefault(c => c.ReportID == reportId);
            return report;
        }

        public Report UpdateReport(Report report)
        {
            if (report == null)
            {
                throw new Exception();
            }

            reportSysContext.Report.Update(report);
            reportSysContext.SaveChanges();
            return report;

        }
    }
}
