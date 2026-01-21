using SolidPrinciples.ReportingSystemDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.ReportingSystemDemo.Services
{
   
    // DIP: Depends on abstractions, not concrete classes
    public class ReportService
    {
        private readonly IReportGenerator _generator;
        private readonly IReportFormatter _formatter;
        private readonly IReportSaver _saver;

        public ReportService(
            IReportGenerator generator,
            IReportFormatter formatter,
            IReportSaver saver)
        {
            _generator = generator;
            _formatter = formatter;
            _saver = saver;
        }

        public void ProcessReport()
        {
            var report = _generator.GenerateReport();
            var formattedContent = _formatter.Format(report.GetContent());
            _saver.Save(formattedContent);
        }
    }
}
