using SolidPrinciples.ReportingSystemDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.ReportingSystemDemo.Models
{
    
    // Derived class follows LSP
    public class SalesReport : Report
    {
        public override string GetContent()
        {
            return "Sales Report Content";
        }
    }
}
