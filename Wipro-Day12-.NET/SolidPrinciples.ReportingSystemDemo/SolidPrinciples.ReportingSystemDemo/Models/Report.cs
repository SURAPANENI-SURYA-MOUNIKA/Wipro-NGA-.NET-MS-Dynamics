using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.ReportingSystemDemo.Models
{
    


    // Base class
    public abstract class Report
    {
        public string Title { get; set; }

        public abstract string GetContent();
    }
}
