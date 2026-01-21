using DesignPatternsCaseStudy.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCaseStudy.Observer
{
    // WeatherStation acts as Subject
    public class WeatherStation : ISubject
    {
        // List to store observers
        private List<IObserver> observers = new List<IObserver>();

        // Temperature data
        private float temperature;

        // Method to update temperature
        public void SetTemperature(float temp)
        {
            // Update temperature value
            temperature = temp;

            // Notify observers about change
            NotifyObservers();
        }

        // Add observer to list
        public void Register(IObserver observer)
        {
            observers.Add(observer);
        }

        // Remove observer from list
        public void Unregister(IObserver observer)
        {
            observers.Remove(observer);
        }

        // Notify all registered observers
        public void NotifyObservers()
        {
            // Loop through observers
            foreach (var observer in observers)
            {
                // Call Update method of each observer
                observer.Update(temperature);
            }
        }
    }
}
