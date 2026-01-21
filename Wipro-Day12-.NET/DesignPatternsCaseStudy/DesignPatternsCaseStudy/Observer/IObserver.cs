using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCaseStudy.Observer
{
    // Observer interface
    public interface IObserver
    {
        // Method called when subject updates data
        void Update(float temperature);
    }
}
