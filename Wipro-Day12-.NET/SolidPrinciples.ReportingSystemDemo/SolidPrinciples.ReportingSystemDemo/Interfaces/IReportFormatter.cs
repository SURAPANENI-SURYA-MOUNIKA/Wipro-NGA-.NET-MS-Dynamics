using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.ReportingSystemDemo.Interfaces
{

    public interface IReportFormatter
    {
        string Format(string content);
    }
}
