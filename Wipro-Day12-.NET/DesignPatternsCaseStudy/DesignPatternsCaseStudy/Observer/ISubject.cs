using DesignPatternsCaseStudy.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCaseStudy.Observer
{
    // Subject interface
    public interface ISubject
    {
        // Register an observer
        void Register(IObserver observer);

        // Remove an observer
        void Unregister(IObserver observer);

        // Notify all observers
        void NotifyObservers();
    }
}
