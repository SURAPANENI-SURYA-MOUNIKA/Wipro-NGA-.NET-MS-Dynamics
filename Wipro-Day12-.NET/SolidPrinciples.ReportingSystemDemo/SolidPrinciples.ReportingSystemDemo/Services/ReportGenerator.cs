using SolidPrinciples.ReportingSystemDemo.Interfaces;
using SolidPrinciples.ReportingSystemDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.ReportingSystemDemo.Services
{
    // SRP: Only generates reports
    public class ReportGenerator : IReportGenerator
    {
        public Report GenerateReport()
        {
            return new SalesReport
            {
                Title = "Monthly Sales Report"
            };
        }
    }
}
