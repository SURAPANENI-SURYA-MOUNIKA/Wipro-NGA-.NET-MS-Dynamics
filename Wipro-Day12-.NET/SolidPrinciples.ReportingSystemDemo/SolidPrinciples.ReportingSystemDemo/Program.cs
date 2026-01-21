using SolidPrinciples.ReportingSystemDemo.Interfaces;
using SolidPrinciples.ReportingSystemDemo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.ReportingSystemDemo
{
    class Program
    {
        static void Main()
        {
            // Manual Dependency Injection
            IReportGenerator generator = new ReportGenerator();
            IReportFormatter formatter = new PdfReportFormatter(); // Change to ExcelReportFormatter if needed
            IReportSaver saver = new FileReportSaver();

            ReportService service = new ReportService(generator, formatter, saver);
            service.ProcessReport();
        }
    }
}