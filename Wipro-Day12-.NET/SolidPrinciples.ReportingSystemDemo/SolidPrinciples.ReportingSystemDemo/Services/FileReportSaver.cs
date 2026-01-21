using SolidPrinciples.ReportingSystemDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.ReportingSystemDemo.Services
{
    // SRP: Only saves reports
    public class FileReportSaver : IReportSaver
    {
        public void Save(string content)
        {
            Console.WriteLine("Saving report to file...");
            Console.WriteLine(content);
        }
    }
}
