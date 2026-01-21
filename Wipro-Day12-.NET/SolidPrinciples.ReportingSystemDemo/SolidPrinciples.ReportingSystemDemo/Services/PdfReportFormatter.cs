using SolidPrinciples.ReportingSystemDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.ReportingSystemDemo.Services
{
   
    // OCP: New formatter without changing existing code
    public class PdfReportFormatter : IReportFormatter
    {
        public string Format(string content)
        {
            return $"[PDF FORMAT] {content}";
        }
    }
}
