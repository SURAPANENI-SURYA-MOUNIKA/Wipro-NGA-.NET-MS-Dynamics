using SolidPrinciples.ReportingSystemDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.ReportingSystemDemo.Services
{
  
    public class ExcelReportFormatter : IReportFormatter
    {
        public string Format(string content)
        {
            return $"[EXCEL FORMAT] {content}";
        }
    }
}
